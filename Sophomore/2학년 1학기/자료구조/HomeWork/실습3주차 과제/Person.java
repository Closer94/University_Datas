import java.util.Scanner;

public class Person {

	String name = null;
	int num = 0;
	int max = 0;

	public Person(int max) { // main에서 받은 max값 생성자
		this.max = max;
	}

	public void insert(List[] list) {
		Scanner sc = new Scanner(System.in);
		for (int i = 0; i < max; i++) {
			list[i] = new List(); // 리스트의 값을 넣어줄 객체를 생성
			System.out.println(i + "번째 학생의 이름:");
			name = sc.next(); // 학생이름 저장
			System.out.println(i + "번째 학생의 학번은:");
			num = sc.nextInt(); // 학생학번 저장

			list[i].setValue(name, num); // List에 있는 setValue()에 이름과 학번을 저장시킴.
		}
	}

	public void prt(List[] list) {
		System.out.println("저장된 학생 명단");
		for (int i = 0; i < max; i++) {
			System.out.println(i + "번째 학생의 이름: " + list[i].getName() + " 학번: " + list[i].getNum());
			// setValue을 통해 List에 저장된 이름과 학번을 불러옴.
		}
	}
}
