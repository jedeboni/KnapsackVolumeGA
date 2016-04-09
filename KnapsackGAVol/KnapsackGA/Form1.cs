using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace KnapsackGA
{
    public partial class Form1 : Form
    {
        //  
        //   Variáveis globias do Estudo
        public static int NMAX = 10000;                 // Tamanho dos vetores
        public static double VeryBigDouble = 9.99E99;    // Valores iniciais para iterações
        public static Int32 VeryBigInteger = 9999999;
        //
        //   Dados de Entrada
        public String fileName;                    // Nome do arquivo com os dados da lista
        public String[] header = new String[10];   // Header do arquivo CSV
        public Item[] Litens = new Item[NMAX];     // Lista de Itens para colocar na sacola
        public int N;                              // Tamanho da Lista
        //
        public char delimiter = ';';              // Delimitador dos arquivos CSV
        //
        // Parametros para o GA
        private static int GA_POPSIZE = 1024;           // Tamanho da população
        private static double GA_ELITRATE = 0.20;
        private static double GA_MUTATIONRATE = 0.25;
        private static int GA_MAXGENERATION = 512;
        public int GA_GCount = 1;
        private static int GA_GSTOP = 10;                 
        //
        public static Random rand = new Random();
        //
        private Individuo[] Populacao = new Individuo[NMAX];
        public double _PesoSacola = 4.0;
        public double _VolumeSacola = 5.0;
        
        public Form1()
        {
            InitializeComponent();
            txtElitRate.Text = GA_ELITRATE.ToString();
            txtMRate.Text = GA_MUTATIONRATE.ToString();
            txtPopsize.Text = GA_POPSIZE.ToString();
            txtPesoSacola.Text = _PesoSacola.ToString();
            txtVolumeSacola.Text = _VolumeSacola.ToString();
            txtGenStop.Text = GA_GSTOP.ToString();
            txtMaxGen.Text = GA_MAXGENERATION.ToString();
        }

 
 

        public void EntradaListaCSV(String file)
        {
            // Leitura dos dados dos pontos iniciais dos Clusters de um arquivo CSV. 
            // Estrutura do CSV
            // (separador ";")
            // Header na primeira linha
            // UTMX, UTMY, Capacidade, #Cluster, Fixo
            // ... K linhas
            //
            try
            {
                var reader = new StreamReader(File.OpenRead(file));
                N = 0;
                var line = reader.ReadLine();
                var headerCluster = line.Split(delimiter); //  not used
                //
                New2Log("Reading File " + file + "\n");
                //
                while (!reader.EndOfStream)
                {
 //                   if ((N % 50) == 0) { Add2Log("."); };  // a dot every 50 points
                    line = reader.ReadLine();
                    var values = line.Split(delimiter);
                    N = N + 1;
                    //                   Descricao         PESO	       VOLUME       VALOR
                    Litens[N] = new Item(values[0], double.Parse(values[1]), 
                                                    double.Parse(values[2]),
                                                    double.Parse(values[3]));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error while reading file\n" + file + "\n" + e.ToString(),
                                "ERRO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void New2Log(String texto)
        {
            rtfLOG.Text = rtfLOG.Text + "\n" + texto;
            rtfLOG.Invalidate();
            rtfLOG.Update();
            rtfLOG.Refresh();
        }


        public void ClearLog(String texto)
        {
            rtfLOG.Text =  texto;
            rtfLOG.Invalidate();
            rtfLOG.Update();
            rtfLOG.Refresh();
        }

        public void Setup()
        {
            // Step Up
            //
            GA_ELITRATE = double.Parse(txtElitRate.Text);
            GA_MUTATIONRATE = double.Parse(txtMRate.Text);
            GA_POPSIZE = int.Parse(txtPopsize.Text);
            _PesoSacola = double.Parse(txtPesoSacola.Text);
            _VolumeSacola = double.Parse(txtVolumeSacola.Text);
            GA_MAXGENERATION = int.Parse(txtMaxGen.Text);
            GA_GSTOP = int.Parse(txtGenStop.Text);
            //
            Individuo _Auxiliar = new Individuo(_PesoSacola, _VolumeSacola, N);
            for (int i = 1; i <= GA_POPSIZE; i++)
            {
                Populacao[i] = _Auxiliar.geraAleatorio(_PesoSacola, _VolumeSacola, N, rand);
                Populacao[i].setFitness(Populacao[i].CalcFitness(Litens, N));
                //                New2Log("Gerando Individuo " + i.ToString("000") 
                //                                          + " fit = " + Populacao[i].getFitness().ToString("000.000"));
            }
            //
            Populacao = SortElite(Populacao, N);
            //
            New2Log("G = " + GA_GCount.ToString("000") +
                     " Best Fit = " + Populacao[1].getFitness().ToString("00.00") +
                     " P = " + Populacao[1].CalculaPeso(Litens, N).ToString("00.00") +
                     " V = " + Populacao[1].CalculaVolume(Litens, N).ToString("00.00"));
 
        }

 

        public Individuo[] SortElite(Individuo[] _pop, int _N)
        {
            // Ordena a Elite e coloca no inicio da população
            
            int EliteSize = (int)(GA_POPSIZE * GA_ELITRATE);
            Individuo auxiliar;
            for (int i = 1; i < EliteSize; i++)
            {
                int iBest = i;
                double vBest = Populacao[i].getFitness();
                for (int j = i; j < GA_POPSIZE; j++)
                {
                    if (vBest < Populacao[j].getFitness())
                    {
                        vBest = Populacao[j].getFitness();
                        iBest = j;
                    }
                }
                auxiliar = Populacao[i];
                Populacao[i] = Populacao[iBest].copy();
                Populacao[iBest] = auxiliar;
 //               New2Log("Ordenando Individuo " + i.ToString("000")
 //                          + " fit = " + Populacao[i].getFitness().ToString("000.000"));
 
             }
            return Populacao;
        }

        public void RunGA()
        {
            // RUN ALL AT ONCE
            Setup();
            int _RepeatFit = 0;
            double _LastBestFit = 0;
            while ((GA_GCount <= GA_MAXGENERATION) && (_RepeatFit <= GA_GSTOP))
            {
                RunGeneration();
                if (Populacao[1].getFitness() == _LastBestFit)  // Conta o número que o BestFit se repete.
                {
                    _RepeatFit++;
                }
                else
                {
                    _RepeatFit = 0;
                    _LastBestFit = Populacao[1].getFitness();
                }

            }
            ListaSacola(Populacao[1]);
        }


        public void ReadLIst()
        {
            // READFILE
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "CSV Files (.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtItemList.Text = openFileDialog1.FileName;
                String ListFile = openFileDialog1.FileName;
                EntradaListaCSV(txtItemList.Text);
                rtfLOG.Text = rtfLOG.Text + "Lendo a Lista de Itens de " + txtItemList.Text;
                rtfLOG.Text = rtfLOG.Text + "Encontrado " + N.ToString("000") + " itens";
            }
            txtN.Text = N.ToString();
            ListaItens();
        }



        public void ListaItens()
        {
            listSack.Items.Clear();
            for (int i = 1; i <= N; i++)
            {
                String _linha = "#" + i.ToString("000") + " | ";
                _linha = _linha + Litens[i].descricao.PadRight(20) +
                                " P = " + Litens[i].peso.ToString("00.00") +
                                " Kg  Vol = " + Litens[i].volume.ToString("00.00") +
                                "US$ " + Litens[i].valor.ToString("000.00");
                listSack.Items.Add(_linha);
            }
        }

        public void RunGeneration()
        {
            // RUN ONE STEP
            //
            int EliteSize = (int)(GA_POPSIZE * GA_ELITRATE);
            for (int i = EliteSize; i < (GA_POPSIZE); i++)
            {
                int iPai = 1 + (int)(EliteSize * rand.NextDouble());
                int iMae = 1 + (int)(EliteSize * rand.NextDouble());
                int corte = 1 + (int)(N * rand.NextDouble());

                // Cross over entre os pais geram um filho
                //
                Individuo filho = Populacao[iPai].copy();
                //
                for (int ic = corte; ic < N; ic++)
                {
                    filho.setItem(ic, Populacao[iMae].getItem(ic));
                }
                if (rand.NextDouble() < GA_MUTATIONRATE)
                {
                    int _id = 1 + (int)(N * rand.NextDouble());
                    if (rand.NextDouble() <= 0.5)
                    {
                        filho.setItem(_id, 0);
                    }
                    else
                    {
                        filho.setItem(_id, 1);
                    }
                }
                //
                filho.setFitness(filho.CalcFitness(Litens, N));
                Populacao[i] = filho;
                //Populacao[i].Calc_Fitness(C0, K)
            }
            GA_GCount++;
            Populacao = SortElite(Populacao, N);
            New2Log("G = " + GA_GCount.ToString("000") +
                     " Best Fit = " + Populacao[1].getFitness().ToString("00.00") +
                     " P = " + Populacao[1].CalculaPeso(Litens, N).ToString("00.00") +
                     " V = " + Populacao[1].CalculaVolume(Litens, N).ToString("00.00"));
        }


        public void ListaSacola(Individuo sacola)
        {
            listSack.Items.Clear();
            String _linha;
            for (int i = 1; i <= N; i++)
            {
                if (sacola.getItem(i) == 1)
                {
                    _linha = "#" + i.ToString("000") + " >> ";
                } else
                {
                    _linha = "#" + i.ToString("000") + "    ";
                }

                _linha = _linha + Litens[i].descricao.PadRight(20) +
                                " P = " + Litens[i].peso.ToString("00.00") +
                                " Kg  V = " + Litens[i].volume.ToString("00.00") +
                                " US$ " + Litens[i].valor.ToString("000.00");
                listSack.Items.Add(_linha);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void RunGABtn_Click(object sender, EventArgs e)
        {
            RunGA();
        }


        private void ReadBtn_Click(object sender, EventArgs e)
        {
            ReadLIst();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            RunGeneration();
        }

        private void readListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadLIst();
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunGA();
        }

        private void singleStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunGeneration();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearLog("");
        }

 
    }
}
