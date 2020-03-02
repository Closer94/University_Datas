
public class listQueueMain {
	public static void main(String[] args) {
		listQueue q1 = new listQueue();
		q1.enqueue(10);
		q1.enqueue(20);
		q1.enqueue(30);
		q1.dequeue();
		q1.dequeue();
		q1.peek();
		q1.dequeue();
	}
}
