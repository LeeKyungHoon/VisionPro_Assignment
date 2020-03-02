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
using Cognex.VisionPro.Display;

namespace VisionPro_Assignment
{
    public delegate void GraphicInteractiveEventHander(ICogGraphicInteractive graphicInteractive);

    public partial class SettingForm : Form
    {
        public GraphicInteractiveEventHander graphicInteractiveEvent;

        private static PMAlignPattern pattern = new PMAlignPattern();

        private static ICogImage _image = null;


        public SettingForm()
        {
            InitializeComponent();
        }

        public ICogImage SetImage
        {
            set => _image = value;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            pAdjustRegionShapeComboBox.SelectedIndex = 4;
        }

        private void pEanbleChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pEnableChkBox.Checked)
            {
                pattern.Enable = true;
            }
            else
            {
                pattern.Enable = false;
            }
        }

        private void pImageGrabBtn_Click(object sender, EventArgs e)
        {
            pattern.GrabImage = _image;
        }

        private void pAdjustRegionBtn_Click(object sender, EventArgs e)
        {
            pattern.GetShape(pAdjustRegionShapeComboBox.SelectedIndex);
            pattern.DisplayGraphic();
            graphicInteractiveEvent(pattern.GetGraphicInteractive);
        }

        private void pRegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void pAdjustRegionShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pSearchRegionShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
