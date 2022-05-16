using System;
using System.Drawing;
using System.Windows.Forms;
using DomainModel;

namespace Laba2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();           
        }

        public void InitializeMenu()
        {
            foreach (Type itm in Program.DomainModel.TypeList)
            {
                toolStripCMBMouse.Items.Add(itm.ToString());
                toolStripCMBCoordinates.Items.Add(itm.ToString());
                StatusBarLabel.Text = "Ничего не выбрано";
            }
        }

        // New file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Controller.NewFile();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.Controller.MouseDown(e.X, e.Y);       
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Program.Controller.MouseUp();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                EraseSelectedElement();
                Program.Controller.MouseMove(e.X, e.Y);
                DrawWithSelectedElement();
                Program.DomainModel.DrawElements();
            }
            else 
            {
                Program.Controller.MouseMove(e.X, e.Y);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
                Program.Controller.OpenFile(openFileDialog1.FileName);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
                Program.Controller.SaveFile(saveFileDialog.FileName);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            Program.DomainModel.DrawElements();
            DrawWithSelectedElement();
        }

        private void DrawWithSelectedElement()
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                Pen pen = new Pen(Program.AppModel.CurrentElement.BorderColor, Program.AppModel.CurrentElement.Width);
                Program.AppModel.CurrentElement.Draw(Program.DomainModel.Graphics, pen);
            }
        }

        private void EraseSelectedElement()
        {
            if (Program.AppModel.CurrentElement != null && Program.AppModel.IsCurrentElementActive)
            {
                Pen pen = new Pen(Color.White, Program.AppModel.CurrentElement.Width);
                Program.AppModel.CurrentElement.Draw(Program.DomainModel.Graphics, pen);
            }
        }

        private void toolStripCMBMouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string newElement = toolStripCMBMouse.SelectedItem.ToString();
            Program.Controller.CreateNewElement(newElement);
            StatusBarLabel.Text = $"Выбран элемент рисования {newElement}";
        }

        private void toolStripMenuItemPaint_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripCMBCoordinates.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(toolStripCMBCoordinates.SelectedItem));
                }
                int coordX1 = toolStripTXBCoordX1.Text != string.Empty ? Convert.ToInt16(toolStripTXBCoordX1.Text) : 0;
                int coordY1 = toolStripTXBCoordY1.Text != string.Empty ? Convert.ToInt16(toolStripTXBCoordY1.Text) : 0;
                int coordX2 = toolStripTXBCoordX2.Text != string.Empty ? Convert.ToInt16(toolStripTXBCoordX2.Text) : 0;
                int coordY2 = toolStripTXBCoordY2.Text != string.Empty ? Convert.ToInt16(toolStripTXBCoordY2.Text) : 0;

                string newElement = toolStripCMBCoordinates.SelectedItem.ToString();

                Program.Controller.DrawByCoordinates(newElement, coordX1, coordY1, coordX2, coordY2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill the inputs of coordinates", ex.Message);
            }
            
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set current element to draw to: Line
            var element = new Line();
            element.PosX1 = Program.AppModel.CursorPositionX;
            element.PosY1 = Program.AppModel.CursorPositionY;
            element.TypeOfElement = element.GetType().ToString();
            Program.AppModel.CurrentElement = element;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Controller.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Controller.Redo();
        }

        private void toolStripCMBWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = Convert.ToSingle(toolStripCMBWidth.SelectedItem);
            Program.Controller.SetWidth(width);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                            "Вы хотите сохранить изменения в файле?",
                            "Сообщение",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void chooseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CMBMainColorDialog.ShowDialog() == DialogResult.OK)
            {
                Program.Controller.SetMainColor(CMBMainColorDialog.Color);
            }
            else
            {
                Program.Controller.SetMainColor(CMBBackgroundColor.Color);
            }
        }

        private void chooseColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CMBBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                Program.Controller.SetFillColor(CMBBackgroundColor.Color);
            }
            else
            {
                Program.Controller.SetFillColor(CMBBackgroundColor.Color);
            }
        }
    }
}
