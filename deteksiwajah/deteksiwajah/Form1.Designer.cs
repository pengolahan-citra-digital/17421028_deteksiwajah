namespace deteksiwajah
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
            this.components = new System.ComponentModel.Container();
            this.matrixBox1 = new Emgu.CV.UI.MatrixBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btn_kamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixBox1
            // 
            this.matrixBox1.Location = new System.Drawing.Point(132, 164);
            this.matrixBox1.Matrix = null;
            this.matrixBox1.Name = "matrixBox1";
            this.matrixBox1.Size = new System.Drawing.Size(10, 8);
            this.matrixBox1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(22, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(232, 217);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btn_kamera
            // 
            this.btn_kamera.Location = new System.Drawing.Point(154, 236);
            this.btn_kamera.Name = "btn_kamera";
            this.btn_kamera.Size = new System.Drawing.Size(99, 23);
            this.btn_kamera.TabIndex = 3;
            this.btn_kamera.Text = "buka kamera";
            this.btn_kamera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_kamera);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.matrixBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.MatrixBox matrixBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_kamera;
    }
}

