
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
            this.ButtonLine = new System.Windows.Forms.Button();
            this.ButtonRectangle = new System.Windows.Forms.Button();
            this.ButtonEllipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonLine
            // 
            this.ButtonLine.Location = new System.Drawing.Point(1040, 32);
            this.ButtonLine.Name = "ButtonLine";
            this.ButtonLine.Size = new System.Drawing.Size(100, 34);
            this.ButtonLine.TabIndex = 0;
            this.ButtonLine.Text = "Line";
            this.ButtonLine.UseVisualStyleBackColor = true;
            this.ButtonLine.Click += new System.EventHandler(this.ButtonLine_Click);
            // 
            // ButtonRectangle
            // 
            this.ButtonRectangle.Location = new System.Drawing.Point(1040, 87);
            this.ButtonRectangle.Name = "ButtonRectangle";
            this.ButtonRectangle.Size = new System.Drawing.Size(100, 34);
            this.ButtonRectangle.TabIndex = 1;
            this.ButtonRectangle.Text = "Rectangle";
            this.ButtonRectangle.UseVisualStyleBackColor = true;
            this.ButtonRectangle.Click += new System.EventHandler(this.ButtonRectangle_Click);
            // 
            // ButtonEllipse
            // 
            this.ButtonEllipse.Location = new System.Drawing.Point(1040, 137);
            this.ButtonEllipse.Name = "ButtonEllipse";
            this.ButtonEllipse.Size = new System.Drawing.Size(100, 34);
            this.ButtonEllipse.TabIndex = 2;
            this.ButtonEllipse.Text = "Ellipse";
            this.ButtonEllipse.UseVisualStyleBackColor = true;
            this.ButtonEllipse.Click += new System.EventHandler(this.ButtonEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 694);
            this.Controls.Add(this.ButtonEllipse);
            this.Controls.Add(this.ButtonRectangle);
            this.Controls.Add(this.ButtonLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonLine;
        private System.Windows.Forms.Button ButtonRectangle;
        private System.Windows.Forms.Button ButtonEllipse;
    }
}

