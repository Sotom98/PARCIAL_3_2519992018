using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Login {
    public partial class Porcentaje : Form {
        public Porcentaje() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Class1 cl1 = new Class1();

            double cnt, prj, resul;

            cnt = double.Parse(textBox1.Text);
            prj = (double.Parse(textBox2.Text)) / 100;

            resul = cl1.Porcentaje(cnt, prj);

            textBox3.Text = resul.ToString();

            if (radioButton1.Checked == true) {
                double resulB;

                resulB = resul + cnt;
                textBox4.Text = resulB.ToString();
            }
        }
    }
}
