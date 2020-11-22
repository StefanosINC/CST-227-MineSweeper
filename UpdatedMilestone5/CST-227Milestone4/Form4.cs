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

namespace CST_227Milestone4
{
    public partial class Form4 : Form
    {

        List<PlayerStats> player = new List<PlayerStats>();
        public Form4()
        {
          

            InitializeComponent();
           
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Name " + textBox1.Text);
            listBox1.Items.Add(" Points " + textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string Path = @"C:\Users\stefa\Desktop\HighScores.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(Path);
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Score Info is saved");
            Application.Exit();
        }
    }
}
