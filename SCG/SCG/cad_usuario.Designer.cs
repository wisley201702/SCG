namespace SCG
{
    partial class cad_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cad_usuario));
            this.novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excluir = new System.Windows.Forms.Button();
            this.gravar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.csenha = new System.Windows.Forms.TextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.dgusuario = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // novo
            // 
            this.novo.Location = new System.Drawing.Point(3, 0);
            this.novo.Name = "novo";
            this.novo.Size = new System.Drawing.Size(53, 23);
            this.novo.TabIndex = 0;
            this.novo.Text = "Novo";
            this.novo.UseVisualStyleBackColor = true;
            this.novo.Click += new System.EventHandler(this.novo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.excluir);
            this.panel1.Controls.Add(this.gravar);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.alterar);
            this.panel1.Controls.Add(this.novo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 24);
            this.panel1.TabIndex = 1;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(579, 0);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(49, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(376, 2);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(197, 20);
            this.id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por Id:";
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(242, 0);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(49, 23);
            this.excluir.TabIndex = 5;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.button5_Click);
            // 
            // gravar
            // 
            this.gravar.Location = new System.Drawing.Point(187, 0);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(49, 23);
            this.gravar.TabIndex = 4;
            this.gravar.Text = "Gravar";
            this.gravar.UseVisualStyleBackColor = true;
            this.gravar.Click += new System.EventHandler(this.gravar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(121, 0);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(60, 23);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // alterar
            // 
            this.alterar.Location = new System.Drawing.Point(62, 0);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(53, 23);
            this.alterar.TabIndex = 2;
            this.alterar.Text = "Alterar";
            this.alterar.UseVisualStyleBackColor = true;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(91, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(88, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(41, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirmar Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(98, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(135, 72);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(175, 20);
            this.nome.TabIndex = 6;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(135, 128);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(175, 20);
            this.senha.TabIndex = 7;
            this.senha.UseSystemPasswordChar = true;
            // 
            // csenha
            // 
            this.csenha.Location = new System.Drawing.Point(135, 154);
            this.csenha.Name = "csenha";
            this.csenha.Size = new System.Drawing.Size(175, 20);
            this.csenha.TabIndex = 8;
            this.csenha.UseSystemPasswordChar = true;
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "SUPORTE",
            "VENDEDOR",
            "GERENTE",
            "CAIXA",
            "SUPERVISOR"});
            this.tipo.Location = new System.Drawing.Point(135, 98);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(155, 21);
            this.tipo.TabIndex = 9;
            // 
            // dgusuario
            // 
            this.dgusuario.AllowUserToAddRows = false;
            this.dgusuario.AllowUserToDeleteRows = false;
            this.dgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuario.Location = new System.Drawing.Point(321, 63);
            this.dgusuario.Name = "dgusuario";
            this.dgusuario.ReadOnly = true;
            this.dgusuario.Size = new System.Drawing.Size(353, 111);
            this.dgusuario.TabIndex = 10;
            this.dgusuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuario_CellDoubleClick);
            this.dgusuario.SelectionChanged += new System.EventHandler(this.dgusuario_SelectionChanged);
            this.dgusuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgusuario_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cad_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(676, 186);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgusuario);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.csenha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cad_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.cad_usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button gravar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox csenha;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.DataGridView dgusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}