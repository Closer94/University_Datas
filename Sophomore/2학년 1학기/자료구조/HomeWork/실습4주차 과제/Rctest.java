
public class Rctest {
	public static void main(String[] args) {
		int i = 5;
		print(i);
	}
	public static int print(int i)
	{
		if(i >= 1)
		{
			System.out.println(i);
			return print(i-1);
		}
		else 
			return 0;
	}
}
