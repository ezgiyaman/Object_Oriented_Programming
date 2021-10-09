
namespace Bank_InterestRate_StaticMethod
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
            this.btnAkbank = new System.Windows.Forms.Button();
            this.btnIsbank = new System.Windows.Forms.Button();
            this.btnFinansbank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAkbank
            // 
            this.btnAkbank.Location = new System.Drawing.Point(123, 84);
            this.btnAkbank.Name = "btnAkbank";
            this.btnAkbank.Size = new System.Drawing.Size(170, 83);
            this.btnAkbank.TabIndex = 0;
            this.btnAkbank.Text = "Akbank ";
            this.btnAkbank.UseVisualStyleBackColor = true;
            this.btnAkbank.Click += new System.EventHandler(this.btnAkbank_Click);
            // 
            // btnIsbank
            // 
            this.btnIsbank.Location = new System.Drawing.Point(123, 193);
            this.btnIsbank.Name = "btnIsbank";
            this.btnIsbank.Size = new System.Drawing.Size(170, 83);
            this.btnIsbank.TabIndex = 1;
            this.btnIsbank.Text = "Isbank";
            this.btnIsbank.UseVisualStyleBackColor = true;
            this.btnIsbank.Click += new System.EventHandler(this.btnIsbank_Click);
            // 
            // btnFinansbank
            // 
            this.btnFinansbank.Location = new System.Drawing.Point(123, 305);
            this.btnFinansbank.Name = "btnFinansbank";
            this.btnFinansbank.Size = new System.Drawing.Size(170, 84);
            this.btnFinansbank.TabIndex = 2;
            this.btnFinansbank.Text = "Finansbank";
            this.btnFinansbank.UseVisualStyleBackColor = true;
            this.btnFinansbank.Click += new System.EventHandler(this.btnFinansbank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinansbank);
            this.Controls.Add(this.btnIsbank);
            this.Controls.Add(this.btnAkbank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAkbank;
        private System.Windows.Forms.Button btnIsbank;
        private System.Windows.Forms.Button btnFinansbank;
    }
}

