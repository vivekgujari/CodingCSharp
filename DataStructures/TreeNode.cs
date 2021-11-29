namespace Coding.DataStructures
{
    public partial class BinaryTree
    {
        public class TreeNode
        {
            public int value;
            public TreeNode LeftChild;
            public TreeNode RightChild;
            public TreeNode(int value)
            {
                this.value = value;
                LeftChild = null;
                RightChild = null;
            }

            public override string ToString()
            { 
                return "Node -> " + this.value;
            }
        }
    }
}
