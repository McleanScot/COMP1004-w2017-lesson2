using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_w2017_lesson2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void CalculatorButton_Clicked(object sender, EventArgs e)
        {
            //could also do as Button
            Button CalculatorButton = (Button)sender;

            label1.Text += CalculatorButton.Text;
        }
    }
}
