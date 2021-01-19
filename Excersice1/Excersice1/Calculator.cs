using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersice1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello C# !!";

            
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(sum1.Text);
            int number2 = Convert.ToInt32(sum2.Text);

            int Sum = number1 + number2;

            SumResult.Text = Sum.ToString();
        }
    }
}
