using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login {
    public partial class Form1 : Form {

        private string usuario = "Oscar";
        private string password = "Soto";
 
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            if ((textBox1.Text == usuario) && (textBox2.Text == password) ) {
                //MessageBox.Show("Bienvenido");
                Formulario2 fm2 = new Formulario2();
                fm2.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Usuario y/o password incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
