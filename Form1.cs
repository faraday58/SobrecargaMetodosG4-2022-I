using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SobrecargaMetodosG4_2022_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar1_Click(object sender, EventArgs e)
        {
            float sumando1 = float.Parse( txtbSumando1.Text);
            float sumando2 = float.Parse(txtbSumando2.Text);
            float suma = Sumar(sumando1, sumando2);
            lbSuma1.Text = suma.ToString();
        }

        private float Sumar(float sumando1, float sumando2  )
        {
            return sumando1 + sumando2;
        }

        private float Sumar(float sumando1, float sumando2, float sumando3)
        {
            return sumando1 + sumando2 + sumando3;
        }

        private void btnSumar22_Click(object sender, EventArgs e)
        {
            float operando1 = float.Parse(txtbSumando12.Text);
            float operando2 = float.Parse(txtbSumando22.Text);
            float operando3 = float.Parse(txtbSumando32.Text);
            float suma = Sumar(operando1, operando2, operando3);
            lbSuma22.Text = suma.ToString();
        }


    }
}
