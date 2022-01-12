﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa155_fingStringExact02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yer = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            string aranan;
            aranan = textBox1.Text;
            yer = listBox1.FindStringExact(aranan, yer);

            if (yer < 0)
            {
                MessageBox.Show("Aranan İfade Bulunamadı");
            }
            else
            {
                MessageBox.Show((yer + 1).ToString() + ". eleman");
                listBox1.SelectedIndex = yer;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] isimler = {"İsmail","Asaf","Ömer","Mustafa" };
            listBox1.Items.AddRange(isimler);

        }
    }
}
