﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMediaExample
{
    public partial class Form1 : Form
    {
        // Drag Window Panel
        private bool draggable;
        private int mouseX;
        private int mouseY;

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState.ToString() == "Maximized")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // Drag Window
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            draggable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggable)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }
        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            draggable = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            btnQuitar.Visible = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
