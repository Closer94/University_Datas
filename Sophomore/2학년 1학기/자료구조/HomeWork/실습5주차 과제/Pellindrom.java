import java.util.Scanner;

public class Pellindrom {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		String str;
		boolean result;
		int first, last;

		while (true) {
			System.out.print("문자를 입력하세요: ");
			str = sc.next();
			first = 0;
			last = str.length() - 1;
			result = play(first, last, str);
			if (result == true)
				System.out.println(str + "은 팰린드롬입니다.");
			else
				System.out.println(str + "은 팰린드롬이 아닙니다.");
		}
	}

	public static boolean play(int first, int last, String str) {

		if (first < last) {
			if (str.charAt(first) == str.charAt(last)) {

				return play(first + 1, last - 1, str);
			} else
				return false;
		} else
			return true;

	}

}
