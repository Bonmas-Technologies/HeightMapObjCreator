namespace HeightMapObjCreator
{
    partial class Form1
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
            this.loadbutton = new System.Windows.Forms.Button();
            this.viewer = new System.Windows.Forms.PictureBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.fileOpener = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(12, 218);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(200, 37);
            this.loadbutton.TabIndex = 0;
            this.loadbutton.Text = "Open HeightMap";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.LoadImage);
            // 
            // viewer
            // 
            this.viewer.Location = new System.Drawing.Point(12, 12);
            this.viewer.Name = "viewer";
            this.viewer.Size = new System.Drawing.Size(200, 200);
            this.viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewer.TabIndex = 1;
            this.viewer.TabStop = false;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(12, 261);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(200, 37);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "Save OBJ file";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.GetAndSaveObj);
            // 
            // fileOpener
            // 
            this.fileOpener.FileName = "your image";
            this.fileOpener.Filter = "images|*.png;*.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Graysale image required";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.viewer);
            this.Controls.Add(this.loadbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HM2OBJ";
            ((System.ComponentModel.ISupportInitialize)(this.viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.PictureBox viewer;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.OpenFileDialog fileOpener;
        private System.Windows.Forms.Label label1;
    }
}

