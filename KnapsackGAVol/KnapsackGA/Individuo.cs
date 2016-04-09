using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackGA

{
    public class Individuo
    // O indiviuo deste problema é uma Sacola (knapsack)
    // sem itens (toda vazia)
    // com um _PesoTotal
    //
    {
        public static int NMAX = 10000;                 // Tamanho dos vetores
        public static double VeryBigDouble = 9.99E99;    // Valores iniciais para iterações
        public static Int32 VeryBigInteger = 9999999;

        private int[] Sacola = new int[NMAX];  // lista de itens que estão na sacola
        private int N;                         // tamanho da lista de itens 
        private double _PesoTotal;             // Número de Recursos para ser desiginado
        private double _VolumeTotal;           // Volume total da sacola
        private double fitness;                // Valor do ajuste do individuo (valor carregado na sacola)

        public Individuo(double _capacidade, double _volTotal, int _N)
        {
            _PesoTotal = _capacidade;
            _VolumeTotal = _volTotal;
            N = _N;
            EsvaziaSacola();
        }

        public void EsvaziaSacola()
        {
            for (int i = 1; i <= N; i++)
            {
                Sacola[i] = 0;
            }
        }
 
        public void ColocaItem(int i)
        {
            // coloca o item i na sacola
            Sacola[i] = 1;
        }


        public Individuo copy()
        {
           Individuo clone = new Individuo(_PesoTotal, _VolumeTotal, N);
           for (int i = 1; i <= N; i++) {
                if (this.Sacola[i] == 1) { clone.ColocaItem(i); }
            } 
            clone.setFitness(this.fitness);
            return clone;
        }

        public Individuo geraAleatorio(double _PesoTotal, double _volTotal, int _N, Random _rand){
            Individuo feto = new Individuo(_PesoTotal, _volTotal, _N);
            for (int i=1; i<=_N; i++){
                if (_rand.NextDouble()<=0.5)
                {
                   feto.Sacola[i]=0;
                } else {
                   feto.Sacola[i]=1;
                }
            }
            return feto;
        }

/**
        public int NumeroItens()
        {
            // Conta quantos itens há na sacola 
            int NR = 0;
            // Numero de recursos na base K
            for (int j = 1; j <= R; j++)
            {
                if (Base[j] == iBase)
                {
                    NR = NR + 1;
                }
            }
            return NR;

        }
 */
        public double CalculaPeso(Item[] _Lista, int _N)
        {
            double _pesoSacola = 0.0;
            for (int i = 1; i <= _N; i++)
            {
                _pesoSacola = _pesoSacola + _Lista[i].peso * Sacola[i];
            }
            return _pesoSacola;
        }

        public double CalculaVolume(Item[] _Lista, int _N)
        {
            double _volSacola = 0.0;
            for (int i = 1; i <= _N; i++)
            {
                _volSacola = _volSacola + _Lista[i].volume * Sacola[i];
            }
            return _volSacola;
        }

        public double CalcFitness(Item[] _Lista, int _N)
        {
            double myFitness = 0.0;
            double _pesoSacola = 0.0;
            double _volSacola = 0.0;
            double _valorSacola = 0.0;

            for (int i = 1; i <= _N; i++)
            {
                _pesoSacola = _pesoSacola + _Lista[i].peso * Sacola[i]; 
                _volSacola = _volSacola + _Lista[i].volume * Sacola[i];
                _valorSacola = _valorSacola + _Lista[i].valor * Sacola[i];
            }
            if ((_pesoSacola <= _PesoTotal) && (_volSacola <= _VolumeTotal))
            {
                myFitness = _valorSacola;

             } else {

              myFitness = 0.0;

            }
            fitness = myFitness;  // salva o fitness para não ficar calculando toda hora
            return myFitness;
        }

        public double getFitness()
        {
            return fitness;
        }

        public void setFitness(double _NewFitness)
        {
            fitness = _NewFitness;
        }

        public void setItem(int _id, int _item)
        {
            this.Sacola[_id] = _item;
        }

        public int getItem(int _id)
        {
            return(this.Sacola[_id]);
        }

    }
}
