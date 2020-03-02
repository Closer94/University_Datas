class Heap2 {
	int maxSize;
	int heap[];
	int n;

	Heap2() {
		maxSize = 50;
		heap = new int[maxSize];
		n = 0;
	}

	void makeTreeHeap(int H[], int cnt) {
		
	} //end makeTreeHeap()
}

public class HeapTest2 {
	public static void main(String[] args) {
		Heap2 hp2 = new Heap2();
		int a[] = {0,15,11,70,5,13,50}; //완전이진트리구현 0은 제외될 값
		System.out.println("완전이진트리의 값");
		for(int i = 1; i < a.length; i++){
			System.out.print(a[i]+" ");
		}
		System.out.println("\n");
		hp2.makeTreeHeap(a, a.length-1);
		
	}
}