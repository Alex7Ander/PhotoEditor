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
    public partial class MainForm : Form
    {
        public newPhotoForm originalPhoto;
        public newPhotoForm newPhoto;
        List<ToolTip> ToolTips; 
        List<Button> buttons; 
        public Painter painter;
        public MainForm()
        {
            InitializeComponent();
            ToolTips = new List<ToolTip>();
            buttons = new List<Button>();
            buttons.Add(openButton);
            buttons.Add(saveButton);
            buttons.Add(addEditionButton);
            buttons.Add(backButton);
            buttons.Add(removeButton);
            buttons.Add(originPictureButton);
            buttons.Add(newPictureButton);
            buttons.Add(bwButton);
            buttons.Add(colorEditionButton);
            buttons.Add(exitButton);
            string[] ToolTipsText = new string[10] {"Открыть","Сохранить", "Добавить изменения", "Отменить", "Отменить все", "Исходное изображение", "Новое изображение", "Сделать ЧБ", "Цветовая коррекция", "Выход" };
            int step = 0;
            foreach (string str in ToolTipsText)
            {
                ToolTip anyToolTip = new ToolTip();
                anyToolTip.SetToolTip(buttons[step], str);
                ToolTips.Add(anyToolTip);
                if (step > 0 && step <9) buttons[step].Enabled = false;
                step++;
            }         
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            var x1 = resolution.Width/2;
            var x2 = this.Width / 2;
            var dx = x1 - x2;
            this.Top = 10;
            this.Left = dx;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string currentPath = openFileDialog1.FileName;
                Info.originalPhoto.photoPath = currentPath;
                Info.originalPhoto.Photo = new Bitmap(currentPath);
                Info.newPhoto.Photo = new Bitmap(currentPath);

                painter = new Painter(ref Info.newPhoto);
                for (int i=0; i<9; i++) buttons[i].Enabled = true;

                if (Info.newphotoFormIsShown == false)
                {
                    newPhoto = new newPhotoForm("new");
                    newPhoto.Text = "Новое фото";
                    newPhoto.Show();
                    Info.newphotoFormIsShown = true;
                }
                newPhoto.setPhoto(Info.newPhoto.Photo);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string currentPath = saveFileDialog1.FileName;
                Info.newPhoto.Photo.Save(currentPath);
                Info.newPhoto.photoPath = currentPath;
            }
        }

        private void originPictureButton_Click(object sender, EventArgs e)
        {
            if (Info.originalPhotoFormIsShown == false)
            {
                originalPhoto = new newPhotoForm("original");
                originalPhoto.Text = "Исходное фото";
                originalPhoto.Show();
                Info.originalPhotoFormIsShown = true;
            }
            else
            {
                originalPhoto.Close();
                Info.originalPhotoFormIsShown = false;
            }
        }

        private void newPictureButton_Click(object sender, EventArgs e)
        {
            if (Info.newphotoFormIsShown == false)
            {
                newPhoto = new newPhotoForm("new");
                newPhoto.Text = "Новое фото";
                newPhoto.Show();
                Info.newphotoFormIsShown = true;
            }
            else
            {
                newPhoto.Close();
                Info.newphotoFormIsShown = false;
            }
        }

        private void bwButton_Click(object sender, EventArgs e)
        {
            Info.newPhoto.Photo = painter.transformColorToBW();
            newPhoto.setPhoto(Info.newPhoto.Photo);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Info.newPhoto.Photo = Info.originalPhoto.Photo;
            newPhoto.setPhoto(Info.newPhoto.Photo);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEditionButton_Click(object sender, EventArgs e)
        {
            //Добавить изменения к сохраненному фото
            if (Info.newPhoto.photoPath == null)
            {
                MessageBox.Show("Новое фото необходимо предварительно сохранить", "Ошибка");
            }
            else
            {
                if (Info.newPhoto.photoPath.Length != 0)
                {
                    String currentPath = Info.newPhoto.photoPath;
                    System.IO.File.Delete(currentPath);
                    Info.newPhoto.Photo.Save(currentPath);
                }
            }
        }
    }
}
