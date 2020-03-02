
public class BST 
{
	TreeNode root;
	public BST()
	{
		
	}
	public void insert(String x)
	{
		if(root == null)
		{
			TreeNode newNode = new TreeNode();
			newNode.data = x;
			newNode.left = null;
			newNode.right = null;
			
			root = newNode;
		}
		else
		{
			insertKey(root,x);
		}
	}
	public void insertKey(TreeNode subroot, String x)
	{
		if(subroot.data.compareTo(x) < 0)
		{
			if(subroot.right == null)
			{
				TreeNode newNode = new TreeNode();
				newNode.data = x;
				newNode.left = null;
				newNode.right = null;
				
				subroot.right = newNode;
			}
			else
			{
				insertKey(subroot.right, x);
			}
		}
		else if(subroot.data.compareTo(x) > 0)
		{
			if(subroot.left == null)
			{
				TreeNode newNode = new TreeNode();
				newNode.data = x;
				newNode.left = null;
				newNode.right = null;
				
				subroot.left = newNode;
			}
			else
			{
				insertKey(subroot.left, x);
			}
		}
	}
	public void inorderPrint()
	{
		inorder(root);
	}
	public void inorder(TreeNode Node1)
	{
		if(Node1 != null)
		{
			inorder(Node1.left);
			System.out.println(Node1.data);
			inorder(Node1.right);
		}
	}
}
