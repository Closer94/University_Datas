
public class Test {
	public static void main(String[] args) {
		Formula op = new Formula();
		String exp = "((A*B)-(C/D))";
		System.out.println(exp);
		
		System.out.println("===후위연산자===");
		op.testPair(exp);
		
	}
}
