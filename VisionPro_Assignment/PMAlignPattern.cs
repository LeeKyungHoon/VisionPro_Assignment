﻿using System;
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
        private bool pAutoEdgeThresholdEnable = false;

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

        public bool PatternAutoEdgeThresholdEnable
        {
            get => pAutoEdgeThresholdEnable;
            set => pAutoEdgeThresholdEnable = value;
        }


        public void SetTrainRegion(int idx=4)
        {
            ICogRegion region = null;
            pMAlignPattern.TrainRegion = region;
        }
        public void AdjustRegion(CogDisplay display)
        {
            ICogGraphicInteractive InteractiveGraphic = (ICogGraphicInteractive)pMAlignPattern.TrainRegion;

            InteractiveGraphic.Interactive = true;
            InteractiveGraphic.DragLineStyle = CogGraphicLineStyleConstants.Solid;
            InteractiveGraphic.GraphicDOFEnableBase = CogGraphicDOFConstants.All;
            InteractiveGraphic.LineStyle = CogGraphicLineStyleConstants.Solid;
            InteractiveGraphic.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            InteractiveGraphic.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;

            display.InteractiveGraphics.Add(InteractiveGraphic, "", false);

        }
        
        public void TrainImageGrab(ICogImage image)
        {
            pMAlignPattern.TrainImage = image;
        }

        public void PatternTrain()
        {
            pMAlignPattern.Train();
        }

    }
}
