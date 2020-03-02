using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Exceptions;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.ToolGroup;

namespace VisionPro_Assignment
{
    class PMAlignPattern : RegionShape
    {
        #region Params
        private static bool pEnable = true;

        private CogPMAlignPattern pattern = new CogPMAlignPattern();
        private CogPMAlignRunParams pRunParams = new CogPMAlignRunParams();
        private CogPMAlignZoneAngle pZoneAngle = new CogPMAlignZoneAngle();
        private CogPMAlignZoneScale pZoneScale = new CogPMAlignZoneScale();
        private CogPMAlignResult pResult = new CogPMAlignResult();

        private static ICogRegion pSearchRegion = null;

        #endregion

        public bool Enable
        {
            get => pEnable;
            set => pEnable = value;
        }


        public ICogImage GrabImage
        {
            set => pattern.TrainImage = value;
        }

        public ICogRegion TrainRegion
        {
            set => pattern.TrainRegion = value;
        }

        public ICogRegion SearchRegion
        {
            set => pSearchRegion = value;
        }

        public void Train()
        {
            pattern.Train();
        }


    }
}
