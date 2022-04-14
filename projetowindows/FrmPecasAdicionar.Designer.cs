
namespace ProjetoWindows
{
    partial class FrmPecasAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPecasAdicionar));
            this.label_info = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_fechar = new ProjetoWindows.ControloBotoes();
            this.drop_tipo = new System.Windows.Forms.ComboBox();
            this.drop_marca = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Black;
            this.label_info.Location = new System.Drawing.Point(22, 24);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(168, 24);
            this.label_info.TabIndex = 81;
            this.label_info.Text = "Adicionar  Peças";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkOrange;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(708, 10);
            this.panel12.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(23, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Refª";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nome do produto";
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(495, 372);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(87, 30);
            this.btn_limpar.TabIndex = 73;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(128, 372);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(87, 30);
            this.btn_adicionar.TabIndex = 72;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(29, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 1);
            this.panel4.TabIndex = 76;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_nome.Location = new System.Drawing.Point(29, 81);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(316, 24);
            this.txt_nome.TabIndex = 68;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(26, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 1);
            this.panel3.TabIndex = 75;
            // 
            // txt_ref
            // 
            this.txt_ref.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ref.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ref.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_ref.Location = new System.Drawing.Point(26, 135);
            this.txt_ref.Multiline = true;
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.PasswordChar = '*';
            this.txt_ref.Size = new System.Drawing.Size(316, 24);
            this.txt_ref.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(26, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 1);
            this.panel2.TabIndex = 74;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.ForeColor = System.Drawing.Color.DarkOrange;
            this.txt_valor.Location = new System.Drawing.Point(26, 258);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(104, 24);
            this.txt_valor.TabIndex = 71;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ProjetoWindows.Properties.Resources._360_F_131093912_NtISEAFQAmBcYtU3VnO3b4U8Vn1tLacZ;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(397, 65);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(279, 279);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 85;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Image = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Imagemdiferente = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Imagemdiferente")));
            this.btn_fechar.ImagemNormal = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Location = new System.Drawing.Point(664, 16);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(32, 32);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 82;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // drop_tipo
            // 
            this.drop_tipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_tipo.ForeColor = System.Drawing.Color.DarkOrange;
            this.drop_tipo.FormattingEnabled = true;
            this.drop_tipo.Location = new System.Drawing.Point(29, 195);
            this.drop_tipo.Name = "drop_tipo";
            this.drop_tipo.Size = new System.Drawing.Size(147, 26);
            this.drop_tipo.TabIndex = 86;
            this.drop_tipo.Text = "Tipo";
            // 
            // drop_marca
            // 
            this.drop_marca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_marca.ForeColor = System.Drawing.Color.DarkOrange;
            this.drop_marca.FormattingEnabled = true;
            this.drop_marca.Location = new System.Drawing.Point(198, 195);
            this.drop_marca.Name = "drop_marca";
            this.drop_marca.Size = new System.Drawing.Size(147, 26);
            this.drop_marca.TabIndex = 87;
            this.drop_marca.Text = "Marca";
            // 
            // txt_data
            // 
            this.txt_data.CalendarForeColor = System.Drawing.Color.DarkOrange;
            this.txt_data.CalendarTitleForeColor = System.Drawing.Color.DarkOrange;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(205, 265);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(140, 24);
            this.txt_data.TabIndex = 88;
            // 
            // FrmPecasAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 453);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.drop_marca);
            this.Controls.Add(this.drop_tipo);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_ref);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPecasAdicionar";
            this.Text = "FrmPecasAdicionar";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControloBotoes btn_fechar;
        public System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txt_valor;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.ComboBox drop_tipo;
        public System.Windows.Forms.ComboBox drop_marca;
        public System.Windows.Forms.DateTimePicker txt_data;
    }
}