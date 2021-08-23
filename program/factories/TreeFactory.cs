using System;
using program.entities;

namespace program.factories
{
    public static class TreeFactory
    {
        public static TreeNode<string> GetForProblem1()
        {
            var root = new TreeNode<string>("root");
            {
                TreeNode<string> node0 = root.AddChild("yellow-1");
                TreeNode<string> node1 = root.AddChild("red-1");
                TreeNode<string> node2 = root.AddChild("yellow-2");
                {
                    TreeNode<string> node21 = node2.AddChild("yellow-2.1");
                    {
                        TreeNode<string> node210 = node21.AddChild("yellow-2.1.0");
                        TreeNode<string> node211 = node21.AddChild("yellow-2.1.1");
                    }
                }
                TreeNode<string> node3 = root.AddChild("orange-3");
                {
                    TreeNode<string> node31 = node3.AddChild("orange-3.1");
                    TreeNode<string> node32 = node3.AddChild("orange-3.2");                    
                    TreeNode<string> node33 = node3.AddChild("orange-3.2");                    
                }
                TreeNode<string> node4 = root.AddChild("red-2");                
            };

            return root;
        }

        public static TreeNode<int> GetForProblem3()
        {
            var root = new TreeNode<int>(0);
            {
                TreeNode<int> node2 = root.AddChild(0);
                {
                    TreeNode<int> node21 = node2.AddChild(6);
                    TreeNode<int> node210 = node21.AddChild(3);
                    TreeNode<int> node211 = node21.AddChild(13);                    
                    TreeNode<int> node212 = node2.AddChild(1);
                }
                TreeNode<int> node3 = root.AddChild(0);
                {
                    TreeNode<int> node30 = root.AddChild(11);
                    TreeNode<int> node31 = node3.AddChild(21);
                    TreeNode<int> node32 = node3.AddChild(2);                    
                    TreeNode<int> node33 = node3.AddChild(12);                    
                }                
            };

            return root;
        }
    }
}