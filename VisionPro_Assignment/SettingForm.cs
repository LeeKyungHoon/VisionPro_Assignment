using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.Display;

namespace VisionPro_Assignment
{
    public partial class SettingForm : Form
    {
        private static RegionControl rControl = new RegionControl();

        Mainform main = null;

        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(Mainform f)
        {
            InitializeComponent();
            main = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rControl.GraphicInteractiveControl(main.Diplay, RegionConstants.Circle);
        }
    }
}
