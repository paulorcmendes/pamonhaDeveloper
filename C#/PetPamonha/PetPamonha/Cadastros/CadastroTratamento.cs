﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PetPamonha.Cadastros
{
    public partial class CadastroTratamento : Form
    {
        public CadastroTratamento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            String nome;
            String preco;
            String duracaoMedia;

            nome = txtNome.Text;
            preco = mktPreco.Text;
            duracaoMedia = mktDuracaoMedia.Text;

            Tratamento tratamento = new Tratamento();

            tratamento.Nome = nome;
            tratamento.Preco = double.Parse(preco).ToString("G",System.Globalization.CultureInfo.InvariantCulture);
            tratamento.DuracaoMedia = duracaoMedia;
            Console.WriteLine(tratamento.Preco);


            DAOTratamento daoTratamento = new DAOTratamento();

            daoTratamento.insereTratamento(tratamento);


        }
    }
}
