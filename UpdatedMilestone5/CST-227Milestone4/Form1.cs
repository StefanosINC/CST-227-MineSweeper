using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_227Milestone4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // Getters and Setters for my Difficulty.
        public static bool Easy { get; set; }
        public static bool Medium { get; set; }
        public static bool Hard { get; set; }
        // Set parameters for each option. If the option is clicked SEt it to true. 
        private void btn_play_Click(object sender, EventArgs e)
        {
            if (rdo_easy.Checked)
            {
             Easy = true;
                Form2 newForm = new Form2(8);
                newForm.Show();
                Hide();
                
            }
            if (rdo_medium.Checked)
            {
                Medium = true;
                Form2 newForm = new Form2(12);
                newForm.Show();
                Hide();
            }
            if (rdo_hard.Checked)
            {
                Hard = true;
                Form2 newForm = new Form2(14);
                newForm.Show();
                Hide();
            }
        }

        private void rdo_medium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
