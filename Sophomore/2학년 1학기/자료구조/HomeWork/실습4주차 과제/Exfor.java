public class Exfor {
	public static void main(String[] args) {
		int i = 5;
		print(i);
	}

	public static void print(int i) {
		// case 1
		for (int j = 1; j <= i; j++) {
			System.out.println(j);
		}

		// case 2
		for (int k = i; k > 0; k--) {
			System.out.println(k);
		}
	}
}
