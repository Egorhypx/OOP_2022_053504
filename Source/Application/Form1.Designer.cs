
namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCMBMouse = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCMBCoordinates = new System.Windows.Forms.ToolStripComboBox();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTXBCoordX1 = new System.Windows.Forms.ToolStripTextBox();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTXBCoordY1 = new System.Windows.Forms.ToolStripTextBox();
            this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTXBCoordX2 = new System.Windows.Forms.ToolStripTextBox();
            this.y2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTXBCoordY2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemPaint = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCMBWidth = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CMBMainColorDialog = new System.Windows.Forms.ColorDialog();
            this.CMBBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(80, 1061);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(180, 30);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 30);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCMBMouse});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 30);
            this.toolStripMenuItem1.Text = "Mouse";
            // 
            // toolStripCMBMouse
            // 
            this.toolStripCMBMouse.DropDownWidth = 50;
            this.toolStripCMBMouse.Name = "toolStripCMBMouse";
            this.toolStripCMBMouse.Size = new System.Drawing.Size(352, 23);
            this.toolStripCMBMouse.SelectedIndexChanged += new System.EventHandler(this.toolStripCMBMouse_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCMBCoordinates,
            this.xToolStripMenuItem,
            this.yToolStripMenuItem,
            this.x1ToolStripMenuItem,
            this.y2ToolStripMenuItem,
            this.toolStripMenuItemPaint});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(186, 30);
            this.toolStripMenuItem2.Text = "Coordinates";
            // 
            // toolStripCMBCoordinates
            // 
            this.toolStripCMBCoordinates.Name = "toolStripCMBCoordinates";
            this.toolStripCMBCoordinates.Size = new System.Drawing.Size(121, 23);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTXBCoordX1});
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.xToolStripMenuItem.Text = "X1:";
            // 
            // toolStripTXBCoordX1
            // 
            this.toolStripTXBCoordX1.Name = "toolStripTXBCoordX1";
            this.toolStripTXBCoordX1.Size = new System.Drawing.Size(100, 23);
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTXBCoordY1});
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.yToolStripMenuItem.Text = "Y1:";
            // 
            // toolStripTXBCoordY1
            // 
            this.toolStripTXBCoordY1.Name = "toolStripTXBCoordY1";
            this.toolStripTXBCoordY1.Size = new System.Drawing.Size(100, 23);
            // 
            // x1ToolStripMenuItem
            // 
            this.x1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTXBCoordX2});
            this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
            this.x1ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.x1ToolStripMenuItem.Text = "X2:";
            // 
            // toolStripTXBCoordX2
            // 
            this.toolStripTXBCoordX2.Name = "toolStripTXBCoordX2";
            this.toolStripTXBCoordX2.Size = new System.Drawing.Size(100, 23);
            // 
            // y2ToolStripMenuItem
            // 
            this.y2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTXBCoordY2});
            this.y2ToolStripMenuItem.Name = "y2ToolStripMenuItem";
            this.y2ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.y2ToolStripMenuItem.Text = "Y2:";
            // 
            // toolStripTXBCoordY2
            // 
            this.toolStripTXBCoordY2.Name = "toolStripTXBCoordY2";
            this.toolStripTXBCoordY2.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItemPaint
            // 
            this.toolStripMenuItemPaint.Name = "toolStripMenuItemPaint";
            this.toolStripMenuItemPaint.Size = new System.Drawing.Size(181, 30);
            this.toolStripMenuItemPaint.Text = "Paint";
            this.toolStripMenuItemPaint.Click += new System.EventHandler(this.toolStripMenuItemPaint_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // mainColorToolStripMenuItem
            // 
            this.mainColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorToolStripMenuItem});
            this.mainColorToolStripMenuItem.Name = "mainColorToolStripMenuItem";
            this.mainColorToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.mainColorToolStripMenuItem.Text = "Main color";
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            this.chooseColorToolStripMenuItem.Size = new System.Drawing.Size(195, 30);
            this.chooseColorToolStripMenuItem.Text = "Choose color";
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.chooseColorToolStripMenuItem_Click);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorToolStripMenuItem1});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            // 
            // chooseColorToolStripMenuItem1
            // 
            this.chooseColorToolStripMenuItem1.Name = "chooseColorToolStripMenuItem1";
            this.chooseColorToolStripMenuItem1.Size = new System.Drawing.Size(195, 30);
            this.chooseColorToolStripMenuItem1.Text = "Choose color";
            this.chooseColorToolStripMenuItem1.Click += new System.EventHandler(this.chooseColorToolStripMenuItem1_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCMBWidth});
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.widthToolStripMenuItem.Text = "Width";
            // 
            // toolStripCMBWidth
            // 
            this.toolStripCMBWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.toolStripCMBWidth.Name = "toolStripCMBWidth";
            this.toolStripCMBWidth.Size = new System.Drawing.Size(121, 23);
            this.toolStripCMBWidth.Text = "1";
            this.toolStripCMBWidth.SelectedIndexChanged += new System.EventHandler(this.toolStripCMBWidth_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(80, 1039);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1844, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatusBarLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widthToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCMBWidth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripCMBMouse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox toolStripCMBCoordinates;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTXBCoordX1;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTXBCoordY1;
        private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTXBCoordX2;
        private System.Windows.Forms.ToolStripMenuItem y2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTXBCoordY2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaint;
        private System.Windows.Forms.ColorDialog CMBMainColorDialog;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog CMBBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

