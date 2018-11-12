namespace WordCount
{
    partial class WordCount
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
            this.groupTxtBox = new System.Windows.Forms.GroupBox();
            this.wordsResultList = new System.Windows.Forms.ListBox();
            this.btnWords = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.grpUpload = new System.Windows.Forms.GroupBox();
            this.fileResultList = new System.Windows.Forms.ListBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.groupTxtBox.SuspendLayout();
            this.grpUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTxtBox
            // 
            this.groupTxtBox.Controls.Add(this.wordsResultList);
            this.groupTxtBox.Controls.Add(this.btnWords);
            this.groupTxtBox.Controls.Add(this.txtWords);
            this.groupTxtBox.Location = new System.Drawing.Point(12, 17);
            this.groupTxtBox.Name = "groupTxtBox";
            this.groupTxtBox.Size = new System.Drawing.Size(245, 303);
            this.groupTxtBox.TabIndex = 0;
            this.groupTxtBox.TabStop = false;
            this.groupTxtBox.Text = "Text Box";
            // 
            // wordsResultList
            // 
            this.wordsResultList.FormattingEnabled = true;
            this.wordsResultList.Location = new System.Drawing.Point(24, 220);
            this.wordsResultList.Name = "wordsResultList";
            this.wordsResultList.Size = new System.Drawing.Size(197, 69);
            this.wordsResultList.TabIndex = 2;
            // 
            // btnWords
            // 
            this.btnWords.Location = new System.Drawing.Point(24, 179);
            this.btnWords.Name = "btnWords";
            this.btnWords.Size = new System.Drawing.Size(197, 23);
            this.btnWords.TabIndex = 1;
            this.btnWords.Text = "Count Words From Text Box";
            this.btnWords.UseVisualStyleBackColor = true;
            this.btnWords.Click += new System.EventHandler(this.btnWords_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(6, 98);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(233, 20);
            this.txtWords.TabIndex = 0;
            // 
            // grpUpload
            // 
            this.grpUpload.Controls.Add(this.fileResultList);
            this.grpUpload.Controls.Add(this.btnFile);
            this.grpUpload.Location = new System.Drawing.Point(287, 17);
            this.grpUpload.Name = "grpUpload";
            this.grpUpload.Size = new System.Drawing.Size(245, 303);
            this.grpUpload.TabIndex = 1;
            this.grpUpload.TabStop = false;
            this.grpUpload.Text = "From File";
            // 
            // fileResultList
            // 
            this.fileResultList.FormattingEnabled = true;
            this.fileResultList.Location = new System.Drawing.Point(26, 220);
            this.fileResultList.Name = "fileResultList";
            this.fileResultList.Size = new System.Drawing.Size(197, 69);
            this.fileResultList.TabIndex = 3;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(26, 179);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(197, 23);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Count Words From Text File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // WordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 335);
            this.Controls.Add(this.grpUpload);
            this.Controls.Add(this.groupTxtBox);
            this.Name = "WordCount";
            this.Text = "WordCount";
            this.groupTxtBox.ResumeLayout(false);
            this.groupTxtBox.PerformLayout();
            this.grpUpload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTxtBox;
        private System.Windows.Forms.Button btnWords;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.GroupBox grpUpload;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ListBox wordsResultList;
        private System.Windows.Forms.ListBox fileResultList;
    }
}

