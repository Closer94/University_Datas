
public class CList {
	CNode head;
	CNode tail;

	public void addFirst(int val) {
		CNode newNode = new CNode(val);
		
		if(tail == null)
		{
			tail = newNode;
			head = newNode;
		}
		else 
		{
			newNode.link = head;
			tail = head;
			head = newNode;
			tail.link = head;
		}
	}
	
	public int lengthC()
	{
		if(tail == null)
			return 0;
		else
		{
			int cnt = 1;
			CNode p = tail.link;
			while(p != tail)
			{
				p = p.link;
				cnt++;
			}
			return cnt;
		}
	}
	
	public void Print()
	{
		CNode p = head;
		System.out.println("리스트 데이터값: ");
		while(p != tail)
		{
			System.out.println(p.data);
			p = p.link;
		}
		System.out.println(p.data);
	}
	
	public void Insert(CNode p, int val)
	{
		CNode newNode = new CNode(val);
	
		if(p == null)
		{
			p = newNode;
			head = p;
			tail = p;
			p.link = head;
		}
		else if(p == tail)
		{
			p.link = newNode;
			newNode.link = head;
			tail = newNode; //중요!
		}
		else if(p != tail)
		{
			newNode.link = p.link;
			p.link = newNode;
		}
	}
	
	public static void main(String[] args) {
		CList cl = new CList();
		cl.addFirst(10);
		cl.Insert(cl.head, 20);
		cl.addFirst(30);
		System.out.println("리스트의 길이: " + cl.lengthC());
		cl.Print();
	}
}
