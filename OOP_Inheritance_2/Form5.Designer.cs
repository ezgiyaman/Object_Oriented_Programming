
namespace OOP_Inheritance_2
{
    partial class Form5
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
            this.btnMilky = new System.Windows.Forms.Button();
            this.btnSyrup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMilky
            // 
            this.btnMilky.Location = new System.Drawing.Point(153, 136);
            this.btnMilky.Name = "btnMilky";
            this.btnMilky.Size = new System.Drawing.Size(136, 66);
            this.btnMilky.TabIndex = 0;
            this.btnMilky.Text = "Milky Dessert";
            this.btnMilky.UseVisualStyleBackColor = true;
            this.btnMilky.Click += new System.EventHandler(this.btnMilky_Click);
            // 
            // btnSyrup
            // 
            this.btnSyrup.Location = new System.Drawing.Point(417, 136);
            this.btnSyrup.Name = "btnSyrup";
            this.btnSyrup.Size = new System.Drawing.Size(126, 66);
            this.btnSyrup.TabIndex = 1;
            this.btnSyrup.Text = "Syrup Dessert";
            this.btnSyrup.UseVisualStyleBackColor = true;
            this.btnSyrup.Click += new System.EventHandler(this.btnSyrup_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSyrup);
            this.Controls.Add(this.btnMilky);
            this.Name = "Form5";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMilky;
        private System.Windows.Forms.Button btnSyrup;
    }
}

