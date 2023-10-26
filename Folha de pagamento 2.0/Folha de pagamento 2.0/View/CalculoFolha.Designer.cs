namespace Folha_de_pagamento_2._0.View
{
    partial class CalculoFolha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_nome = new System.Windows.Forms.TextBox();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_calcular = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_relatorio = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(82, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "CPF:";
			// 
			// msk_cpf
			// 
			this.msk_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msk_cpf.Location = new System.Drawing.Point(130, 26);
			this.msk_cpf.Mask = "999,999,999-99";
			this.msk_cpf.Name = "msk_cpf";
			this.msk_cpf.Size = new System.Drawing.Size(128, 26);
			this.msk_cpf.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(405, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nome:";
			// 
			// tb_nome
			// 
			this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_nome.Location = new System.Drawing.Point(466, 25);
			this.tb_nome.Name = "tb_nome";
			this.tb_nome.Size = new System.Drawing.Size(217, 26);
			this.tb_nome.TabIndex = 6;
			// 
			// btn_buscar
			// 
			this.btn_buscar.Location = new System.Drawing.Point(86, 318);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(105, 23);
			this.btn_buscar.TabIndex = 2;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Location = new System.Drawing.Point(586, 318);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(97, 23);
			this.btn_cancelar.TabIndex = 5;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_calcular
			// 
			this.btn_calcular.Location = new System.Drawing.Point(259, 318);
			this.btn_calcular.Name = "btn_calcular";
			this.btn_calcular.Size = new System.Drawing.Size(105, 23);
			this.btn_calcular.TabIndex = 3;
			this.btn_calcular.Text = "Calcular";
			this.btn_calcular.UseVisualStyleBackColor = true;
			this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(86, 124);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(597, 150);
			this.dataGridView1.TabIndex = 20;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btn_relatorio
			// 
			this.btn_relatorio.Location = new System.Drawing.Point(425, 318);
			this.btn_relatorio.Name = "btn_relatorio";
			this.btn_relatorio.Size = new System.Drawing.Size(105, 23);
			this.btn_relatorio.TabIndex = 4;
			this.btn_relatorio.Text = "Relatório";
			this.btn_relatorio.UseVisualStyleBackColor = true;
			this.btn_relatorio.Click += new System.EventHandler(this.btn_relatorio_Click);
			// 
			// CalculoFolha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 373);
			this.Controls.Add(this.btn_relatorio);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_calcular);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_buscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.msk_cpf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_nome);
			this.Name = "CalculoFolha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CalculoFolha";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_cancelar;
		private System.Windows.Forms.Button btn_calcular;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_relatorio;
	}
}