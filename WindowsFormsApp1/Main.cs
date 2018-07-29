using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        private Form01 _form01;
        private Form02 _form02;
        private Form03 _form03;

        public Main()
        {
            InitializeComponent();
        }

        private void form01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_form01 == null)
            {
                _form01            =  new Form01(this);
                _form01.MdiParent  =  this;
                _form01.FormClosed += new FormClosedEventHandler(form01_FormClosed);
                _form01.Show();
            }
            else _form01.Activate();
        }
        
        private void form02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_form02 == null)
            {
                _form02            =  new Form02();
                _form02.MdiParent  =  this;
                _form02.FormClosed += new FormClosedEventHandler(form02_FormClosed);
                _form02.Show();
            }
            else _form02.Activate();
        }

        private void form03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_form03 == null)
            {
                _form03            =  new Form03();
                _form03.MdiParent  =  this;
                _form03.FormClosed += new FormClosedEventHandler(form03_FormClosed);
                _form03.Show();
            }
            else _form03.Activate();
        }

        void form01_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form01 = null;
        }

        void form02_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form02 = null;
        }

        void form03_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form03 = null;
        }
    }
}
