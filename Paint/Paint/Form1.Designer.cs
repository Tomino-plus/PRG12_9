namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.elipse = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.elipse);
            this.panel1.Controls.Add(this.eraser);
            this.panel1.Controls.Add(this.pen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 101);
            this.panel1.TabIndex = 0;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(1170, 54);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(82, 37);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(697, 10);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(81, 81);
            this.line.TabIndex = 4;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(609, 10);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(81, 81);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // elipse
            // 
            this.elipse.Location = new System.Drawing.Point(521, 10);
            this.elipse.Name = "elipse";
            this.elipse.Size = new System.Drawing.Size(81, 81);
            this.elipse.TabIndex = 2;
            this.elipse.Text = "elipse";
            this.elipse.UseVisualStyleBackColor = true;
            this.elipse.Click += new System.EventHandler(this.elipse_Click);
            // 
            // eraser
            // 
            this.eraser.Location = new System.Drawing.Point(433, 10);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(81, 81);
            this.eraser.TabIndex = 1;
            this.eraser.Text = "erase";
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // pen
            // 
            this.pen.Location = new System.Drawing.Point(345, 10);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(81, 81);
            this.pen.TabIndex = 0;
            this.pen.Text = "pen";
            this.pen.UseVisualStyleBackColor = true;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 61);
            this.panel2.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 101);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1264, 519);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1170, 10);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(82, 37);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_color
            // 
            this.button_color.Location = new System.Drawing.Point(257, 10);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(81, 81);
            this.button_color.TabIndex = 3;
            this.button_color.Text = "color";
            this.button_color.UseVisualStyleBackColor = true;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button elipse;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_color;
    }
}

