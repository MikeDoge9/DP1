using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Circuit.Model
{
    public class NodeFactory
    {
        private static Dictionary<string, Type> nodes;


        public NodeFactory() => nodes = new Dictionary<string, Type>();

        public static void Register(string key, Type t)
        {
            nodes.Add(key, t);
        }
    }
}
