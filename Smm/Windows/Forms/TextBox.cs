using System;
namespace Smm.Windows.Forms
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox()
        {
            BaseBackColor = System.Drawing.Color.Orange;
        }

        public System.Drawing.Color BaseBackColor { get; set; }

        public System.Drawing.Color DefulatBackColor { get; set; }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            DefulatBackColor = BackColor;
            BackColor = BaseBackColor;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            BackColor = DefulatBackColor;
        }

    }
}
