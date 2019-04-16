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
        public PhotoForm originalPhotoForm;
        public PhotoForm newPhotoForm;
        public ColorEditingForm colorEditorForm;
        List<ToolTip> ToolTips; 
        List<Button> buttons; 
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
            buttons.Add(colorEditionButton);
            buttons.Add(exitButton);
            string[] ToolTipsText = new string[9] {"Открыть","Сохранить", "Добавить изменения", "Отменить", "Отменить все", "Исходное изображение", "Новое изображение", "Редактирование", "Выход" };
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
                Info.editingPhoto.Photo = new Bitmap(currentPath);

                for (int i=0; i<9; i++) buttons[i].Enabled = true;

                if (Info.newphotoFormIsShown == false)
                {
                    newPhotoForm = new PhotoForm("new");
                    newPhotoForm.Text = "Новое фото";
                    newPhotoForm.Show();
                    Info.newphotoFormIsShown = true;
                }
                newPhotoForm.setPhoto(Info.newPhoto.Photo);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string currentPath = saveFileDialog1.FileName;
                Info.newPhoto = Info.editingPhoto;
                Info.newPhoto.Photo.Save(currentPath);
                Info.newPhoto.photoPath = currentPath;
            }
        }

        private void originPictureButton_Click(object sender, EventArgs e)
        {
            if (Info.originalPhotoFormIsShown)
            {
                originalPhotoForm.Close();
                Info.originalPhotoFormIsShown = false;
            }
            else
            {
                originalPhotoForm = new PhotoForm("original");
                originalPhotoForm.Text = "Исходное фото";
                originalPhotoForm.Show();
                Info.originalPhotoFormIsShown = true;
            }
        }

        private void newPictureButton_Click(object sender, EventArgs e)
        {
            if (Info.newphotoFormIsShown)
            {
                newPhotoForm.Close();
                Info.newphotoFormIsShown = false;
            }
            else
            {
                newPhotoForm = new PhotoForm("new");
                newPhotoForm.Text = "Новое фото";
                newPhotoForm.Show();
                Info.newphotoFormIsShown = true;
            }
        }

        private void colorEditionButton_Click(object sender, EventArgs e)
        {
            if (Info.colorEditingFormIsShown)
            {
                colorEditorForm.Close();
                Info.colorEditingFormIsShown = false;
            }
            else
            {
                colorEditorForm = new ColorEditingForm();
                colorEditorForm.Show();
                Info.colorEditingFormIsShown = true;
            }
        }

        private void bwButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
            Painter.transformColorToBW(ref editedBM);
            Info.newPhoto.Photo = editedBM;
            newPhotoForm.setPhoto(Info.newPhoto.Photo);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Info.newPhoto.Photo = Info.originalPhoto.Photo;
            Info.editingPhoto.Photo = Info.originalPhoto.Photo;
            newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEditionButton_Click(object sender, EventArgs e)
        {
            //Добавить изменения к сохраненному фото
            if (Info.newPhoto.photoPath == null) {
                MessageBox.Show("Новое фото необходимо предварительно сохранить", "Ошибка");
            }
            else{
                if (Info.newPhoto.photoPath.Length != 0) {
                    String currentPath = Info.newPhoto.photoPath;
                    System.IO.File.Delete(currentPath);
                    Info.newPhoto.Photo = Info.editingPhoto.Photo;
                    Info.newPhoto.Photo.Save(currentPath);                    
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Info.editingPhoto.Photo = Info.newPhoto.Photo;
            newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }

    }
}
