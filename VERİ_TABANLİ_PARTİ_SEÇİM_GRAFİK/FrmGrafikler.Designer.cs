﻿namespace VERİ_TABANLİ_PARTİ_SEÇİM_GRAFİK
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblE = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.PRBE = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.PRBD = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.PRBC = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.PRBb = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.PRBA = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBİLCE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 21);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1002, 332);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.PRBE);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PRBD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PRBC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PRBb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PRBA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CMBİLCE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(336, 195);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(17, 18);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "0";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(336, 166);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(17, 18);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(336, 134);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(17, 18);
            this.LblC.TabIndex = 14;
            this.LblC.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(336, 108);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(17, 18);
            this.LblB.TabIndex = 13;
            this.LblB.Text = "0";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(336, 79);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(17, 18);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "0";
            // 
            // PRBE
            // 
            this.PRBE.Location = new System.Drawing.Point(125, 190);
            this.PRBE.Maximum = 200;
            this.PRBE.Name = "PRBE";
            this.PRBE.Size = new System.Drawing.Size(205, 23);
            this.PRBE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ :";
            // 
            // PRBD
            // 
            this.PRBD.Location = new System.Drawing.Point(125, 161);
            this.PRBD.Maximum = 200;
            this.PRBD.Name = "PRBD";
            this.PRBD.Size = new System.Drawing.Size(205, 23);
            this.PRBD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ :";
            // 
            // PRBC
            // 
            this.PRBC.Location = new System.Drawing.Point(125, 132);
            this.PRBC.Maximum = 200;
            this.PRBC.Name = "PRBC";
            this.PRBC.Size = new System.Drawing.Size(205, 23);
            this.PRBC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ : ";
            // 
            // PRBb
            // 
            this.PRBb.Location = new System.Drawing.Point(125, 103);
            this.PRBb.Maximum = 200;
            this.PRBb.Name = "PRBb";
            this.PRBb.Size = new System.Drawing.Size(205, 23);
            this.PRBb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = " B PARTİ :";
            // 
            // PRBA
            // 
            this.PRBA.Location = new System.Drawing.Point(125, 74);
            this.PRBA.Maximum = 200;
            this.PRBA.Name = "PRBA";
            this.PRBA.Size = new System.Drawing.Size(205, 23);
            this.PRBA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = " A PARTİ :";
            // 
            // CMBİLCE
            // 
            this.CMBİLCE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBİLCE.FormattingEnabled = true;
            this.CMBİLCE.Location = new System.Drawing.Point(125, 32);
            this.CMBİLCE.Name = "CMBİLCE";
            this.CMBİLCE.Size = new System.Drawing.Size(205, 26);
            this.CMBİLCE.TabIndex = 1;
            this.CMBİLCE.SelectedIndexChanged += new System.EventHandler(this.CMBİLCE_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " İLÇE SEÇİN ";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1024, 665);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.Text = " VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar PRBE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar PRBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar PRBC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar PRBb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PRBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBİLCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
    }
}