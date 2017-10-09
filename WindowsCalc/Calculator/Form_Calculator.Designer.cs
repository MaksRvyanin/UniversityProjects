using System;
using System.Drawing;

namespace Calculator
{
    partial class Form_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calc));
            this.btn_brckt_open = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_brckt_close = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_devide = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.btn_neg = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_MS = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_1_x = new System.Windows.Forms.Button();
            this.btn_perc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_brckt_open
            // 
            this.btn_brckt_open.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_brckt_open.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_brckt_open.CausesValidation = false;
            this.btn_brckt_open.FlatAppearance.BorderSize = 0;
            this.btn_brckt_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brckt_open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brckt_open.ForeColor = System.Drawing.Color.Black;
            this.btn_brckt_open.Location = new System.Drawing.Point(17, 78);
            this.btn_brckt_open.Name = "btn_brckt_open";
            this.btn_brckt_open.Size = new System.Drawing.Size(34, 27);
            this.btn_brckt_open.TabIndex = 0;
            this.btn_brckt_open.TabStop = false;
            this.btn_brckt_open.Text = "(";
            this.btn_brckt_open.UseVisualStyleBackColor = false;
            this.btn_brckt_open.Click += new System.EventHandler(this.btn_Brckts);
            // 
            // btn_7
            // 
            this.btn_7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_7.CausesValidation = false;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.Black;
            this.btn_7.Location = new System.Drawing.Point(17, 174);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(34, 27);
            this.btn_7.TabIndex = 0;
            this.btn_7.TabStop = false;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1.CausesValidation = false;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(17, 238);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(34, 27);
            this.btn_1.TabIndex = 0;
            this.btn_1.TabStop = false;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_brckt_close
            // 
            this.btn_brckt_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_brckt_close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_brckt_close.CausesValidation = false;
            this.btn_brckt_close.FlatAppearance.BorderSize = 0;
            this.btn_brckt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brckt_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brckt_close.ForeColor = System.Drawing.Color.Black;
            this.btn_brckt_close.Location = new System.Drawing.Point(56, 78);
            this.btn_brckt_close.Name = "btn_brckt_close";
            this.btn_brckt_close.Size = new System.Drawing.Size(34, 27);
            this.btn_brckt_close.TabIndex = 1;
            this.btn_brckt_close.TabStop = false;
            this.btn_brckt_close.Text = ")";
            this.btn_brckt_close.UseVisualStyleBackColor = false;
            this.btn_brckt_close.Click += new System.EventHandler(this.btn_Brckts);
            // 
            // btn_8
            // 
            this.btn_8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_8.CausesValidation = false;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.Black;
            this.btn_8.Location = new System.Drawing.Point(56, 174);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(34, 27);
            this.btn_8.TabIndex = 1;
            this.btn_8.TabStop = false;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_2
            // 
            this.btn_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_2.CausesValidation = false;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.Black;
            this.btn_2.Location = new System.Drawing.Point(56, 238);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(34, 27);
            this.btn_2.TabIndex = 1;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_9
            // 
            this.btn_9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_9.CausesValidation = false;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.Black;
            this.btn_9.Location = new System.Drawing.Point(95, 174);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(34, 27);
            this.btn_9.TabIndex = 2;
            this.btn_9.TabStop = false;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_3
            // 
            this.btn_3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_3.CausesValidation = false;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.Black;
            this.btn_3.Location = new System.Drawing.Point(94, 238);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(34, 27);
            this.btn_3.TabIndex = 2;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_devide
            // 
            this.btn_devide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_devide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_devide.CausesValidation = false;
            this.btn_devide.FlatAppearance.BorderSize = 0;
            this.btn_devide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devide.ForeColor = System.Drawing.Color.Black;
            this.btn_devide.Location = new System.Drawing.Point(136, 109);
            this.btn_devide.Name = "btn_devide";
            this.btn_devide.Size = new System.Drawing.Size(34, 27);
            this.btn_devide.TabIndex = 3;
            this.btn_devide.TabStop = false;
            this.btn_devide.Text = "/";
            this.btn_devide.UseVisualStyleBackColor = false;
            this.btn_devide.Click += new System.EventHandler(this.btn_Operators);
            // 
            // btn_minus
            // 
            this.btn_minus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minus.CausesValidation = false;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.Black;
            this.btn_minus.Location = new System.Drawing.Point(136, 173);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(34, 27);
            this.btn_minus.TabIndex = 3;
            this.btn_minus.TabStop = false;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_Operators);
            // 
            // btn_0
            // 
            this.btn_0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_0.CausesValidation = false;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.Black;
            this.btn_0.Location = new System.Drawing.Point(54, 270);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(36, 27);
            this.btn_0.TabIndex = 4;
            this.btn_0.TabStop = false;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_del
            // 
            this.btn_del.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_del.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_del.CausesValidation = false;
            this.btn_del.FlatAppearance.BorderSize = 0;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_del.Image = ((System.Drawing.Image)(resources.GetObject("btn_del.Image")));
            this.btn_del.Location = new System.Drawing.Point(96, 140);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(34, 27);
            this.btn_del.TabIndex = 5;
            this.btn_del.TabStop = false;
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_4
            // 
            this.btn_4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_4.CausesValidation = false;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.Black;
            this.btn_4.Location = new System.Drawing.Point(17, 206);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(34, 27);
            this.btn_4.TabIndex = 5;
            this.btn_4.TabStop = false;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_point
            // 
            this.btn_point.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_point.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_point.CausesValidation = false;
            this.btn_point.FlatAppearance.BorderSize = 0;
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_point.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_point.ForeColor = System.Drawing.Color.Black;
            this.btn_point.Location = new System.Drawing.Point(94, 270);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(34, 27);
            this.btn_point.TabIndex = 5;
            this.btn_point.TabStop = false;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = false;
            this.btn_point.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CE.CausesValidation = false;
            this.btn_CE.FlatAppearance.BorderSize = 0;
            this.btn_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.ForeColor = System.Drawing.Color.Black;
            this.btn_CE.Location = new System.Drawing.Point(17, 141);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(34, 27);
            this.btn_CE.TabIndex = 6;
            this.btn_CE.TabStop = false;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_5
            // 
            this.btn_5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_5.CausesValidation = false;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.Black;
            this.btn_5.Location = new System.Drawing.Point(56, 206);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(34, 27);
            this.btn_5.TabIndex = 6;
            this.btn_5.TabStop = false;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_plus.CausesValidation = false;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.Black;
            this.btn_plus.Location = new System.Drawing.Point(136, 205);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(34, 27);
            this.btn_plus.TabIndex = 6;
            this.btn_plus.TabStop = false;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_Operators);
            // 
            // btn_6
            // 
            this.btn_6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_6.CausesValidation = false;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.Black;
            this.btn_6.Location = new System.Drawing.Point(95, 206);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(34, 27);
            this.btn_6.TabIndex = 7;
            this.btn_6.TabStop = false;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_Solve
            // 
            this.btn_Solve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Solve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Solve.CausesValidation = false;
            this.btn_Solve.FlatAppearance.BorderSize = 0;
            this.btn_Solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Solve.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Solve.ForeColor = System.Drawing.Color.Black;
            this.btn_Solve.Location = new System.Drawing.Point(136, 237);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(34, 60);
            this.btn_Solve.TabIndex = 7;
            this.btn_Solve.TabStop = false;
            this.btn_Solve.Text = "=";
            this.btn_Solve.UseVisualStyleBackColor = false;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Result);
            // 
            // btn_neg
            // 
            this.btn_neg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_neg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_neg.CausesValidation = false;
            this.btn_neg.FlatAppearance.BorderSize = 0;
            this.btn_neg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_neg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_neg.ForeColor = System.Drawing.Color.Black;
            this.btn_neg.Location = new System.Drawing.Point(17, 270);
            this.btn_neg.Name = "btn_neg";
            this.btn_neg.Size = new System.Drawing.Size(34, 27);
            this.btn_neg.TabIndex = 8;
            this.btn_neg.TabStop = false;
            this.btn_neg.Text = "±";
            this.btn_neg.UseVisualStyleBackColor = false;
            this.btn_neg.Click += new System.EventHandler(this.btn_negative);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_multiply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_multiply.CausesValidation = false;
            this.btn_multiply.FlatAppearance.BorderSize = 0;
            this.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.ForeColor = System.Drawing.Color.Black;
            this.btn_multiply.Location = new System.Drawing.Point(136, 140);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(34, 27);
            this.btn_multiply.TabIndex = 8;
            this.btn_multiply.TabStop = false;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = false;
            this.btn_multiply.Click += new System.EventHandler(this.btn_Operators);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sqrt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sqrt.CausesValidation = false;
            this.btn_sqrt.FlatAppearance.BorderSize = 0;
            this.btn_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sqrt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqrt.ForeColor = System.Drawing.Color.Black;
            this.btn_sqrt.Location = new System.Drawing.Point(55, 109);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(34, 27);
            this.btn_sqrt.TabIndex = 8;
            this.btn_sqrt.TabStop = false;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = false;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 48);
            this.panel1.TabIndex = 12;
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(5, 16);
            this.lbl2.MinimumSize = new System.Drawing.Size(180, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl2.Size = new System.Drawing.Size(180, 25);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "0";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(-614, -1);
            this.lbl1.MinimumSize = new System.Drawing.Size(185, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1.Size = new System.Drawing.Size(803, 17);
            this.lbl1.TabIndex = 11;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_C
            // 
            this.btn_C.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_C.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_C.CausesValidation = false;
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.ForeColor = System.Drawing.Color.Black;
            this.btn_C.Location = new System.Drawing.Point(56, 141);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(34, 27);
            this.btn_C.TabIndex = 7;
            this.btn_C.TabStop = false;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_MR
            // 
            this.btn_MR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_MR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MR.CausesValidation = false;
            this.btn_MR.FlatAppearance.BorderSize = 0;
            this.btn_MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MR.ForeColor = System.Drawing.Color.Black;
            this.btn_MR.Location = new System.Drawing.Point(136, 82);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(34, 23);
            this.btn_MR.TabIndex = 4;
            this.btn_MR.TabStop = false;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = false;
            this.btn_MR.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // btn_MS
            // 
            this.btn_MS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_MS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_MS.CausesValidation = false;
            this.btn_MS.FlatAppearance.BorderSize = 0;
            this.btn_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MS.ForeColor = System.Drawing.Color.Black;
            this.btn_MS.Location = new System.Drawing.Point(95, 82);
            this.btn_MS.Name = "btn_MS";
            this.btn_MS.Size = new System.Drawing.Size(34, 23);
            this.btn_MS.TabIndex = 3;
            this.btn_MS.TabStop = false;
            this.btn_MS.Text = "MS";
            this.btn_MS.UseVisualStyleBackColor = false;
            this.btn_MS.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 7.75F);
            this.textBox1.Location = new System.Drawing.Point(0, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Memory";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_1_x
            // 
            this.btn_1_x.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_1_x.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_1_x.CausesValidation = false;
            this.btn_1_x.FlatAppearance.BorderSize = 0;
            this.btn_1_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1_x.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1_x.ForeColor = System.Drawing.Color.Black;
            this.btn_1_x.Location = new System.Drawing.Point(96, 109);
            this.btn_1_x.Name = "btn_1_x";
            this.btn_1_x.Size = new System.Drawing.Size(34, 27);
            this.btn_1_x.TabIndex = 14;
            this.btn_1_x.TabStop = false;
            this.btn_1_x.Text = "1/x";
            this.btn_1_x.UseVisualStyleBackColor = false;
            this.btn_1_x.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // btn_perc
            // 
            this.btn_perc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_perc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_perc.CausesValidation = false;
            this.btn_perc.FlatAppearance.BorderSize = 0;
            this.btn_perc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perc.ForeColor = System.Drawing.Color.Black;
            this.btn_perc.Location = new System.Drawing.Point(17, 109);
            this.btn_perc.Name = "btn_perc";
            this.btn_perc.Size = new System.Drawing.Size(34, 27);
            this.btn_perc.TabIndex = 15;
            this.btn_perc.TabStop = false;
            this.btn_perc.Text = "%";
            this.btn_perc.UseVisualStyleBackColor = false;
            this.btn_perc.Click += new System.EventHandler(this.btn_other_Click);
            // 
            // Form_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(188, 304);
            this.Controls.Add(this.btn_perc);
            this.Controls.Add(this.btn_1_x);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_neg);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_devide);
            this.Controls.Add(this.btn_MS);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_brckt_close);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_brckt_open);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Calc";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(Object sender, EventArgs e)
        {
          

        }

        #endregion
        private System.Windows.Forms.Button btn_brckt_open;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_brckt_close;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_devide;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Button btn_neg;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_MS;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_1_x;
        private System.Windows.Forms.Button btn_perc;
    }

}

