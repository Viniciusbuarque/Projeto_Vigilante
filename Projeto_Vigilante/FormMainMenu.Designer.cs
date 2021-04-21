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
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnOcorrencia = new FontAwesome.Sharp.IconButton();
            this.btnCadVisitante = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.btnOcorrencia);
            this.panelMenu.Controls.Add(this.btnCadVisitante);
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
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 380);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(220, 60);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Tela Extra";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnOcorrencia
            // 
            this.btnOcorrencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOcorrencia.FlatAppearance.BorderSize = 0;
            this.btnOcorrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcorrencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOcorrencia.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnOcorrencia.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOcorrencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOcorrencia.IconSize = 32;
            this.btnOcorrencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcorrencia.Location = new System.Drawing.Point(0, 320);
            this.btnOcorrencia.Name = "btnOcorrencia";
            this.btnOcorrencia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOcorrencia.Size = new System.Drawing.Size(220, 60);
            this.btnOcorrencia.TabIndex = 4;
            this.btnOcorrencia.Text = "Tela de Ocorrência";
            this.btnOcorrencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOcorrencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOcorrencia.UseVisualStyleBackColor = true;
            this.btnOcorrencia.Click += new System.EventHandler(this.btnOcorrencia_Click);
            // 
            // btnCadVisitante
            // 
            this.btnCadVisitante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadVisitante.FlatAppearance.BorderSize = 0;
            this.btnCadVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVisitante.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadVisitante.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnCadVisitante.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCadVisitante.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadVisitante.IconSize = 32;
            this.btnCadVisitante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVisitante.Location = new System.Drawing.Point(0, 260);
            this.btnCadVisitante.Name = "btnCadVisitante";
            this.btnCadVisitante.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadVisitante.Size = new System.Drawing.Size(220, 60);
            this.btnCadVisitante.TabIndex = 3;
            this.btnCadVisitante.Text = "Registro Visitante";
            this.btnCadVisitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadVisitante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadVisitante.UseVisualStyleBackColor = true;
            this.btnCadVisitante.Click += new System.EventHandler(this.btnCadVisitante_Click);
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
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btnOcorrencia;
        private FontAwesome.Sharp.IconButton btnCadVisitante;
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

