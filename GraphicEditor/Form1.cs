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
            if (controller.Settings.SelectionStoreCount == 0)
            {
                controller.Settings.SetObjectStyleSettings();
            }
            else
            {
                controller.Settings.Refresh(StyleType.LineWidth);
            }     
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
        private void ChangeLineColor(Color color)
        {
            // если selectionStore.Count == 0, то смена настроек фабрики
            // иначе меняем настройки стиля объектов
            controller.Settings.ObjectStyleSettings.PenSettings.LineColor = color;
            if (controller.Settings.SelectionStoreCount == 0)
            {
                controller.Settings.SetObjectStyleSettings();
            }
            else
            {
                controller.Settings.Refresh(StyleType.LineColor);
            }
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonWhite.BackColor);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonBlack.BackColor);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonRed.BackColor);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonBlue.BackColor);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonYellow.BackColor);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonGreen.BackColor);
        }

        private void buttonViolet_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonViolet.BackColor);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonOrange.BackColor);
        }

        private void buttonStateBlue_Click(object sender, EventArgs e)
        {
            ChangeLineColor(buttonStateBlue.BackColor);
        }

        private void buttonAddNewColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonAddNewColor.BackColor = colorDialog.Color;
            }
            ChangeLineColor(colorDialog.Color);
        }






        /*------------------------------------------Цвета заливки------------------------------------------*/
        private void ChangeFillColor(Color color)
        {
            // если selectionStore.Count == 0, то смена настроек фабрики
            // иначе меняем настройки стиля объектов
            controller.Settings.ObjectStyleSettings.BrushSettings.BrushColor = color;
            if (controller.Settings.SelectionStoreCount == 0)
            {
                controller.Settings.SetObjectStyleSettings();
            }
            else
            {
                controller.Settings.Refresh(StyleType.FillColor);
            }
        }
        private void buttonBackWhite_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackWhite.BackColor);
        }

        private void buttonBackBlack_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackBlack.BackColor);
        }

        private void buttonBackRed_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackRed.BackColor);
        }

        private void buttonBackBlue_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackBlue.BackColor);
        }

        private void buttonBackYellow_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackYellow.BackColor);
        }

        private void buttonBackGreen_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackGreen.BackColor);
        }

        private void buttonBackViolet_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackViolet.BackColor);
        }

        private void buttonBackOrange_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackOrange.BackColor);
        }

        private void buttonBackStateBlue_Click(object sender, EventArgs e)
        {
            ChangeFillColor(buttonBackStateBlue.BackColor);
        }

        private void buttonBackAddNewColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonBackAddNewColor.BackColor = colorDialog.Color;
            }
            ChangeFillColor(colorDialog.Color);
        }
    }
}