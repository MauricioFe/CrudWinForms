﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinoCrud.Models;

namespace TreinoCrud
{
    public partial class FrmMenu : Form
    {
        Usuario _usuario = new Usuario();
        public FrmMenu(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += " " + _usuario.Nome;
        }
    }
}