
public class Binary {

	public int search(int a[], int key) {
		return binarySearch(a, key, 0, a.length - 1);
	}

	private int binarySearch(int a[], int key, int left, int right) {
		int mid = 0;
		if (key > a.length || key < 0) {
			return -1;
		} else {
			if (left < right) {

				mid = (left + right) / 2;
				System.out.println("left: " + a[left] + " right:  " + a[right] + " mid : " + a[mid]);
				if (key == a[mid]) {
					return mid;
				} else if (key == a[left]) {
					return left;
				} else if (key == a[right]) {
					return right;
				} else if (key < a[mid]) {
					return binarySearch(a, key, left, mid - 1);
				} else if (key > a[mid]) {
					return binarySearch(a, key, mid + 1, right);
				}
			}
			return 0;
		}
	}
}
// 질문
// 54나 어떤 특정한 부분의 값은 결과를 못찾는데 어떻게 수정해야하나요?
