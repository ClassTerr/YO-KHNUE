using Borderless.Buttons;
using Borderless.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static MO_KHNUE.Theme;

namespace Borderless
{
    public partial class BorderlessForm : FormBase
    {
        private FormWindowState previousWindowState;
        private HeaderButton[] allButtons;

        public Size ButtonSize { get; } = new Size(SystemInformation.CaptionButtonSize.Width,
            SystemInformation.CaptionButtonSize.Height + 5);


        public enum MouseState
        {
            Normal,
            Hover,
            Down
        }

        protected void SetLabelColors(Control control, MouseState state)
        {
            if (!ContainsFocus) return;

            var textColor = ActiveTextColor;
            Color dark = ControlPaint.Dark(textColor, 30);
            var backColor = NormalBackColor;

            switch (state)
            {
                case MouseState.Hover:
                    textColor = HoverTextColor;
                    backColor = HoverBackColor;
                    break;
                case MouseState.Down:
                    textColor = DownTextColor;
                    backColor = DownBackColor;
                    break;
            }

            control.ForeColor = textColor;
            control.BackColor = backColor;
        }


        public BorderlessForm()
        {
            InitializeComponent();

            CustomHeader.Height = ButtonSize.Height;

            allButtons = new HeaderButton[] { BackButton, CloseButton, MaximizeButton, MinimizeButton };
            foreach (var item in allButtons)
            {
                item.Size = ButtonSize;
            }

            Activated += MainForm_Activated;
            Deactivate += MainForm_Deactivate;

            InitBorder();

            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseUp += (s, e) => { if (e.Button == MouseButtons.Right && TitleLabel.ClientRectangle.Contains(e.Location)) ShowSystemMenu(MouseButtons); };
            TitleLabel.Text = Text;
            TextChanged += (s, e) => TitleLabel.Text = Text;

            var marlett = new Font("Marlett", 8.5f);

            TitleRightButtons.Width = ButtonSize.Width * TitleRightButtons.Controls.Count;
            TitleLeftButtons.Width = ButtonSize.Width * TitleLeftButtons.Controls.Count;

            MinimizeButton.MouseClick += (s, e) => { if (e.Button == MouseButtons.Left) WindowState = FormWindowState.Minimized; };
            MaximizeButton.MouseClick += (s, e) => { if (e.Button == MouseButtons.Left) ToggleMaximize(); };
            CloseButton.MouseClick += (s, e) => Close(e);

            previousWindowState = MinMaxState;
            SizeChanged += MainForm_SizeChanged;
        }

        void InitBorder()
        {
            TopLeftCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOPLEFT);
            TopRightCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOPRIGHT);
            BottomLeftCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOMLEFT);
            BottomRightCornerPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOMRIGHT);

            TopBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTTOP);
            LeftBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTLEFT);
            RightBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTRIGHT);
            BottomBorderPanel.MouseDown += (s, e) => DecorationMouseDown(e, HitTestValues.HTBOTTOM);
        }

        void SystemLabel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) ShowSystemMenu(MouseButtons);
        }

        private DateTime systemClickTime = DateTime.MinValue;
        private DateTime systemMenuCloseTime = DateTime.MinValue;

        void Close(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Close();
        }

        void DecorationMouseDown(MouseEventArgs e, HitTestValues h)
        {
            if (e.Button == MouseButtons.Left) DecorationMouseDown(h);
        }

        void MainForm_Deactivate(object sender, EventArgs e)
        {
            SetBorderColor(InactiveBorderColor);
            SetTextColor(InactiveTextColor);
        }

        void MainForm_Activated(object sender, EventArgs e)
        {
            SetBorderColor(ActiveBorderColor);
            SetTextColor(ActiveTextColor);
        }

        protected void SetBorderColor(Color color)
        {
            TopLeftCornerPanel.BackColor = color;
            TopBorderPanel.BackColor = color;
            TopRightCornerPanel.BackColor = color;
            LeftBorderPanel.BackColor = color;
            RightBorderPanel.BackColor = color;
            BottomLeftCornerPanel.BackColor = color;
            BottomBorderPanel.BackColor = color;
            BottomRightCornerPanel.BackColor = color;
        }

        protected void SetBorderVisibility(bool visible)
        {
            TopLeftCornerPanel.Visible = visible;
            TopBorderPanel.Visible = visible;
            TopRightCornerPanel.Visible = visible;
            LeftBorderPanel.Visible = visible;
            RightBorderPanel.Visible = visible;
            BottomLeftCornerPanel.Visible = visible;
            BottomBorderPanel.Visible = visible;
            BottomRightCornerPanel.Visible = visible;
        }

        protected void SetTextColor(Color color)
        {
            TitleLabel.ForeColor = color;

            foreach (var item in allButtons)
            {
                item.ForeColor = color;
            }
        }

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            var maximized = MinMaxState == FormWindowState.Maximized;
            SetBorderVisibility(!maximized);
            MaximizeButton.Text = maximized ? "2" : "1";

            var panels = new[] { TopLeftCornerPanel, TopRightCornerPanel, BottomLeftCornerPanel, BottomRightCornerPanel,
                TopBorderPanel, LeftBorderPanel, RightBorderPanel, BottomBorderPanel };

            foreach (var panel in panels)
            {
                panel.Visible = !maximized;
            }

            if (previousWindowState != MinMaxState)
            {
                if (maximized)
                {
                    CloseButton.Left += RightBorderPanel.Width;
                    CloseButton.Top = 0;
                    MaximizeButton.Left += RightBorderPanel.Width;
                    MaximizeButton.Top = 0;
                    MinimizeButton.Left += RightBorderPanel.Width;
                    MinimizeButton.Top = 0;
                    TitleLabel.Left -= LeftBorderPanel.Width;
                    TitleLabel.Width += LeftBorderPanel.Width + RightBorderPanel.Width;
                    TitleLabel.Top = 0;
                }
                else if (previousWindowState == FormWindowState.Maximized)
                {
                    CloseButton.Left -= RightBorderPanel.Width;
                    CloseButton.Top = TopBorderPanel.Height;
                    MaximizeButton.Left -= RightBorderPanel.Width;
                    MaximizeButton.Top = TopBorderPanel.Height;
                    MinimizeButton.Left -= RightBorderPanel.Width;
                    MinimizeButton.Top = TopBorderPanel.Height;
                    TitleLabel.Left += LeftBorderPanel.Width;
                    TitleLabel.Width -= LeftBorderPanel.Width + RightBorderPanel.Width;
                    TitleLabel.Top = TopBorderPanel.Height;
                }

                previousWindowState = MinMaxState;
            }
        }

        private FormWindowState ToggleMaximize()
        {
            return WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private DateTime titleClickTime = DateTime.MinValue;
        private Point titleClickPosition = Point.Empty;

        void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var clickTime = (DateTime.Now - titleClickTime).TotalMilliseconds;
                if (clickTime < SystemInformation.DoubleClickTime && e.Location == titleClickPosition)
                    ToggleMaximize();
                else
                {
                    titleClickTime = DateTime.Now;
                    titleClickPosition = e.Location;
                    DecorationMouseDown(HitTestValues.HTCAPTION);
                }
            }
        }
    }
}
