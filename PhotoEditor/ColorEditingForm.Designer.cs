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
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
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
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(134, 31);
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.redTrackBar.Size = new System.Drawing.Size(45, 402);
            this.redTrackBar.TabIndex = 2;
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(228, 31);
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.greenTrackBar.Size = new System.Drawing.Size(45, 402);
            this.greenTrackBar.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Красный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зеленый";
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
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(131, 442);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(31, 13);
            this.redLabel.TabIndex = 9;
            this.redLabel.Text = "____";
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
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(225, 442);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(31, 13);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "____";
            // 
            // ColorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 486);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.transparancyLabel);
            this.Controls.Add(this.transparancyTrackBar);
            this.Name = "ColorEditingForm";
            this.Text = "ColorEditingForm";
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar transparancyTrackBar;
        private System.Windows.Forms.Label transparancyLabel;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
    }
}