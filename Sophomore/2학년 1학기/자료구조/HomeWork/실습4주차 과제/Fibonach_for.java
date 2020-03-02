import java.util.Scanner;

public class Fibonach_for {
	public static void main(String[] args) {
		int num;

		Scanner sc = new Scanner(System.in);

		System.out.println("정수를 입력하세요: ");
		num = sc.nextInt();
		System.out.println("결과값: " + fib(num));
	}

	public static int fib(int n) {
		int f_val = 0, s_val = 1;
		int result = 0;
		if (n == 0)
			return 0;
		else if (n == 1)
			return 1;
		else {
			for (int i = 2; i <= n; i++) {
				result = f_val + s_val;
				f_val = s_val;
				s_val = result;
			}
			return result;
		}
	}
}
