/******************************************************************************

	FILE : Semantic.cs
	AUTHOR  : Zongcheng.LI
	
	DATE OF DESIGN : 14/06/2013
	MODIFIED ON : 14/10/2013

	GOAL : Base Class for the Semantic.

******************************************************************************/
using System.Collections.Generic;

namespace GSDMLibrary.GSDM.Core.Semantics
{
    public class Semantic
    {
        public List<SName> names;

        public Semantic(string name, string domain = "")
        {
            names = new List<SName>();
            names.Add(new SName(name, domain));
        }
        public string firstName()
        {
            if (names != null)
                return names[0].name;
            else
                return "";
        }
        public bool add(string name, string domain = "")
        {
            if (names == null)
                names = new List<SName>();
            SName sname = new SName(name, domain);
            if (!names.Contains(sname))
            {
                names.Add(sname);
                return true;
            }
            else
                return false;
        }
        public bool add(SName sname)
        {
            if (names == null)
                names = new List<SName>();
            if (!names.Contains(sname))
            {
                names.Add(sname);
                return true;
            }
            else
                return false;
        }
        public bool remove(string name)
        {
            List<SName> removeNames = new List<SName>();
            if (names != null)
                for (int i = 0; i < names.Count; i++)
                    if (names[i].name == name)
                        removeNames.Add(names[i]);
            if (removeNames.Count == 0)
                return false;
            for (int j = 0; j < removeNames.Count; j++)
                names.Remove(removeNames[j]);
            return true;
        }
        public bool remove(string name, string domain)
        {
            if (names != null)
                for (int i = 0; i < names.Count; i++)
                    if (names[i].name == name && names[i].domain.name == domain)
                    {
                        names.Remove(names[i]);
                        return true;
                    }
            return false;
        }
        public bool remove(SName sname)
        {
            if (names != null)
                if (names.Contains(sname))
                {
                    names.Remove(sname);
                    return true;
                }
            return false;
        }
    }
    public class Domain
    {
        public string name;
        public Domain father;
        public Domain(string name)
        {
            this.name = name;
            this.father = null;
        }
        public void addFather(string name)
        {
            this.father = new Domain(name);
        }
        public void removeFather()
        {
            this.father = null;
        }
    }
    public class SName
    {
        public string name;
        public Domain domain;

        public SName(string name, string domain = "")
        {
            this.name = name;
            this.domain = new Domain(domain);
        }
    }
}
