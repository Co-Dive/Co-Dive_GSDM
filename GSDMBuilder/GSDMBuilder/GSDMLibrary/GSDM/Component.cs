/******************************************************************************

	FILE : Component.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Class for Component.

******************************************************************************/
using GSDMLibrary.GSDM.Core.Semantics;
using GSDMLibrary.GSDM.Core.Structures;
using GSDMLibrary.GSDM.Core.Geometries;

using System.Collections.Generic;

namespace GSDMLibrary.GSDM
{
    public class Component
    {
        public Semantic semantics;
        public Geometry geometry;
        public Structure structure;

        public Component(string name)
        {
            this.semantics = new Semantic(name);
        }
    }
}
