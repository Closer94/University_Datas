import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int count;

		System.out.println("How many data?");
		count = sc.nextInt();

		List list = new List(count);
		list.input();
	}
	
	
}
