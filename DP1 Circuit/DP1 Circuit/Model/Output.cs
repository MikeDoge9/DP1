using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Circuit.Model
{
    public class Output
    {
        public void Register() => NodeFactory.Register("OUTPUT", typeof(Output));
    }
}
