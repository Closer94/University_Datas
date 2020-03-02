
public class BinaryTree {
	private TreeNode root;
	public TreeNode makenode(TreeNode leftv, int data, TreeNode rightv){
		TreeNode root = new TreeNode(data);
		root.left=leftv;
		root.right=rightv;
		return root;
	}
	public void preorder(TreeNode root){

	}
	public void postorder(TreeNode root){

	}
	public void inorder(TreeNode root){
		if(root!=null){
			inorder(root.left);
			System.out.print(root.data+", ");
			inorder(root.right);
		}
	}
}
