using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //OpenFileDialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları |*.bmp;*.jpg;*.png";
            ofd.Title = "Resim Seçiniz";
           
            if(ofd.ShowDialog() == DialogResult.OK)
            {              
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   //FontDialog
            FontDialog fontDialog = new FontDialog();

            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap=MessageBox.Show("Kayıt Silinsin mi?", "Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(cevap == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Silindi");
            }

        }
    }
}
