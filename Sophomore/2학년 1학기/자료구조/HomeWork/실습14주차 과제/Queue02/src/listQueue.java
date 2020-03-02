
public class listQueue {
	private listNode front, rear;
	
	public listQueue()
	{
		front = null;
		rear = null;
	}
	
	public void enqueue(int x)
	{
		listNode newNode = new listNode(x);
		
		if(front == null)
			front = rear = newNode;
		else
		{
			rear.link = newNode;
			rear = newNode;
		}
			
		
	}
	
	public void dequeue()
	{
		System.out.println(front.data);
		front = front.link;

	}
	
	public void peek()
	{
		System.out.println("가장 앞에있는 값: " + front.data);
	}
}
