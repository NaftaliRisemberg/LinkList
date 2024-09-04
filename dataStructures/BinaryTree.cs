using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
	public class BinaryTree
	{
		private TreeNode root;
		public BinaryTree() 
		{
			root = null;
		}	

		public void Insert(int value)
		{
			root = InsertRecursive(root, value);
		}
		private TreeNode InsertRecursive(TreeNode node, int value)
		{
			if (node == null)
			{
				node = new TreeNode(value);
				return node;
			}
			if (value < node.Value)
			{
				node.Left = InsertRecursive(node.Left, value);	
			}
			if (value > node.Value)
			{
				node.Right = InsertRecursive(node.Right, value);
			}
			return node;
		}
			
	}
}
			

