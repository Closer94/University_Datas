public class Polynomial {
	int arr[];
	int max;
	int size;
	int degree;

	public Polynomial(int max) {
		this.max = max;
		arr = new int[max];
		size = 0;
		degree = 0;
	}

	public void isEmpty() {
		if (size > 0)
			System.out.println("it is not empty");
		else
			System.out.println("it is empty");
	}

	public int length() {
		return size;
	}

	public void insert(int jisu, int gesu) {
		arr[jisu] = gesu;
		size++; //size = size + 1;
		if (jisu > degree) {
			degree = jisu;
		}
	}

	public int retrieve(int jisu) {
		return arr[jisu];
	}

	public void replace(int jisu, int regesu) {
		arr[jisu] = regesu;
	}

	public void delete(int jisu) {
		arr[jisu] = 0;
		size = size - 1;
	}

	public void Print() {
		int i;
		for (i = degree; i >= 0; i--) {
			if (arr[i] != 0) {
				System.out.print(arr[i] + "[" + i + "]");
				if (i > 0)
					System.out.print("+");
			}
		}
		System.out.println(" ");
	}

	public void addEO(Polynomial p1) {
		int result[] = new int[100];

		System.out.println("add result: ");
		if (p1.degree > degree) {
			for (int i = 0; i <= p1.degree; i++) {
				result[i] = p1.arr[i] + arr[i];
			}
			for (int j = p1.degree; j >= 0; j--) {
				if (result[j] != 0) {
					System.out.print(result[j] + "[" + j + "]");
					if (j > 0) {
						System.out.print("+");
					}
				}
			}
		} else if (degree > p1.degree) {
			for (int i = 0; i <= degree; i++) {
				result[i] = arr[i] + p1.arr[i];
			}
			for (int j = degree; j >= 0; j--) {
				if (result[j] != 0) {
					System.out.print(result[j] + "[" + j + "]");
					if (j > 0) {
						System.out.print("+");
					}
				}
			}
		}
	}
}
