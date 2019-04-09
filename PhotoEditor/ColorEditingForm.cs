using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class ColorEditingForm : Form
    {
        public delegate void onTransparancyChanging();
        public onTransparancyChanging tCh;

        public ColorEditingForm()
        {
            InitializeComponent();
            transparancyLabel.Text = transparancyTrackBar.Value.ToString();
            var pixel = Info.newPhoto.Photo.GetPixel(0, 0);

            transparancyTrackBar.Maximum = 255;
            redTrackBar.Maximum = 255;
            greenTrackBar.Maximum = 255;
            blueTrackBar.Maximum = 255;

            transparancyTrackBar.Value = pixel.A;
            redTrackBar.Value = pixel.R;
            greenTrackBar.Value = pixel.G;
            blueTrackBar.Value = pixel.B;

            transparancyLabel.Text = transparancyTrackBar.Value.ToString();
            redLabel.Text = redTrackBar.Value.ToString();
            blueLabel.Text = blueTrackBar.Value.ToString();
            greenLabel.Text = greenTrackBar.Value.ToString();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        }

        public int getTrancparancyPosition()
        {
            return this.transparancyTrackBar.Value;
        }

        private void transparancyTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = transparancyTrackBar.Value;
            transparancyLabel.Text = position.ToString();
            Info.transparancy = transparancyTrackBar.Value; 
            Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
            Painter.changeTransparancy(ref editedBM, position);
            Info.newPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.newPhoto.Photo);
        }

    }
}
