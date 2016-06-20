namespace Jpeg2Bitmap
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
            this.tbJpeg = new System.Windows.Forms.TextBox();
            this.jpeg = new System.Windows.Forms.PictureBox();
            this.bitmap = new System.Windows.Forms.PictureBox();
            this.tbBitmap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encode = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jpeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbJpeg
            // 
            this.tbJpeg.Location = new System.Drawing.Point(100, 46);
            this.tbJpeg.Name = "tbJpeg";
            this.tbJpeg.Size = new System.Drawing.Size(277, 20);
            this.tbJpeg.TabIndex = 0;
            // 
            // jpeg
            // 
            this.jpeg.Location = new System.Drawing.Point(100, 72);
            this.jpeg.Name = "jpeg";
            this.jpeg.Size = new System.Drawing.Size(277, 181);
            this.jpeg.TabIndex = 1;
            this.jpeg.TabStop = false;
            // 
            // bitmap
            // 
            this.bitmap.Location = new System.Drawing.Point(100, 324);
            this.bitmap.Name = "bitmap";
            this.bitmap.Size = new System.Drawing.Size(277, 161);
            this.bitmap.TabIndex = 2;
            this.bitmap.TabStop = false;
            // 
            // tbBitmap
            // 
            this.tbBitmap.Location = new System.Drawing.Point(100, 265);
            this.tbBitmap.Name = "tbBitmap";
            this.tbBitmap.Size = new System.Drawing.Size(277, 20);
            this.tbBitmap.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Jpeg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Image (jpeg)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitmap Image";
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(142, 291);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(190, 23);
            this.encode.TabIndex = 8;
            this.encode.Text = "Encode";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(383, 44);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(75, 23);
            this.upload.TabIndex = 9;
            this.upload.Text = "...";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(383, 263);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(75, 23);
            this.output.TabIndex = 10;
            this.output.Text = "...";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 507);
            this.Controls.Add(this.output);
            this.Controls.Add(this.upload);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBitmap);
            this.Controls.Add(this.bitmap);
            this.Controls.Add(this.jpeg);
            this.Controls.Add(this.tbJpeg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jpeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJpeg;
        private System.Windows.Forms.PictureBox jpeg;
        private System.Windows.Forms.PictureBox bitmap;
        private System.Windows.Forms.TextBox tbBitmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.Button output;
    }
}

