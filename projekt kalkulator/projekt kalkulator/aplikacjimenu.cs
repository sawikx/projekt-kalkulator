﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projekt_kalkulator
{
    public partial class aplikacjimenu : Form
    {
        Thread th;
        public aplikacjimenu()
        {
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openform(object obj)
        {
            Application.Run(new kalkurator());
        }
    }
}