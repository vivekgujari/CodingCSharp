﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.DataStructures
{
    public class BinaryTree
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
