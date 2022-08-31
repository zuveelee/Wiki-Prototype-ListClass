using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki_Prototype_ListClass
{
    internal class Information : IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string description;
        //default constructor
        public Information()
        {
            
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetCategory()
        {
            return category;
        }
        public void SetCategory(string newCategory)
        {
            category = newCategory;
        }
        public string GetStructure()
        {
            return structure;
        }
        public void SetStructure(string newStructure)
        {
            structure = newStructure;
        }
        public string GetDescription()
        {
            return description;
        }
        public void SetDescription(string newDescription)
        {
            description = newDescription;
        }
        public int CompareTo(Information other)
        {
            return this.name.CompareTo(other.name);
        }




    }
}
