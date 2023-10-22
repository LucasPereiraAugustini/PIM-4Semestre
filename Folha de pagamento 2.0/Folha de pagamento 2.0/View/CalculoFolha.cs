using Folha_de_pagamento_2._0.Model;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace Folha_de_pagamento_2._0.View
{
    public partial class CalculoFolha : Form
    {
        public CalculoFolha()
        {
            InitializeComponent();
        }

        ClassCalculoFolhha classCalculoFolhha = new ClassCalculoFolhha();

        private void calculoFolha()
        {

        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            string sql = @"Data Source=DESKTOP-M71N3MS;Initial Catalog=DBClientes;Integrated Security=True";
            string strsql = string.Empty;
            strsql = "select f.Cpf, f.Nome, d.Horasdetrabalho, d.Salariobase, d.Periculosidade from funcionario as f inner join dadostrabalhista as d on f.CPF = d.CpfFunc where CPF=@CPF";
            conn = new SqlConnection(sql);

            SqlCommand cmd = new SqlCommand(strsql, conn);

            cmd.Parameters.Add(new SqlParameter("@CPF", msk_cpf.Text));

            try
            {
                if (msk_cpf.Text == "")
                {
                    throw new Exception("Você precisa digitar um CPF!");
                }
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("CPF Não cadastrado!");
                }
                while (dr.Read())
                {
                    msk_cpf.Text = Convert.ToString(dr["CPF"]);
                    tb_nome.Text = Convert.ToString(dr["Nome"]);
                    classCalculoFolhha.Cpf = Convert.ToString(dr["CPF"]);
                    classCalculoFolhha.Nome = Convert.ToString(dr["Nome"]);
                    classCalculoFolhha.HorasTrab = Convert.ToInt16(dr["Horasdetrabalho"]);
                    classCalculoFolhha.SalarioBase = Convert.ToDecimal(dr["Salariobase"]);
                    classCalculoFolhha.Periculosidade = Convert.ToBoolean(dr["Periculosidade"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }


        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar a operação?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Hide();
                Principal principal = new Principal();
                principal.Show();
            }
        }
    }
}
