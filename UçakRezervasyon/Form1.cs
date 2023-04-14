using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçakRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(MskTC.Text+" TC kimlik numaralı " + TxtAdSoyad.Text+ " isimli yolcunun " + CmbNereden.Text + "'dan " + CmbNereye.Text+"'a "+DtpTarih.Text+" tarihinde, saat "+MskSaat.Text+"'da yolculuğu vardır.");
            MessageBox.Show("Uçuşunuz kaydedilmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = CmbNereden.Text;
            CmbNereden.Text = CmbNereye.Text;
            CmbNereye.Text = label9.Text;
        }
    }
}
