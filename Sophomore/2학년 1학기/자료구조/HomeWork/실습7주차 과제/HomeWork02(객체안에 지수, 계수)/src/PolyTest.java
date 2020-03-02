
public class PolyTest {
	public static void main(String[] args) {
		Polynomial p1 = new Polynomial();
		p1.addTerm(6, 4);
		p1.addTerm(2, 3);
		p1.addTerm(3, 0);
		System.out.println("첫번째 다항식");
		p1.Print();
		
		Polynomial p2 = new Polynomial();
		p2.addTerm(2, 4);
		p2.addTerm(4, 2);
		p2.addTerm(2, 1);
		System.out.println("두번째 다항식");
		p2.Print();
		
		Polynomial r = p1.polyAdd(p2);
		System.out.println("첫번째 다항식과 두번째 다항식의 합");
		r.Print();
		r = p1.Mult(p2);
		System.err.println("첫번째 다항식과 두번째 다항식의 곱");
		r.Print();
		
	}

}
