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

namespace MS_SQL_Helper
{
    public partial class Main : Form
    {
        #region RESIZE METOD
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------RECTANGULO 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelMain.Region = region;
            this.Invalidate();
        }
        //----------------COLOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 191, 76)); //255, 191, 76
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.FromArgb(29, 36, 51), sizeGripRectangle);// 29, 36, 51
        }
        #endregion

        public Main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            CustomizeDesign();
        }

        void CustomizeDesign()
        {
            panelLogo.Visible = false;
            panelMenu.Visible = false;
            panelCodeFirst.Visible = false;
            panelEditing.Visible = false;

            /* Подгон высоты каждой панели под кол-во кнопок */
            int btnHeight = 50;

            panelMenu.Height = panelMenu.Controls.Count * btnHeight;
            panelCodeFirst.Height = panelCodeFirst.Controls.Count * btnHeight;
            panelEditing.Height = panelEditing.Controls.Count * btnHeight;
        }

        void HideSubMenu()
        {
            if (panelMenu.Visible)
                panelMenu.Visible = false;

            if (panelCodeFirst.Visible)
                panelCodeFirst.Visible = false;

            if (panelEditing.Visible)
                panelEditing.Visible = false;
        }

        void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private Form activeForm = null;
        private void OpenChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelRigth.Controls.Add(childForm);
            panelRigth.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Кнопка: выход, свернуть, на весь экран
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            /* Save params */
            Variables.Width = Width;
            Variables.Height = Height;
            Variables.Top = Top;
            Variables.Left = Left;

            Width = Screen.PrimaryScreen.Bounds.Size.Width;
            Height = Screen.PrimaryScreen.Bounds.Size.Height;
            Top = 0;
            Left = 0;

            btnFull.Visible = false;
            btnFullResize.Visible = true;
        }

        private void btnFullResize_Click(object sender, EventArgs e)
        {
            /* Upload params */
            Width = Variables.Width;
            Height = Variables.Height;
            Top = Variables.Top;
            Left = Variables.Left;

            btnFull.Visible = true;
            btnFullResize.Visible = false;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Moving
        /* Metod moving */
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        private void panelTab_MouseDown(object sender, MouseEventArgs e)
        {
            /* Use metod moving */
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        #endregion

        #region Button Click
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMenu);
        }

        private void btnCodeFirst_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCodeFirst);
        }
        private void btnEditing_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEditing);
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(new CreateTable());
            HideSubMenu();
        }

        private void btnRelationship_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(new RelationShip());
            HideSubMenu();
        }

        private void btnJSONAdd_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(new JSONAdd());
            HideSubMenu();
        }

        private void btnCreateTableCF_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(new CreateTableFC());
            HideSubMenu();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {/* При загрузке создает папки, если они отсутсвуют */
            System.IO.Directory.CreateDirectory("Resource/Settings");
            System.IO.Directory.CreateDirectory("Resource/Tables");
            System.IO.Directory.CreateDirectory("Resource/Scripts");
        }


    }
}