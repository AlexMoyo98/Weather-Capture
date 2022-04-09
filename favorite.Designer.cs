namespace WeatherCaptureDemo
{
    partial class favorite
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
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbFav = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCity
            // 
            this.cbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Pretoria",
            "Cape Town",
            "Polokwane",
            "Tzaneen",
            "Rustenburg",
            "Port Elizabeth",
            "Mbombela"});
            this.cbCity.Location = new System.Drawing.Point(55, 25);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(195, 21);
            this.cbCity.TabIndex = 0;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(268, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbFav);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(227, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cbFav
            // 
            this.cbFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFav.FormattingEnabled = true;
            this.cbFav.Location = new System.Drawing.Point(62, 16);
            this.cbFav.Name = "cbFav";
            this.cbFav.Size = new System.Drawing.Size(159, 21);
            this.cbFav.TabIndex = 9;
            this.cbFav.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Favorites";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnFill
            // 
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFill.Location = new System.Drawing.Point(55, 52);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(64, 23);
            this.btnFill.TabIndex = 5;
            this.btnFill.Text = "Fill Items";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(205, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSort
            // 
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSort.Location = new System.Drawing.Point(137, 52);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(45, 23);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 110);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(82, 271);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "Show Results";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(271, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 314);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "favorite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "favorite";
            this.Load += new System.EventHandler(this.favorite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cbFav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}