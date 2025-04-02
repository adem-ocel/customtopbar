using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace customform
{
    public partial class Topbar : UserControl
    {
        Form parent = null!;
        public Topbar()
        {
            InitializeComponent();
        }

        private bool _Xbuttonhide = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Xbuttonhide
        {
            get => _Xbuttonhide;
            set
            {
                _Xbuttonhide = value;

                if (value)
                {
                    this.closebutton.Click += (sender, e) => parent.Hide();
                    this.closebutton.Click -= (sender, e) => parent.Close();
                }
                else
                {
                    this.closebutton.Click += (sender, e) => parent.Close();
                    this.closebutton.Click -= (sender, e) => parent.Hide();
                }
            }
        }
        private void Customtopbar_Load(object sender, EventArgs e)
        {
            this.SendToBack();
            parent.FormBorderStyle = FormBorderStyle.None;
        }
        private void Closebutton_Click(object sender, EventArgs e)
        {
            parent.Close();
        }
        private void Windowstatemaxbutton_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                if (parent.WindowState == FormWindowState.Normal)
                {
                    parent.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    parent.WindowState = FormWindowState.Normal;
                }
            }
        }
        private void Windowstatusminbutton_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                parent.WindowState = FormWindowState.Minimized;
            }
        }
        private void Title_TextChanged(object sender, EventArgs e)
        {
            titlepanel.Visible = !string.IsNullOrEmpty(title.Text);
            if (titlepanel.Visible)
            {
                titlepanel.Width = title.Width + 10;
            }
        }

        #region drag
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Customtopbar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = parent.Location;
        }
        private void Customtopbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                parent.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Customtopbar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion
        public void UseSizer(ref Message m)
        {
            const int HT_LEFT = 0xA;
            const int HT_RIGHT = 0xB;
            const int HT_TOP = 0xC;
            const int HT_TOPLEFT = 0xD;
            const int HT_TOPRIGHT = 0xE;
            const int HT_BOTTOM = 0xF;
            const int HT_BOTTOMLEFT = 0x10;
            const int HT_BOTTOMRIGHT = 0x11;
            const int WM_NCHITTEST = 0x84;
            const int resizeAreaSize = 10;

            if (m.Msg == WM_NCHITTEST)
            {
                Point cursorPos = PointToClient(Cursor.Position);

                // Cursor pozisyonu
                int cursorX = cursorPos.X;
                int cursorY = cursorPos.Y;

                // Resimleme alanları
                if (cursorX <= resizeAreaSize && cursorY <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOPLEFT;
                else if (cursorX >= ClientSize.Width - resizeAreaSize && cursorY <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOPRIGHT;
                else if (cursorX <= resizeAreaSize && cursorY >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOMLEFT;
                else if (cursorX >= ClientSize.Width - resizeAreaSize && cursorY >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOMRIGHT;
                else if (cursorX <= resizeAreaSize)
                    m.Result = (IntPtr)HT_LEFT;
                else if (cursorX >= ClientSize.Width - resizeAreaSize)
                    m.Result = (IntPtr)HT_RIGHT;
                else if (cursorY <= resizeAreaSize)
                    m.Result = (IntPtr)HT_TOP;
                else if (cursorY >= ClientSize.Height - resizeAreaSize)
                    m.Result = (IntPtr)HT_BOTTOM;
            }
        }

        private void Topbar_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent is null)
            {
                throw new Exception("parent is null");
            }
            else if (this.Parent is not Form)
            {
                throw new Exception("CustomTopBar can only be added to Form objects.");
            }
            parent = (Form)this.Parent;

            Dock = DockStyle.Top;
            BackColor = parent.BackColor;
            parent.Height += this.Height;
            this.Width = parent.Width;
            parent.Controls.Add(this);
        }

        private void Topbar_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.BackColor = BackColor;
            }
            title.BackColor = BackColor;
        }

        private void İcon_BackgroundImageChanged(object sender, EventArgs e)
        {
            icon.Visible = icon.BackgroundImage != null;
        }

        private void Title_TextChanged_1(object sender, EventArgs e)
        {
            titlepanel.Width = Math.Max(title.PreferredWidth + 10, 100);
        }
    }
}
