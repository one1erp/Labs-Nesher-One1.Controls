using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace One1.Controls
{
    public static class CustomMessageBox
    {
      public static void  Show(string text, MessageBoxButtons messageBoxButtons=MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon=MessageBoxIcon.None)
      {
          MessageBox.Show(text, "Nautilus", messageBoxButtons,messageBoxIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
      }
    }
}
