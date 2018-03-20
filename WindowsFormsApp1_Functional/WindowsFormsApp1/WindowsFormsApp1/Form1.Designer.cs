namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.userFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userExtInput = new System.Windows.Forms.ComboBox();
            this.userTextInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBOutputList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userSearchText = new System.Windows.Forms.Button();
            this.searchFilePath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter File Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userFilePath
            // 
            this.userFilePath.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userFilePath.Location = new System.Drawing.Point(36, 159);
            this.userFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userFilePath.Name = "userFilePath";
            this.userFilePath.Size = new System.Drawing.Size(724, 27);
            this.userFilePath.TabIndex = 2;
            this.userFilePath.Text = "C:\\Users\\ClevelandCodes\\Desktop\\";
            this.userFilePath.TextChanged += new System.EventHandler(this.userFilePath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Extension";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // userExtInput
            // 
            this.userExtInput.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userExtInput.FormattingEnabled = true;
            this.userExtInput.Items.AddRange(new object[] {
            ".JSON",
            ".TXT",
            ".XML",
            ".CONFIG"});
            this.userExtInput.Location = new System.Drawing.Point(615, 224);
            this.userExtInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userExtInput.Name = "userExtInput";
            this.userExtInput.Size = new System.Drawing.Size(145, 31);
            this.userExtInput.TabIndex = 5;
            this.userExtInput.SelectedIndexChanged += new System.EventHandler(this.userExtInput_SelectedIndexChanged);
            // 
            // userTextInput
            // 
            this.userTextInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextInput.Location = new System.Drawing.Point(36, 306);
            this.userTextInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTextInput.Name = "userTextInput";
            this.userTextInput.Size = new System.Drawing.Size(724, 36);
            this.userTextInput.TabIndex = 7;
            this.userTextInput.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Text";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LBOutputList
            // 
            this.LBOutputList.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBOutputList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBOutputList.FormattingEnabled = true;
            this.LBOutputList.ItemHeight = 29;
            this.LBOutputList.Location = new System.Drawing.Point(36, 416);
            this.LBOutputList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBOutputList.Name = "LBOutputList";
            this.LBOutputList.Size = new System.Drawing.Size(724, 294);
            this.LBOutputList.TabIndex = 9;
            this.LBOutputList.SelectedIndexChanged += new System.EventHandler(this.LBOutputList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(644, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Files found";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.recycling_bin;
            this.button1.Location = new System.Drawing.Point(849, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 316);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Again ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userSearchText
            // 
            this.userSearchText.Image = global::WindowsFormsApp1.Properties.Resources.text_lines__1_;
            this.userSearchText.Location = new System.Drawing.Point(849, 271);
            this.userSearchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSearchText.Name = "userSearchText";
            this.userSearchText.Size = new System.Drawing.Size(305, 112);
            this.userSearchText.TabIndex = 8;
            this.userSearchText.Text = "Search Text";
            this.userSearchText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userSearchText.UseVisualStyleBackColor = true;
            this.userSearchText.Click += new System.EventHandler(this.userSearchText_Click);
            // 
            // searchFilePath
            // 
            this.searchFilePath.Image = global::WindowsFormsApp1.Properties.Resources.search__1_;
            this.searchFilePath.Location = new System.Drawing.Point(849, 143);
            this.searchFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchFilePath.Name = "searchFilePath";
            this.searchFilePath.Size = new System.Drawing.Size(305, 111);
            this.searchFilePath.TabIndex = 1;
            this.searchFilePath.Text = "Search File";
            this.searchFilePath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchFilePath.UseVisualStyleBackColor = true;
            this.searchFilePath.Click += new System.EventHandler(this.searchFilePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 36.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 82);
            this.label5.TabIndex = 12;
            this.label5.Text = "FileFinder";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1252, 778);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBOutputList);
            this.Controls.Add(this.userSearchText);
            this.Controls.Add(this.userTextInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userExtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userFilePath);
            this.Controls.Add(this.searchFilePath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "FileFinder v1.0 (3/19/18)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchFilePath;
        private System.Windows.Forms.TextBox userFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userExtInput;
        private System.Windows.Forms.TextBox userTextInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button userSearchText;
        private System.Windows.Forms.ListBox LBOutputList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

