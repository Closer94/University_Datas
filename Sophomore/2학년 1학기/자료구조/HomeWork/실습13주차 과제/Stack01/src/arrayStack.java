
public class arrayStack {
	int max;
	int list[];
	private int top;
	
	public arrayStack(){
		max = 5;
		top = -1;
		list = new int[max];
	}
	
	public void push(int x)
	{
		top = top + 1;
		list[top] = x;
	}
	
	public int pop()
	{
		if(top == -1)
		{
			System.out.println("더이상 출력할 값이 없습니다.");
		}
		else{
			int result;
			result = list[top];
			top = top - 1;
			return result;
		}
		return -1;
	}
	
	public int peek()
	{
		return list[top];
	}
	
	public boolean isEmpty()
	{
		if(top == -1)
			return true;
		else
			return false;
	}
}
