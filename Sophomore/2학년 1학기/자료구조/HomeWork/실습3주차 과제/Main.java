import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		int max;
		System.out.println("학생 정보를 저장할 공간이 몇 개 필요합니까?");
		max = sc.nextInt();

		List list[] = new List[max]; // list 배열 객체 생성
		Person per = new Person(max); // per 객체 생성

		per.insert(list); // per의 insert 메소드에 리스트를 넣어줌
		per.prt(list); // per의 리스트에 저장되 있는 값들을 프린트 해줌.
	}
}
