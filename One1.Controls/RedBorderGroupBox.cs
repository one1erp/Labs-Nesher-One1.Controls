using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace One1.Controls
{
    public class RedBorderGroupBox : RadGroupBox
    {
        private bool redBorder;

        public bool RedBorder
        {
            get { return redBorder; }


        }
        public void RemoveRedBorder()
        {
            redBorder = false;
            Invalidate();
        }
        public void SetRedBorder()
        {
            redBorder = true;
            Invalidate();
        }

  

         protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (redBorder)
            {
                ButtonBorderStyle b = ButtonBorderStyle.Dotted;
                base.OnPaint(e);
                ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                        Color.Red, 2, b,
                                        Color.Red, 2, b,
                                        Color.Red, 2, b,
                                        Color.Red, 2, b);


            }
        }
    }
}
