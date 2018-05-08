using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MO_KHNUE.Properties;

namespace MO_KHNUE
{
    public partial class StyledForm : Form
    {
        public Color HighlightButtonCloseColor { get; set; } = Color.FromArgb(150, 255, 0, 0);
        public Color HighlightButtonColor { get; set; } = Color.FromArgb(130, 230, 230, 230);

        public delegate void EmptyEventHandler();

        public event EmptyEventHandler BackButtonClicked;
        
        public StyledForm()
        {
            InitializeComponent();
            InitTitle();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
        }
        
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = captionLabel.Text = value;
            }
        }

        public bool BackAvailiable
        {
            get
            {
                return BackButton?.Visible == true;
            }
            set
            {
                if (BackButton != null)
                    BackButton.Visible = value;
            }
        }

        public PictureBox MaximizeButton { get; set; }
        public PictureBox MinimizeButton { get; set; }
        public PictureBox BackButton { get; set; }
        public PictureBox CloseButton { get; set; }

        void InitTitle()
        {
            Size buttonSize = new Size(SystemInformation.CaptionButtonSize.Width,
                SystemInformation.CaptionButtonSize.Height + 5);
            Title.Height = buttonSize.Height;

            InitMovable();


            CloseButton = new PictureBox()
            {
                Size = buttonSize,
                Image = Resources.Close,
                Margin = Padding.Empty,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            CloseButton.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    this.Close();
            };

            MaximizeButton = new PictureBox()
            {
                Size = buttonSize,
                Image = Resources.Maximize,
                Margin = Padding.Empty,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            MaximizeButton.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    MaximizeButtonClick();
            };

            MinimizeButton = new PictureBox()
            {
                Size = buttonSize,
                Image = Resources.Minimize,
                Margin = Padding.Empty,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            MinimizeButton.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    WindowState = FormWindowState.Minimized;
            };

            BackButton = new PictureBox()
            {
                Size = buttonSize,
                Image = Resources.Back,
                Margin = Padding.Empty,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = Point.Empty,
                Visible = false
            };
            InitButtonEffects(BackButton, HighlightButtonColor);
            BackButton.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    if (BackButtonClicked != null)
                        BackButtonClicked();
            };

            TitleRightButtons.Controls.Clear();
            TitleRightButtons.Controls.AddRange(new[] { CloseButton, MaximizeButton, MinimizeButton });
            TitleRightButtons.Width = buttonSize.Width * TitleRightButtons.Controls.Count;
            
            TitleLeftButtons.Controls.Add(BackButton);
            TitleLeftButtons.Width = TitleLeftButtons.Controls.Count * buttonSize.Width;
            Title.SendToBack();

            foreach (Control item in TitleRightButtons.Controls)
            {
                if (item == CloseButton)
                    InitButtonEffects(item, HighlightButtonCloseColor);
                else
                    InitButtonEffects(item, HighlightButtonColor);
            }
        }

        void InitMovable()
        {
            Title.MouseDown += new MouseEventHandler(Title_MouseDown);
            captionLabel.MouseDown += new MouseEventHandler(Title_MouseDown);
        }


        void InitButtonEffects(Control c, Color col)
        {
            Color dark = ControlPaint.Dark(col, 30);

            c.MouseEnter += (s, e) =>
            {
                (s as Control).BackColor = col;
            };
            c.MouseLeave += (s, e) =>
            {
                (s as Control).BackColor = Color.Transparent;
            };
            c.MouseDown += (s, e) =>
            {
                (s as Control).BackColor = dark;
            };

            c.MouseUp += (s, e) =>
            {
                (s as Control).BackColor = col;
            };
        }

        void MaximizeButtonClick()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1)
                {
                    (sender as Control).Capture = false;
                    Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
                    base.WndProc(ref msg);
                }
                else MaximizeButtonClick();
            }
        }


        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_NCHITTEST = 0x84;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
    }
}
