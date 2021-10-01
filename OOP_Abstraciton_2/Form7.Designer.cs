
namespace OOP_Abstraciton_2
{
    partial class Form7
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
            this.btnDrum = new System.Windows.Forms.Button();
            this.btnPiano = new System.Windows.Forms.Button();
            this.btnFlute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrum
            // 
            this.btnDrum.Location = new System.Drawing.Point(173, 75);
            this.btnDrum.Name = "btnDrum";
            this.btnDrum.Size = new System.Drawing.Size(159, 68);
            this.btnDrum.TabIndex = 0;
            this.btnDrum.Text = "Play the Drum";
            this.btnDrum.UseVisualStyleBackColor = true;
            this.btnDrum.Click += new System.EventHandler(this.btnDrum_Click);
            // 
            // btnPiano
            // 
            this.btnPiano.Location = new System.Drawing.Point(411, 75);
            this.btnPiano.Name = "btnPiano";
            this.btnPiano.Size = new System.Drawing.Size(151, 68);
            this.btnPiano.TabIndex = 1;
            this.btnPiano.Text = "Play the Piano";
            this.btnPiano.UseVisualStyleBackColor = true;
            this.btnPiano.Click += new System.EventHandler(this.btnPiano_Click);
            // 
            // btnFlute
            // 
            this.btnFlute.Location = new System.Drawing.Point(289, 191);
            this.btnFlute.Name = "btnFlute";
            this.btnFlute.Size = new System.Drawing.Size(159, 63);
            this.btnFlute.TabIndex = 2;
            this.btnFlute.Text = "Play the Flute";
            this.btnFlute.UseVisualStyleBackColor = true;
            this.btnFlute.Click += new System.EventHandler(this.btnFlute_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFlute);
            this.Controls.Add(this.btnPiano);
            this.Controls.Add(this.btnDrum);
            this.Name = "Form7";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrum;
        private System.Windows.Forms.Button btnPiano;
        private System.Windows.Forms.Button btnFlute;
    }
}

