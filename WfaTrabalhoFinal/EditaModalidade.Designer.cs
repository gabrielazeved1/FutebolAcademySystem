namespace WfaTrabalhoFinal
{
    partial class EditaModalidade
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
            this.dgvModalidade = new System.Windows.Forms.DataGridView();
            this.btExcluirModalidade = new System.Windows.Forms.Button();
            this.btAtualizarModalidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvModalidade
            // 
            this.dgvModalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModalidade.Location = new System.Drawing.Point(2, 12);
            this.dgvModalidade.Name = "dgvModalidade";
            this.dgvModalidade.Size = new System.Drawing.Size(559, 150);
            this.dgvModalidade.TabIndex = 0;
            // 
            // btExcluirModalidade
            // 
            this.btExcluirModalidade.Location = new System.Drawing.Point(12, 175);
            this.btExcluirModalidade.Name = "btExcluirModalidade";
            this.btExcluirModalidade.Size = new System.Drawing.Size(73, 23);
            this.btExcluirModalidade.TabIndex = 2;
            this.btExcluirModalidade.Text = "Excluir";
            this.btExcluirModalidade.UseVisualStyleBackColor = true;
            this.btExcluirModalidade.Click += new System.EventHandler(this.btExcluirModalidade_Click);
            // 
            // btAtualizarModalidade
            // 
            this.btAtualizarModalidade.Location = new System.Drawing.Point(112, 175);
            this.btAtualizarModalidade.Name = "btAtualizarModalidade";
            this.btAtualizarModalidade.Size = new System.Drawing.Size(73, 23);
            this.btAtualizarModalidade.TabIndex = 3;
            this.btAtualizarModalidade.Text = "Atualizar";
            this.btAtualizarModalidade.UseVisualStyleBackColor = true;
            this.btAtualizarModalidade.Click += new System.EventHandler(this.btAtualizarModalidade_Click);
            // 
            // EditaModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 210);
            this.Controls.Add(this.btAtualizarModalidade);
            this.Controls.Add(this.btExcluirModalidade);
            this.Controls.Add(this.dgvModalidade);
            this.Name = "EditaModalidade";
            this.Text = "EditaModalidade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvModalidade;
        private System.Windows.Forms.Button btExcluirModalidade;
        private System.Windows.Forms.Button btAtualizarModalidade;
    }
}