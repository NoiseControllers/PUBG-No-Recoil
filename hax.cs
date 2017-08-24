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
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.MouseUpExt += GlobalHookMouseUpExt;

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }
        private bool _enabled = false;

        private int frequence = 0;

        private bool enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
            }
        }

        private void EnableNoRecoil()
        {
            int i = 0;
            while (i < 5)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 15);
                System.Threading.Thread.Sleep(25);
                i++;
            }
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (enabled) EnableNoRecoil();
        }

        private void GlobalHookMouseUpExt(object sender, MouseEventExtArgs e)
        {

        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            string key = e.KeyChar.ToString();
            if (key == "b" && !enabled)
            {
                enabled = true;
            } else if (key == "b" && enabled)
            {
                enabled = false;
            }
        }
    }
}
