﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE
{
    public static class Theme
    {
        public static Color PrimaryColor => Color.FromArgb(255, 61, 0, 67);

        public static Color HoverTextColor => Color.FromArgb(220, 220, 220);

        public static Color DownTextColor => Color.White;

        public static Color HoverBackColor => Color.FromArgb(255, 61, 0, 67);

        public static Color DownBackColor => Color.FromArgb(255, 126, 62, 135);

        public static Color ActiveBorderColor => Color.FromArgb(255, 61, 0, 67);

        public static Color InactiveBorderColor => Color.FromArgb(131, 131, 131);

        public static Color ActiveTextColor => Color.Black;

        public static Color InactiveTextColor => Color.FromArgb(177, 177, 177);

        public static Color DefaultBackgorundColor => Color.White;

        public static Color AccentElementBackgorundColor => Color.FromArgb(255, 55, 106);

        public static Color DefaultElementBackgorundColor => Color.White;

        public static Color HoveredDefaultElementBackgorundColor => Color.WhiteSmoke;

        public static Color DefaultElementForeColor => Color.Black;

        public static Color HoveredDefaultElementForeColor => Color.Black;
    }
}