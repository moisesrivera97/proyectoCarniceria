using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TextBox3
{
    class TextBoxRounded : TextBox
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // coordenada X
            int nTopRect,// coordenada Y
            int nRightRect, // ancho
            int nBottomRect,// altura
            int nheightRect, //altura Elipse 
            int nweightRect //ancho Elipse
        );
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(this.ForeColor);
            LinearGradientBrush lb = new LinearGradientBrush(this.ClientRectangle,
             Color.FromArgb(243, 243, 243), Color.White, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(lb, this.ClientRectangle);
            e.Graphics.DrawString(this.Text, this.Font, sb, 0f, 0f);
            sb.Dispose();
            lb.Dispose();
        }
        protected override void OnCreateControl()
        {
            if (IsHandleCreated)
            {
                SetStyle(ControlStyles.UserPaint, true);
            }
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
        }

    }
}
