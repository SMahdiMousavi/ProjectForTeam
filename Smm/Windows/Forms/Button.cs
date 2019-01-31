using System;
using System.Windows.Forms;
namespace Smm.Windows.Forms
{
    public class Button:System.Windows.Forms.Button
    {
        public Button():base()
        {
            BaseBackColor = System.Drawing.Color.Yellow;
        }

        public System.Drawing.Color DefultBackColor { get; set; }
        public System.Drawing.Color BaseBackColor { get; set; }
       
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = DefultBackColor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            
            base.OnMouseEnter(e);
            DefultBackColor = BackColor;
            BackColor = BaseBackColor;
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            Cursor = System.Windows.Forms.Cursors.Hand;
        }

    }
}
