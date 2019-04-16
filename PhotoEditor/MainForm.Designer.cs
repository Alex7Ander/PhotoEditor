namespace PhotoEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorEditionButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addEditionButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.newPictureButton = new System.Windows.Forms.Button();
            this.originPictureButton = new System.Windows.Forms.Button();
            this.HeadGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadGroupBox
            // 
            this.HeadGroupBox.Controls.Add(this.exitButton);
            this.HeadGroupBox.Controls.Add(this.colorEditionButton);
            this.HeadGroupBox.Controls.Add(this.removeButton);
            this.HeadGroupBox.Controls.Add(this.backButton);
            this.HeadGroupBox.Controls.Add(this.addEditionButton);
            this.HeadGroupBox.Controls.Add(this.saveButton);
            this.HeadGroupBox.Controls.Add(this.openButton);
            this.HeadGroupBox.Controls.Add(this.newPictureButton);
            this.HeadGroupBox.Controls.Add(this.originPictureButton);
            this.HeadGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadGroupBox.Location = new System.Drawing.Point(1, 1);
            this.HeadGroupBox.Name = "HeadGroupBox";
            this.HeadGroupBox.Size = new System.Drawing.Size(774, 100);
            this.HeadGroupBox.TabIndex = 0;
            this.HeadGroupBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Location = new System.Drawing.Point(688, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 71);
            this.exitButton.TabIndex = 9;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // colorEditionButton
            // 
            this.colorEditionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colorEditionButton.BackgroundImage")));
            this.colorEditionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorEditionButton.Location = new System.Drawing.Point(593, 19);
            this.colorEditionButton.Name = "colorEditionButton";
            this.colorEditionButton.Size = new System.Drawing.Size(75, 71);
            this.colorEditionButton.TabIndex = 7;
            this.colorEditionButton.UseVisualStyleBackColor = true;
            this.colorEditionButton.Click += new System.EventHandler(this.colorEditionButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeButton.BackgroundImage")));
            this.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.removeButton.Location = new System.Drawing.Point(335, 19);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 71);
            this.removeButton.TabIndex = 6;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(254, 19);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 71);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addEditionButton
            // 
            this.addEditionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEditionButton.BackgroundImage")));
            this.addEditionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addEditionButton.Location = new System.Drawing.Point(173, 19);
            this.addEditionButton.Name = "addEditionButton";
            this.addEditionButton.Size = new System.Drawing.Size(75, 71);
            this.addEditionButton.TabIndex = 4;
            this.addEditionButton.UseVisualStyleBackColor = true;
            this.addEditionButton.Click += new System.EventHandler(this.addEditionButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveButton.Location = new System.Drawing.Point(92, 19);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 71);
            this.saveButton.TabIndex = 3;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openButton.BackgroundImage")));
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.openButton.Location = new System.Drawing.Point(11, 19);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 71);
            this.openButton.TabIndex = 2;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // newPictureButton
            // 
            this.newPictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPictureButton.BackgroundImage")));
            this.newPictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newPictureButton.Location = new System.Drawing.Point(512, 19);
            this.newPictureButton.Name = "newPictureButton";
            this.newPictureButton.Size = new System.Drawing.Size(75, 71);
            this.newPictureButton.TabIndex = 1;
            this.newPictureButton.UseVisualStyleBackColor = true;
            this.newPictureButton.Click += new System.EventHandler(this.newPictureButton_Click);
            // 
            // originPictureButton
            // 
            this.originPictureButton.BackColor = System.Drawing.SystemColors.Control;
            this.originPictureButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("originPictureButton.BackgroundImage")));
            this.originPictureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.originPictureButton.Location = new System.Drawing.Point(431, 19);
            this.originPictureButton.Name = "originPictureButton";
            this.originPictureButton.Size = new System.Drawing.Size(75, 71);
            this.originPictureButton.TabIndex = 0;
            this.originPictureButton.UseVisualStyleBackColor = false;
            this.originPictureButton.Click += new System.EventHandler(this.originPictureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 103);
            this.Controls.Add(this.HeadGroupBox);
            this.Name = "MainForm";
            this.Text = "Photo editor";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.HeadGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HeadGroupBox;
        private System.Windows.Forms.Button newPictureButton;
        private System.Windows.Forms.Button originPictureButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addEditionButton;
        private System.Windows.Forms.Button colorEditionButton;
        private System.Windows.Forms.Button exitButton;
    }
}

