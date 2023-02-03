using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWinForm0202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibirMsg_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (String.IsNullOrEmpty(nome) || String.IsNullOrWhiteSpace(nome))
            {
                lblErroNome.Text = "O campo não pode ser vazio.";
                lblErroNome.Visible = true;
            }
            else
            {
                if (nome.Length < 3)
                {
                    lblErroNome.Text = "nome deve ter pelo menos 3 caracteres";
                    lblErroNome.Visible = true;
                }
                else
                {
                    lblErroNome.Visible = false;
                    MessageBox.Show("Olá " + nome, "Lembrete", MessageBoxButtons.OK);
                }
            }
        }
    }
}
