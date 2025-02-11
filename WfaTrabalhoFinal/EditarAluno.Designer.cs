namespace WfaTrabalhoFinal
{
    partial class EditarAluno
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btExcluirAluno = new System.Windows.Forms.Button();
            this.btAtualizarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(599, 170);
            this.dgvAlunos.TabIndex = 0;
            // 
            // btExcluirAluno
            // 
            this.btExcluirAluno.Location = new System.Drawing.Point(12, 188);
            this.btExcluirAluno.Name = "btExcluirAluno";
            this.btExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btExcluirAluno.TabIndex = 2;
            this.btExcluirAluno.Text = "Excluir";
            this.btExcluirAluno.UseVisualStyleBackColor = true;
            this.btExcluirAluno.Click += new System.EventHandler(this.btExcluirAluno_Click);
            // 
            // btAtualizarAluno
            // 
            this.btAtualizarAluno.Location = new System.Drawing.Point(113, 188);
            this.btAtualizarAluno.Name = "btAtualizarAluno";
            this.btAtualizarAluno.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarAluno.TabIndex = 3;
            this.btAtualizarAluno.Text = "Atualizar";
            this.btAtualizarAluno.UseVisualStyleBackColor = true;
            this.btAtualizarAluno.Click += new System.EventHandler(this.btAtualizarAluno_Click);
            // 
            // EditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 232);
            this.Controls.Add(this.btAtualizarAluno);
            this.Controls.Add(this.btExcluirAluno);
            this.Controls.Add(this.dgvAlunos);
            this.Name = "EditarAluno";
            this.Text = "Editar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btExcluirAluno;
        private System.Windows.Forms.Button btAtualizarAluno;
    }
}