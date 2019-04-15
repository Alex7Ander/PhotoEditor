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
                    int G = (int)pixel.G; 
                    int B = (int)pixel.B; 
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
                    trImage.SetPixel(i, j, Color.FromArgb(transparancyValue, R, G, B));
                }
            }
            Image = trImage;
            return;
        }

        public static void changeBrightness(ref Bitmap Image, int brightness, bool more)
        {
            Bitmap trImage = new Bitmap(Image.Width, Image.Height);
            for (int j = 0; j < trImage.Height; j++)
            {
                for (int i = 0; i < trImage.Width; i++)
                {
                    var pixel = Image.GetPixel(i, j);
                    //
                    int A = (int)pixel.A;

                    //R
                    int R = (int)pixel.R;
                    if (more)
                    {
                        double factor = (1 + (float)brightness / 100);
                        R = System.Convert.ToInt32(R * factor);
                        if (R > 255) R = 255;
                    }
                    else
                    {
                        double factor = (float)brightness / 100;
                        R = System.Convert.ToInt32(R * factor);
                        if (R < 0) R = 255;
                    }
                    

                    //G
                    int G = (int)pixel.G;
                    if (more)
                    {
                        double factor = (1 + (float)brightness / 100);
                        G = System.Convert.ToInt32(G * factor);
                        if (G > 255) G = 255;
                    }
                    else
                    {
                        double factor = (float)brightness / 100;
                        G = System.Convert.ToInt32(G * factor);
                        if (G < 0) G = 255;
                    }

                    
                    //B
                    int B = (int)pixel.B;
                    if (more)
                    {
                        double factor = (1 + (float)brightness / 100);
                        B = System.Convert.ToInt32(B * factor);
                        if (B > 255) B = 255;
                    }
                    else
                    {
                        double factor = (float)brightness / 100;
                        B = System.Convert.ToInt32(B * factor);
                        if (B < 0) B = 255;
                    }

                    trImage.SetPixel(i, j, Color.FromArgb(A, R, G, B));
                }
            }
            Image = trImage;
            return;
        }

        public static void changeContrast(ref Bitmap Image, int contrast, bool more)
        {
            Bitmap trImage = new Bitmap(Image.Width, Image.Height);
            //
        }

    }
}
