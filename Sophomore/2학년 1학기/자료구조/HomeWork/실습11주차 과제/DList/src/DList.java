
public class DList {

	DNode head;

	public void Insert(DNode p, int val) {
		DNode newNode = new DNode(val);

		if (head == null) { // 링크에 값이 아무것도 없을때
			head = newNode; // head에 새로운값을 넣는다
			head.Pre_link = head; // head의 이전주소값을 자기 자신을 가르치게 한다.
			head.Next_link = head; // head의 다음주소값을 자기 자신을 가르치게 한다. 왜냐면 원형의 특성을
									// 갖고 있으므로
		} 
		else if (p == null) { // p노드의 다음값에 노드를 추가하려고했는데 정작 p노드가 없을때
			p = newNode; // p에 새로운 값을 입력한다.
			p.Pre_link = head.Next_link; // p(새로운값)에 이전주소를 head의 다음주소를 가르키게 한다.
			p.Next_link = head; // p(새로운값)에 다음주소를 head를 가르키게한다.
			head.Next_link = p.Pre_link; // head의 다음주소에 p(새로운값)의 이전주소를 가르키게한다.
			head.Pre_link = p; // head의 이전주소는 p(새로운값)를 가르키게한다.

		}
		else if (p.rlink == head){
			newNode.rlink = p.rlink;
			p.rlink.llink = newNode;
			newNode.llink = p;
			p.rlink = newNode;
			

		}
		else {
			newNode.Next_link = p.Next_link; // 새로운 노드의 다음주소를 p의 다음값을 가르키게한다.
			newNode.Pre_link = p; // 새로운 노드의 이전주소에 p를 가르키게한다.
			p.Next_link.Pre_link = newNode; // newNode의 다음주소의 노드에서 이전 주소를 새로운 노드를
			// 가르키게한다.
			p.Next_link = newNode; // p의 다음주소를 새로운 노드를 가르키게 한다.
		}
	}

	public void Delete(DNode p) {
		if (p == null) { // 삭제할 노드 p가 없는 경우
			System.out.println("삭제할 값이 존재하지않습니다.");
		} else if (p == head) // 삭제할 노드 p가 head인 경우
		{
			head = p.Next_link; // head를 p의 다음주소의 노드로 변경한다.
			p.Next_link.Pre_link = p.Pre_link; // p의 다음주소의 노드의 이전주소를 헤드의
													// 이전주소를 넣어준다.
			p.Pre_link.Next_link = p.Next_link; // p의 이전주소의 노드의 다음주소를 p의 다음주소를
												// 넣어준다.

		} 
		else if (p.Next_link == head) // p의 넥스트링크가 헤드일때, => p가 마지막 노드일때
		{
			p.Pre_link.Next_link = head; // p의 이전주소의 노드의 다음주소를 head를 가르킨다.
			head.Pre_link = p.Pre_link; // head의 이전주소는 p의 이전주소를 넣어준다.
		} 
		else {
			p.Pre_link.Next_link = p.Next_link; // p의 이전주소의 노드에서 다음주소를 p의 다음주소를 넣어준다.
			p.Next_link.Pre_link = p.Pre_link; // p의 다음주소의 노드에서 이전주소에 p의 이전주소를 넣어준다.
		}
	}

	public void Print() {
		System.out.println("값 출력: ");
		if (head == null) {
			System.out.println("출력할 값이 없습니다.");
		} else {
			DNode p = head;
			while (p.Next_link != head) {
				System.out.println(p.data);
				p = p.Next_link;
			}
			System.out.println(p.data);
		}
		System.out.println("");
	}

	public static void main(String[] args) {
		DList dl = new DList();
		dl.Insert(dl.head, 10);
		dl.Insert(dl.head, 20);
		dl.Insert(dl.head.Next_link, 30);
		dl.Insert(dl.head.Next_link.Next_link, 40);
		dl.Print();
		System.out.println("Delete: " + dl.head.Next_link.data);
		dl.Delete(dl.head.Next_link);
		dl.Print();
	}
}
