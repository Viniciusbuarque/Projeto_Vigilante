using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Projeto_Vigilante
{


    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //BUTTON
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                // BORDA BUTTON LEFT
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCadVig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Cadastro Vigilante";
            OpenChildForm(new frmCadVigilante());

        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            lblTitleChildForm.Text = "Cadastro Funcionário";
            OpenChildForm(new frmCadFunc());
        }

        private void btnCadVisitante_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            lblTitleChildForm.Text = "Registro Vigilante";
            OpenChildForm(new frmRegVigilante());
        }

        private void btnRegVisitante_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            lblTitleChildForm.Text = "Registro Visitante";
            OpenChildForm(new frmRegVisitante());
        }

        private void btnTelaExtra_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            lblTitleChildForm.Text = "Tela Extra";
            OpenChildForm(new frmTelaExtra());
        }

        private void btnPesqVig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            lblTitleChildForm.Text = "Pesquisa Vigilante";
            OpenChildForm(new frmPesqVigilante());
        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            lblTitleChildForm.Text = "Pesquisa Funcionario";
            OpenChildForm(new frmPesqFunc());
        }

        private void btnPesqVisitante_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            lblTitleChildForm.Text = "Pesquisa Visitante";
            OpenChildForm(new frmPesqVisitante());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
