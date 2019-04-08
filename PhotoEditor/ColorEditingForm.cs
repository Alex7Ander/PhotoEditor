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
        }

        public int getTrancparancyPosition()
        {
            return this.transparancyTrackBar.Value;
        }

        private void transparancyTrackBar_Scroll(object sender, EventArgs e)
        {
            //int position = transparancyTrackBar.Value;
            Info.transparancy = transparancyTrackBar.Value;
            onTransparancyChanging tCh;
            
        }
    }
}
