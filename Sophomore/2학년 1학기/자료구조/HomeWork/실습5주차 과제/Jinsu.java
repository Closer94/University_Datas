import java.util.Scanner;

public class Jinsu {
	public static void main(String[] args) {
		int num;
		int prt;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("2진수로 알고자하는 10진수의 값을 입력하세요:");
		num = sc.nextInt();
		System.out.print("[" + num + "]의 2진수 표현: ");
		jin(num);
	}
	
	public static int jin(int n)
	{
		int rest;
		
		if(n > 0){
		rest = n % 2;
		n = n / 2;
		jin(n);
		System.out.print(rest);
		}
		return 0;
	}
}