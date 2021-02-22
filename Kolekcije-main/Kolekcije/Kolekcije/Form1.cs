using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcije
{

    
    public partial class Form1 : Form
    {
        List<Brkovi> brks = new List<Brkovi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Brkovi brk = new Brkovi(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToString(comboBox1.SelectedItem));

                brks.Add(brk);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                

            }
            catch(Exception greska)
            {
                MessageBox.Show("greška");
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "Podatak 1" + "\t" + "Podatak2" + "\t" + "Podatak3" + "\t" + "Podatak4" + "\r\n";
            foreach(Brkovi brk in brks)
            {
                richTextBox1.AppendText(brk.ToString());
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(Brkovi brk in brks)
            {
                if(brk.Pod4 == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
            }
        }
    }
}
