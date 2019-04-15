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
        private void editBrigtness(int percentValue)
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
            return;
        }

        public ColorEditingForm()
        {
            InitializeComponent();
            
            transparancyLabel.Text = transparancyTrackBar.Value.ToString();
            contrastValueLabel.Text = contrastTrackBar.Value.ToString();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        }

        public int getTrancparancyPosition()
        {
            return this.transparancyTrackBar.Value;
        }
//Прозрачность
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
//Яркость
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = this.brightnessTrackBar.Value;
            brightnessValueLabel.Text = position.ToString();
            brightnessTextBox.Text = position.ToString();
            editBrigtness(position);    
        }
//ручной ввод яркости
        private void brightnessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            sbyte position;
            try
            {
                position = System.Convert.ToSByte(brightnessTextBox.Text);
                if (position > 100 || position < -100)
                {
                    MessageBox.Show("Ошибка", "Введенное вами число должно быть в диапазоне от -100 до 100", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error, 
                                    MessageBoxDefaultButton.Button1, 
                                    MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    brightnessTrackBar.Value = position;
                    editBrigtness(position);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка", "Введенное вами значение не является действительным числом",                         
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error, 
                            MessageBoxDefaultButton.Button1, 
                            MessageBoxOptions.ServiceNotification);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Ошибка", "Введенное вами число должно быть в диапазоне от -100 до 100", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error, 
                            MessageBoxDefaultButton.Button1, 
                            MessageBoxOptions.ServiceNotification);
            }
        }
//Контраст
        private void contrastTrackBar_Scroll(object sender, EventArgs e)
        {
            int position = this.contrastTrackBar.Value;
            contrastValueLabel.Text = position.ToString();
            Bitmap editedBM = new Bitmap(Info.newPhoto.Photo);
            int dContrast = position - Info.prevContrast;
            if (dContrast > 0) Painter.changeContrast(ref editedBM, dContrast, true);
            else Painter.changeContrast(ref editedBM, dContrast, false);
            Info.newPhoto.Photo = editedBM;
            Program.MainForm.newPhotoForm.setPhoto(Info.newPhoto.Photo);
            Info.prevContrast = position;
        }


    }
}
