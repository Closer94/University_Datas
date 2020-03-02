import java.util.Scanner;

public class Main {
	public static void main(String args[]) {
		Scanner sc = new Scanner(System.in);
		int max;

		System.out.println("배열의 크기 값을 입력하세요: ");
		max = sc.nextInt();
		Polynomial p1 = new Polynomial(max);
		Polynomial p2 = new Polynomial(max);

		p1.insert(0, 3);
		p1.insert(1, 5);
		p1.insert(5, 4);
		p1.isEmpty();
		System.out.println("length " + p1.length());
		System.out.println(p1.retrieve(5));
		p1.replace(2, 6);
		p1.insert(2, 1);
		System.out.println("length " + p1.length());
		p1.delete(1);
		System.out.println("length " + p1.length());
		System.out.println(p1.retrieve(2));

		p2.insert(10, 3);
		p2.insert(8, 5);
		p2.insert(5, 4);
		p2.insert(2, 2);
		p2.insert(0, 7);

		p1.Print();
		p2.Print();
		p2.addEO(p1);
	}

}
