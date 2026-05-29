using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercad
{
    public class EstiloMenu
    {
        public static void Menu_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(0, 102, 204);
        }
        public static void Menu_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(6, 30, 64);
        }
        public static void MouseSairEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Name == "btnSair")
            {
                btn.BackColor = Color.FromArgb(220, 53, 69);
            }
            else
            {
                btn.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        public static void MouseSairLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.BackColor = Color.FromArgb(6, 30, 64);
        }
    }
}
