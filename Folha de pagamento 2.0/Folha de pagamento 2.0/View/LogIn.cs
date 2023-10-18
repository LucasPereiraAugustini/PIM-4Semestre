using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_pagamento_2._0
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=TOMBINEE;Initial Catalog=usuario;Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();

            tb_usuario.Select();
        }
        int verificacao()
        {
            
            if(tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Digite um usuário e senha!");
                tb_usuario.Select();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            
            int teste = verificacao();
            if (teste == 1)
            {
                con.Open();
                string busuario = "SELECT * FROM usuario where usuario = '" + tb_usuario.Text + "' AND senha = '" + tb_senha.Text + "'";

                SqlDataAdapter dp = new SqlDataAdapter(busuario, con);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Principal principal = new Principal();
                    this.Hide();
                    principal.Show();
                    con.Close();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Usuário ou senha invalido!");
                    tb_usuario.Clear();
                    tb_senha.Clear();
                    tb_usuario.Select();
                }

            }
            
        }
    }
}
