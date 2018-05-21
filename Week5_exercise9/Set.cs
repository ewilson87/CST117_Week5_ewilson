//Corrected by Evan Wilson

using System.Collections.Generic;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        //doesn't need return type, changed bool to void
        //public bool addElement(int val )
        public void addElement(int val)
        {
            //streamlined code to reflect void instead of bool
            //if (containsElement(val)) return false;
            //else
            //{
            //    elements.Add(val);
            //    return true;
            //}
            if (!containsElement(val))
            {
                elements.Add(val);              
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //prevented proper loop execution by always returning a value in first iteration
                //else return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        //method is never used
        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            //changed return to this from rhs
            //return rhs
            return this;
        }

        //new method to duplicate a Set to perform union on duplicate instead of original
        public Set DuplicateSet(Set A, Set _A)
        {
            for (int i = 0; i < A.elements.Count; i++)
            {
                _A.addElement(A.elements[i]);
            }    
            return _A;
        }
    }
}
