namespace DIPActivityPart2
{
    partial class Form1
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
            this.image = new System.Windows.Forms.PictureBox();
            this.final = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.imageBtn = new System.Windows.Forms.Button();
            this.backgroundBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.subtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(27, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(352, 240);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(572, 153);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(352, 240);
            this.final.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.final.TabIndex = 1;
            this.final.TabStop = false;
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(27, 300);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(352, 240);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 2;
            this.background.TabStop = false;
            // 
            // imageBtn
            // 
            this.imageBtn.Location = new System.Drawing.Point(422, 95);
            this.imageBtn.Name = "imageBtn";
            this.imageBtn.Size = new System.Drawing.Size(112, 33);
            this.imageBtn.TabIndex = 3;
            this.imageBtn.Text = "Load Image";
            this.imageBtn.UseVisualStyleBackColor = true;
            this.imageBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundBtn
            // 
            this.backgroundBtn.Location = new System.Drawing.Point(422, 412);
            this.backgroundBtn.Name = "backgroundBtn";
            this.backgroundBtn.Size = new System.Drawing.Size(165, 33);
            this.backgroundBtn.TabIndex = 4;
            this.backgroundBtn.Text = "Load BackGround";
            this.backgroundBtn.UseVisualStyleBackColor = true;
            this.backgroundBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openImage";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openBackground";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(944, 251);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(112, 33);
            this.subtract.TabIndex = 5;
            this.subtract.Text = "Subtract";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.backgroundBtn);
            this.Controls.Add(this.imageBtn);
            this.Controls.Add(this.background);
            this.Controls.Add(this.final);
            this.Controls.Add(this.image);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.PictureBox final;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Button imageBtn;
        private System.Windows.Forms.Button backgroundBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Label label1;
    }
}

