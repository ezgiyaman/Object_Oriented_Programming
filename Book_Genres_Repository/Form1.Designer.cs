
namespace Book_Genres_Repository
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
            this.grpCreateBook = new System.Windows.Forms.GroupBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtConcent = new System.Windows.Forms.TextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGenre = new System.Windows.Forms.GroupBox();
            this.btnCreatGenre = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grpCreateBook.SuspendLayout();
            this.grpGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCreateBook
            // 
            this.grpCreateBook.Controls.Add(this.btnCreateBook);
            this.grpCreateBook.Controls.Add(this.txtWriter);
            this.grpCreateBook.Controls.Add(this.txtConcent);
            this.grpCreateBook.Controls.Add(this.txtTitel);
            this.grpCreateBook.Controls.Add(this.label3);
            this.grpCreateBook.Controls.Add(this.label2);
            this.grpCreateBook.Controls.Add(this.label1);
            this.grpCreateBook.Location = new System.Drawing.Point(13, 13);
            this.grpCreateBook.Name = "grpCreateBook";
            this.grpCreateBook.Size = new System.Drawing.Size(414, 273);
            this.grpCreateBook.TabIndex = 0;
            this.grpCreateBook.TabStop = false;
            this.grpCreateBook.Text = "Create Book:";
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(147, 223);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(147, 23);
            this.btnCreateBook.TabIndex = 6;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(174, 165);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(100, 22);
            this.txtWriter.TabIndex = 5;
            // 
            // txtConcent
            // 
            this.txtConcent.Location = new System.Drawing.Point(174, 119);
            this.txtConcent.Name = "txtConcent";
            this.txtConcent.Size = new System.Drawing.Size(100, 22);
            this.txtConcent.TabIndex = 4;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(174, 66);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(100, 22);
            this.txtTitel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Writer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concent :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel;";
            // 
            // grpGenre
            // 
            this.grpGenre.Controls.Add(this.btnCreatGenre);
            this.grpGenre.Controls.Add(this.label5);
            this.grpGenre.Controls.Add(this.label4);
            this.grpGenre.Controls.Add(this.txtDescription);
            this.grpGenre.Controls.Add(this.txtName);
            this.grpGenre.Location = new System.Drawing.Point(620, 28);
            this.grpGenre.Name = "grpGenre";
            this.grpGenre.Size = new System.Drawing.Size(461, 258);
            this.grpGenre.TabIndex = 2;
            this.grpGenre.TabStop = false;
            this.grpGenre.Text = "Create Genre;";
            // 
            // btnCreatGenre
            // 
            this.btnCreatGenre.Location = new System.Drawing.Point(144, 163);
            this.btnCreatGenre.Name = "btnCreatGenre";
            this.btnCreatGenre.Size = new System.Drawing.Size(135, 23);
            this.btnCreatGenre.TabIndex = 4;
            this.btnCreatGenre.Text = "Create Genre";
            this.btnCreatGenre.UseVisualStyleBackColor = true;
            this.btnCreatGenre.Click += new System.EventHandler(this.btnCreatGenre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(162, 116);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 241);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(620, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(511, 241);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 622);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpGenre);
            this.Controls.Add(this.grpCreateBook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCreateBook.ResumeLayout(false);
            this.grpCreateBook.PerformLayout();
            this.grpGenre.ResumeLayout(false);
            this.grpGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreateBook;
        private System.Windows.Forms.GroupBox grpGenre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtConcent;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Button btnCreatGenre;
    }
}

