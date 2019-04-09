using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    public static class Painter
    {
        private static Bitmap Image;

        static Painter()
        {
            //
        }

        public static void transformColorToBW(ref Bitmap Image)
        {
            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    var pixel = Image.GetPixel(i, j); // получаем (i, j) пиксель
                    int R = (int)pixel.R;
                    int G = (int)pixel.G; // зеленый
                    int B = (int)pixel.B; // синий
                    int average = (R + G + B) / 3;
                    Image.SetPixel(i, j, Color.FromArgb(average, average, average));
                }
            }
            return;
        }

        public static void changeTransparancy(ref Bitmap Image, int transparancyValue)
        {
            Bitmap trImage = new Bitmap(Image.Width, Image.Height);
            for (int j = 0; j < trImage.Height; j++)
            {
                for (int i = 0; i < trImage.Width; i++)
                {
                    var pixel = Image.GetPixel(i, j); // получаем (i, j) пиксель
                    int R = (int)pixel.R;
                    int G = (int)pixel.G; 
                    int B = (int)pixel.B; 
                    //int A = (int)pixel.A;
                    //A = A + transparancyValue * 128 / 100;
                    trImage.SetPixel(i, j, Color.FromArgb(transparancyValue, R, G, B));
                }
            }
            Image = trImage;
            return;
        }
    }
}
