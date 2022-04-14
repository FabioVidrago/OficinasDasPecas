
namespace ProjetoWindows
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.lbl_utilizador = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_servicos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_encomendas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pecas = new Guna.UI2.WinForms.Guna2Button();
            this.btn_utilizadores = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new ProjetoWindows.ControloBotoes();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 5);
            this.panel4.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 675);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btn_servicos);
            this.panel5.Controls.Add(this.btn_encomendas);
            this.panel5.Controls.Add(this.btn_pecas);
            this.panel5.Controls.Add(this.btn_utilizadores);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 601);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_perfil);
            this.panel3.Controls.Add(this.lbl_utilizador);
            this.panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 184);
            this.panel3.TabIndex = 4;
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.Location = new System.Drawing.Point(27, 125);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(140, 24);
            this.lbl_perfil.TabIndex = 7;
            this.lbl_perfil.Text = "perfil";
            this.lbl_perfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_utilizador
            // 
            this.lbl_utilizador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_utilizador.Location = new System.Drawing.Point(27, 101);
            this.lbl_utilizador.Name = "lbl_utilizador";
            this.lbl_utilizador.Size = new System.Drawing.Size(140, 24);
            this.lbl_utilizador.TabIndex = 8;
            this.lbl_utilizador.Text = "Utilizador";
            this.lbl_utilizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(194, 74);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1006, 393);
            this.panelMain.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(194, 473);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1006, 202);
            this.panel6.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoWindows.Properties.Resources.reparacoes_banner;
            this.pictureBox2.Location = new System.Drawing.Point(6, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(997, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_servicos
            // 
            this.btn_servicos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_servicos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_servicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_servicos.FillColor = System.Drawing.Color.Transparent;
            this.btn_servicos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servicos.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_servicos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_servicos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_servicos.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_servicos.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_servicos.Image = global::ProjetoWindows.Properties.Resources.Services_24px;
            this.btn_servicos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_servicos.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_servicos.Location = new System.Drawing.Point(0, 319);
            this.btn_servicos.Name = "btn_servicos";
            this.btn_servicos.Size = new System.Drawing.Size(194, 45);
            this.btn_servicos.TabIndex = 61;
            this.btn_servicos.Text = "Serviços";
            this.btn_servicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_servicos.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_servicos.Click += new System.EventHandler(this.btn_servicos_Click);
            // 
            // btn_encomendas
            // 
            this.btn_encomendas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_encomendas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_encomendas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_encomendas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_encomendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_encomendas.FillColor = System.Drawing.Color.Transparent;
            this.btn_encomendas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encomendas.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_encomendas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_encomendas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_encomendas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_encomendas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_encomendas.Image = global::ProjetoWindows.Properties.Resources.box_26px;
            this.btn_encomendas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_encomendas.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_encomendas.Location = new System.Drawing.Point(0, 274);
            this.btn_encomendas.Name = "btn_encomendas";
            this.btn_encomendas.Size = new System.Drawing.Size(194, 45);
            this.btn_encomendas.TabIndex = 60;
            this.btn_encomendas.Text = "Encomendas";
            this.btn_encomendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_encomendas.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_encomendas.Click += new System.EventHandler(this.btn_encomendas_Click);
            // 
            // btn_pecas
            // 
            this.btn_pecas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pecas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pecas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pecas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pecas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pecas.FillColor = System.Drawing.Color.Transparent;
            this.btn_pecas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pecas.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_pecas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_pecas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_pecas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_pecas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_pecas.Image = global::ProjetoWindows.Properties.Resources.maintenance_50px;
            this.btn_pecas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pecas.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_pecas.Location = new System.Drawing.Point(0, 229);
            this.btn_pecas.Name = "btn_pecas";
            this.btn_pecas.Size = new System.Drawing.Size(194, 45);
            this.btn_pecas.TabIndex = 59;
            this.btn_pecas.Text = "Peças";
            this.btn_pecas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pecas.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_pecas.Click += new System.EventHandler(this.btn_pecas_Click);
            // 
            // btn_utilizadores
            // 
            this.btn_utilizadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_utilizadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_utilizadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_utilizadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_utilizadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_utilizadores.FillColor = System.Drawing.Color.Transparent;
            this.btn_utilizadores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilizadores.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_utilizadores.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_utilizadores.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.btn_utilizadores.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_utilizadores.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.btn_utilizadores.Image = global::ProjetoWindows.Properties.Resources.member_32px;
            this.btn_utilizadores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_utilizadores.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_utilizadores.Location = new System.Drawing.Point(0, 184);
            this.btn_utilizadores.Name = "btn_utilizadores";
            this.btn_utilizadores.Size = new System.Drawing.Size(194, 45);
            this.btn_utilizadores.TabIndex = 58;
            this.btn_utilizadores.Text = "Utilizadores";
            this.btn_utilizadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_utilizadores.TextOffset = new System.Drawing.Point(10, 0);
            this.btn_utilizadores.Click += new System.EventHandler(this.btn_utilizadores_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::ProjetoWindows.Properties.Resources.user;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(57, 16);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(81, 82);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoWindows.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(47, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Image = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Imagemdiferente = ((System.Drawing.Image)(resources.GetObject("btn_fechar.Imagemdiferente")));
            this.btn_fechar.ImagemNormal = global::ProjetoWindows.Properties.Resources.close_window_48px;
            this.btn_fechar.Location = new System.Drawing.Point(1165, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(32, 32);
            this.btn_fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_fechar.TabIndex = 59;
            this.btn_fechar.TabStop = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_fechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ControloBotoes btn_fechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbl_perfil;
        public System.Windows.Forms.Label lbl_utilizador;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btn_utilizadores;
        private Guna.UI2.WinForms.Guna2Button btn_pecas;
        private Guna.UI2.WinForms.Guna2Button btn_servicos;
        private Guna.UI2.WinForms.Guna2Button btn_encomendas;
    }
}