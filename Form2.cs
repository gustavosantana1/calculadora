using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CalculatorFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel2.Hide();
            ClientSize = new System.Drawing.Size(660, 200);
        }

        double limite, cont_plot;
        String arquivo = string.Empty;

        double[] x_csv = new double[2000];
        double[] y_csv = new double[2000];

        private void Display_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!(char.IsNumber(e.KeyChar)) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Back))

            {

                e.Handled = false;

            }

        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_plotar_Click(object sender, EventArgs e)
        {
            double y, ga, gb, gc, passo;

            

            grafico.Series[0].Points.Clear();

            if (!String.IsNullOrEmpty(graf_a.Text) && !String.IsNullOrEmpty(graf_b.Text) && !String.IsNullOrEmpty(graf_c.Text)  && !String.IsNullOrEmpty(graf_limite.Text) && !String.IsNullOrEmpty(graf_passo.Text))
            {
                if (Convert.ToDouble(graf_passo.Text) != 0)
                {

                    if (Convert.ToInt32(graf_limite.Text) > 0)
                    {
                        panel2.Show();
                        ga = Convert.ToDouble(graf_a.Text);
                        gb = Convert.ToDouble(graf_b.Text);
                        gc = Convert.ToDouble(graf_c.Text);

                        limite = Convert.ToInt32(graf_limite.Text);
                        passo = Convert.ToDouble(graf_passo.Text);

                        ClientSize = new System.Drawing.Size(660, 580);
                        StartPosition = new FormStartPosition();
                        
                        grafico.Visible = true;

                        int indice = 0;

                        //if (limite < 0) limite *= -1;
                        cont_plot = 1;
                        for (double x = (limite * -1); x < limite; x += passo)
                        {
                            y = ga*(Math.Pow(x, 2)) + gb*x + gc;
                            grafico.Series[0].Points.AddXY(x, y);
                            if (indice < 2000)
                            {
                                x_csv[indice] = x;
                                y_csv[indice] = y;
                            }
                            indice++;
                        }


                    }
                    else MessageBox.Show("Limite deve ser maior que Zero!");
                }
                else MessageBox.Show("Passo deve ser diferente de Zero!");
            }
            else MessageBox.Show("Valores não podem ser nulos!");

        }




        private void Bt_salvar_Click(object sender, EventArgs e)
        {
            if (cont_plot == 0) MessageBox.Show("Não existem dados para serem salvos!");

            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    arquivo = saveFileDialog1.FileName;

                    using (StreamWriter sw = new StreamWriter(arquivo, true))
                    {
                        for (int i = 0; i < limite * 2; i++)
                        {
                            sw.Write(Convert.ToString(x_csv[i + 1]) + ";");
                            sw.Write(Convert.ToString(y_csv[i]) + "\n");
                        }
                    }

                    cont_plot = 0;
                    arquivo = String.Empty;
                }
            }
        }
    }
}
