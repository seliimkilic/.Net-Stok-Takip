﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CevikMetalTeknik
{
    public partial class denemeresim : Form
    {
        public denemeresim()
        {
            InitializeComponent();
        }

        private void denemeresim_Load(object sender, EventArgs e)
        {

        }
        public void SetImage(Image image)
        {
            pictureBox1.Image = image;
        }
    }
}
