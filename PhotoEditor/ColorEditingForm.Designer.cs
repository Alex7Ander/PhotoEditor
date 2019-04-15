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
            this.transparancyLabel = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.brightnessValueLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.contrastValueLabel = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // transparancyTrackBar
            // 
            this.transparancyTrackBar.Location = new System.Drawing.Point(16, 31);
            this.transparancyTrackBar.Maximum = 100;
            this.transparancyTrackBar.Name = "transparancyTrackBar";
            this.transparancyTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.transparancyTrackBar.Size = new System.Drawing.Size(45, 402);
            this.transparancyTrackBar.TabIndex = 0;
            this.transparancyTrackBar.Scroll += new System.EventHandler(this.transparancyTrackBar_Scroll);
            // 
            // transparancyLabel
            // 
            this.transparancyLabel.AutoSize = true;
            this.transparancyLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transparancyLabel.Location = new System.Drawing.Point(12, 436);
            this.transparancyLabel.Name = "transparancyLabel";
            this.transparancyLabel.Size = new System.Drawing.Size(33, 19);
            this.transparancyLabel.TabIndex = 1;
            this.transparancyLabel.Text = "___";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(134, 31);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.brightnessTrackBar.Size = new System.Drawing.Size(45, 402);
            this.brightnessTrackBar.TabIndex = 2;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(228, 31);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.contrastTrackBar.Size = new System.Drawing.Size(45, 402);
            this.contrastTrackBar.TabIndex = 3;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // blueTrackBar
            // 
            this.blueTrackBar.Location = new System.Drawing.Point(324, 31);
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.blueTrackBar.Size = new System.Drawing.Size(45, 402);
            this.blueTrackBar.TabIndex = 4;
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
            this.brightnessNameLabel.Location = new System.Drawing.Point(130, 9);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(320, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Синий";
            // 
            // brightnessValueLabel
            // 
            this.brightnessValueLabel.AutoSize = true;
            this.brightnessValueLabel.Location = new System.Drawing.Point(131, 442);
            this.brightnessValueLabel.Name = "brightnessValueLabel";
            this.brightnessValueLabel.Size = new System.Drawing.Size(31, 13);
            this.brightnessValueLabel.TabIndex = 9;
            this.brightnessValueLabel.Text = "____";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(321, 442);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(31, 13);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "____";
            // 
            // contrastValueLabel
            // 
            this.contrastValueLabel.AutoSize = true;
            this.contrastValueLabel.Location = new System.Drawing.Point(225, 442);
            this.contrastValueLabel.Name = "contrastValueLabel";
            this.contrastValueLabel.Size = new System.Drawing.Size(31, 13);
            this.contrastValueLabel.TabIndex = 11;
            this.contrastValueLabel.Text = "____";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(92, 458);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.brightnessTextBox.TabIndex = 12;
            this.brightnessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brightnessTextBox_KeyDown);
            // 
            // ColorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 486);
            this.Controls.Add(this.brightnessTextBox);
            this.Controls.Add(this.contrastValueLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.brightnessValueLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brightnessNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.contrastTrackBar);
            this.Controls.Add(this.brightnessTrackBar);
            this.Controls.Add(this.transparancyLabel);
            this.Controls.Add(this.transparancyTrackBar);
            this.Name = "ColorEditingForm";
            this.Text = "ColorEditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar transparancyTrackBar;
        private System.Windows.Forms.Label transparancyLabel;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.TrackBar contrastTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brightnessNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label brightnessValueLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label contrastValueLabel;
        private System.Windows.Forms.TextBox brightnessTextBox;
    }
}