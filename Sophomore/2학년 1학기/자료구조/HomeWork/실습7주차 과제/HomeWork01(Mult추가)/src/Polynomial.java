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
		size++; // size = size + 1;
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
				if (i > 1)
					System.out.print("+");
			}
		}
		System.out.println(" ");
	}

	public void addEO(Polynomial p1) {
		int result[] = new int[100];
		System.out.println("µ¡¼À °á°ú: ");
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
			System.out.println("");
		}
	}

	public void mult(Polynomial p1) {
		int result[] = new int[100];
		int temp[] = new int[100];

		int jisu;
		int gesu;
		int muldegree = 0;

		System.out.println("°ö¼À°á°ú: ");
		if (degree >= p1.degree) {
			for (int i = degree; i >= 0; i--) {
				for (int j = p1.degree; j >= 0; j--) {
					jisu = i + j;
					if (jisu > muldegree)
						muldegree = jisu;
					gesu = arr[i] * p1.arr[j];
					temp[jisu] = gesu;
				}
				for (int k = muldegree; k >= 0; k--) {
					result[k] = temp[k] + result[k];
				}
				temp = new int[100]; // ¹è¿­ÀÇ ÃÊ±âÈ­
			}
			for (int l = muldegree; l >= 0; l--) {
				if (result[l] != 0) {
					System.out.print(result[l] + "[" + l + "]");
					if (l > 1)
						System.out.print("+");
				}
			}
		} else if (p1.degree >= degree) {
			for (int i = p1.degree; i >= 0; i--) {
				for (int j = degree; j >= 0; j--) {
					jisu = i + j;
					if (muldegree < jisu)
						muldegree = jisu;
					gesu = p1.arr[i] * arr[j];
					temp[jisu] = gesu;
				}
				for (int k = muldegree; k >= 0; k--) {
					result[k] = result[k] + temp[k];
				}
				temp = new int[100];
			}
			for (int l = muldegree; l >= 0; l--) {
				if (result[l] != 0) {
					System.out.print(result[l] + "[" + l + "]");
					if (l > 1)
						System.out.print("+");
				}
			}
		}
	}

}
