using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROJECT
{
    internal class Provider
    {
        private string name;
        private int founded;
        private List<Material> materials;

        public Provider()
        {
            name = "N/A";
            founded = 0;
            materials = null;
        }

        public Provider(string name, int founded, List<Material> materials)
        {
            this.name = name;
            this.founded = founded;
            this.materials = materials;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }

        public int Founded
        {
            get { return founded; }
            set
            {
                if (value != 0 && value >= 1600)
                {
                    founded = value;
                }
            }
        }

        public List<Material> Materials
        {
            get { return materials; }
            set
            {
                if (value != null)
                {
                    materials = value;
                }
            }
        }

        public override string ToString()
        {
            string mesaj = $"Provider name is {name} that is founded in {founded} and has the following materials: ";
            foreach(Material material in materials)
            {
                mesaj += material.ToString() + " ";
            }
            return mesaj;
        }

    }
}
