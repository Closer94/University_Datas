public class Polynomial {
	private int MAX;
	private Term terms[];
	private int noOfTerms; // = size; 객체개수(= 원소개수)
	int degree; // 최고차항을 저장하는 변수

	public Polynomial() {
		int MAX = 10;
		terms = new Term[MAX];
		noOfTerms = 0;
		degree = 0;

	}

	public boolean ispZero() {
		if (noOfTerms > 0)
			return false;
		else
			return true;
	}

	public int maxJisu() {
		for (int i = 0; i < noOfTerms; i++) {
			if (degree < terms[i].getJisu())
				degree = terms[i].getJisu();
		}
		return degree;
	}

	public void addTerm(int gesu, int jisu) {
		terms[noOfTerms] = new Term(gesu, jisu);
		// terms 배열에 객체생성.
		noOfTerms = noOfTerms + 1;
	}

	public void delTerm(int jisu) {
		for (int i = 0; i < noOfTerms; i++) {
			if (terms[i].getJisu() == jisu) {
				terms[i].setJisu(0);
				terms[i].setGesu(0);
				for (int k = i + 1; k < noOfTerms; k++)
					terms[k - 1] = terms[k];
			}
		}

		noOfTerms = noOfTerms - 1;
	}

	public void Print() {
		for (int i = 0; i < noOfTerms; i++) {
			System.out.print(terms[i].getGesu() + "[" + terms[i].getJisu() + "]");
			if (i < noOfTerms - 1)
				System.out.print("+");
		}
		System.out.println("");
	}

	public int findIndex(int jisu) {
		for (int i = 0; i < noOfTerms; i++) {
			if (terms[i].getJisu() == jisu)
				return terms[i].getGesu();
		}
		return 0;
	}

	public int findNextIndex(int jisu) {
		for (int i = 0; i < noOfTerms; i++) {
			if (terms[i].getJisu() == jisu)
				return terms[i + 1].getJisu();
		}
		return 0;
	}

	public Polynomial polyAdd(Polynomial p) {
		int p1index = 0, p2index = 0, reindex = 0;
		Polynomial result = new Polynomial(); 
		while (p1index < noOfTerms && p2index < p.noOfTerms) {
			if (p.terms[p2index].getJisu() > terms[p1index].getJisu()) {
				result.terms[reindex] = new Term(p.terms[p2index].getGesu(), p.terms[p2index].getJisu());
				p2index++;
				reindex++;
			} else if (p.terms[p2index].getJisu() < terms[p1index].getJisu()) {
				result.terms[reindex] = new Term(terms[p1index].getGesu(), terms[p1index].getJisu());
				p1index++;
				reindex++;
			} else if (p.terms[p2index].getJisu() == terms[p1index].getJisu()) {
				result.terms[reindex] = new Term(terms[p1index].getGesu() + p.terms[p2index].getGesu(),
						p.terms[p2index].getJisu());
				p1index++;
				p2index++;
				reindex++;
			}
		}
		
		// 비교를 다하고 남은 값을 출력해주기 위해서 아래의 소스를 이용.
		// 예를 들면 위에 두개의 다항식을 비교하면 나중에는 3[0]만 남게되는데 그것을 출력하는 소스이다.
		
		if(terms[p1index] != null)
		{
			while(terms[p1index] != null)
			{
				result.terms[reindex] = new Term(terms[p1index].getGesu(), terms[p1index].getJisu());
				reindex++;
				p1index++;
			}
		}
		else if(p.terms[p2index] != null)
		{
			while(p.terms[p2index] != null)
			{
				result.terms[reindex] = new Term(p.terms[p2index].getGesu(), p.terms[p2index].getJisu());
				reindex++;
				p2index++;
			}
		}
		
		result.noOfTerms = reindex; // Polynomial 의 속성을 갖는 result에 noOfTerms도 값을
									// 지정해주어야만
									// Print할때 어디까지 출력을 할지 알 수 있다.
									// 그래서 result의 noOfTerms(result.noOfTerms)에
									// reindex를 넣어준다.

		return result;

	}

	public Polynomial Mult(Polynomial p) {
		Polynomial result = new Polynomial();
		Polynomial temp = new Polynomial();
		int teGesu, teJisu;
		for (int i = 0; i < noOfTerms; i++) {
			for (int j = 0; j < p.noOfTerms; j++) {
				teGesu = terms[i].getGesu() * p.terms[j].getGesu();
				teJisu = terms[i].getJisu() + p.terms[j].getJisu();
				temp.terms[j] = new Term(teGesu, teJisu);
			}
			temp.noOfTerms = p.noOfTerms;
			result = result.polyAdd(temp);
			}
		return result;
	}
}
