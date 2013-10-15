/******************************************************************************

	FILE : Geometry2D.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Classes for the 2D Geometries.

******************************************************************************/
using System.Collections.Generic;

namespace GSDMLibrary.GSDM.Core.Geometries.Geometry2D
{
    public class Pixel : Geometry
    {
        public float x;
        public float y;
        public Pixel(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Image2D : Geometry
    {
        public List<Pixel> nodes;
        public List<List<int>> contours;
        public Image2D()
        {

        }
    }
}
