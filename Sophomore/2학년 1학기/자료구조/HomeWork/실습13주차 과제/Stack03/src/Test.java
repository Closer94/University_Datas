
public class Test {
	public static void main(String[] args) {
		Formula op = new Formula();
		String exp = "{(A+B)-3}*5+[{cos(x+y)+7}]";
		System.out.println(exp);
		
		if(op.testPair(exp) == true)
		{
			System.out.println("수식이 올바름");
		}
		else
		{
			System.out.println("수식이 올바르지 않음");
		}
	}
}
