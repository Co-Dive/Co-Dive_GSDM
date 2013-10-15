/******************************************************************************

	FILE : Scene.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Class for the Scene.

******************************************************************************/

using GSDMLibrary.GSDM.Core.Semantics;
using GSDMLibrary.GSDM.Core.Structures;

using System.Collections.Generic;

namespace GSDMLibrary.GSDM
{
    public class Scene
    {
        public Semantic semantics;
        public List<Object> objects;
        public Structure structure;

        public Scene(string name)
        {
            this.semantics = new Semantic(name);
        }
    }
}
