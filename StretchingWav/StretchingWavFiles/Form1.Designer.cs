namespace KursRvyanin
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
            this.Btn_OpenWav = new System.Windows.Forms.Button();
            this.Btn_Stretch = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.RatioBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RatioBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_OpenWav
            // 
            this.Btn_OpenWav.Location = new System.Drawing.Point(12, 13);
            this.Btn_OpenWav.Name = "Btn_OpenWav";
            this.Btn_OpenWav.Size = new System.Drawing.Size(134, 43);
            this.Btn_OpenWav.TabIndex = 0;
            this.Btn_OpenWav.Text = "Загрузить WAV файл";
            this.Btn_OpenWav.UseVisualStyleBackColor = true;
            this.Btn_OpenWav.Click += new System.EventHandler(this.Btn_OpenWav_Click);
            // 
            // Btn_Stretch
            // 
            this.Btn_Stretch.Enabled = false;
            this.Btn_Stretch.Location = new System.Drawing.Point(12, 73);
            this.Btn_Stretch.Name = "Btn_Stretch";
            this.Btn_Stretch.Size = new System.Drawing.Size(134, 43);
            this.Btn_Stretch.TabIndex = 1;
            this.Btn_Stretch.Text = "Изменить длительность";
            this.Btn_Stretch.UseVisualStyleBackColor = true;
            this.Btn_Stretch.Click += new System.EventHandler(this.Btn_Stretch_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Enabled = false;
            this.Btn_Save.Location = new System.Drawing.Point(12, 129);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(134, 43);
            this.Btn_Save.TabIndex = 2;
            this.Btn_Save.Text = "Сохранить";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // RatioBar
            // 
            this.RatioBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.RatioBar.Enabled = false;
            this.RatioBar.LargeChange = 1;
            this.RatioBar.Location = new System.Drawing.Point(212, 13);
            this.RatioBar.Maximum = 15;
            this.RatioBar.Minimum = 5;
            this.RatioBar.Name = "RatioBar";
            this.RatioBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RatioBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RatioBar.Size = new System.Drawing.Size(45, 159);
            this.RatioBar.TabIndex = 1;
            this.RatioBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.RatioBar.Value = 10;
            this.RatioBar.Scroll += new System.EventHandler(this.RatioBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 143);
            this.label1.TabIndex = 5;
            this.label1.Text = "1.5\r\n1.4\r\n1.3\r\n1.2\r\n1.1\r\n1.0\r\n0.9\r\n0.8\r\n0.7\r\n0.6\r\n0.5";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(298, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вопроизвести оригинал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(298, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Воспроизвести изменненый файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Остановить воспроизведение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 206);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_OpenWav);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Stretch);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RatioBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Stretching WAV files";
            ((System.ComponentModel.ISupportInitialize)(this.RatioBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_OpenWav;
        private System.Windows.Forms.Button Btn_Stretch;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TrackBar RatioBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

