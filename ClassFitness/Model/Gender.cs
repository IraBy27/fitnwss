using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFitness.Model
{
    public class Gender
    {
        public string Name { get; }
        public Gender (string name)
        {
          if (string.IsNullOrWhiteSpace(name)) 
            { throw new ArgumentNullException("name is not null",nameof(name)); }
          Name= name;
        }
        public override string ToString()
        {
            return Name;

        }

    }
}
