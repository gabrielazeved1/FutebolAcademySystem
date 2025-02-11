namespace WfaTrabalhoFinal
{
    partial class EditaTreinador_
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
            this.dgvTreinador = new System.Windows.Forms.DataGridView();
            this.btExcluirTreinador = new System.Windows.Forms.Button();
            this.btAtualizarTreinador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreinador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTreinador
            // 
            this.dgvTreinador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreinador.Location = new System.Drawing.Point(12, 12);
            this.dgvTreinador.Name = "dgvTreinador";
            this.dgvTreinador.Size = new System.Drawing.Size(601, 150);
            this.dgvTreinador.TabIndex = 0;
            // 
            // btExcluirTreinador
            // 
            this.btExcluirTreinador.Location = new System.Drawing.Point(12, 184);
            this.btExcluirTreinador.Name = "btExcluirTreinador";
            this.btExcluirTreinador.Size = new System.Drawing.Size(75, 23);
            this.btExcluirTreinador.TabIndex = 2;
            this.btExcluirTreinador.Text = "Excluir";
            this.btExcluirTreinador.UseVisualStyleBackColor = true;
            this.btExcluirTreinador.Click += new System.EventHandler(this.btExcluirTreinador_Click);
            // 
            // btAtualizarTreinador
            // 
            this.btAtualizarTreinador.Location = new System.Drawing.Point(104, 184);
            this.btAtualizarTreinador.Name = "btAtualizarTreinador";
            this.btAtualizarTreinador.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarTreinador.TabIndex = 3;
            this.btAtualizarTreinador.Text = "Atualizar";
            this.btAtualizarTreinador.UseVisualStyleBackColor = true;
            this.btAtualizarTreinador.Click += new System.EventHandler(this.btAtualizarTreinador_Click);
            // 
            // EditaTreinador_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 219);
            this.Controls.Add(this.btAtualizarTreinador);
            this.Controls.Add(this.btExcluirTreinador);
            this.Controls.Add(this.dgvTreinador);
            this.Name = "EditaTreinador_";
            this.Text = "Editar Treinador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreinador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTreinador;
        private System.Windows.Forms.Button btExcluirTreinador;
        private System.Windows.Forms.Button btAtualizarTreinador;
    }
}