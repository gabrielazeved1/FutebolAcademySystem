namespace WfaTrabalhoFinal
{
    partial class CadastroModalidadeForms
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
            this.lblNomeModalidade = new System.Windows.Forms.Label();
            this.lblIInicial = new System.Windows.Forms.Label();
            this.tbNomeModalidade = new System.Windows.Forms.TextBox();
            this.tbINivelTecnico = new System.Windows.Forms.TextBox();
            this.btCadastrarModalidade = new System.Windows.Forms.Button();
            this.btCancelarModalidade = new System.Windows.Forms.Button();
            this.tbMensalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeModalidade
            // 
            this.lblNomeModalidade.AutoSize = true;
            this.lblNomeModalidade.Location = new System.Drawing.Point(12, 9);
            this.lblNomeModalidade.Name = "lblNomeModalidade";
            this.lblNomeModalidade.Size = new System.Drawing.Size(38, 13);
            this.lblNomeModalidade.TabIndex = 0;
            this.lblNomeModalidade.Text = "Nome:";
            // 
            // lblIInicial
            // 
            this.lblIInicial.AutoSize = true;
            this.lblIInicial.Location = new System.Drawing.Point(12, 35);
            this.lblIInicial.Name = "lblIInicial";
            this.lblIInicial.Size = new System.Drawing.Size(76, 13);
            this.lblIInicial.TabIndex = 1;
            this.lblIInicial.Text = "Nivel Técnico:";
            // 
            // tbNomeModalidade
            // 
            this.tbNomeModalidade.Location = new System.Drawing.Point(56, 6);
            this.tbNomeModalidade.Name = "tbNomeModalidade";
            this.tbNomeModalidade.Size = new System.Drawing.Size(157, 20);
            this.tbNomeModalidade.TabIndex = 3;
            // 
            // tbINivelTecnico
            // 
            this.tbINivelTecnico.Location = new System.Drawing.Point(85, 32);
            this.tbINivelTecnico.Name = "tbINivelTecnico";
            this.tbINivelTecnico.Size = new System.Drawing.Size(128, 20);
            this.tbINivelTecnico.TabIndex = 4;
            // 
            // btCadastrarModalidade
            // 
            this.btCadastrarModalidade.Location = new System.Drawing.Point(13, 94);
            this.btCadastrarModalidade.Name = "btCadastrarModalidade";
            this.btCadastrarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarModalidade.TabIndex = 6;
            this.btCadastrarModalidade.Text = "Cadastrar";
            this.btCadastrarModalidade.UseVisualStyleBackColor = true;
            this.btCadastrarModalidade.Click += new System.EventHandler(this.btCadastrarModalidade_Click);
            // 
            // btCancelarModalidade
            // 
            this.btCancelarModalidade.Location = new System.Drawing.Point(124, 90);
            this.btCancelarModalidade.Name = "btCancelarModalidade";
            this.btCancelarModalidade.Size = new System.Drawing.Size(75, 27);
            this.btCancelarModalidade.TabIndex = 7;
            this.btCancelarModalidade.Text = "Cancelar";
            this.btCancelarModalidade.UseVisualStyleBackColor = true;
            this.btCancelarModalidade.Click += new System.EventHandler(this.btCancelarModalidade_Click);
            // 
            // tbMensalidade
            // 
            this.tbMensalidade.Location = new System.Drawing.Point(85, 64);
            this.tbMensalidade.Name = "tbMensalidade";
            this.tbMensalidade.Size = new System.Drawing.Size(128, 20);
            this.tbMensalidade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mensalidade:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CadastroModalidadeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 129);
            this.Controls.Add(this.tbMensalidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelarModalidade);
            this.Controls.Add(this.btCadastrarModalidade);
            this.Controls.Add(this.tbINivelTecnico);
            this.Controls.Add(this.tbNomeModalidade);
            this.Controls.Add(this.lblIInicial);
            this.Controls.Add(this.lblNomeModalidade);
            this.Name = "CadastroModalidadeForms";
            this.Text = "CadastroModalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeModalidade;
        private System.Windows.Forms.Label lblIInicial;
        private System.Windows.Forms.TextBox tbNomeModalidade;
        private System.Windows.Forms.TextBox tbINivelTecnico;
        private System.Windows.Forms.Button btCadastrarModalidade;
        private System.Windows.Forms.Button btCancelarModalidade;
        private System.Windows.Forms.TextBox tbMensalidade;
        private System.Windows.Forms.Label label1;
    }
}