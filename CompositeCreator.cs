using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class CompositeCreator
    {

        public Composite CreateComposite(string option)
        {
            var options = option.Split(' ');
            ComparerCreator resultCompositeCreate = new ComparerCreator();
            Composite composite = new Composite();
            foreach (var item in options)
            {
                composite.AddComparer(resultCompositeCreate.CreateComparer(item));
            }
           
            return composite;

        }
    }
}

