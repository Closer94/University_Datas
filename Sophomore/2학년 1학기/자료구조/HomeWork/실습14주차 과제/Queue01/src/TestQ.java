
public class TestQ {
	private int Qsize;
	private int arrayQ[];
	private int front, rear;
	private int cnt;
	public TestQ()
	{
		Qsize = 5;
		arrayQ = new int[Qsize];
		front = rear = 0;
		cnt = 0;
	}
	
	public void enqueue(int x)
	{
		if(cnt == Qsize)
		{
			System.out.println("배열이 다 찼습니다.");
		}
		else
		{
			arrayQ[rear] = x;
			rear = (rear + 1) % Qsize;
			cnt++;
		}
	}
	
	public int dequeue()
	{

		if(cnt == 0)
		{
			System.out.println("출력할값이 없습니다.");
		}
		else
		{
		int result = 0;
		result = arrayQ[front];
		front = (front + 1) % Qsize;
		cnt--;
		return result;
		}
		return -1;
	}
	
	public int peek()
	{
		if(front ==  null)
			System.out.println("출력할 값이 없습니다.");
		else
			return arrayQ[front];
	}
	

	
	public void isEmpty()
	{
		if(front == 0)
			System.out.println("비어있지 않습니다.");
		else
			System.out.println("비어있습니다.");
	}
}
