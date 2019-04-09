using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoEditor
{
    public struct photo
    {
        public Bitmap Photo { get; set; }
        public string photoPath { get; set; }
    }


    public static class Info
    {
        public static photo originalPhoto;
        public static photo newPhoto;
        public static bool originalPhotoFormIsShown;
        public static bool newphotoFormIsShown;
        public static bool colorEditingFormIsShown;

        public static int transparancy;

        static Info()
        {
            originalPhotoFormIsShown = false;
            newphotoFormIsShown = false;
        }

    }
}
