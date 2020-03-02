import java.util.Scanner;

public class Fibonachi {
	public static void main(String[] args) {
		int num;

		Scanner sc = new Scanner(System.in);

		System.out.print("정수를 입력하세요:");
		num = sc.nextInt();
		System.out.println("결과값: " + fib(num));
	}

	public static int fib(int n) {
		int result;

		if (n == 0)
			return 0;
		if (n == 1)
			return 1;

		result = (fib(n - 1) + fib(n - 2));
		return result;

	}
}
