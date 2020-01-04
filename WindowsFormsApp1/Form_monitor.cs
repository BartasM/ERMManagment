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
    public partial class Form_monitor : Form
    {
        public Form_monitor()
        {        
            InitializeComponent();
            this.ControlBox = false;
            textBox_tip.Text = "";
        }

        public void setLabelText(String value)
        {
            textBox_tip.Text = value;
        }

        public void setLabelTimeText(String min, String sec)
        {
            label_minutes.Text = min;
            label_secounds.Text = sec;
        }

    }
}
