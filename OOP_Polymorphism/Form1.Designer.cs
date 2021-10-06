
namespace OOP_Polymorphism
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
            this.btnCatSound = new System.Windows.Forms.Button();
            this.btnDogSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatSound
            // 
            this.btnCatSound.Location = new System.Drawing.Point(246, 65);
            this.btnCatSound.Name = "btnCatSound";
            this.btnCatSound.Size = new System.Drawing.Size(203, 78);
            this.btnCatSound.TabIndex = 0;
            this.btnCatSound.Text = "Cat";
            this.btnCatSound.UseVisualStyleBackColor = true;
            this.btnCatSound.Click += new System.EventHandler(this.btnCatSound_Click);
            // 
            // btnDogSound
            // 
            this.btnDogSound.Location = new System.Drawing.Point(246, 191);
            this.btnDogSound.Name = "btnDogSound";
            this.btnDogSound.Size = new System.Drawing.Size(203, 87);
            this.btnDogSound.TabIndex = 1;
            this.btnDogSound.Text = "Dog";
            this.btnDogSound.UseVisualStyleBackColor = true;
            this.btnDogSound.Click += new System.EventHandler(this.btnDogSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDogSound);
            this.Controls.Add(this.btnCatSound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatSound;
        private System.Windows.Forms.Button btnDogSound;
    }
}

