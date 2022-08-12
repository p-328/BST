using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BinSTree
    {
        public int data;
        public BinSTree? right;
        public BinSTree? left;

        public BinSTree(int data)
        {
            this.data = data;
            right = null;
            left = null;
        }
    }
    
}
