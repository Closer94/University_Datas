
public class Node {
	char data;
	Node link;
	Node top;

	public Node() {
		this.data = '\0';
		this.link = null;
	}

	public Node(char data) {
		this.data = data;
		this.link = null;
	}

	public void push(char data) {
		Node newNode = new Node(data);

		if (top == null)
			top = newNode;
		else {
			newNode.link = top;
			top = newNode;
		}
	}

	public char pop() {
		if (top == null)
			return '\0';
		else {
			char result = top.data;
			top = top.link;
			return result;
		}
	}
}
