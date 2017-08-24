using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace NoRecoil
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;

        public Form1()
        {
            InitializeComponent();
        }
        private bool enabled = false;
        private bool _isShooting = false;
        
        private void EnableNoRecoil()
        {
            int y = Cursor.Position.Y;
            int x = Cursor.Position.X;
            int i = 1;

            while (i < 20)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 15);
                System.Threading.Thread.Sleep(25);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enable = false;
        }
    }
}
