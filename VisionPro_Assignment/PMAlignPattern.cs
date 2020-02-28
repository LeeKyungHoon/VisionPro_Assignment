using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
using Cognex.VisionPro.Blob;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.Caliper;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.ToolGroup;

namespace VisionPro_Assignment
{
    class PMAlignPattern
    {
        private bool pMAlignEnable = false;

        private RegionShape shape = new RegionShape();

        private CogPMAlignPattern pMAlignPattern = new CogPMAlignPattern();
        private CogPMAlignResult pMAlignResult = new CogPMAlignResult();
        private CogPMAlignRunParams pMAlignRunParams = new CogPMAlignRunParams();
        private CogPMAlignTool pMAlignTool = new CogPMAlignTool();

       




        public bool PMAlignEnable
        {
            get => pMAlignEnable;
            set => pMAlignEnable = value;
        }

        public void SetTrainRegion(int idx=0)
        {
            ICogRegion region = null;
            shape.SetTrainRegionShape(ref region, idx);
            pMAlignPattern.TrainRegion = region;
        }

        
    }
}
