using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP1_Circuit.Model
{
    public class Node
    {
        public string Type;
        public List<Node> prev;
        public List<Node> next;
        public bool HasFired;

        public void Calculate()
        {
            
        }
    }
}
