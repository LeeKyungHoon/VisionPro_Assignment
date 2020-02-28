using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;
using Cognex.VisionPro.Display;

namespace VisionPro_Assignment
{
    class RegionShape
    {

        private CogRectangle none = new CogRectangle();
        private CogCircle circle = new CogCircle();
        private CogEllipse ellipse = new CogEllipse();
        private CogPolygon polygon = new CogPolygon();
        private CogRectangle rectangle = new CogRectangle();
        private CogRectangleAffine rectangleAffine = new CogRectangleAffine();
        private CogCircularAnnulusSection circularAnnulusSection = new CogCircularAnnulusSection();
        private CogEllipticalAnnulusSection ellipticalAnnulusSection = new CogEllipticalAnnulusSection();

        public void NoneShape(ICogImage image)
        {
            none.SetXYWidthHeight(0, 0, image.Width, image.Height);
        }

        public void GetShape(ref ICogRegion shape, int idx)
        {
            switch (idx)
            {
                case 0:
                    shape = none;
                    break;
                case 1:
                    shape = circle;
                    break;
                case 2:
                    shape = ellipse;
                    break;
                case 3:
                    shape = polygon;
                    break;
                case 4:
                    shape = rectangle;
                    break;
                case 5:
                    shape = rectangleAffine;
                    break;
                case 6:
                    shape = circularAnnulusSection;
                    break;
                case 7:
                    shape = ellipticalAnnulusSection;
                    break;
            }
        }

        public void DisplayGraphic(CogDisplay display, ICogRegion shape)
        {
            ICogGraphicInteractive pTrainInteractive = null;

            pTrainInteractive = (ICogGraphicInteractive)shape;
            pTrainInteractive.DragLineStyle = CogGraphicLineStyleConstants.Solid;
            pTrainInteractive.LineStyle = CogGraphicLineStyleConstants.Solid;
            pTrainInteractive.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;
            pTrainInteractive.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
            pTrainInteractive.GraphicDOFEnableBase = CogGraphicDOFConstants.All;
            pTrainInteractive.Interactive = true;

            display.InteractiveGraphics.Clear();
            display.InteractiveGraphics.Add(pTrainInteractive, "", false);
        }


    }
}