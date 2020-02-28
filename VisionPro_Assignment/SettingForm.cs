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
        private static PMAlignPattern pattern = new PMAlignPattern();

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


        private void PMAlignEnableChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PMAlignEnableChkBox.Checked)
            {
                pattern.PMAlignEnable = true;
            }else
            {
                pattern.PMAlignEnable = false;
            }
        }

        private void patternTrainRegionBtn_Click(object sender, EventArgs e)
        {
            pattern.SetTrainRegion(5);
        }

        private void patternSearchRegionBtn_Click(object sender, EventArgs e)
        {

        }

        private void pRegionShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
