
namespace OOP_Constructor
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalySeat = new System.Windows.Forms.TextBox();
            this.txtTotalyPerson = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtBusinessClassPerson = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Totaly Seat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Totaly Person :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Business Class Person :";
            // 
            // txtTotalySeat
            // 
            this.txtTotalySeat.Location = new System.Drawing.Point(361, 74);
            this.txtTotalySeat.Name = "txtTotalySeat";
            this.txtTotalySeat.Size = new System.Drawing.Size(100, 22);
            this.txtTotalySeat.TabIndex = 4;
            // 
            // txtTotalyPerson
            // 
            this.txtTotalyPerson.Location = new System.Drawing.Point(361, 120);
            this.txtTotalyPerson.Name = "txtTotalyPerson";
            this.txtTotalyPerson.Size = new System.Drawing.Size(100, 22);
            this.txtTotalyPerson.TabIndex = 5;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(361, 171);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 6;
            // 
            // txtBusinessClassPerson
            // 
            this.txtBusinessClassPerson.Location = new System.Drawing.Point(361, 225);
            this.txtBusinessClassPerson.Name = "txtBusinessClassPerson";
            this.txtBusinessClassPerson.Size = new System.Drawing.Size(100, 22);
            this.txtBusinessClassPerson.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(597, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 55);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBusinessClassPerson);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtTotalyPerson);
            this.Controls.Add(this.txtTotalySeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalySeat;
        private System.Windows.Forms.TextBox txtTotalyPerson;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtBusinessClassPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

