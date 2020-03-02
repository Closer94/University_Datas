
public class Main {

	public static void main(String[] args) {
		Test op = new Test();
		String exp = "A+(B*C+E)/F-G";
		System.out.println(exp);

		System.out.println("===후위연산자===");
		op.testPair(exp);

	}

}

