using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    class FormResizer
    {
        public int getSizeX(int currentSizeX, int coefficient)
        {
            bool notDone = true;
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            int x = currentSizeX;
            int necessurySize = resolution.Width - (resolution.Width * coefficient/100);
            while (notDone)
            {
                if (x > necessurySize)
                {
                    x = x-x*coefficient/100;
                }
                else
                {
                    notDone = false;
                }
            }
            return x;
        }

        public int getSizeY(int currentSizeY, int coefficient)
        {
            bool notDone = true;
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            int y = currentSizeY;
            int necessurySize = resolution.Height - (resolution.Height * coefficient / 100);
            while (notDone)
            {
                if (y > necessurySize)
                {
                    y = y - y * coefficient / 100;
                }
                else
                {
                    notDone = false;
                }
            }
            return y;
        }
    }
}
