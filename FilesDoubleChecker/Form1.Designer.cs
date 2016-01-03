namespace FilesDoubleChecker
{
    partial class Main
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
            this.Folder1Txt = new System.Windows.Forms.TextBox();
            this.Folder2Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder1Btn = new System.Windows.Forms.Button();
            this.Folder2Btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GoBtn = new System.Windows.Forms.Button();
            this.SaveCSVBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MoveToDelBtn = new System.Windows.Forms.Button();
            this.DeleteFolderTxt = new System.Windows.Forms.TextBox();
            this.FileToMoveTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ClearDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Folder1Txt
            // 
            this.Folder1Txt.Location = new System.Drawing.Point(68, 50);
            this.Folder1Txt.Name = "Folder1Txt";
            this.Folder1Txt.Size = new System.Drawing.Size(530, 20);
            this.Folder1Txt.TabIndex = 0;
            this.Folder1Txt.Text = "D:\\Video";
            // 
            // Folder2Txt
            // 
            this.Folder2Txt.Location = new System.Drawing.Point(68, 171);
            this.Folder2Txt.Name = "Folder2Txt";
            this.Folder2Txt.Size = new System.Drawing.Size(530, 20);
            this.Folder2Txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder 2";
            // 
            // Folder1Btn
            // 
            this.Folder1Btn.Location = new System.Drawing.Point(605, 46);
            this.Folder1Btn.Name = "Folder1Btn";
            this.Folder1Btn.Size = new System.Drawing.Size(75, 23);
            this.Folder1Btn.TabIndex = 4;
            this.Folder1Btn.Text = "Get Folder";
            this.Folder1Btn.UseVisualStyleBackColor = true;
            this.Folder1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Folder2Btn
            // 
            this.Folder2Btn.Location = new System.Drawing.Point(605, 171);
            this.Folder2Btn.Name = "Folder2Btn";
            this.Folder2Btn.Size = new System.Drawing.Size(75, 23);
            this.Folder2Btn.TabIndex = 5;
            this.Folder2Btn.Text = "Get Folder";
            this.Folder2Btn.UseVisualStyleBackColor = true;
            this.Folder2Btn.Click += new System.EventHandler(this.Folder2Btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(605, 318);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 50);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // SaveCSVBtn
            // 
            this.SaveCSVBtn.Location = new System.Drawing.Point(112, 377);
            this.SaveCSVBtn.Name = "SaveCSVBtn";
            this.SaveCSVBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveCSVBtn.TabIndex = 8;
            this.SaveCSVBtn.Text = "Save CSV";
            this.SaveCSVBtn.UseVisualStyleBackColor = true;
            this.SaveCSVBtn.Click += new System.EventHandler(this.SaveCSVBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "CSV Exact Match";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MoveToDelBtn
            // 
            this.MoveToDelBtn.Location = new System.Drawing.Point(523, 441);
            this.MoveToDelBtn.Name = "MoveToDelBtn";
            this.MoveToDelBtn.Size = new System.Drawing.Size(75, 23);
            this.MoveToDelBtn.TabIndex = 10;
            this.MoveToDelBtn.Text = "Move To Delete";
            this.MoveToDelBtn.UseVisualStyleBackColor = true;
            this.MoveToDelBtn.Click += new System.EventHandler(this.MoveToDelBtn_Click);
            // 
            // DeleteFolderTxt
            // 
            this.DeleteFolderTxt.Location = new System.Drawing.Point(498, 392);
            this.DeleteFolderTxt.Name = "DeleteFolderTxt";
            this.DeleteFolderTxt.Size = new System.Drawing.Size(198, 20);
            this.DeleteFolderTxt.TabIndex = 11;
            this.DeleteFolderTxt.Text = "D:\\To be deleted";
            // 
            // FileToMoveTxt
            // 
            this.FileToMoveTxt.Location = new System.Drawing.Point(498, 414);
            this.FileToMoveTxt.Name = "FileToMoveTxt";
            this.FileToMoveTxt.Size = new System.Drawing.Size(198, 20);
            this.FileToMoveTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delete Folder";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "File To Move";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(605, 541);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(605, 441);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 16;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ClearDeleteBtn
            // 
            this.ClearDeleteBtn.Location = new System.Drawing.Point(532, 470);
            this.ClearDeleteBtn.Name = "ClearDeleteBtn";
            this.ClearDeleteBtn.Size = new System.Drawing.Size(127, 23);
            this.ClearDeleteBtn.TabIndex = 17;
            this.ClearDeleteBtn.Text = "Clear Delete Folder";
            this.ClearDeleteBtn.UseVisualStyleBackColor = true;
            this.ClearDeleteBtn.Click += new System.EventHandler(this.ClearDeleteBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 623);
            this.Controls.Add(this.ClearDeleteBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileToMoveTxt);
            this.Controls.Add(this.DeleteFolderTxt);
            this.Controls.Add(this.MoveToDelBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveCSVBtn);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Folder2Btn);
            this.Controls.Add(this.Folder1Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Folder2Txt);
            this.Controls.Add(this.Folder1Txt);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Folder1Txt;
        private System.Windows.Forms.TextBox Folder2Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Folder1Btn;
        private System.Windows.Forms.Button Folder2Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Button SaveCSVBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MoveToDelBtn;
        private System.Windows.Forms.TextBox DeleteFolderTxt;
        private System.Windows.Forms.TextBox FileToMoveTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ClearDeleteBtn;
    }
}

