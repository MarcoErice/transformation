namespace TransformationApp
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
            this.btnFirstFile = new System.Windows.Forms.Button();
            this.btnSecondFile = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFirstFile
            // 
            this.btnFirstFile.Location = new System.Drawing.Point(30, 28);
            this.btnFirstFile.Name = "btnFirstFile";
            this.btnFirstFile.Size = new System.Drawing.Size(242, 108);
            this.btnFirstFile.TabIndex = 0;
            this.btnFirstFile.Text = "Select first file";
            this.btnFirstFile.UseVisualStyleBackColor = true;
            this.btnFirstFile.Click += new System.EventHandler(this.btnFirstFile_Click);
            // 
            // btnSecondFile
            // 
            this.btnSecondFile.Location = new System.Drawing.Point(386, 28);
            this.btnSecondFile.Name = "btnSecondFile";
            this.btnSecondFile.Size = new System.Drawing.Size(249, 108);
            this.btnSecondFile.TabIndex = 1;
            this.btnSecondFile.Text = "Select second file";
            this.btnSecondFile.UseVisualStyleBackColor = true;
            this.btnSecondFile.Click += new System.EventHandler(this.btnSecondFile_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(770, 28);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(258, 108);
            this.btnTransform.TabIndex = 2;
            this.btnTransform.Text = "Transfom";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(30, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 254);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(386, 207);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(249, 254);
            this.listBox2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(770, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 254);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 684);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnSecondFile);
            this.Controls.Add(this.btnFirstFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstFile;
        private System.Windows.Forms.Button btnSecondFile;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

