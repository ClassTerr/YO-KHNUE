using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;
using MO_KHNUE.Properties;

namespace Borderless
{
    public static class UIFont
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        static Dictionary<float, Font> myFonts = new Dictionary<float, Font>();

        public static Font GetUIFont(float size = 30)
        {
            Font font;
            myFonts.TryGetValue(size, out font);
            if (font != null)
                return font;
            
            byte[] fontData = Resources.UI;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.UI.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.UI.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            font = new Font(fonts.Families[0], size);
            myFonts.Add(size, font);
            return font;
        }
    }
}
