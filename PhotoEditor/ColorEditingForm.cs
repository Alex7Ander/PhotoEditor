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
        public ColorEditingForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            var A = Info.editingPhoto.Photo.GetPixel(0, 0).A;
            this.transparancyTrackBar.Value = A;
            this.transperencyTextBox.Text = A.ToString();
            this.brightnessTextBox.Text = Info.prevBrightness.ToString();
            this.contrastTextBox.Text = Info.prevContrast.ToString();
        }
        //************************************************
        private void errorMessage(string msg)
        {
            MessageBox.Show("Ошибка", msg, MessageBoxButtons.OK, MessageBoxIcon.Error, 
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        //************************************************
        private void editTransperency(int percentValue)
        {
            Info.transparancy = transparancyTrackBar.Value;
            Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
            Painter.changeTransparancy(ref editedBM, percentValue);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(editedBM);            
            return;
        }
        //************************************************
        private void editBrightness(int percentValue)
        {
            if (percentValue != 0)
            {
                Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
                if (percentValue > 0)
                    Painter.changeBrightness(ref editedBM, percentValue, true);
                else
                    Painter.changeBrightness(ref editedBM, percentValue * (-1), false);

                Info.editingPhoto.Photo = editedBM;
                Program.MainForm.newPhotoForm.setPhoto(editedBM);
            }
            else
            {
                Info.editingPhoto = Info.newPhoto;
                Program.MainForm.newPhotoForm.setPhoto(Info.newPhoto.Photo);
            }
            Info.prevBrightness = percentValue;
            return;
        }
        //************************************************
        private void editContrast(int percentValue)
        {
            if (percentValue != 0)
            {
                Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
                if (percentValue > 0)
                    Painter.changeContrast(ref editedBM, percentValue, true);
                else
                    Painter.changeContrast(ref editedBM, percentValue * (-1), false);

                Info.editingPhoto.Photo = editedBM;
                Program.MainForm.newPhotoForm.setPhoto(editedBM);
            }
            else
            {
                Info.editingPhoto = Info.newPhoto;
                Program.MainForm.newPhotoForm.setPhoto(Info.newPhoto.Photo);
            }
            Info.prevContrast = percentValue;
            return;
        }
        //************************************************
        public int getTrancparancyPosition()
        {            
            return this.transparancyTrackBar.Value;
        }
//Прозрачность
        private void transparancyTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = transparancyTrackBar.Value;
            transperencyTextBox.Text = position.ToString();
            editTransperency(position);
        }
//ручной ввод прозрачности
        private void transperencyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            byte position;
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    position = System.Convert.ToByte(transperencyTextBox.Text);
                    this.transparancyTrackBar.Value = position;
                    editTransperency(position);
                }
                catch (FormatException)
                {
                    errorMessage("Введенное вами значение не является действительным числом");
                }
                catch (OverflowException)
                {
                    errorMessage("Введенное вами число должно быть в диапазоне от 0 до 255");
                }
            }
        }
//Яркость
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = this.brightnessTrackBar.Value;
            brightnessTextBox.Text = position.ToString();
            editBrightness(position);    
        }
//ручной ввод яркости
        private void brightnessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            sbyte position;
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    position = System.Convert.ToSByte(brightnessTextBox.Text);
                    if (position > 100 || position < -100)
                    {
                        errorMessage("Введенное вами число должно быть в диапазоне от -100 до 100");
                    }
                    else
                    {
                        brightnessTrackBar.Value = position;
                        editBrightness(position);
                    }
                }
                catch (FormatException)
                {
                    errorMessage("Введенное вами значение не является действительным числом");
                }
                catch (OverflowException)
                {
                    errorMessage("Введенное вами число должно быть в диапазоне от -100 до 100");
                }
            }
        }
//Контраст
        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = this.contrastTrackBar.Value;
            contrastTextBox.Text = position.ToString();
            editContrast(position);
        }
//Ручной ввод
        private void contrastTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            sbyte position;
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    position = System.Convert.ToSByte(contrastTextBox.Text);
                    if (position > 100 || position < -100)
                    {
                        errorMessage("Введенное вами число должно быть в диапазоне от -100 до 100");
                    }
                    else
                    {
                        this.contrastTrackBar.Value = position;
                        editContrast(position);
                    }
                }
                catch (FormatException)
                {
                    errorMessage("Введенное вами значение не является действительным числом");
                }
                catch (OverflowException)
                {
                    errorMessage("Введенное вами число должно быть в диапазоне от -100 до 100");
                }
            }
        }
//Черно-белое преобразование
        private void bwButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.editingPhoto.Photo);
            Painter.transformColorToBW(ref editedBM);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }
//Вращения и отображения
        private void leftRotationButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.editingPhoto.Photo);
            Painter.leftRotation(ref editedBM);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }

        private void rightRotationButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.editingPhoto.Photo);
            Painter.rightRotation(ref editedBM);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.editingPhoto.Photo); 
        }

        private void verticalReflButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.editingPhoto.Photo);
            Painter.verticalReflection(ref editedBM);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }

        private void horizontalReflButton_Click(object sender, EventArgs e)
        {
            Bitmap editedBM = new Bitmap(Info.editingPhoto.Photo);
            Painter.horizontalReflection(ref editedBM);
            Info.editingPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.editingPhoto.Photo);
        }

    }
}
