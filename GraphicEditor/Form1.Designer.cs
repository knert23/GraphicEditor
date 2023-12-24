
namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonLine = new System.Windows.Forms.Button();
            this.ButtonRectangle = new System.Windows.Forms.Button();
            this.ButtonEllipse = new System.Windows.Forms.Button();
            this.button_Group = new System.Windows.Forms.Button();
            this.button_ungroup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonBackAddNewColor = new System.Windows.Forms.Button();
            this.buttonBackStateBlue = new System.Windows.Forms.Button();
            this.buttonBackOrange = new System.Windows.Forms.Button();
            this.buttonBackViolet = new System.Windows.Forms.Button();
            this.buttonBackGreen = new System.Windows.Forms.Button();
            this.buttonBackYellow = new System.Windows.Forms.Button();
            this.buttonBackBlue = new System.Windows.Forms.Button();
            this.buttonBackRed = new System.Windows.Forms.Button();
            this.buttonBackBlack = new System.Windows.Forms.Button();
            this.buttonBackWhite = new System.Windows.Forms.Button();
            this.labelBackgroundColor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonAddNewColor = new System.Windows.Forms.Button();
            this.buttonStateBlue = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonViolet = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.labelLinecolor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLine
            // 
            this.ButtonLine.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLine.FlatAppearance.BorderSize = 0;
            this.ButtonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLine.Image")));
            this.ButtonLine.Location = new System.Drawing.Point(89, 32);
            this.ButtonLine.Name = "ButtonLine";
            this.ButtonLine.Size = new System.Drawing.Size(49, 49);
            this.ButtonLine.TabIndex = 0;
            this.ButtonLine.UseVisualStyleBackColor = false;
            this.ButtonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // ButtonRectangle
            // 
            this.ButtonRectangle.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRectangle.FlatAppearance.BorderSize = 0;
            this.ButtonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRectangle.Image")));
            this.ButtonRectangle.Location = new System.Drawing.Point(22, 32);
            this.ButtonRectangle.Name = "ButtonRectangle";
            this.ButtonRectangle.Size = new System.Drawing.Size(49, 48);
            this.ButtonRectangle.TabIndex = 1;
            this.ButtonRectangle.UseVisualStyleBackColor = false;
            this.ButtonRectangle.Click += new System.EventHandler(this.ButtonRectangle_Click);
            // 
            // ButtonEllipse
            // 
            this.ButtonEllipse.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonEllipse.FlatAppearance.BorderSize = 0;
            this.ButtonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEllipse.Image")));
            this.ButtonEllipse.Location = new System.Drawing.Point(164, 32);
            this.ButtonEllipse.Name = "ButtonEllipse";
            this.ButtonEllipse.Size = new System.Drawing.Size(49, 49);
            this.ButtonEllipse.TabIndex = 2;
            this.ButtonEllipse.UseVisualStyleBackColor = false;
            this.ButtonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // button_Group
            // 
            this.button_Group.BackColor = System.Drawing.Color.White;
            this.button_Group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Group.Location = new System.Drawing.Point(30, 11);
            this.button_Group.Name = "button_Group";
            this.button_Group.Size = new System.Drawing.Size(100, 33);
            this.button_Group.TabIndex = 3;
            this.button_Group.Text = "Group";
            this.button_Group.UseVisualStyleBackColor = false;
            this.button_Group.Click += new System.EventHandler(this.button_Group_Click);
            // 
            // button_ungroup
            // 
            this.button_ungroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ungroup.Location = new System.Drawing.Point(30, 62);
            this.button_ungroup.Name = "button_ungroup";
            this.button_ungroup.Size = new System.Drawing.Size(100, 37);
            this.button_ungroup.TabIndex = 4;
            this.button_ungroup.Text = "Ungroup";
            this.button_ungroup.UseVisualStyleBackColor = true;
            this.button_ungroup.Click += new System.EventHandler(this.button_ungroup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 113);
            this.panel1.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.buttonBackAddNewColor);
            this.panel6.Controls.Add(this.buttonBackStateBlue);
            this.panel6.Controls.Add(this.buttonBackOrange);
            this.panel6.Controls.Add(this.buttonBackViolet);
            this.panel6.Controls.Add(this.buttonBackGreen);
            this.panel6.Controls.Add(this.buttonBackYellow);
            this.panel6.Controls.Add(this.buttonBackBlue);
            this.panel6.Controls.Add(this.buttonBackRed);
            this.panel6.Controls.Add(this.buttonBackBlack);
            this.panel6.Controls.Add(this.buttonBackWhite);
            this.panel6.Controls.Add(this.labelBackgroundColor);
            this.panel6.Location = new System.Drawing.Point(851, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 113);
            this.panel6.TabIndex = 21;
            // 
            // buttonBackAddNewColor
            // 
            this.buttonBackAddNewColor.Location = new System.Drawing.Point(218, 68);
            this.buttonBackAddNewColor.Name = "buttonBackAddNewColor";
            this.buttonBackAddNewColor.Size = new System.Drawing.Size(30, 30);
            this.buttonBackAddNewColor.TabIndex = 20;
            this.buttonBackAddNewColor.UseVisualStyleBackColor = true;
            this.buttonBackAddNewColor.Click += new System.EventHandler(this.buttonBackAddNewColor_Click);
            // 
            // buttonBackStateBlue
            // 
            this.buttonBackStateBlue.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBackStateBlue.Location = new System.Drawing.Point(182, 68);
            this.buttonBackStateBlue.Name = "buttonBackStateBlue";
            this.buttonBackStateBlue.Size = new System.Drawing.Size(30, 30);
            this.buttonBackStateBlue.TabIndex = 19;
            this.buttonBackStateBlue.UseVisualStyleBackColor = false;
            this.buttonBackStateBlue.Click += new System.EventHandler(this.buttonBackStateBlue_Click);
            // 
            // buttonBackOrange
            // 
            this.buttonBackOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonBackOrange.Location = new System.Drawing.Point(146, 68);
            this.buttonBackOrange.Name = "buttonBackOrange";
            this.buttonBackOrange.Size = new System.Drawing.Size(30, 30);
            this.buttonBackOrange.TabIndex = 18;
            this.buttonBackOrange.UseVisualStyleBackColor = false;
            this.buttonBackOrange.Click += new System.EventHandler(this.buttonBackOrange_Click);
            // 
            // buttonBackViolet
            // 
            this.buttonBackViolet.BackColor = System.Drawing.Color.Violet;
            this.buttonBackViolet.Location = new System.Drawing.Point(110, 68);
            this.buttonBackViolet.Name = "buttonBackViolet";
            this.buttonBackViolet.Size = new System.Drawing.Size(30, 30);
            this.buttonBackViolet.TabIndex = 17;
            this.buttonBackViolet.UseVisualStyleBackColor = false;
            this.buttonBackViolet.Click += new System.EventHandler(this.buttonBackViolet_Click);
            // 
            // buttonBackGreen
            // 
            this.buttonBackGreen.BackColor = System.Drawing.Color.Green;
            this.buttonBackGreen.FlatAppearance.BorderSize = 0;
            this.buttonBackGreen.Location = new System.Drawing.Point(74, 68);
            this.buttonBackGreen.Name = "buttonBackGreen";
            this.buttonBackGreen.Size = new System.Drawing.Size(30, 30);
            this.buttonBackGreen.TabIndex = 16;
            this.buttonBackGreen.UseVisualStyleBackColor = false;
            this.buttonBackGreen.Click += new System.EventHandler(this.buttonBackGreen_Click);
            // 
            // buttonBackYellow
            // 
            this.buttonBackYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonBackYellow.FlatAppearance.BorderSize = 0;
            this.buttonBackYellow.Location = new System.Drawing.Point(218, 32);
            this.buttonBackYellow.Name = "buttonBackYellow";
            this.buttonBackYellow.Size = new System.Drawing.Size(30, 30);
            this.buttonBackYellow.TabIndex = 15;
            this.buttonBackYellow.UseVisualStyleBackColor = false;
            this.buttonBackYellow.Click += new System.EventHandler(this.buttonBackYellow_Click);
            // 
            // buttonBackBlue
            // 
            this.buttonBackBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBackBlue.FlatAppearance.BorderSize = 0;
            this.buttonBackBlue.Location = new System.Drawing.Point(182, 32);
            this.buttonBackBlue.Name = "buttonBackBlue";
            this.buttonBackBlue.Size = new System.Drawing.Size(30, 30);
            this.buttonBackBlue.TabIndex = 14;
            this.buttonBackBlue.UseVisualStyleBackColor = false;
            this.buttonBackBlue.Click += new System.EventHandler(this.buttonBackBlue_Click);
            // 
            // buttonBackRed
            // 
            this.buttonBackRed.BackColor = System.Drawing.Color.Red;
            this.buttonBackRed.FlatAppearance.BorderSize = 0;
            this.buttonBackRed.Location = new System.Drawing.Point(146, 32);
            this.buttonBackRed.Name = "buttonBackRed";
            this.buttonBackRed.Size = new System.Drawing.Size(30, 30);
            this.buttonBackRed.TabIndex = 13;
            this.buttonBackRed.UseVisualStyleBackColor = false;
            this.buttonBackRed.Click += new System.EventHandler(this.buttonBackRed_Click);
            // 
            // buttonBackBlack
            // 
            this.buttonBackBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBackBlack.FlatAppearance.BorderSize = 0;
            this.buttonBackBlack.Location = new System.Drawing.Point(110, 32);
            this.buttonBackBlack.Name = "buttonBackBlack";
            this.buttonBackBlack.Size = new System.Drawing.Size(30, 30);
            this.buttonBackBlack.TabIndex = 12;
            this.buttonBackBlack.UseVisualStyleBackColor = false;
            this.buttonBackBlack.Click += new System.EventHandler(this.buttonBackBlack_Click);
            // 
            // buttonBackWhite
            // 
            this.buttonBackWhite.Location = new System.Drawing.Point(74, 32);
            this.buttonBackWhite.Name = "buttonBackWhite";
            this.buttonBackWhite.Size = new System.Drawing.Size(30, 30);
            this.buttonBackWhite.TabIndex = 11;
            this.buttonBackWhite.UseVisualStyleBackColor = true;
            this.buttonBackWhite.Click += new System.EventHandler(this.buttonBackWhite_Click);
            // 
            // labelBackgroundColor
            // 
            this.labelBackgroundColor.AutoSize = true;
            this.labelBackgroundColor.Location = new System.Drawing.Point(114, 8);
            this.labelBackgroundColor.Name = "labelBackgroundColor";
            this.labelBackgroundColor.Size = new System.Drawing.Size(98, 17);
            this.labelBackgroundColor.TabIndex = 10;
            this.labelBackgroundColor.Text = "Цвет заливки";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonAddNewColor);
            this.panel5.Controls.Add(this.buttonStateBlue);
            this.panel5.Controls.Add(this.buttonOrange);
            this.panel5.Controls.Add(this.buttonViolet);
            this.panel5.Controls.Add(this.buttonGreen);
            this.panel5.Controls.Add(this.buttonYellow);
            this.panel5.Controls.Add(this.buttonBlue);
            this.panel5.Controls.Add(this.buttonRed);
            this.panel5.Controls.Add(this.buttonBlack);
            this.panel5.Controls.Add(this.buttonWhite);
            this.panel5.Controls.Add(this.labelLinecolor);
            this.panel5.Location = new System.Drawing.Point(567, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 113);
            this.panel5.TabIndex = 7;
            // 
            // buttonAddNewColor
            // 
            this.buttonAddNewColor.Location = new System.Drawing.Point(196, 71);
            this.buttonAddNewColor.Name = "buttonAddNewColor";
            this.buttonAddNewColor.Size = new System.Drawing.Size(30, 30);
            this.buttonAddNewColor.TabIndex = 20;
            this.buttonAddNewColor.UseVisualStyleBackColor = true;
            this.buttonAddNewColor.Click += new System.EventHandler(this.buttonAddNewColor_Click);
            // 
            // buttonStateBlue
            // 
            this.buttonStateBlue.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonStateBlue.Location = new System.Drawing.Point(160, 71);
            this.buttonStateBlue.Name = "buttonStateBlue";
            this.buttonStateBlue.Size = new System.Drawing.Size(30, 30);
            this.buttonStateBlue.TabIndex = 19;
            this.buttonStateBlue.UseVisualStyleBackColor = false;
            this.buttonStateBlue.Click += new System.EventHandler(this.buttonStateBlue_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Location = new System.Drawing.Point(124, 71);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(30, 30);
            this.buttonOrange.TabIndex = 18;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonViolet
            // 
            this.buttonViolet.BackColor = System.Drawing.Color.Violet;
            this.buttonViolet.Location = new System.Drawing.Point(88, 71);
            this.buttonViolet.Name = "buttonViolet";
            this.buttonViolet.Size = new System.Drawing.Size(30, 30);
            this.buttonViolet.TabIndex = 17;
            this.buttonViolet.UseVisualStyleBackColor = false;
            this.buttonViolet.Click += new System.EventHandler(this.buttonViolet_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.FlatAppearance.BorderSize = 0;
            this.buttonGreen.Location = new System.Drawing.Point(52, 71);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(30, 30);
            this.buttonGreen.TabIndex = 16;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.FlatAppearance.BorderSize = 0;
            this.buttonYellow.Location = new System.Drawing.Point(196, 35);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(30, 30);
            this.buttonYellow.TabIndex = 15;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.FlatAppearance.BorderSize = 0;
            this.buttonBlue.Location = new System.Drawing.Point(160, 35);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(30, 30);
            this.buttonBlue.TabIndex = 14;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.FlatAppearance.BorderSize = 0;
            this.buttonRed.Location = new System.Drawing.Point(124, 35);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(30, 30);
            this.buttonRed.TabIndex = 13;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBlack.Location = new System.Drawing.Point(88, 35);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(30, 30);
            this.buttonBlack.TabIndex = 12;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonWhite.Location = new System.Drawing.Point(52, 35);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(30, 30);
            this.buttonWhite.TabIndex = 11;
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // labelLinecolor
            // 
            this.labelLinecolor.AutoSize = true;
            this.labelLinecolor.Location = new System.Drawing.Point(92, 11);
            this.labelLinecolor.Name = "labelLinecolor";
            this.labelLinecolor.Size = new System.Drawing.Size(85, 17);
            this.labelLinecolor.TabIndex = 10;
            this.labelLinecolor.Text = "Цвет линии";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.SizeLabel);
            this.panel4.Controls.Add(this.SizeTextBox);
            this.panel4.Location = new System.Drawing.Point(401, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 113);
            this.panel4.TabIndex = 8;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(47, 24);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(57, 17);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Размер";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SizeTextBox.Location = new System.Drawing.Point(31, 59);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.SizeTextBox.TabIndex = 8;
            this.SizeTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SizeTextBox_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_Group);
            this.panel3.Controls.Add(this.button_ungroup);
            this.panel3.Location = new System.Drawing.Point(237, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 113);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonLine);
            this.panel2.Controls.Add(this.ButtonEllipse);
            this.panel2.Controls.Add(this.ButtonRectangle);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 113);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 694);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonLine;
        private System.Windows.Forms.Button ButtonRectangle;
        private System.Windows.Forms.Button ButtonEllipse;
        private System.Windows.Forms.Button button_Group;
        private System.Windows.Forms.Button button_ungroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelLinecolor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonAddNewColor;
        private System.Windows.Forms.Button buttonStateBlue;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonViolet;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonBackAddNewColor;
        private System.Windows.Forms.Button buttonBackStateBlue;
        private System.Windows.Forms.Button buttonBackOrange;
        private System.Windows.Forms.Button buttonBackViolet;
        private System.Windows.Forms.Button buttonBackGreen;
        private System.Windows.Forms.Button buttonBackYellow;
        private System.Windows.Forms.Button buttonBackBlue;
        private System.Windows.Forms.Button buttonBackRed;
        private System.Windows.Forms.Button buttonBackBlack;
        private System.Windows.Forms.Button buttonBackWhite;
        private System.Windows.Forms.Label labelBackgroundColor;
    }
}

