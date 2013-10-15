/******************************************************************************

	FILE : Geometry3D.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Classes for the 3D Geometries.

******************************************************************************/
using System.Collections.Generic;
using System;

namespace GSDMLibrary.GSDM.Core.Geometries.Geometry3D
{
    public class Point3D : Geometry
    {
        public float x;
        public float y;
        public float z;
        public Point3D(float a = 0, float b = 0, float c = 0)
        {
            x = a;
            y = b;
            z = c;
        }
        public void Normalize()
        {
            float d = (float)Math.Sqrt(x * x + y * y + z * z);
            x = x / d;
            y = y / d;
            z = z / d;
        }
    }
    public class PointVector3D : Geometry
    {
        public Point3D point;
        public Point3D normal;
        public PointVector3D(Point3D point, Point3D normal)
        {
            this.point = point;
            this.normal = normal;
        }
    }
    public class Mesh3D : Geometry
    {
        public List<Point3D> nodes;
        public List<int> triangles;
        public bool single = true;
        public Mesh3D()
        {

        }
    }
}
