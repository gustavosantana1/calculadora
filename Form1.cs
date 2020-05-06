using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFinal
{
    public partial class Form1 : Form
    {
        Double resultValue;
        String operationPerformed = "";
        String lastDigit = "";

        // Control Variables
        bool isResult = false;
        bool isOperationPerformed = false;
        bool invalidEntry = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        //GETS AND SETS//

        public void setLastDigit(String value)
        {
            this.lastDigit = value;
        }

        public String getLastDitig()
        {
            return this.lastDigit;
        }

        public void setOperationPerformed(String value)
        {
            this.operationPerformed = value;
        }

        public String getOperationPerformed()
        {
           return this.operationPerformed;
        }

        public bool getInvalidEntry()
        {
            return this.invalidEntry;
        }

        public void setInvalidEntry(bool value)
        {
            this.invalidEntry = value;
        }

        public bool getIsResult()
        {
            return this.isResult;
        }

        public void setIsResult(bool value)
        {
            this.isResult = value;
        }

        public void setTextBoxResultText(String value)
        {

            this.textBox_Result.Text = value;
        }
        public String getTextBoxResultText()
        {
            return this.textBox_Result.Text;
        }

     
        public void setlabelCurrentOperation(String value)
        {

            this.labelCurrentOperation.Text = value;
        }
        public String getlabelCurrentOperation()
        {
            return this.labelCurrentOperation.Text;
        }
        private void setResultValue(Double value)
        {
            this.resultValue = value;
        }
        public Double getResultValue()
        {
            return this.resultValue;
        }

        public void setIsOperationPerformed(bool value)
        {
            this.isOperationPerformed = value;
        }


        public bool getIsOperationPerformed()
        {
            return this.isOperationPerformed;
        }



        //FIM GETS AND SETS//


        public bool verifyDigit(String value)
        {
            String[] operators = new String[4] { "*", "/", "-", "+" };
            if (operators.Contains(value)) return true;
            else return false;
        }

        public void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            setLastDigit(button.Text);
            if ((getTextBoxResultText() == "0") || (getIsOperationPerformed()))
            {
                textBox_Result.Clear();
            }

            setIsOperationPerformed(false);
            if (button.Text == ",")
            {
                if (!getTextBoxResultText().Contains(","))
                    setTextBoxResultText(getTextBoxResultText() + button.Text);
            } else if (getInvalidEntry())
            {
                setTextBoxResultText("");
                setTextBoxResultText(getTextBoxResultText() + button.Text);
                setInvalidEntry(false);
                setlabelCurrentOperation("");
                desableBtn(true);
            }else
            {
                setTextBoxResultText(getTextBoxResultText() + button.Text);
            }
                
            

        }

        


        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            setLastDigit(button.Text);
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                if (verifyDigit(getLastDitig()))
                {
                    setOperationPerformed(button.Text);
                    setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                }
                return;
            }
            else
            {
                if (String.IsNullOrEmpty(getResultValue().ToString()) || getResultValue() == 0)
                {
                    if (verifyDigit(getLastDitig()))
                    {
                        setOperationPerformed(button.Text);
                        setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                    }
                    setOperationPerformed(button.Text);
                    try
                    {
                        setResultValue(Double.Parse(getTextBoxResultText()));
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                    setIsOperationPerformed(true);

                }
                else
                {
                    if (getIsResult() && getIsOperationPerformed())
                    {
                        if (verifyDigit(getLastDitig()))
                        {
                            setOperationPerformed(button.Text);
                            setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                        }
                        setOperationPerformed(button.Text);
                        try
                        {
                            setResultValue(Double.Parse(getTextBoxResultText()));
                        }
                        catch (Exception)
                        {
                            setResultValue(0);
                        }

                        setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                        setIsOperationPerformed(true);
                        setTextBoxResultText("");
                        setIsResult(false);
                    }
                    else
                    {
                        if (verifyDigit(getLastDitig()))
                        {
                            setOperationPerformed(button.Text);
                            setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                        }
                        btnEqual.PerformClick();
                        setOperationPerformed(button.Text);
                        setlabelCurrentOperation(getResultValue() + " " + getOperationPerformed());
                        setIsOperationPerformed(true);
                        setIsResult(true);
                    }


                }
            }
            setTextBoxResultText("");
        }



        private void BtnLog_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (String.IsNullOrEmpty(getTextBoxResultText()) || getTextBoxResultText() == "0")
            {

                setlabelCurrentOperation("Log(" + Convert.ToString("0") + ")");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);



            }
            else
            {

               
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Log(value, 10));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Log(" + Convert.ToString(value) + ")");
            }

        }

        private void BtnLn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (String.IsNullOrEmpty(getTextBoxResultText()) || getTextBoxResultText() == "0")
            {

                setlabelCurrentOperation("Ln(" + Convert.ToString("0") + ")");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);



            }
            else
            {


                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Log(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Ln(" + Convert.ToString(value) + ")");
            }

        }



        private void BtnCos_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            }
            else if (getTextBoxResultText() == "0")
            {


               
                setlabelCurrentOperation("Cos(" + Convert.ToString("0") + ")");
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Cos(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Cos(" + Convert.ToString(value) + ")");


            }
            else
            {

                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Cos(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Cos(" + Convert.ToString(value) + ")");


            }
        }

        private void BtnSen_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            }
            else if (getTextBoxResultText() == "0")
            {



                setlabelCurrentOperation("Sen(" + Convert.ToString("0") + ")");
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Sin(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Sen(" + Convert.ToString(value) + ")");


            }
            else
            {

                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Sin(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Sen(" + Convert.ToString(value) + ")");


            }
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            }
            else if (getTextBoxResultText() == "0")
            {



                setlabelCurrentOperation("Tan(" + Convert.ToString("0") + ")");
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Tan(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Tan(" + Convert.ToString(value) + ")");


            }
            else
            {

                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Tan(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Tan(" + Convert.ToString(value) + ")");


            }


        }



        private void BtnFact_Click(object sender, EventArgs e)
        {


            Button button = (Button)sender;
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            }
            else if (getTextBoxResultText() == "0")
            {

                double value = Double.Parse(getTextBoxResultText());
                double fact = 1;
                for (int i = 1; i <= value; i++)
                {
                    fact *= i;
                }

                setResultValue(fact);
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Fact(" + Convert.ToString(value) + ")");


            }
            else
            {

                double value = Double.Parse(getTextBoxResultText());
                double fact = 1;
                for (int i = 1; i <= value; i++)
                {
                    fact *= i;
                }

                setResultValue(fact);
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("Fact(" + Convert.ToString(value) + ")");

            }
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            } else
            {
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Sqrt(value));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("√(" + Convert.ToString(value) + ")");
            }
           
        }


        private void BtnSquare_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            } else
            {
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Pow(value, 2));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("(" + Convert.ToString(value) + ")^2");
            }
            
        }

        private void BtnCube_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            } else
            {
                double value = Double.Parse(getTextBoxResultText());
                setResultValue(Math.Pow(value, 3));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("(" + Convert.ToString(value) + ")^3");
            }
            
        }
        private void BtnPi_Click(object sender, EventArgs e)
        {
            
            setTextBoxResultText(Convert.ToString(3.1415));
        }

        private void BtnInv_Click(object sender, EventArgs e)
        {

            double value = 0;

            try
            {
                value = Double.Parse(getTextBoxResultText());
            }
            catch (Exception)
            {
                setTextBoxResultText("Entrada Invalida");
                setInvalidEntry(true);
                desableBtn(false);
            }
                   
            if(value == 0 || String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setTextBoxResultText("Entrada Invalida");
                setInvalidEntry(true);
                desableBtn(false);
            }
            else
            {
                
                setResultValue(1 / value);
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("1/" + Convert.ToString(value));
            }
            
          
        }
        private void BtnPercent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setlabelCurrentOperation("");
                setTextBoxResultText("Entrada Inválida");
                setInvalidEntry(true);
                desableBtn(false);
            }
             else if (getTextBoxResultText() == "0")
            {

                double value = Double.Parse(getTextBoxResultText());
                setResultValue(0);
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("(" + Convert.ToString(value) + ")");
            }
            else
            {
                double value = Double.Parse(getTextBoxResultText());
                setResultValue((value / 100));
                setTextBoxResultText(Convert.ToString(getResultValue()));
                setlabelCurrentOperation("(" + Convert.ToString(value) + ")");

            }

        }


        public void desableBtn(Boolean value)
        {

            if (!value)
            {
                Convert.ToBoolean(BtnLog.Enabled = false);
                Convert.ToBoolean(BtnInv.Enabled = false);
                Convert.ToBoolean(BtnLn.Enabled = false);
                Convert.ToBoolean(BtnCos.Enabled = false);
                Convert.ToBoolean(BtnSen.Enabled = false);
                Convert.ToBoolean(BtnTan.Enabled = false);
                Convert.ToBoolean(BtnPI.Enabled = false);
                Convert.ToBoolean(BtnRaiz.Enabled = false);
                Convert.ToBoolean(BtnSquare.Enabled = false);
                Convert.ToBoolean(BtnCube.Enabled = false);
                Convert.ToBoolean(BtnPercent.Enabled = false);
                Convert.ToBoolean(BtnDiv.Enabled = false);
                Convert.ToBoolean(BtnMulti.Enabled = false);
                Convert.ToBoolean(BtnMinus.Enabled = false);
                Convert.ToBoolean(BtnPlus.Enabled = false);
                Convert.ToBoolean(BtnFact.Enabled = false);
                Convert.ToBoolean(BtnVir.Enabled = false);
                Convert.ToBoolean(BtnGraph.Enabled = false);
                Convert.ToBoolean(btnEqual.Enabled = false);

            }
            else
            {

                Convert.ToBoolean(BtnLog.Enabled = true);
                Convert.ToBoolean(BtnInv.Enabled = true);
                Convert.ToBoolean(BtnLn.Enabled = true);
                Convert.ToBoolean(BtnCos.Enabled = true);
                Convert.ToBoolean(BtnSen.Enabled = true);
                Convert.ToBoolean(BtnTan.Enabled = true);
                Convert.ToBoolean(BtnPI.Enabled = true);
                Convert.ToBoolean(BtnRaiz.Enabled = true);
                Convert.ToBoolean(BtnSquare.Enabled = true);
                Convert.ToBoolean(BtnCube.Enabled = true);
                Convert.ToBoolean(BtnPercent.Enabled = true);
                Convert.ToBoolean(BtnDiv.Enabled = true);
                Convert.ToBoolean(BtnMulti.Enabled = true);
                Convert.ToBoolean(BtnMinus.Enabled = true);
                Convert.ToBoolean(BtnPlus.Enabled = true);
                Convert.ToBoolean(BtnFact.Enabled = true);
                Convert.ToBoolean(BtnVir.Enabled = true);
                Convert.ToBoolean(BtnGraph.Enabled = true);
                Convert.ToBoolean(btnEqual.Enabled = true);
            }

        }






        /*private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }*/

        public void BtnClear_Click(object sender, EventArgs e)
        {
            setTextBoxResultText("0");
            setlabelCurrentOperation("");
            setResultValue(0);
            desableBtn(true);
            setIsResult(false);
            setInvalidEntry(false);
            setIsOperationPerformed(false);
            setLastDigit("");
        }

        

        


        public void button15_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(getTextBoxResultText()) || getInvalidEntry())
            {
                return;
            } else
            {
                switch (getOperationPerformed())
                {
                    case "+":
                        setTextBoxResultText((getResultValue() + Double.Parse(getTextBoxResultText())).ToString());
                        setIsResult(true);
                        setIsOperationPerformed(true);
                        break;
                    case "-":
                        setTextBoxResultText((getResultValue() - Double.Parse(getTextBoxResultText())).ToString());
                        setIsResult(true);
                        setIsOperationPerformed(true);
                        break;
                    case "*":
                        setTextBoxResultText((getResultValue() * Double.Parse(getTextBoxResultText())).ToString());
                        setIsResult(true);
                        setIsOperationPerformed(true);
                        break;
                    case "/":
                        if (getResultValue() == 0 || getTextBoxResultText() == "0")
                        {
                            desableBtn(false);
                            setTextBoxResultText("Entrada invalida");
                        }
                        else
                        {
                            setTextBoxResultText((getResultValue() / Double.Parse(getTextBoxResultText())).ToString());
                            setIsResult(true);
                            setIsOperationPerformed(true);
                        }

                        break;

                    default:
                        break;
                }
            }
            
            

            try
            {
                setResultValue(Double.Parse(getTextBoxResultText()));
            }
            catch (System.FormatException)
            {
                setResultValue(0);
            }
            setlabelCurrentOperation("");
        }

        private void BtnGraph_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() > 0)
            {
                MessageBox.Show("Está janela já esta aberta. Feche-a para abrir uma nova!");
            }
            else
            {
                Form2 PolynomialGraph = new Form2();
                PolynomialGraph.Show();
            }
            
        }

        private void BtnVir_Click(object sender, EventArgs e)
        {
            if(getTextBoxResultText().Length == 1 && getTextBoxResultText() == "0" || String.IsNullOrEmpty(getTextBoxResultText()))
            {
                setTextBoxResultText("0,");
            } else if (getTextBoxResultText().Length == 1)
            {
                setTextBoxResultText(getTextBoxResultText() + ",");
            }           
            else if(getTextBoxResultText().IndexOf(",") != -1)
            {
                return;
            } else
            {
                setTextBoxResultText(getTextBoxResultText() + ",");
            }
        }
    }
}
