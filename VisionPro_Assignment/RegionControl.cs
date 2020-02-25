using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cognex.VisionPro;
using Cognex.VisionPro.Display;

namespace VisionPro_Assignment
{
    class RegionControl
    {

        private static CogCircle circle = new CogCircle();
        private static CogEllipse ellipse = new CogEllipse();
        private static CogPolygon polygon = new CogPolygon();
        private static CogRectangle rectangle = new CogRectangle();
        private static CogRectangleAffine rectangleAffine = new CogRectangleAffine();
        private static CogCircularAnnulusSection circularAnnulusSection = new CogCircularAnnulusSection();
        private static CogEllipticalAnnulusSection ellipticalAnnulusSection = new CogEllipticalAnnulusSection();


        private static ICogGraphicInteractive graphicInteractive = null;

        private CogDisplay cDisplay = null;

        public void GraphicInteractiveControl(CogDisplay display, RegionConstants type)
        {
            cDisplay = display;

            switch (type)
            {
                case RegionConstants.Circle:
                    graphicInteractive = circle;
                    circle.GraphicDOFEnable = CogCircleDOFConstants.All;
                    circle.Interactive = true;
                    //circle.LineStyle = CogGraphicLineStyleConstants.Solid;
                    circle.DragLineStyle = CogGraphicLineStyleConstants.Solid;
                    circle.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;
                    circle.MouseCursor = CogStandardCursorConstants.ManipulableGraphic;
                    break;
                case RegionConstants.Ellipse:
                    graphicInteractive = ellipse;
                    ellipse.GraphicDOFEnable = CogEllipseDOFConstants.All;
                    ellipse.Interactive = true;
                    ellipse.LineStyle = CogGraphicLineStyleConstants.Solid;
                    break;
                case RegionConstants.Polygon:
                    graphicInteractive = polygon;
                    polygon.GraphicDOFEnable = CogPolygonDOFConstants.All;
                    polygon.Interactive = true;
                    polygon.LineStyle = CogGraphicLineStyleConstants.Solid;
                    break;
                case RegionConstants.Rectangle:
                    break;
                case RegionConstants.RectangleAffine:
                    break;
                case RegionConstants.CircularAnnulusSection:
                    break;
                case RegionConstants.EllipticalAnnulusSection:
                    break;
                case RegionConstants.None:
                    break;
                default:
                    break;

            }

            graphicInteractive.DragLineStyle = CogGraphicLineStyleConstants.Solid;
            //graphicInteractive.Interactive = true;
            //graphicInteractive.LineStyle = CogGraphicLineStyleConstants.Solid;
            //graphicInteractive.SelectedLineStyle = CogGraphicLineStyleConstants.Solid;

            cDisplay.InteractiveGraphics.Add(graphicInteractive, "", false);

        }






        public CogCircle Circle
        {
            get => circle;
            set => circle = value;
        }

        public CogEllipse Ellipse
        {
            get => ellipse;
            set => ellipse = value;
        }

        public CogPolygon Polygon
        {
            get => polygon;
            set => polygon = value;
        }

        public CogRectangle Rectangle
        {
            get => rectangle;
            set => rectangle = value;
        }

        public CogRectangleAffine RectangleAffine
        {
            get => rectangleAffine;
            set => rectangleAffine = value;
        }

        public CogCircularAnnulusSection CircularAnnulusSection
        {
            get => circularAnnulusSection;
            set => circularAnnulusSection = value;
        }

        public CogEllipticalAnnulusSection EllipticalAnnulusSection
        {
            get => ellipticalAnnulusSection;
            set => ellipticalAnnulusSection = value;
        }

    }
}
