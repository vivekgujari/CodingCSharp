using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public partial class BinaryTree
    {

        public TreeNode root;

        public void insert(int item)
        {
            if (this.root == null)
            {
                this.root = new TreeNode(item);
                return;
            }

            TreeNode temp = this.root;
            while (temp != null)
            {
                if (temp.value > item)
                {
                    if (temp.LeftChild == null)
                    {
                        temp.LeftChild = new TreeNode(item);
                        break;
                    }
                    else
                    {
                        temp = temp.LeftChild;
                    }
                }
                else
                {
                    if (temp.RightChild == null)
                    {
                        temp.RightChild = new TreeNode(item);
                        break;
                    }
                    else
                    {
                        temp = temp.RightChild;
                    }
                }
            }
        }

        public void invert()
        {
            this.root = invert(this.root);
        }

        private TreeNode invert(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode left = invert(root.LeftChild);
            TreeNode right = invert(root.RightChild);

            root.LeftChild = right;
            root.RightChild = left;

            return root;
        }
    }
}
