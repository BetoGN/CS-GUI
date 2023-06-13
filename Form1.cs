using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyParadigmas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        static long CalculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * CalculateFactorial(number - 1);
            }
        }

        private void CalcB_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (!(int.TryParse(txtIn.Text, out number)))
            {
                MessageBox.Show("Introduce un entero");
            }


            long factorial = CalculateFactorial(number);


            result.Text= factorial.ToString();


            try
            {


                string myfile = @"LogFactorial.txt";

                // Appending the given texts
                using (StreamWriter sw = File.AppendText(myfile))
                {
                    sw.WriteLine(factorial);
                }

                /*
                // Opening the file for reading
                using (StreamReader sr = File.OpenText(myfile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        txtLog.Text= System.Environment.NewLine + s;
                    }
                }
                */

                txtLog.Text = File.ReadAllText(myfile);
            }
            catch (IOException er)
            {
                Console.WriteLine("I/O Error: " + er.Message);
            }
            catch (Exception er)
            {
                Console.WriteLine("Error: " + er.Message);
            }
            txtIn.Text = "";

        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            txtLog.ReadOnly = true;
        }
    }
}
