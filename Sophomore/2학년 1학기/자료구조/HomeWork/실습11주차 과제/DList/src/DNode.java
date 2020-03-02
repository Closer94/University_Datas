
public class DNode {
	int data;
	DNode Pre_link;
	DNode Next_link;
	
	public DNode()
	{
		this.data = 0;
		Pre_link = null;
		Next_link = null;
	}
	
	public DNode(int val)
	{
		this.data = val;
		Pre_link = null;
		Next_link = null;
	}
}
