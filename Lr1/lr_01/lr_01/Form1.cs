using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace lr_01
{
    public partial class Calculator : Form
    {
        double result = 0, fkatet, skatet, number;
        double _degree;
        public Calculator()
        {
            InitializeComponent();

            sin.Click += button1_Click;
            cos.Click += cos_Click;
            tg.Click += tg_Click;
            ctg.Click += ctg_Click;
            textBox1.Validating += textBox1_Validating;
            //textBox2.Validating += textBox2_Validating;
            textBox4.Validating += textBox4_Validating;
            textBox5.Validating += textBox5_Validating;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            /*
            this.Controls.Add(firsttext);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                number = double.Parse(textBox1.Text);
                //skatet = double.Parse(textBox2.Text);

                /*result = fkatet / skatet;
                textBox3.Text = result.ToString();*/
                result = Math.Sin(number);
                textBox3.Text = result.ToString();

                if (number < 0 || !double.TryParse(textBox1.Text, out number))
                {
                    throw new Exception("Uncorrect data. Please, try again");
                }
            }
            catch
            {
                textBox3.Text = "No data to solve!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* TextBox firsttext = new TextBox();
             firsttext.Text = string.Empty;*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cos_Click(object sender, EventArgs e)
        {


            try
            {
                number = double.Parse(textBox1.Text);

                result = Math.Cos(number);
                textBox3.Text = result.ToString();

                if (number < 0 || !double.TryParse(textBox1.Text, out number))
                {
                    throw new Exception("Uncorrect data. Please, try again");
                }
            }
            catch
            {
                textBox3.Text = "No data to solve!";
            }
        }

        private void tg_Click(object sender, EventArgs e)
        {


            try
            {
                number = double.Parse(textBox1.Text);

                result = Math.Tan(number);

                textBox3.Text = result.ToString();

                if (number < 0 || !double.TryParse(textBox1.Text, out number))
                {
                    throw new Exception("Uncorrect data. Please, try again");
                }
            }
            catch
            {
                textBox3.Text = "No data to solve!";
            }
        }

        private void ctg_Click(object sender, EventArgs e)
        {


            try
            {
                number = double.Parse(textBox1.Text);

                result = 1 / Math.Tan(number);
                textBox3.Text = result.ToString();

                if (number < 0 || !double.TryParse(textBox1.Text, out number))
                {
                    throw new Exception("Uncorrect data. Please, try again");
                }
            }
            catch
            {
                textBox3.Text = "No data to solve!";
            }
        }

        private void cube_Click(object sender, EventArgs e)
        {


            try
            {
                number = double.Parse(textBox4.Text);

                result = Math.Pow(number, 3);
                textBox6.Text = result.ToString();

                if (!double.TryParse(textBox4.Text, out number))
                {
                    throw new Exception("Not a number");
                }
            }
            catch
            {
                textBox6.Text = "No data to solve!";
            }
        }

        private void square_Click(object sender, EventArgs e)
        {

            try
            {
                number = double.Parse(textBox4.Text);

                result = Math.Pow(number, 2);
                textBox6.Text = result.ToString();

                if (!double.TryParse(textBox4.Text, out number))
                {
                    throw new Exception("Not a number");
                }
            }
            catch
            {
                textBox6.Text = "No data to solve!";
            }
        }

        private void degree_Click(object sender, EventArgs e)
        {

            try
            {
                number = double.Parse(textBox4.Text);
                _degree = double.Parse(textBox5.Text);

                result = Math.Pow(number, _degree);
                textBox6.Text = result.ToString();

                if (!double.TryParse(textBox4.Text, out number) || !double.TryParse(textBox5.Text, out number))
                {
                    throw new Exception("Not a number");
                }
            }
            catch
            {
                textBox6.Text = "No data to solve!";
            }
        }

        private void cleanvalues_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox6.Clear();
        }

        private void textBox1_Validating(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out number) || (double.Parse(textBox1.Text) < 0))
            {
                textBox1.Text = "Enter correct number!";
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }
        

        private void textBox4_Validating(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox4.Text, out number))
            {
                textBox4.Text = "Enter correct number!";
                textBox4.BackColor = Color.Red;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }
        }
        private void textBox5_Validating(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox5.Text, out number))
            {
                textBox5.Text = "Enter correct number!";
                textBox5.BackColor = Color.Red;
            }
            else
            {
                textBox5.BackColor = Color.White;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Heaven.Text += (textBox3.Text.ToString() + " \n");
                //
                for (int i = 0; i < 1; i++)
                {
                    Heaven.Items.Insert(i, textBox3.Text.ToString());
                }

                if (textBox3.Text.Length <= 0)
                {
                    throw new Exception("Empty cell. Nothing to save");
                }
            }
            catch
            {
                for (int i = 0; i < 15; i++)
                {
                    Heaven.Items.Insert(i, "Fail");
                }
            }
        }

        private void Get_Click(object sender, EventArgs e)
        {
            try
            {
                double[] num = new double[15];

                for (int i = 0; i < Heaven.Items.Count; i++)
                {
                    num[i] = Convert.ToDouble(Heaven.Items[i].ToString());
                }


                for (int i = 0; i < 1; i++)
                {
                    textBox4.Text = num[i].ToString();
                }

            }
            catch
            {
                textBox6.Text = "Somthing wrong...";
            }
        }

        private void cleanList_Click(object sender, EventArgs e)
        {
            Heaven.Items.Clear();
        }

        private void cleanLastElement_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Heaven.Items.Count; i++)
                {
                    Heaven.Items.Remove(Heaven.Items[0]);
                    break;
                }
            }
            catch
            {

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}