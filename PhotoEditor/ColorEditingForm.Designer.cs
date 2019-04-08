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
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // transparancyTrackBar
            // 
            this.transparancyTrackBar.Location = new System.Drawing.Point(25, 12);
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
            this.transparancyLabel.Location = new System.Drawing.Point(22, 417);
            this.transparancyLabel.Name = "transparancyLabel";
            this.transparancyLabel.Size = new System.Drawing.Size(33, 19);
            this.transparancyLabel.TabIndex = 1;
            this.transparancyLabel.Text = "___";
            // 
            // ColorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transparancyLabel);
            this.Controls.Add(this.transparancyTrackBar);
            this.Name = "ColorEditingForm";
            this.Text = "ColorEditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar transparancyTrackBar;
        private System.Windows.Forms.Label transparancyLabel;
    }
}