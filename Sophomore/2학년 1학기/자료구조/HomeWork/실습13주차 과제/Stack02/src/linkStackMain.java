
public class linkStackMain {
	public static void main(String[] args) {
		linkStack stack2 = new linkStack();
		stack2.push(10);
		System.out.println(stack2.isEmpty());
		stack2.push(20);
		stack2.push(30);
		System.out.println(stack2.pop());
		System.out.println(stack2.pop());
		System.out.println(stack2.pop());
		System.out.println(stack2.pop());
		System.out.println(stack2.isEmpty());
	}
}
