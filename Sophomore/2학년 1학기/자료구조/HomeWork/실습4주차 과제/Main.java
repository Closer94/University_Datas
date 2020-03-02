import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		int[] a = new int[100];
		int key;
		int index;

		for (int i = 1; i <= 100; i++) {
			a[i - 1] = i;
		}
		System.out.println("0부터 100까지 찾을 숫자를 입력하세요:");
		key = sc.nextInt();

		Binary find = new Binary();
		index = find.search(a, key);
		if (index >= 0) {
			System.out.println("찼았다!! 요놈!! 위치: a [" + index + "] 에 있습니다.");
		} else {
			System.out.println("0부터 100까지의 범위의 값을 입력하지 않았습니다. ");
		}
	}
}