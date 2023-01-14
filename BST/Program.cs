// See https://aka.ms/new-console-template for more information
using BST;


static void Insert(ref BinSTree? root, int data)
{
    if (root == null)
    {
        BinSTree node = new BinSTree(data);
        root = node;
        return;
    }

    if (root.data > data) Insert(ref root.left, data);
    else Insert(ref root.right, data);
}

static void printNodes(BinSTree? root)
{
    if (root == null) return;
    printNodes(root.left);
    Console.WriteLine(root.data);
    printNodes(root.right);
}

static bool Search(BinSTree? root, int val)
{
    if (root == null) return false;
    if (val == root.data) return true;
    if (val < root.data) Search(root.left, val);
    else if (val > root.data) Search(root.right, val);
    return false;
}
// Test code
BinSTree? root = new(1);
for (int i = 0; i < 100; i++)
{
    Insert(ref root, i*i*i);
}


Console.WriteLine(Search(root, 8));
