
public class PolynomialTest {
	public static void main(String[] args) {
		Polynomial p1 = new Polynomial();
		p1.addTerm(10, 3);
		p1.addTerm(2, 4);
		p1.addTerm(3, 2);
		p1.addTerm(4, 5);
		p1.addTerm(5, 0);
		System.out.println("======p1 다항식 출력======");
		p1.print();
		System.out.println("");
		System.out.println("노드가 비어 있습니까? : " + p1.isZero());
		System.out.println("=======지수 2 삭제========");
		p1.delete(2);
		System.out.println("======p1 다항식 출력=======");
		p1.print();
		System.out.println("");
		
		Polynomial p2 = new Polynomial();
		p2.addTerm(3, 4);
		p2.addTerm(3, 2);
		p2.addTerm(2, 3);
		
		System.out.println("======p2 다항식 출력======");
		p2.print();
		System.out.println("");
		System.out.println("=====p1+p2 결과 출력 =====");
		Polynomial result =	p1.polyAdd(p2);
		result.print();
		
	}
}
