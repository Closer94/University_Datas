import java.util.Scanner;

public class Common {
	public static void main(String[] args) {
		int a, b, max, min;

		Scanner sc = new Scanner(System.in);
		System.out.println("두개의 정수를 입력하세요: ");
		a = sc.nextInt();
		b = sc.nextInt();
		max = Big(a, b);
		System.out.println(a + " 와 " + b + "의 최대공약수: " + max);
		min = Small(a, b, max);
		System.out.println(a + " 와 " + b + "의 최소공배수: " + min);
	}

	public static int Big(int a, int b) {
		if (a > b) {
			if (b == 0)
				return a;

			return Big(b, a % b);
		} else {
			if (a == 0)
				return b;
			return Big(a, b % a);
		}
		// 호제법
		// 192 72 의 최대공약수
		// 192 = 72*2 + 48
		// 72 = 48*1 + 24
		// 48 = 24*2 +0
		// b가 0 이니까 stop a는 최대공약수 24

	}

	public static int Small(int a, int b, int max) {
		return max * (a / max) * (b / max);
	}
	// 최대공약수를 알때 최소공배수를 구하는 방법
	// 최대공약수*(첫번째 입력 수/최대공약수)*(두번째 입력 수/최대공약수 )= 최소공배수
}
