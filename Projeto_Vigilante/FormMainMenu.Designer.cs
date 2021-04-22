namespace Projeto_Vigilante
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPesqVisitante = new FontAwesome.Sharp.IconButton();
            this.btnPesqFunc = new FontAwesome.Sharp.IconButton();
            this.btnPesqVig = new FontAwesome.Sharp.IconButton();
            this.btnTelaExtra = new FontAwesome.Sharp.IconButton();
            this.btnRegVisitante = new FontAwesome.Sharp.IconButton();
            this.btnRegVig = new FontAwesome.Sharp.IconButton();
            this.btnCadFunc = new FontAwesome.Sharp.IconButton();
            this.btnCadVig = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnPesqVisitante);
            this.panelMenu.Controls.Add(this.btnPesqFunc);
            this.panelMenu.Controls.Add(this.btnPesqVig);
            this.panelMenu.Controls.Add(this.btnTelaExtra);
            this.panelMenu.Controls.Add(this.btnRegVisitante);
            this.panelMenu.Controls.Add(this.btnRegVig);
            this.panelMenu.Controls.Add(this.btnCadFunc);
            this.panelMenu.Controls.Add(this.btnCadVig);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 675);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPesqVisitante
            // 
            this.btnPesqVisitante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesqVisitante.FlatAppearance.BorderSize = 0;
            this.btnPesqVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqVisitante.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPesqVisitante.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesqVisitante.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPesqVisitante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesqVisitante.IconSize = 32;
            this.btnPesqVisitante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqVisitante.Location = new System.Drawing.Point(0, 560);
            this.btnPesqVisitante.Name = "btnPesqVisitante";
            this.btnPesqVisitante.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPesqVisitante.Size = new System.Drawing.Size(220, 60);
            this.btnPesqVisitante.TabIndex = 8;
            this.btnPesqVisitante.Text = "Pesquisa Visitante";
            this.btnPesqVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqVisitante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesqVisitante.UseVisualStyleBackColor = true;
            this.btnPesqVisitante.Click += new System.EventHandler(this.btnPesqVisitante_Click);
            // 
            // btnPesqFunc
            // 
            this.btnPesqFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesqFunc.FlatAppearance.BorderSize = 0;
            this.btnPesqFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqFunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPesqFunc.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesqFunc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPesqFunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesqFunc.IconSize = 32;
            this.btnPesqFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqFunc.Location = new System.Drawing.Point(0, 500);
            this.btnPesqFunc.Name = "btnPesqFunc";
            this.btnPesqFunc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPesqFunc.Size = new System.Drawing.Size(220, 60);
            this.btnPesqFunc.TabIndex = 7;
            this.btnPesqFunc.Text = "Pesquisa Funcionário";
            this.btnPesqFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesqFunc.UseVisualStyleBackColor = true;
            this.btnPesqFunc.Click += new System.EventHandler(this.btnPesqFunc_Click);
            // 
            // btnPesqVig
            // 
            this.btnPesqVig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesqVig.FlatAppearance.BorderSize = 0;
            this.btnPesqVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqVig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPesqVig.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesqVig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPesqVig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesqVig.IconSize = 32;
            this.btnPesqVig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqVig.Location = new System.Drawing.Point(0, 440);
            this.btnPesqVig.Name = "btnPesqVig";
            this.btnPesqVig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPesqVig.Size = new System.Drawing.Size(220, 60);
            this.btnPesqVig.TabIndex = 6;
            this.btnPesqVig.Text = "Pesquisa Vigilante";
            this.btnPesqVig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesqVig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesqVig.UseVisualStyleBackColor = true;
            this.btnPesqVig.Click += new System.EventHandler(this.btnPesqVig_Click);
            // 
            // btnTelaExtra
            // 
            this.btnTelaExtra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTelaExtra.FlatAppearance.BorderSize = 0;
            this.btnTelaExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaExtra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTelaExtra.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnTelaExtra.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTelaExtra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTelaExtra.IconSize = 32;
            this.btnTelaExtra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaExtra.Location = new System.Drawing.Point(0, 380);
            this.btnTelaExtra.Name = "btnTelaExtra";
            this.btnTelaExtra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTelaExtra.Size = new System.Drawing.Size(220, 60);
            this.btnTelaExtra.TabIndex = 5;
            this.btnTelaExtra.Text = "Tela Extra";
            this.btnTelaExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaExtra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelaExtra.UseVisualStyleBackColor = true;
            this.btnTelaExtra.Click += new System.EventHandler(this.btnTelaExtra_Click);
            // 
            // btnRegVisitante
            // 
            this.btnRegVisitante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegVisitante.FlatAppearance.BorderSize = 0;
            this.btnRegVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegVisitante.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegVisitante.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnRegVisitante.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegVisitante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegVisitante.IconSize = 32;
            this.btnRegVisitante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVisitante.Location = new System.Drawing.Point(0, 320);
            this.btnRegVisitante.Name = "btnRegVisitante";
            this.btnRegVisitante.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegVisitante.Size = new System.Drawing.Size(220, 60);
            this.btnRegVisitante.TabIndex = 4;
            this.btnRegVisitante.Text = "Registro Visitante";
            this.btnRegVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVisitante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegVisitante.UseVisualStyleBackColor = true;
            this.btnRegVisitante.Click += new System.EventHandler(this.btnRegVisitante_Click);
            // 
            // btnRegVig
            // 
            this.btnRegVig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegVig.FlatAppearance.BorderSize = 0;
            this.btnRegVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegVig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegVig.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnRegVig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRegVig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegVig.IconSize = 32;
            this.btnRegVig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVig.Location = new System.Drawing.Point(0, 260);
            this.btnRegVig.Name = "btnRegVig";
            this.btnRegVig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegVig.Size = new System.Drawing.Size(220, 60);
            this.btnRegVig.TabIndex = 3;
            this.btnRegVig.Text = "Registro Vigilante";
            this.btnRegVig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegVig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegVig.UseVisualStyleBackColor = true;
            this.btnRegVig.Click += new System.EventHandler(this.btnCadVisitante_Click);
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadFunc.FlatAppearance.BorderSize = 0;
            this.btnCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFunc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadFunc.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadFunc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCadFunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadFunc.IconSize = 32;
            this.btnCadFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadFunc.Location = new System.Drawing.Point(0, 200);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadFunc.Size = new System.Drawing.Size(220, 60);
            this.btnCadFunc.TabIndex = 2;
            this.btnCadFunc.Text = "Cadastro Funcionário";
            this.btnCadFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // btnCadVig
            // 
            this.btnCadVig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadVig.FlatAppearance.BorderSize = 0;
            this.btnCadVig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVig.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadVig.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadVig.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCadVig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadVig.IconSize = 32;
            this.btnCadVig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVig.Location = new System.Drawing.Point(0, 140);
            this.btnCadVig.Name = "btnCadVig";
            this.btnCadVig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadVig.Size = new System.Drawing.Size(220, 60);
            this.btnCadVig.TabIndex = 1;
            this.btnCadVig.Text = "Cadastro Vigilante";
            this.btnCadVig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadVig.UseVisualStyleBackColor = true;
            this.btnCadVig.Click += new System.EventHandler(this.btnCadVig_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Projeto_Vigilante.Properties.Resources.png_arte_;
            this.btnHome.Location = new System.Drawing.Point(30, 34);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(152, 72);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(59, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 591);
            this.panelDesktop.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnPesqVisitante;
        private FontAwesome.Sharp.IconButton btnPesqFunc;
        private FontAwesome.Sharp.IconButton btnPesqVig;
        private FontAwesome.Sharp.IconButton btnTelaExtra;
        private FontAwesome.Sharp.IconButton btnRegVisitante;
        private FontAwesome.Sharp.IconButton btnRegVig;
        private FontAwesome.Sharp.IconButton btnCadFunc;
        private FontAwesome.Sharp.IconButton btnCadVig;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

