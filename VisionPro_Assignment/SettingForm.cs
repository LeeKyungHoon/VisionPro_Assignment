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
        Mainform main = null;

        #region Pattern Params

        private bool pEnable = true;
        private CogPMAlignPattern pattern = new CogPMAlignPattern();
        private CogPMAlignResult pResult = new CogPMAlignResult();
        private CogPMAlignRunParams pRunParams = new CogPMAlignRunParams();
        private RegionShape pTrainShape = new RegionShape();
        private ICogRegion pTrainRegionShape = null;

        #endregion


        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(Mainform f)
        {
            InitializeComponent();
            main = f;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            pTrainShape.NoneShape(main.Display.Image);
            pAdjustRegionShapeComboBox.SelectedIndex = 4;
            pSearchRegionShapeComboBox.SelectedIndex = 4;
        }

        private void pEanbleChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pEnableChkBox.Checked)
            {
                pEnable = true;
            }
            else
            {
                pEnable = false;
            }
        }

        private void pImageGrabBtn_Click(object sender, EventArgs e)
        {
            pattern.TrainImage = main.Display.Image;
        }

        private void pAdjustRegionBtn_Click(object sender, EventArgs e)
        {
            pTrainShape.GetShape(ref pTrainRegionShape, pAdjustRegionShapeComboBox.SelectedIndex);

            pTrainShape.DisplayGraphic(main.Display, pTrainRegionShape);

        }

        private void pRegisterBtn_Click(object sender, EventArgs e)
        {

        }

        private void pAdjustRegionShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(pTrainShape is null))
            {
                pTrainShape.GetShape(ref pTrainRegionShape, pAdjustRegionShapeComboBox.SelectedIndex);


              

            }

        }

        private void pSearchRegionShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
