using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms1
{
    public partial class Form1 : Form
    {
        public class Tovar
        {
            public string cina;
            public string craina;
            public string nazva;
            public string data_pakuvania;
            public string opis;


        }
        public class Producty : Tovar
        {
            public string termin_prudatnosti;
            public string kilkist;
            public string odunucia_vumiry;
        }
        public class Knuhy : Tovar
        {
            public string kilkist_storinok;
            public string vudavnutstvo;
            public string perelik_avtoriv;
        }
        public List<Tovar> lst = new List<Tovar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Knuhy k = new Knuhy();
            k.cina = textBox1.Text;
            k.craina = textBox2.Text;
            k.nazva = textBox3.Text;
            k.data_pakuvania = textBox4.Text;
            k.opis = textBox5.Text;
            k.kilkist_storinok = textBox6.Text;
            k.vudavnutstvo = textBox8.Text;
            k.perelik_avtoriv = textBox9.Text;
            lst.Add(k);
            dataGridView1.Rows.Add((lst.Count).ToString(), "knuha", k.cina, k.craina, k.nazva, k.data_pakuvania, k.opis, k.kilkist_storinok + " " + k.vudavnutstvo + " " + k.perelik_avtoriv);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(textBox7.Text);
                lst.RemoveAt(num - 1);
                dataGridView1.Rows.RemoveAt(num - 1);
                for (int i = 0; i < dataGridView1.Rows.Count; i++) dataGridView1[0, i].Value = (i+1).ToString();
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producty k = new Producty();
            k.cina = textBox1.Text;
            k.craina = textBox2.Text;
            k.nazva = textBox3.Text;
            k.data_pakuvania = textBox4.Text;
            k.opis = textBox5.Text;
            k.termin_prudatnosti = textBox6.Text;
            k.kilkist = textBox8.Text;
            k.odunucia_vumiry = textBox9.Text;
            lst.Add(k);
            dataGridView1.Rows.Add((lst.Count).ToString(), "produck", k.cina, k.craina, k.nazva, k.data_pakuvania, k.opis, k.termin_prudatnosti + " " + k.kilkist + " " + k.odunucia_vumiry);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
