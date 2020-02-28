using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cognex.VisionPro;

namespace VisionPro_Assignment
{
    class RegionShape
    {

        private CogCircle circle = null;
        private CogEllipse ellipse = null;
        private CogPolygon polygon = null;
        private CogRectangle rectangle = null;
        private CogRectangleAffine rectangleAffine = null;
        private CogCircularAnnulusSection circularAnnulusSection = null;
        private CogEllipticalAnnulusSection ellipticalAnnulusSection = null;


        public void SetTrainRegionShape(ref ICogRegion region, int idx)
        {
            switch (idx)
            {
                case 0:
                    break;
                case 1:
                    if (circle is null)
                    {
                        circle = new CogCircle();
                    }
                    region = circle;
                    break;
                case 2:
                    if (ellipse is null)
                    {
                        ellipse = new CogEllipse();
                    }
                    region = ellipse;
                    break;
                case 3:
                    if (polygon is null)
                    {
                        polygon = new CogPolygon();
                    }
                    region = polygon;
                    break;
                case 4:
                    if (rectangle is null)
                    {
                        rectangle = new CogRectangle();
                    }
                    region = rectangle;
                    break;
                case 5:
                    if (rectangleAffine is null)
                    {
                        rectangleAffine = new CogRectangleAffine();
                    }
                    region = rectangleAffine;
                    break;
                case 6:
                    if (circularAnnulusSection is null)
                    {
                        circularAnnulusSection = new CogCircularAnnulusSection();
                    }
                    region = circularAnnulusSection;
                    break;
                case 7:
                    if (ellipticalAnnulusSection is null)
                    {
                        ellipticalAnnulusSection = new CogEllipticalAnnulusSection();
                    }
                    region = ellipticalAnnulusSection;
                    break;
                default:
                    break;
            }

        }
    }
}