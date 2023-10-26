using Folha_de_pagamento_2._0.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
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

		SqlConnection conn = null;
		string sql = @"Data Source=Leandro\SQLEXPRESS;Initial Catalog=teste;Integrated Security=True";
		string strsql = string.Empty;
		private void calculoFolha()
		{
			double salarioBruto = Convert.ToDouble(classCalculoFolhha.SalarioBase);
			double salarioBase;
			double descINSS = 0;
			double descIRRF = 0;

			// Calculo do INSS
			if (salarioBruto <= 1320)
			{
				descINSS = salarioBruto * 0.075;
			}
			else
			{
				descINSS += 99.00;
				if (salarioBruto >= 1320.01 && salarioBruto <= 2571.29)
				{
					descINSS += (salarioBruto - 1320.01) * 0.09;
				}
				else
				{
					descINSS += 112.61;
					if (salarioBruto >= 2571.30 && salarioBruto <= 3856.94)
					{
						descINSS += (salarioBruto - 2571.30) * 0.12;
					}
					else
					{
						descINSS += 154.27;
						if (salarioBruto >= 3856.95 && salarioBruto <= 7507.49)
						{
							descINSS += (salarioBruto - 3856.95) * 0.14;
						}
						else
						{
							descINSS += 511.07;
						}
					}

				}

			}

			salarioBase = salarioBruto - descINSS;

			//Calculo IRRF
			if (salarioBase <= 2112)
			{
				descIRRF = 0;
			}
			else if (salarioBase >= 2112.01 && salarioBase <= 2826.65)
			{
				descIRRF = (salarioBase * 0.075) - 158.40;
			}
			else if (salarioBase >= 2826.66 && salarioBase <= 3751.05)
			{
				descIRRF = (salarioBase * 0.15) - 370.40;

			}
			else if (salarioBase >= 3751.06 && salarioBase <= 4664.68)
			{
				descIRRF += (salarioBase * 0.225) - 651.73;
			}
			else if (salarioBase >= 4664.69)
			{
				descIRRF = (salarioBase * 0.275) - 884.96;
			}

			//Adicional de Periculosidade
			if (classCalculoFolhha.Periculosidade == "True")
			{
				double addPericulosidade = salarioBruto * 0.30;
				classCalculoFolhha.AddPericulosidade = addPericulosidade;
			}

			//Adicional Insalubridade
			classCalculoFolhha.AddInsalubridade = salarioBruto * classCalculoFolhha.Insalubridade;
			classCalculoFolhha.DescINSS = descINSS;
			classCalculoFolhha.DescIRRF = descIRRF;
			classCalculoFolhha.SalarioLiqui = (salarioBruto + classCalculoFolhha.AddInsalubridade + classCalculoFolhha.AddPericulosidade) - (descINSS + descIRRF);
			
			salvarDadosFolha();
		}

		private void salvarDadosFolha()
		{
			strsql = "insert into dadosFolha (SalarioBase, SalarioLiqui, DescINSS, DescIRRF, AddPericulosidade, AddInsalubridade, HorasTrab, CpfFunc) " +
									  "values (@SalarioBase, @SalarioLiqui, @DescINSS, @DescIRRF, @AddPericulosidade, @AddInsalubridade, @HorasTrab, @CpfFunc)";
			conn = new SqlConnection(sql);

			SqlCommand cmd = new SqlCommand(strsql, conn);

			cmd.Parameters.Add("@SalarioBase", SqlDbType.VarChar).Value = classCalculoFolhha.SalarioBase;
			cmd.Parameters.Add("@SalarioLiqui", SqlDbType.VarChar).Value = classCalculoFolhha.SalarioLiqui;
			cmd.Parameters.Add("@DescINSS", SqlDbType.VarChar).Value = classCalculoFolhha.DescINSS;
			cmd.Parameters.Add("@DescIRRF", SqlDbType.VarChar).Value = classCalculoFolhha.DescIRRF;
			cmd.Parameters.Add("@AddPericulosidade", SqlDbType.VarChar).Value = classCalculoFolhha.AddPericulosidade;
			cmd.Parameters.Add("@AddInsalubridade", SqlDbType.VarChar).Value = classCalculoFolhha.AddInsalubridade;
			cmd.Parameters.Add("@HorasTrab", SqlDbType.VarChar).Value = classCalculoFolhha.HorasTrab;
			cmd.Parameters.Add("@CpfFunc", SqlDbType.VarChar).Value = classCalculoFolhha.Cpf;

			try
			{
				conn.Open();
				cmd.ExecuteNonQuery();
				MessageBox.Show("Calculo realizado com sucesso!", "Sucesso");
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				conn.Close();
			}
		}
			
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            strsql = "select f.Cpf, f.Nome, d.Horasdetrabalho, d.Salariobase, d.Periculosidade, d.Insalubridade from funcionario as f inner join dadostrabalhista as d on f.CPF = d.CpfFunc where CPF=@CPF";
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
                    classCalculoFolhha.HorasTrab = Convert.ToString(dr["Horasdetrabalho"]);
                    classCalculoFolhha.SalarioBase = Convert.ToString(dr["Salariobase"]);
                    classCalculoFolhha.Periculosidade = Convert.ToString(dr["Periculosidade"]);
					classCalculoFolhha.Insalubridade = Convert.ToDouble(dr["Insalubridade"]);
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

		private void btn_calcular_Click(object sender, EventArgs e)
		{
            calculoFolha();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_relatorio_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = new SqlCommand("Select HorasTrab, SalarioBase, SalarioLiqui, DescINSS, DescIRRF, AddPericulosidade, AddInsalubridade from dadosFolha", conn);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			conn.Close();
		}
	}
}
