using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form01 : Form
    {
        private readonly Main   _mdiParentForm;
        private          Form02 _form02;
        private          Form03 _form03;

        public Form01(Main mdiParentForm)
        {
            _mdiParentForm = mdiParentForm;
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            if (_form02 == null)
            {
                _form02            =  new Form02();
                _form02.MdiParent  =  _mdiParentForm;
                _form02.FormClosed += new FormClosedEventHandler(form02_FormClosed);
                _form02.Show();
            }
            else _form02.Activate();
        }

        private void btnOpenForm3_Click(object sender, EventArgs e)
        {
            if (_form03 == null)
            {
                _form03            =  new Form03();
                _form03.MdiParent  =  _mdiParentForm;
                _form03.FormClosed += new FormClosedEventHandler(form03_FormClosed);
                _form03.Show();
            }
            else _form02.Activate();
        }

        private void form02_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form02 = null;
        }

        private void form03_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form03 = null;
        }

        private void Form01_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form02.Close();
            _form03.Close();
        }
    }
}