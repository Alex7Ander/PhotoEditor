using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    public class Painter
    {
        public delegate Bitmap ParametrNewState(int value);
        ParametrNewState parametrChanging;

        public void regParametrNewState(ParametrNewState newState)
        {
            parametrChanging = newState;
        }

        private Bitmap Image;

        public Painter(ref Bitmap anyImage)
        {
            this.Image = anyImage;
        }

        public Painter(ref photo anyPhoto)
        {
            this.Image = anyPhoto.Photo;
        }

        public Bitmap transformColorToBW()
        {
            Bitmap trImage = new Bitmap(this.Image.Width, this.Image.Height);
            for (int j = 0; j < trImage.Height; j++)
            {
                for (int i = 0; i < trImage.Width; i++)
                {
                    var pixel = this.Image.GetPixel(i, j); // получаем (i, j) пиксель
                    int R = (int)pixel.R;
                    int G = (int)pixel.G; // зеленый
                    int B = (int)pixel.B; // синий
                    int average = (R + G + B) / 3;
                    trImage.SetPixel(i, j, Color.FromArgb(average, average, average));
                }
            }
            this.Image = trImage;
            return trImage;
        }

        public Bitmap changeTransparancy(int transparancyValue)
        {
            Bitmap trImage = new Bitmap(this.Image.Width, this.Image.Height);
            for (int j = 0; j < trImage.Height; j++)
            {
                for (int i = 0; i < trImage.Width; i++)
                {
                    var pixel = this.Image.GetPixel(i, j); // получаем (i, j) пиксель
                    int R = (int)pixel.R;
                    int G = (int)pixel.G; // зеленый
                    int B = (int)pixel.B; // синий
                    int A = (int)pixel.A;
                    A = A + transparancyValue * 128 / 100;
                    trImage.SetPixel(i, j, Color.FromArgb(transparancyValue, R, G, B));
                }
            }
            this.Image = trImage;
            return trImage;
        }
    }
}
