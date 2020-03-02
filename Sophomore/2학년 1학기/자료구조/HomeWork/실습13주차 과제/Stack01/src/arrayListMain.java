
public class arrayListMain {
	public static void main(String[] args) {
		int i;
		arrayStack stack1 = new arrayStack();
		
		stack1.push(10);
		System.out.println(stack1.isEmpty());
		stack1.push(20);
		stack1.push(30);
		stack1.push(40);
		
		System.out.println("가장 맨 위의 값: " + stack1.peek());
		
		System.out.println("======pop실행=======");
		for(i = 0; i < 5; i++)
		{
			System.out.println(stack1.pop());
		}
		System.out.println(stack1.isEmpty());
	}
}
