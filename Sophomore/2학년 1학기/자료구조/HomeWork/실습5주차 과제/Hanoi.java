import java.util.Scanner;

public class Hanoi {
	public void hanoi(int n, char a, char b, char c) {
		if (n == 1) {
			System.out.println(n + "번째 원반을 " + a + "에서 " + c + "로 이동");
		} else {
			hanoi(n - 1, a, c, b);
			System.out.println(n + "번째 원반을" + a + "에서" + c + "로 이동");
			hanoi(n - 1, b, a, c);
		}
	}

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int n;

		System.out.print("몇개의 탑을 생성할것입니까?");
		n = sc.nextInt();
		Hanoi ex = new Hanoi();
		ex.hanoi(n, 'A', 'B', 'C');
	}
}

// 하노이 공략!!

// 처음 기준(3 A B C)으로 A -> B(첫번째 -> 두번째), B -> C(두번째 -> 세번째)로 계속 바뀐다
// 3 A B C 기준으로 A는 이동할 대상 C는 이동할 목표로 정하고, 2번째 탑을 움직이는 예를 들어보자
// 무조건 첫 -> 둘, 둘 -> 셋 이므로 3 A B C 에서 첫 -> 둘 은 2 A C B, 둘 -> 셋 은 2 B A C 이다.
// 2 A C B 에서는 첫 -> 둘 은 1 A B C 이고 둘 -> 셋 은 1 C A B 이다.
// 가장 중요한건  "3 A B C 기준으로 A는 이동할 대상 C는 이동할 목표" 인것이다. 그 후 첫둘, 둘셋이다.