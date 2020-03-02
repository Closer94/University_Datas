class Heap1 {
	int maxSize;
	int n;
	int heap[];

	Heap1() {
		maxSize = 50;
		n = 0;
		heap = new int[maxSize];		
	}
	
	void insertHeap(int item) {
		
	}

	Object deleteHeap() {
		
	}

	public void printHeap() {
		for (int i = 1; i <= n; i++) {
			System.out.print(heap[i] + "   ");
		}
		System.out.println();
	} // end printHeap()
}

public class HeapTest1 {
	public static void main(String[] args) {
		Heap1 hp = new Heap1();
		hp.insertHeap(18);
		hp.insertHeap(13);
		hp.insertHeap(5);
		hp.insertHeap(12);
		hp.insertHeap(8);
		hp.insertHeap(19);
		
		System.out.print("입력 된 값 : ");
		hp.printHeap();
		System.out.println("");

		boolean a = true;
		Object ob;
		while (a) {
			ob = hp.deleteHeap();
			if(ob != null){
				System.out.println("삭제 된 값 : " + ob);
				System.out.print("삭제 후 값 : ");
				hp.printHeap();
				System.out.println("");
			}
			else
				a = false;
		}
	}
}