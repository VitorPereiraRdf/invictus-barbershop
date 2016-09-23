﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudioRL2._0.Class;

namespace StudioRL2._0
{
    public partial class Consulta : Form
    {
        string[] data;
        DataBase bd = new DataBase();

        //strings de incersao no banco
        string corte = "N";
        string barba = "N";
        string gel = "N";
        string lapis = "N";
        string luzes = "N";
        string pezinho = "N";
        string pigbarba = "N";
        string pigCorte = "N";
        string progressiva = "N";
        string relaxamento = "N";
        string sombancelha = "N";
        string sombancelhaHenna = "N";
        string status = "Pago";
        public Consulta()
        {
            InitializeComponent();
            
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (bd.countCliente(txtNome.Text) > 0)
            {
                data = bd.buscarCliente(txtNome.Text);
                txtApelido.Text = data[2];
                txtNomeCompleto.Text = data[1];
                txtEndereco.Text = data[3];
                mskTelCel.Text = data[5]; 
                mskTelFixo.Text = data[4];
                cboOperadora.Text = data[6];
            }
            else
            {
                MessageBox.Show("sdads");
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            verificaDados();
            bd.cadastarConsulta(data[0], corte, barba, pezinho, sombancelha, sombancelhaHenna, relaxamento, progressiva, pigCorte, pigbarba, luzes, gel, lapis, txtValor.Text, status, txtValor.Text);
        }

        private void verificaDados()
        {
            if(chkCorte.Checked)
                corte = "S";
            if (chkBarba.Checked)
                barba = "S";
            if (chkGel.Checked)
                gel = "S";
            if (chkLapis.Checked)
                lapis = "S";
            if (chkPezinho.Checked)
                pezinho = "S";
            if (chkPigmentacaoBarba.Checked)
                pigbarba = "S";
            if (chkPigmentacaoCorte.Checked)
                pigCorte = "S";
            if (chkProgressiva.Checked)
                progressiva = "S";
            if (chkRelaxamento.Checked)
                relaxamento = "S";
            if (chkSombrancelha.Checked)
                sombancelha = "S";
            if (chkSombrancelhaHenna.Checked)
                sombancelhaHenna = "S";
            if (chkPagar.Checked)
                status = "Em aberto";
        }
    }
}