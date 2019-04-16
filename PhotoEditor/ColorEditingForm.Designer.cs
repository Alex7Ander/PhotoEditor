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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorEditingForm));
            this.transparancyTrackBar = new System.Windows.Forms.TrackBar();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.contrastTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.brightnessNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.contrastTextBox = new System.Windows.Forms.TextBox();
            this.transperencyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leftRotationButton = new System.Windows.Forms.Button();
            this.rightRotationButton = new System.Windows.Forms.Button();
            this.verticalReflButton = new System.Windows.Forms.Button();
            this.horizontalReflButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transparancyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // transparancyTrackBar
            // 
            this.transparancyTrackBar.Location = new System.Drawing.Point(12, 165);
            this.transparancyTrackBar.Maximum = 255;
            this.transparancyTrackBar.Name = "transparancyTrackBar";
            this.transparancyTrackBar.Size = new System.Drawing.Size(871, 45);
            this.transparancyTrackBar.TabIndex = 0;
            this.transparancyTrackBar.Scroll += new System.EventHandler(this.transparancyTrackBar_Scroll);
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(12, 31);
            this.brightnessTrackBar.Maximum = 100;
            this.brightnessTrackBar.Minimum = -100;
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(871, 45);
            this.brightnessTrackBar.TabIndex = 2;
            this.brightnessTrackBar.Scroll += new System.EventHandler(this.brightnessTrackBar_Scroll);
            // 
            // contrastTrackBar
            // 
            this.contrastTrackBar.Location = new System.Drawing.Point(12, 104);
            this.contrastTrackBar.Maximum = 100;
            this.contrastTrackBar.Minimum = -100;
            this.contrastTrackBar.Name = "contrastTrackBar";
            this.contrastTrackBar.Size = new System.Drawing.Size(871, 45);
            this.contrastTrackBar.TabIndex = 3;
            this.contrastTrackBar.Scroll += new System.EventHandler(this.contrastTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 140);
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
            this.brightnessNameLabel.Location = new System.Drawing.Point(12, 9);
            this.brightnessNameLabel.Name = "brightnessNameLabel";
            this.brightnessNameLabel.Size = new System.Drawing.Size(62, 19);
            this.brightnessNameLabel.TabIndex = 6;
            this.brightnessNameLabel.Text = "Яркость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Контраст";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(122, 8);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(100, 20);
            this.brightnessTextBox.TabIndex = 12;
            this.brightnessTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.brightnessTextBox_KeyDown);
            // 
            // contrastTextBox
            // 
            this.contrastTextBox.Location = new System.Drawing.Point(122, 78);
            this.contrastTextBox.Name = "contrastTextBox";
            this.contrastTextBox.Size = new System.Drawing.Size(100, 20);
            this.contrastTextBox.TabIndex = 13;
            this.contrastTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contrastTextBox_KeyDown);
            // 
            // transperencyTextBox
            // 
            this.transperencyTextBox.Location = new System.Drawing.Point(122, 139);
            this.transperencyTextBox.Name = "transperencyTextBox";
            this.transperencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.transperencyTextBox.TabIndex = 14;
            this.transperencyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.transperencyTextBox_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(16, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 73);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bwButton_Click);
            // 
            // leftRotationButton
            // 
            this.leftRotationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftRotationButton.BackgroundImage")));
            this.leftRotationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leftRotationButton.Location = new System.Drawing.Point(114, 209);
            this.leftRotationButton.Name = "leftRotationButton";
            this.leftRotationButton.Size = new System.Drawing.Size(83, 73);
            this.leftRotationButton.TabIndex = 16;
            this.leftRotationButton.UseVisualStyleBackColor = true;
            this.leftRotationButton.Click += new System.EventHandler(this.leftRotationButton_Click);
            // 
            // rightRotationButton
            // 
            this.rightRotationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightRotationButton.BackgroundImage")));
            this.rightRotationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightRotationButton.Location = new System.Drawing.Point(203, 209);
            this.rightRotationButton.Name = "rightRotationButton";
            this.rightRotationButton.Size = new System.Drawing.Size(81, 73);
            this.rightRotationButton.TabIndex = 17;
            this.rightRotationButton.UseVisualStyleBackColor = true;
            this.rightRotationButton.Click += new System.EventHandler(this.rightRotationButton_Click);
            // 
            // verticalReflButton
            // 
            this.verticalReflButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalReflButton.BackgroundImage")));
            this.verticalReflButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.verticalReflButton.Location = new System.Drawing.Point(313, 209);
            this.verticalReflButton.Name = "verticalReflButton";
            this.verticalReflButton.Size = new System.Drawing.Size(80, 73);
            this.verticalReflButton.TabIndex = 18;
            this.verticalReflButton.UseVisualStyleBackColor = true;
            this.verticalReflButton.Click += new System.EventHandler(this.verticalReflButton_Click);
            // 
            // horizontalReflButton
            // 
            this.horizontalReflButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("horizontalReflButton.BackgroundImage")));
            this.horizontalReflButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.horizontalReflButton.Location = new System.Drawing.Point(399, 209);
            this.horizontalReflButton.Name = "horizontalReflButton";
            this.horizontalReflButton.Size = new System.Drawing.Size(79, 73);
            this.horizontalReflButton.TabIndex = 19;
            this.horizontalReflButton.UseVisualStyleBackColor = true;
            this.horizontalReflButton.Click += new System.EventHandler(this.horizontalReflButton_Click);
            // 
            // ColorEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 289);
            this.Controls.Add(this.horizontalReflButton);
            this.Controls.Add(this.verticalReflButton);
            this.Controls.Add(this.rightRotationButton);
            this.Controls.Add(this.leftRotationButton);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button leftRotationButton;
        private System.Windows.Forms.Button rightRotationButton;
        private System.Windows.Forms.Button verticalReflButton;
        private System.Windows.Forms.Button horizontalReflButton;
    }
}