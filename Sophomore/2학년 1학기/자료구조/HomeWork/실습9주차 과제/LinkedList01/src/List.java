
public class List {
	Node head; // 객체 생성안하고 Node head만 하면 그림으로 어떻게 되는지?

	public void addFirst(int val) {
		Node newNode = new Node(val);
		if (head == null) { // head 가 비어(null)있을떄
			head = newNode;
		} else {
			newNode.link = head;
			head = newNode;

		}
	}

	public void addLast(int val) {
		Node newNode = new Node(val);
		if (head == null) { 
			head = newNode;
		} else if (head != null) {
			Node temp;
			temp = head;
			while (temp.link != null) {
				temp = temp.link;
			}
			// while문이 끝나면 temp는 마지막을 Node를 가르키게 된다.
			// 마지막 Node의 링크에다가 newNode를 입력시켜준다.
			temp.link = newNode;
		}
	}

	public void Print() {
		Node temp = head; // Node라는 변수인 temp에 head에는 Node라는 객체를 갖고있으므로 
						 // Node temp = head를 하면 temp는 head를 값을 가르키게된다(reference)
		while (temp.link != null) {
			System.out.println(temp.data);
			temp = temp.link;
		}
		System.out.println(temp.data); // 여기에 temp는 증가만하고 출력을 못한 마지막 Node값이다.
									  //마지막 Node값까지 출력을 해주어야하기때문에 while문 밖에서 출력을 해준다.
	}

	public void Insert(Node p, int val) // 매개변수 Node p 인 이유는 head.link의 변수가 Node 객체임으로
	{
		Node newNode = new Node(val);
		if (p == null) {
			p.link = newNode;
		} else {
			newNode.link = p.link;
			p.link = newNode;
		}
	}

	public void Delete(Node p) {
		if (p.link == null) {
			System.out.println("삭제할 값이 없습니다.");
		} else {
			p.link = p.link.link;

		}
	}

	public static void main(String[] args) {
		List test = new List();
		test.addFirst(10); // head가 지정됨.
		test.addLast(20);
		test.addFirst(30);
		test.Print();
		System.out.println("");
		test.Insert(test.head.link, 40);
		test.Delete(test.head.link);
		test.Print();
	}
}
