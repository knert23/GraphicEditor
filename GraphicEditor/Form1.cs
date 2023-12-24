using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controller controller = new Controller(new Model());
        int lineSize = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.PaintController.SetPort(Handle);
            controller.PaintController.Clear();
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            controller.Action.StartCreate(ObjectType.Line);

            SetStyleSettingsWidth();
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            controller.Action.StartCreate(ObjectType.Rectangle);

            SetStyleSettingsWidth();
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            controller.Action.StartCreate(ObjectType.Ellipse);

            SetStyleSettingsWidth();
        }

        private void SetStyleSettingsWidth()
        {
            Int32.TryParse(SizeTextBox.Text, out lineSize);
            if (lineSize <= 0) lineSize = 1;

            controller.Settings.ObjectStyleSettings.PenSettings.LineWidth = lineSize;
            controller.Settings.ObjectStyleSettings.isLineWidthChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        // Для того, что бы событие MouseMove срабатывало только после MouseDown
        bool isDown = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                controller.Action.MouseDown(e.X, e.Y);
                isDown = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                controller.Action.ShiftMouseUp(e.X, e.Y);
                return;
            }

            controller.Action.MouseUp(e.X, e.Y);
            isDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                controller.Action.MouseMove(e.X, e.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) controller.Action.Esc();
            if (e.KeyCode == Keys.Delete) controller.Action.Del();
        }

        private void button_Group_Click(object sender, EventArgs e)
        {
            controller.Action.Group();
        }

        private void button_ungroup_Click(object sender, EventArgs e)
        {
            controller.Action.Ungroup();
        }

        private void SizeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetStyleSettingsWidth();
            }
        }


        /*------------------------------------------Цвета линии------------------------------------------*/
        private void buttonWhite_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonWhite.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonBlack.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonRed.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonBlue.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonYellow.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonGreen.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonViolet_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonViolet.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonOrange.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonStateBlue_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = buttonStateBlue.BackColor;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonAddNewColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonAddNewColor.BackColor = colorDialog.Color;
            }
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = colorDialog.Color;
            controller.Settings.ObjectStyleSettings.isLineColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }






        /*------------------------------------------Цвета фона------------------------------------------*/
        private void buttonBackWhite_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackWhite.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackBlack_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackBlack.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackRed_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackRed.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackBlue_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackBlue.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackYellow_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackYellow.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackGreen_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackGreen.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackViolet_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackViolet.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackOrange_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackOrange.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackStateBlue_Click(object sender, EventArgs e)
        {
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = buttonBackStateBlue.BackColor;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }

        private void buttonBackAddNewColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonBackAddNewColor.BackColor = colorDialog.Color;
            }
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = colorDialog.Color;
            controller.Settings.ObjectStyleSettings.isFillColorChanged = true;

            controller.Settings.SetObjectStyleSettings();
            controller.Settings.Refresh();
        }
    }
}