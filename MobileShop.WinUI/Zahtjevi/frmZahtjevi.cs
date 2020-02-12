﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShop.Model.Models;

namespace MobileShop.WinUI.Zahtjevi
{
    public partial class frmZahtjevi : Form
    {
        private readonly APIService _apiService = new APIService("zahtjevi");
        public frmZahtjevi()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Models.Zahtjevi>>(null);
            dgvZahtjevi.AutoGenerateColumns = false;
            dgvZahtjevi.DataSource = result;

        }
        private void FrmZahtjevi_Load(object sender, EventArgs e)
        {
            dgvZahtjevi.AutoGenerateColumns = false;
            
        }

    }
}
