using Laba2;
using System;
using System.Drawing;

namespace MVC
{
    public class AppView
    {
        private Form1 MainForm = null;
        public Graphics Graphics { get; set; }

        public AppView()
        {
            Graphics = null;
        }

        public Form1 GetMainForm()
        {
            return MainForm;
        }
        public void Update()
        {
            MainForm.Invalidate();
        }

        public void Initialize()
        {
            MainForm = new Form1();
            MainForm.SizeChanged += OnWindowSizeChanged;
            this.Graphics = MainForm.CreateGraphics();
        }

        public void OnWindowSizeChanged(object sender, EventArgs e)
        {
            if (this.Graphics != null)
            {
                this.Graphics.VisibleClipBounds.Inflate(new Size(MainForm.Width, MainForm.Height));
            }
        }

        public void CreateMenu()
        {
            MainForm.InitializeMenu();
        }
    }
}
