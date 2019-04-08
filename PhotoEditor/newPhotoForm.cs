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
    public partial class newPhotoForm : Form
    {
        private string photoType;

        public newPhotoForm()
        {
            InitializeComponent();
            Bind();
        }

        public newPhotoForm(string type)
        {
            InitializeComponent();
            this.photoType = type;
            Bind();
        }

        public void Bind()
        {
            Binding newPhotoBinding = new Binding("Image", Info.newPhoto, "Photo", true);
            this.pictureBox1.DataBindings.Add(newPhotoBinding);
        }

        public void setPhoto(Bitmap anyPhoto)
        {
            this.pictureBox1.Image = anyPhoto;
        }

        public void setPictureBoxSize(int width, int height)
        {
            this.pictureBox1.Height = height;
            this.pictureBox1.Width = width;
        }

        private void newPhotoForm_Shown(object sender, EventArgs e)
        {
            Resizer resizer = new Resizer();
            var width = resizer.getSizeX(Info.newPhoto.Photo.Width, 20);
            var height = resizer.getSizeY(Info.newPhoto.Photo.Height, 20);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.Width = width+25;
            this.Height = height+50;
            this.setPictureBoxSize(width, height);
        }

        private void newPhotoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.photoType == "new")
                Info.newphotoFormIsShown = false;
            if (this.photoType == "original")
                Info.originalPhotoFormIsShown = false;
        }
    }
}
