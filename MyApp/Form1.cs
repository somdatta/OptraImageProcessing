﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Euraqua!!!!";

            const string caption = "Hello";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information); 
        }
    }
}
