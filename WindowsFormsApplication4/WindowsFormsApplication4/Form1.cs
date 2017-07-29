using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class osoba
        {
            public string ime;
            public string prezime;
            public int tezina;
            public int visina;
            public string pol;
            public void Pol(string x)
            {
                pol = x;
            }
            public string Pol1()
            {
                return pol;
            }
            public osoba(string x, string y, int a, int b)
            {
                ime = x; prezime = y; tezina = a; visina = b;
            }
        }
        class decak : osoba
        {
            private string pol;
            public decak(string x, string y, int a, int b):base(x,y,a,b)
            {
                ime = x; prezime = y; tezina = a; visina = b;
            }
           
        }
        class devojcica : osoba
        {
            private string pol;
        public devojcica(string x, string y, int a, int b):base(x,y,a,b)
            {
                ime = x; prezime = y; tezina = a; visina = b;
            }
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            string p = textBox6.Text;
            if (checkBox1.Checked) 
            {
                osoba Covek = new osoba(a, b, c, d);
                textBox5.Text=Covek.ime+""+Covek.prezime+""+Covek.tezina+""+Covek.visina;
            }
            if (checkBox2.Checked)
            {
                osoba Decak = new decak(a, b, c, d);
                Decak.Pol(p);
                textBox5.Text = Decak.ime + "" + Decak.prezime + "" + Decak.tezina + "" + Decak.visina+Decak.Pol1();
            }
            if (checkBox3.Checked)
            {
                osoba Ana = new devojcica(a, b, c, d);
                Ana.Pol(p);
                textBox5.Text = Ana.ime + "" + Ana.prezime + "" + Ana.tezina + "" + Ana.visina+Ana.Pol1();
            }
        }
    }
}
