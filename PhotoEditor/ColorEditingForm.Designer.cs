namespace PhotoEditor
{
    partial class ColorEditingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.transparancyTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.transperencyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // transparancyTrackBar
            // 
            this.transparancyTrackBar.Location = new System.Drawing.Point(16, 57);
            this.transparancyTrackBar.Maximum = 255;
            this.transparancyTrackBar.Name = "transparancyTrackBar";
            this.transparancyTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.transparancyTrackBar.Size = new System.Drawing.Size(45, 426);
            this.transparancyTrackBar.TabIndex = 0;
            this.transparancyTrackBar.Scroll += new System.EventHandler(this.transparancyTrackBar_Scroll);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(122, 57);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.brightnessTrackBar.Size = new System.Drawing.Size(45, 426);
            this.brightnessTrackBar.TabIndex = 2;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(228, 57);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.contrastTrackBar.Size = new System.Drawing.Size(45, 426);
            this.contrastTrackBar.TabIndex = 3;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Прозрачность";
            // 
            // brightnessNameLabel
            // 
            this.brightnessNameLabel.AutoSize = true;
            this.brightnessNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brightnessNameLabel.Location = new System.Drawing.Point(122, 9);
            this.brightnessNameLabel.Name = "brightnessNameLabel";
            this.brightnessNameLabel.Size = new System.Drawing.Size(62, 19);
            this.brightnessNameLabel.TabIndex = 6;
            this.brightnessNameLabel.Text = "Яркость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Контраст";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(122, 31);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.brightnessTextBox.TabIndex = 12;
            this.brightnessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brightnessTextBox_KeyDown);
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.Location = new System.Drawing.Point(228, 31);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.contrastTextBox.TabIndex = 13;
            // 
            // transperencyTextBox
            // 
            this.transperencyTextBox.Location = new System.Drawing.Point(16, 31);
            this.transperencyTextBox.Name = "transperencyTextBox";
            this.transperencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.transperencyTextBox.TabIndex = 14;
            this.transperencyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transperencyTextBox_KeyDown);
            // 
            // ColorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 486);
            this.Controls.Add(this.transperencyTextBox);
            this.Controls.Add(this.contrastTextBox);
            this.Controls.Add(this.brightnessTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brightnessNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.transparancyTrackBar);
            this.Name = "ColorEditingForm";
            this.Text = "ColorEditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar transparancyTrackBar;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brightnessNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.TextBox contrastTextBox;
        private System.Windows.Forms.TextBox transperencyTextBox;
    }
}