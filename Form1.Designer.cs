namespace teste2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtbox_sexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.txtbox_documento = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.Label();
            this.txtbox_endereco = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(84, 57);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(266, 26);
            this.txtbox_name.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(13, 63);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(51, 20);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(84, 114);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(315, 26);
            this.txtbox_email.TabIndex = 2;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(17, 114);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(53, 20);
            this.email.TabIndex = 3;
            this.email.Text = "E-mail";
            // 
            // txtbox_sexo
            // 
            this.txtbox_sexo.Location = new System.Drawing.Point(84, 163);
            this.txtbox_sexo.Name = "txtbox_sexo";
            this.txtbox_sexo.Size = new System.Drawing.Size(315, 26);
            this.txtbox_sexo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(13, 163);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(42, 20);
            this.sexo.TabIndex = 6;
            this.sexo.Text = "sexo";
            // 
            // txtbox_documento
            // 
            this.txtbox_documento.Location = new System.Drawing.Point(84, 212);
            this.txtbox_documento.Name = "txtbox_documento";
            this.txtbox_documento.Size = new System.Drawing.Size(396, 26);
            this.txtbox_documento.TabIndex = 7;
            // 
            // documento
            // 
            this.documento.AutoSize = true;
            this.documento.Location = new System.Drawing.Point(21, 212);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(23, 20);
            this.documento.TabIndex = 8;
            this.documento.Text = "rg";
            // 
            // txtbox_endereco
            // 
            this.txtbox_endereco.Location = new System.Drawing.Point(84, 261);
            this.txtbox_endereco.Multiline = true;
            this.txtbox_endereco.Name = "txtbox_endereco";
            this.txtbox_endereco.Size = new System.Drawing.Size(408, 83);
            this.txtbox_endereco.TabIndex = 9;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(0, 261);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(78, 20);
            this.endereco.TabIndex = 10;
            this.endereco.Text = "Endereço";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(84, 364);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(97, 38);
            this.btn_enviar.TabIndex = 11;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.txtbox_endereco);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.txtbox_documento);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_sexo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtbox_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtbox_sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.TextBox txtbox_documento;
        private System.Windows.Forms.Label documento;
        private System.Windows.Forms.TextBox txtbox_endereco;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Button btn_enviar;
    }
}

