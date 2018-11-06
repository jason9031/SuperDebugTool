using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXBC.CP
{
    public partial class CMDTextBox : TextBox
    {

        public event Lib.ZxbcEvent.DataSendHandler DataSend;

        public CMDTextBox()
        {
            //InitializeComponent();
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
        }

        /*public CMDTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }*/

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!this.ReadOnly)
            {
                if (this.SelectionStart != this.Text.Length)
                {
                    this.SelectionStart = this.Text.Length;
                }
                if (DataSend(new UTF8Encoding().GetBytes(e.KeyChar.ToString())) == false)
                {
                    e.Handled = true;
                }
            }
        }

    }
}
