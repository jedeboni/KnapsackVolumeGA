namespace KnapsackGA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtItemList = new System.Windows.Forms.TextBox();
            this.listSack = new System.Windows.Forms.ListBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtfLOG = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoSacola = new System.Windows.Forms.TextBox();
            this.RunGABtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKnapsack10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGenStop = new System.Windows.Forms.TextBox();
            this.txtMaxGen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMRate = new System.Windows.Forms.TextBox();
            this.txtElitRate = new System.Windows.Forms.TextBox();
            this.txtPopsize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVolumeSacola = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtItemList
            // 
            this.txtItemList.Location = new System.Drawing.Point(10, 56);
            this.txtItemList.Name = "txtItemList";
            this.txtItemList.Size = new System.Drawing.Size(266, 20);
            this.txtItemList.TabIndex = 0;
            // 
            // listSack
            // 
            this.listSack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSack.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSack.FormattingEnabled = true;
            this.listSack.ItemHeight = 14;
            this.listSack.Location = new System.Drawing.Point(357, 30);
            this.listSack.Name = "listSack";
            this.listSack.Size = new System.Drawing.Size(389, 424);
            this.listSack.TabIndex = 1;
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(283, 56);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(68, 23);
            this.ReadBtn.TabIndex = 2;
            this.ReadBtn.Text = "Read...";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Itens";
            // 
            // rtfLOG
            // 
            this.rtfLOG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtfLOG.BackColor = System.Drawing.SystemColors.Menu;
            this.rtfLOG.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfLOG.Location = new System.Drawing.Point(-30, 194);
            this.rtfLOG.Name = "rtfLOG";
            this.rtfLOG.Size = new System.Drawing.Size(381, 260);
            this.rtfLOG.TabIndex = 6;
            this.rtfLOG.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "N = ";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(28, 92);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(27, 20);
            this.txtN.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Peso = ";
            // 
            // txtPesoSacola
            // 
            this.txtPesoSacola.Location = new System.Drawing.Point(240, 92);
            this.txtPesoSacola.Name = "txtPesoSacola";
            this.txtPesoSacola.Size = new System.Drawing.Size(36, 20);
            this.txtPesoSacola.TabIndex = 8;
            // 
            // RunGABtn
            // 
            this.RunGABtn.Location = new System.Drawing.Point(283, 96);
            this.RunGABtn.Name = "RunGABtn";
            this.RunGABtn.Size = new System.Drawing.Size(68, 23);
            this.RunGABtn.TabIndex = 9;
            this.RunGABtn.Text = "Run";
            this.RunGABtn.UseVisualStyleBackColor = true;
            this.RunGABtn.Click += new System.EventHandler(this.RunGABtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readListToolStripMenuItem,
            this.clearLogToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readListToolStripMenuItem
            // 
            this.readListToolStripMenuItem.Name = "readListToolStripMenuItem";
            this.readListToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.readListToolStripMenuItem.Text = "Read list...";
            this.readListToolStripMenuItem.Click += new System.EventHandler(this.readListToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.singleStepToolStripMenuItem,
            this.toolStripMenuItem1,
            this.runToolStripMenuItem1});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // singleStepToolStripMenuItem
            // 
            this.singleStepToolStripMenuItem.Name = "singleStepToolStripMenuItem";
            this.singleStepToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.singleStepToolStripMenuItem.Text = "Single Step";
            this.singleStepToolStripMenuItem.Click += new System.EventHandler(this.singleStepToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.runToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutKnapsack10ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutKnapsack10ToolStripMenuItem
            // 
            this.aboutKnapsack10ToolStripMenuItem.Name = "aboutKnapsack10ToolStripMenuItem";
            this.aboutKnapsack10ToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutKnapsack10ToolStripMenuItem.Text = "About Knapsack 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGenStop);
            this.groupBox1.Controls.Add(this.txtMaxGen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMRate);
            this.groupBox1.Controls.Add(this.txtElitRate);
            this.groupBox1.Controls.Add(this.txtPopsize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtGenStop
            // 
            this.txtGenStop.Location = new System.Drawing.Point(229, 31);
            this.txtGenStop.Name = "txtGenStop";
            this.txtGenStop.Size = new System.Drawing.Size(40, 20);
            this.txtGenStop.TabIndex = 19;
            // 
            // txtMaxGen
            // 
            this.txtMaxGen.Location = new System.Drawing.Point(176, 31);
            this.txtMaxGen.Name = "txtMaxGen";
            this.txtMaxGen.Size = new System.Drawing.Size(40, 20);
            this.txtMaxGen.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "GSTOP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "MAXGEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "MUTATE";
            // 
            // txtMRate
            // 
            this.txtMRate.Location = new System.Drawing.Point(123, 31);
            this.txtMRate.Name = "txtMRate";
            this.txtMRate.Size = new System.Drawing.Size(40, 20);
            this.txtMRate.TabIndex = 13;
            // 
            // txtElitRate
            // 
            this.txtElitRate.Location = new System.Drawing.Point(70, 31);
            this.txtElitRate.Name = "txtElitRate";
            this.txtElitRate.Size = new System.Drawing.Size(40, 20);
            this.txtElitRate.TabIndex = 14;
            // 
            // txtPopsize
            // 
            this.txtPopsize.Location = new System.Drawing.Point(17, 31);
            this.txtPopsize.Name = "txtPopsize";
            this.txtPopsize.Size = new System.Drawing.Size(40, 20);
            this.txtPopsize.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ELITE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "POPSIZE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Vol = ";
            // 
            // txtVolumeSacola
            // 
            this.txtVolumeSacola.Location = new System.Drawing.Point(132, 92);
            this.txtVolumeSacola.Name = "txtVolumeSacola";
            this.txtVolumeSacola.Size = new System.Drawing.Size(40, 20);
            this.txtVolumeSacola.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RunGABtn);
            this.Controls.Add(this.txtVolumeSacola);
            this.Controls.Add(this.txtPesoSacola);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.rtfLOG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.listSack);
            this.Controls.Add(this.txtItemList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Knapsack GA Volume";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemList;
        private System.Windows.Forms.ListBox listSack;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtfLOG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesoSacola;
        private System.Windows.Forms.Button RunGABtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleStepToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutKnapsack10ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGenStop;
        private System.Windows.Forms.TextBox txtMaxGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMRate;
        private System.Windows.Forms.TextBox txtElitRate;
        private System.Windows.Forms.TextBox txtPopsize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVolumeSacola;
    }
}

