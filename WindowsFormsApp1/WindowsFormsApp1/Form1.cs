using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int nroImagem = 1;
        private int totalImagens = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nroImagem = (nroImagem % totalImagens) + 1;
            pbImagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("img{0}", nroImagem));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (nroImagem == 1)
                nroImagem = 1;
            else
            {
                nroImagem--;
            }

            pbImagem.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("img{0}", nroImagem));
        }
    }
}
