/******************************************************************************

	FILE : Object.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Class for the object in the Scene.

******************************************************************************/
using GSDMLibrary.GSDM.Core.Semantics;
using GSDMLibrary.GSDM.Core.Structures;

using System.Collections.Generic;

namespace GSDMLibrary.GSDM
{
    public class Object
    {
        public Semantic semantics;
        public List<Component> components;
        public Structure structure;

        public Object(string name)
        {
            this.semantics = new Semantic(name);
        }
    }
}
