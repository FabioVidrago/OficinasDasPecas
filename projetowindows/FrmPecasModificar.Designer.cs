
namespace ProjetoWindows
{
    partial class FrmPecasModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPecasModificar));
            this.label_info = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            this.drop_marca = new System.Windows.Forms.ComboBox();
            this.drop_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_fechar = new ProjetoWindows.ControloBotoes();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.ForeColor = System.Drawing.Color.Black;
            this.label_info.Location = new System.Drawing.Point(12, 29);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(157, 24);
            this.label_info.TabIndex = 100;
            this.label_info.Text = "Modificar peças";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(34, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "ID";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkOrange;
            this.panel13.Location = new System.Drawing.Point(37, 123);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(57, 1);
            this.panel13.TabIndex = 102;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(37, 93);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(57, 24);
            this.txt_id.TabIndex = 101;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkOrange;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(722, 10);
            this.panel12.TabIndex = 99;
            // 
            // txt_data
            // 
            this.txt_data.CalendarForeColor = System.Drawing.Color.DarkOrange;
            this.txt_data.CalendarTitleForeColor = System.Drawing.Color.DarkOrange;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(37, 412);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(140, 24);
            this.txt_data.TabIndex = 117;
            // 
            // drop_marca
            // 
            this.drop_marca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_marca.ForeColor = System.Drawing.Color.DarkOrange;
            this.drop_marca.FormattingEnabled = true;
            this.drop_marca.Location = new System.Drawing.Point(206, 271);
            this.drop_marca.Name = "drop_marca";
            this.drop_marca.Size = new System.Drawing.Size(147, 26);
            this.drop_marca.TabIndex = 116;
            this.drop_marca.Text = "Marca";
            // 
            // drop_tipo
            // 
            this.drop_tipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drop_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drop_tipo.ForeColor = System.Drawing.Color.DarkOrange;
            this.drop_tipo.FormattingEnabled = true;
            this.drop_tipo.Location = new System.Drawing.Point(37, 271);
            this.drop_tipo.Name = "drop_tipo";
            this.drop_tipo.Size = new System.Drawing.Size(147, 26);
            this.drop_tipo.TabIndex = 115;
            this.drop_tipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(31, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(31, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Refª";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(34, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Nome do produto";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(37, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 1);
            this.panel4.TabIndex = 111;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.Color.Black;
            this.txt_nome.Location = new System.Drawing.Point(37, 157);
            this.txt_nome.Multiline = true;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(316, 24);
            this.txt_nome.TabIndex = 106;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(34, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 1);
            this.panel1.TabIndex = 109;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.ForeColor = System.Drawing.Color.Black;
            this.txt_valor.Location = new System.Drawing.Point(34, 334);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(104, 24);
            this.txt_valor.TabIndex = 108;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.Red;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(431, 583);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(87, 30);
            this.btn_limpar.TabIndex = 119;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.Location = new System.Drawing.Point(230, 583);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(87, 30);
            this.btn_adicionar.TabIndex = 118;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(243, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Quantidade";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel5.Location = new System.Drawing.Point(246, 364);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 1);
            this.panel5.TabIndex = 121;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.ForeColor = System.Drawing.Color.Black;
            this.txt_quantidade.Location = new System.Drawing.Point(246, 334);
            this.txt_quantidade.Multiline = true;
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(104, 24);
            this.txt_quantidade.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(34, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 123;
            this.label5.Text = "Data de fabrico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(34, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 1);
            this.panel2.TabIndex = 125;
            // 
            // txt_ref
            // 
            this.txt_ref.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ref.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ref.ForeColor = System.Drawing.Color.Black;
            this.txt_ref.Location = new System.Drawing.Point(34, 211);
            this.txt_ref.Multiline = true;
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(316, 24);
            this.txt_ref.TabIndex = 124;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ProjetoWindows.Properties.Resources._360_F_131093912_NtISEAFQAmBcYtU3VnO3b4U8Vn1tLacZ;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(412, 123);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(279, 279);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 105;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Image = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Imagemdiferente = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Imagemdiferente")));
            this.btn_fechar.ImagemNormal = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Location = new System.Drawing.Point(678, 16);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(32, 32);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 104;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // FrmPecasModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_ref);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.drop_marca);
            this.Controls.Add(this.drop_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPecasModificar";
            this.Text = "FrmPecasModificar";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControloBotoes btn_fechar;
        public System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel13;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        public System.Windows.Forms.DateTimePicker txt_data;
        public System.Windows.Forms.ComboBox drop_marca;
        public System.Windows.Forms.ComboBox drop_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_valor;
        public System.Windows.Forms.Button btn_limpar;
        public System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txt_ref;
    }
}