﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIDInterfaceAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            HID myhid = new HID();
            lblstatus.Text = myhid.Gethid();
        }
    }
}