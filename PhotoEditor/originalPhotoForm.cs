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
    public partial class originalPhotoForm : Form
    {
        public originalPhotoForm()
        {
            InitializeComponent();
            Bind();
        }

        private void originalPhotoForm_Load(object sender, EventArgs e)
        {

        }

        private void Bind()
        {
            Binding originalPhotoBinding = new Binding("Image", Info.originalPhoto, "Photo", true);
            this.pictureBox1.DataBindings.Add(originalPhotoBinding);
        }

        private void originalPhotoForm_Shown(object sender, EventArgs e)
        {
            Resizer resizer = new Resizer();
            var width = resizer.getSizeX(Info.newPhoto.Photo.Width, 1);
            var height = resizer.getSizeY(Info.newPhoto.Photo.Height, 1);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.Width = width + 25;
            this.Height = height + 50;
            //this.setPictureBoxSize(width, height);
        }
    }
}
