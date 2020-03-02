import java.util.Scanner;

public class List {
	int count;

	public List(int count) { // »ı±âÈ­
		this.count = count;
	}

	public void input() {
		Scanner sc = new Scanner(System.in);
		String name[] = new String[count];

		for (int i = 0; i < count; i++) {
			System.out.print("[" + i + "]input data: ");
			name[i] = sc.next();
		}

		System.out.println("");

		for (int j = 0; j < count; j++) {
			System.out.println("[" + j + "] = " + name[j]);
		}
	}
}
