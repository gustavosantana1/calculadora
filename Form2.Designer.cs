namespace CalculatorFinal
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.graf_a = new System.Windows.Forms.TextBox();
            this.graf_b = new System.Windows.Forms.TextBox();
            this.graf_c = new System.Windows.Forms.TextBox();
            this.graf_d = new System.Windows.Forms.TextBox();
            this.graf_e = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.graf_limite = new System.Windows.Forms.TextBox();
            this.graf_passo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(44, 17);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(418, 307);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(44, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Graph";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Bt_salvar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(369, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // graf_a
            // 
            this.graf_a.Location = new System.Drawing.Point(21, 25);
            this.graf_a.Name = "graf_a";
            this.graf_a.Size = new System.Drawing.Size(43, 20);
            this.graf_a.TabIndex = 3;
            this.graf_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // graf_b
            // 
            this.graf_b.Location = new System.Drawing.Point(70, 25);
            this.graf_b.Name = "graf_b";
            this.graf_b.Size = new System.Drawing.Size(43, 20);
            this.graf_b.TabIndex = 4;
            this.graf_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // graf_c
            // 
            this.graf_c.Location = new System.Drawing.Point(119, 25);
            this.graf_c.Name = "graf_c";
            this.graf_c.Size = new System.Drawing.Size(43, 20);
            this.graf_c.TabIndex = 5;
            this.graf_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // graf_d
            // 
            this.graf_d.Location = new System.Drawing.Point(168, 25);
            this.graf_d.Name = "graf_d";
            this.graf_d.Size = new System.Drawing.Size(43, 20);
            this.graf_d.TabIndex = 6;
            this.graf_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // graf_e
            // 
            this.graf_e.Location = new System.Drawing.Point(217, 25);
            this.graf_e.Name = "graf_e";
            this.graf_e.Size = new System.Drawing.Size(43, 20);
            this.graf_e.TabIndex = 7;
            this.graf_e.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(232, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "E";
            // 
            // graf_limite
            // 
            this.graf_limite.Location = new System.Drawing.Point(21, 65);
            this.graf_limite.Name = "graf_limite";
            this.graf_limite.Size = new System.Drawing.Size(100, 20);
            this.graf_limite.TabIndex = 13;
            this.graf_limite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // graf_passo
            // 
            this.graf_passo.Location = new System.Drawing.Point(160, 65);
            this.graf_passo.Name = "graf_passo";
            this.graf_passo.Size = new System.Drawing.Size(100, 20);
            this.graf_passo.TabIndex = 14;
            this.graf_passo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Limite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(195, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passo";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo CSV |*.csv";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(21, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "Plotar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Bt_plotar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.graf_passo);
            this.panel1.Controls.Add(this.graf_limite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.graf_e);
            this.panel1.Controls.Add(this.graf_d);
            this.panel1.Controls.Add(this.graf_c);
            this.panel1.Controls.Add(this.graf_b);
            this.panel1.Controls.Add(this.graf_a);
            this.panel1.Location = new System.Drawing.Point(184, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 142);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.grafico);
            this.panel2.Location = new System.Drawing.Point(75, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 384);
            this.panel2.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(644, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilynom Graph";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox graf_a;
        private System.Windows.Forms.TextBox graf_b;
        private System.Windows.Forms.TextBox graf_c;
        private System.Windows.Forms.TextBox graf_d;
        private System.Windows.Forms.TextBox graf_e;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox graf_limite;
        private System.Windows.Forms.TextBox graf_passo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}