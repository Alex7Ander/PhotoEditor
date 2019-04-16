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
                    double factor;
                    if (more)
                    {
                        factor = (1 + (float)brightness / 100);
                    }
                    else 
                    {
                        factor = (float)(100-brightness) / 100;
                    }
                    //
                    int A = (int)pixel.A;

                    //R
                    int R = (int)pixel.R;
                    if (more)
                    {
                        R = System.Convert.ToInt32(R * factor);
                        if (R > 255) R = 255;
                    }
                    else
                    {
                        R = System.Convert.ToInt32(R * factor);
                        if (R < 0) R = 0;
                    }
                    

                    //G
                    int G = (int)pixel.G;
                    if (more)
                    {
                        G = System.Convert.ToInt32(G * factor);
                        if (G > 255) G = 255;
                    }
                    else
                    {
                        G = System.Convert.ToInt32(G * factor);
                        if (G < 0) G = 0;
                    }

                    
                    //B
                    int B = (int)pixel.B;
                    if (more)
                    {
                        B = System.Convert.ToInt32(B * factor);
                        if (B > 255) B = 255;
                    }
                    else
                    {
                        B = System.Convert.ToInt32(B * factor);
                        if (B < 0) B = 0;
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
            for (int j = 0; j < trImage.Height; j++)
            {
                for (int i = 0; i < trImage.Width; i++)
                {
                    var pixel = Image.GetPixel(i, j);
                    //A
                    int A = (int)pixel.A;

                    //R
                    int R = (int)pixel.R;
                    if (more)
                    {
                        R = (R*100 - 128*contrast)/(100-contrast);
                        if (R > 255) R = 255;
                        if (R < 0) R = 0;
                    }
                    else
                    {
                        R = (R*(100-contrast)+128*contrast)/100;
                        if (R > 255) R = 255;
                        if (R < 0) R = 0;
                    }

                    //G
                    int G = (int)pixel.G;
                    if (more)
                    {
                        G = (G * 100 - 128 * contrast) / (100 - contrast);
                        if (G > 255) G = 255;
                        if (G < 0) G = 0;
                    }
                    else
                    {
                        G = (G * (100 - contrast) + 128 * contrast) / 100;
                        if (G > 255) G = 255;
                        if (G < 0) G = 0;
                    }

                    //B
                    int B = (int)pixel.B;
                    if (more)
                    {
                        B = (B * 100 - 128 * contrast) / (100 - contrast);
                        if (B > 255) B = 255;
                        if (B < 0) B = 0;
                    }
                    else
                    {
                        B = (B * (100 - contrast) + 128 * contrast) / 100;
                        if (B > 255) B = 255;
                        if (B < 0) B = 0;
                    }
                    trImage.SetPixel(i, j, Color.FromArgb(A, R, G, B));
                }
            }
            Image = trImage;
            return;
        }

        public static void leftRotation(ref Bitmap Image)
        {
            int newHeight = Image.Width;
            int newWidth = Image.Height;
            Color[,] initialPixels = new Color[Image.Width, Image.Height];

            for (int j=0; j<Image.Height; j++){
                for (int i=0; i<Image.Width; i++){
                    initialPixels[i,j] = Image.GetPixel(i,j);
                }
            }
            
            Bitmap trImage = new Bitmap(newWidth, newHeight);
            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    trImage.SetPixel(i, j, initialPixels[Image.Width - j - 1, i]);
                }
            }
            Image = trImage;
            return;
        }

        public static void rightRotation(ref Bitmap Image)
        {
            int newHeight = Image.Width;
            int newWidth = Image.Height;
            Color[,] initialPixels = new Color[Image.Width, Image.Height];

            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    initialPixels[i, j] = Image.GetPixel(i, j);
                }
            }

            Bitmap trImage = new Bitmap(newWidth, newHeight);
            for (int i = 0; i < newWidth; i++)
            {
                for (int j = 0; j < newHeight; j++)
                {
                    trImage.SetPixel(i, j, initialPixels[j, Image.Height - i - 1]);
                }
            }
            Image = trImage;
            return;
        }

        public static void verticalReflection(ref Bitmap Image)
        {
            Color[,] initialPixels = new Color[Image.Width, Image.Height];

            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    initialPixels[i, j] = Image.GetPixel(i, j);
                }
            }

            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    Image.SetPixel(i, j, initialPixels[i, Image.Height - j - 1]);
                }
            }
            return;
        }

        public static void horizontalReflection(ref Bitmap Image)
        {
            Color[,] initialPixels = new Color[Image.Width, Image.Height];

            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    initialPixels[i, j] = Image.GetPixel(i, j);
                }
            }

            for (int j = 0; j < Image.Height; j++)
            {
                for (int i = 0; i < Image.Width; i++)
                {
                    Image.SetPixel(i, j, initialPixels[Image.Width - i - 1, j]);
                }
            }
            return;
        }


    }
}
