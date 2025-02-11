namespace WfaTrabalhoFinal
{
    partial class CadastroAlunoForm
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
            this.lblTreinador = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPai = new System.Windows.Forms.Label();
            this.lblMae = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblNCasa = new System.Windows.Forms.Label();
            this.lblDEClube = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInform_Individuais = new System.Windows.Forms.Label();
            this.lblInformEndereco = new System.Windows.Forms.Label();
            this.lblInformEscolinha = new System.Windows.Forms.Label();
            this.tbA_Nome = new System.Windows.Forms.TextBox();
            this.tbA_Pai = new System.Windows.Forms.TextBox();
            this.tbA_Mae = new System.Windows.Forms.TextBox();
            this.mtbA_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbA_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.tbA_Idade = new System.Windows.Forms.TextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.tbA_NCasa = new System.Windows.Forms.TextBox();
            this.cbA_Sexo = new System.Windows.Forms.ComboBox();
            this.cbA_Treinador = new System.Windows.Forms.ComboBox();
            this.cbA_Modalidade = new System.Windows.Forms.ComboBox();
            this.btCadastrarAlunos = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbMensalidade = new System.Windows.Forms.ComboBox();
            this.lblMensalidade = new System.Windows.Forms.Label();
            this.mtbDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTreinador
            // 
            this.lblTreinador.AutoSize = true;
            this.lblTreinador.Location = new System.Drawing.Point(15, 311);
            this.lblTreinador.Name = "lblTreinador";
            this.lblTreinador.Size = new System.Drawing.Size(55, 13);
            this.lblTreinador.TabIndex = 1;
            this.lblTreinador.Text = "Treinador:";
            this.lblTreinador.Click += new System.EventHandler(this.lblTreinador_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 69);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblPai
            // 
            this.lblPai.AutoSize = true;
            this.lblPai.Location = new System.Drawing.Point(15, 124);
            this.lblPai.Name = "lblPai";
            this.lblPai.Size = new System.Drawing.Size(25, 13);
            this.lblPai.TabIndex = 3;
            this.lblPai.Text = "Pai:";
            // 
            // lblMae
            // 
            this.lblMae.AutoSize = true;
            this.lblMae.Location = new System.Drawing.Point(15, 149);
            this.lblMae.Name = "lblMae";
            this.lblMae.Size = new System.Drawing.Size(31, 13);
            this.lblMae.TabIndex = 4;
            this.lblMae.Text = "Mãe:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 183);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(15, 395);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "Ceep:";
            this.lblCep.Click += new System.EventHandler(this.lblCep_Click);
            // 
            // lblNCasa
            // 
            this.lblNCasa.AutoSize = true;
            this.lblNCasa.Location = new System.Drawing.Point(15, 433);
            this.lblNCasa.Name = "lblNCasa";
            this.lblNCasa.Size = new System.Drawing.Size(52, 13);
            this.lblNCasa.TabIndex = 7;
            this.lblNCasa.Text = "Nº. Casa:";
            this.lblNCasa.Click += new System.EventHandler(this.lblNCasa_Click);
            // 
            // lblDEClube
            // 
            this.lblDEClube.AutoSize = true;
            this.lblDEClube.Location = new System.Drawing.Point(15, 339);
            this.lblDEClube.Name = "lblDEClube";
            this.lblDEClube.Size = new System.Drawing.Size(135, 13);
            this.lblDEClube.TabIndex = 8;
            this.lblDEClube.Text = "Data De Entrada no Clube:";
            this.lblDEClube.Click += new System.EventHandler(this.lblDEClube_Click);
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.Location = new System.Drawing.Point(15, 285);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(65, 13);
            this.lblModalidade.TabIndex = 9;
            this.lblModalidade.Text = "Modalidade:";
            this.lblModalidade.Click += new System.EventHandler(this.lblModalidade_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(17, 43);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(15, 96);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 11;
            this.lblIdade.Text = "Idade:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // lblInform_Individuais
            // 
            this.lblInform_Individuais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInform_Individuais.Location = new System.Drawing.Point(164, -2);
            this.lblInform_Individuais.Name = "lblInform_Individuais";
            this.lblInform_Individuais.Size = new System.Drawing.Size(175, 19);
            this.lblInform_Individuais.TabIndex = 13;
            this.lblInform_Individuais.Text = "Informações Individuais";
            // 
            // lblInformEndereco
            // 
            this.lblInformEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformEndereco.Location = new System.Drawing.Point(164, 360);
            this.lblInformEndereco.Name = "lblInformEndereco";
            this.lblInformEndereco.Size = new System.Drawing.Size(175, 23);
            this.lblInformEndereco.TabIndex = 14;
            this.lblInformEndereco.Text = "Informações de Endereço";
            this.lblInformEndereco.Click += new System.EventHandler(this.lblInformEndereco_Click);
            // 
            // lblInformEscolinha
            // 
            this.lblInformEscolinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformEscolinha.Location = new System.Drawing.Point(164, 231);
            this.lblInformEscolinha.Name = "lblInformEscolinha";
            this.lblInformEscolinha.Size = new System.Drawing.Size(166, 23);
            this.lblInformEscolinha.TabIndex = 15;
            this.lblInformEscolinha.Text = "Informações da Escolinha";
            this.lblInformEscolinha.Click += new System.EventHandler(this.lblInformEscolinha_Click);
            // 
            // tbA_Nome
            // 
            this.tbA_Nome.Location = new System.Drawing.Point(59, 15);
            this.tbA_Nome.Name = "tbA_Nome";
            this.tbA_Nome.Size = new System.Drawing.Size(255, 20);
            this.tbA_Nome.TabIndex = 16;
            // 
            // tbA_Pai
            // 
            this.tbA_Pai.Location = new System.Drawing.Point(59, 123);
            this.tbA_Pai.Name = "tbA_Pai";
            this.tbA_Pai.Size = new System.Drawing.Size(255, 20);
            this.tbA_Pai.TabIndex = 17;
            // 
            // tbA_Mae
            // 
            this.tbA_Mae.Location = new System.Drawing.Point(59, 149);
            this.tbA_Mae.Name = "tbA_Mae";
            this.tbA_Mae.Size = new System.Drawing.Size(255, 20);
            this.tbA_Mae.TabIndex = 18;
            // 
            // mtbA_Cpf
            // 
            this.mtbA_Cpf.Location = new System.Drawing.Point(59, 41);
            this.mtbA_Cpf.Mask = "000,000,000-00";
            this.mtbA_Cpf.Name = "mtbA_Cpf";
            this.mtbA_Cpf.Size = new System.Drawing.Size(255, 20);
            this.mtbA_Cpf.TabIndex = 19;
            // 
            // mtbA_Telefone
            // 
            this.mtbA_Telefone.Location = new System.Drawing.Point(59, 180);
            this.mtbA_Telefone.Mask = "(00)00000-0000";
            this.mtbA_Telefone.Name = "mtbA_Telefone";
            this.mtbA_Telefone.Size = new System.Drawing.Size(255, 20);
            this.mtbA_Telefone.TabIndex = 21;
            // 
            // tbA_Idade
            // 
            this.tbA_Idade.Location = new System.Drawing.Point(58, 93);
            this.tbA_Idade.Name = "tbA_Idade";
            this.tbA_Idade.Size = new System.Drawing.Size(255, 20);
            this.tbA_Idade.TabIndex = 22;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(56, 392);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(258, 20);
            this.mtbCep.TabIndex = 25;
            // 
            // tbA_NCasa
            // 
            this.tbA_NCasa.Location = new System.Drawing.Point(73, 430);
            this.tbA_NCasa.Name = "tbA_NCasa";
            this.tbA_NCasa.Size = new System.Drawing.Size(241, 20);
            this.tbA_NCasa.TabIndex = 26;
            // 
            // cbA_Sexo
            // 
            this.cbA_Sexo.FormattingEnabled = true;
            this.cbA_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbA_Sexo.Location = new System.Drawing.Point(59, 66);
            this.cbA_Sexo.Name = "cbA_Sexo";
            this.cbA_Sexo.Size = new System.Drawing.Size(255, 21);
            this.cbA_Sexo.TabIndex = 27;
            this.cbA_Sexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbA_Treinador
            // 
            this.cbA_Treinador.FormattingEnabled = true;
            this.cbA_Treinador.Location = new System.Drawing.Point(73, 308);
            this.cbA_Treinador.Name = "cbA_Treinador";
            this.cbA_Treinador.Size = new System.Drawing.Size(241, 21);
            this.cbA_Treinador.TabIndex = 28;
            // 
            // cbA_Modalidade
            // 
            this.cbA_Modalidade.FormattingEnabled = true;
            this.cbA_Modalidade.Items.AddRange(new object[] {
            "Intermediario"});
            this.cbA_Modalidade.Location = new System.Drawing.Point(86, 281);
            this.cbA_Modalidade.Name = "cbA_Modalidade";
            this.cbA_Modalidade.Size = new System.Drawing.Size(228, 21);
            this.cbA_Modalidade.TabIndex = 30;
            // 
            // btCadastrarAlunos
            // 
            this.btCadastrarAlunos.Location = new System.Drawing.Point(75, 473);
            this.btCadastrarAlunos.Name = "btCadastrarAlunos";
            this.btCadastrarAlunos.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarAlunos.TabIndex = 31;
            this.btCadastrarAlunos.Text = "Cadastrar";
            this.btCadastrarAlunos.UseVisualStyleBackColor = true;
            this.btCadastrarAlunos.Click += new System.EventHandler(this.btCadastrarAlunos_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(210, 473);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 32;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbMensalidade
            // 
            this.cbMensalidade.FormattingEnabled = true;
            this.cbMensalidade.Items.AddRange(new object[] {
            "100.00",
            "150.00",
            "200.00"});
            this.cbMensalidade.Location = new System.Drawing.Point(84, 206);
            this.cbMensalidade.Name = "cbMensalidade";
            this.cbMensalidade.Size = new System.Drawing.Size(230, 21);
            this.cbMensalidade.TabIndex = 34;
            // 
            // lblMensalidade
            // 
            this.lblMensalidade.AutoSize = true;
            this.lblMensalidade.Location = new System.Drawing.Point(15, 210);
            this.lblMensalidade.Name = "lblMensalidade";
            this.lblMensalidade.Size = new System.Drawing.Size(70, 13);
            this.lblMensalidade.TabIndex = 33;
            this.lblMensalidade.Text = "Mensalidade:";
            // 
            // mtbDataEntrada
            // 
            this.mtbDataEntrada.Location = new System.Drawing.Point(156, 335);
            this.mtbDataEntrada.Mask = "00/00/00";
            this.mtbDataEntrada.Name = "mtbDataEntrada";
            this.mtbDataEntrada.Size = new System.Drawing.Size(157, 20);
            this.mtbDataEntrada.TabIndex = 35;
            // 
            // CadastroAlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 535);
            this.Controls.Add(this.mtbDataEntrada);
            this.Controls.Add(this.cbMensalidade);
            this.Controls.Add(this.lblMensalidade);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrarAlunos);
            this.Controls.Add(this.cbA_Modalidade);
            this.Controls.Add(this.cbA_Treinador);
            this.Controls.Add(this.cbA_Sexo);
            this.Controls.Add(this.tbA_NCasa);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.tbA_Idade);
            this.Controls.Add(this.mtbA_Telefone);
            this.Controls.Add(this.mtbA_Cpf);
            this.Controls.Add(this.tbA_Mae);
            this.Controls.Add(this.tbA_Pai);
            this.Controls.Add(this.tbA_Nome);
            this.Controls.Add(this.lblInformEscolinha);
            this.Controls.Add(this.lblInformEndereco);
            this.Controls.Add(this.lblInform_Individuais);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.lblDEClube);
            this.Controls.Add(this.lblNCasa);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblMae);
            this.Controls.Add(this.lblPai);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTreinador);
            this.Name = "CadastroAlunoForm";
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAlunoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTreinador;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPai;
        private System.Windows.Forms.Label lblMae;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblNCasa;
        private System.Windows.Forms.Label lblDEClube;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInform_Individuais;
        private System.Windows.Forms.Label lblInformEndereco;
        private System.Windows.Forms.Label lblInformEscolinha;
        private System.Windows.Forms.TextBox tbA_Nome;
        private System.Windows.Forms.TextBox tbA_Pai;
        private System.Windows.Forms.TextBox tbA_Mae;
        private System.Windows.Forms.MaskedTextBox mtbA_Cpf;
        private System.Windows.Forms.MaskedTextBox mtbA_Telefone;
        private System.Windows.Forms.TextBox tbA_Idade;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.TextBox tbA_NCasa;
        private System.Windows.Forms.ComboBox cbA_Sexo;
        private System.Windows.Forms.ComboBox cbA_Treinador;
        private System.Windows.Forms.ComboBox cbA_Modalidade;
        private System.Windows.Forms.Button btCadastrarAlunos;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ComboBox cbMensalidade;
        private System.Windows.Forms.Label lblMensalidade;
        private System.Windows.Forms.MaskedTextBox mtbDataEntrada;
    }
}