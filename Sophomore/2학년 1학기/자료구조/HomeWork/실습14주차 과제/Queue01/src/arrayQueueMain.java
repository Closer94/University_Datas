
public class arrayQueueMain {
	public static void main(String[] args) {
		TestQ tq1 = new TestQ();
		tq1.enqueue(10);
		tq1.enqueue(20);
		tq1.enqueue(30);
		tq1.isEmpty();
		tq1.peek();
		tq1.dequeue();
		tq1.dequeue();
		tq1.remove();
		tq1.dequeue();
	}
}
