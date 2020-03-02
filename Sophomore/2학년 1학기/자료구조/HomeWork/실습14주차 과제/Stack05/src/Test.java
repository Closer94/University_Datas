
public class Test {

	public void testPair(String exp) {
		Node stack = new Node();
		
		int i= 0;
		char ch;
		while (i < exp.length()) {

			ch = exp.charAt(i);

			if (ch == '(' || ch == '{' || ch == '[') 
				stack.push(ch);
			else if (ch == '+' || ch == '-') // + - 연산자가 들어갈때
			{ 
				if(stack.top != null && (stack.top.data == '*' || stack.top.data == '/')) // 만약 * 과 / 이 스택에 있으면 안에 있는 연산자는 모두 나온다.
				{
					while(stack.top != null && (stack.top.data != '(' && stack.top.data != '{' && stack.top.data != '['))
						System.out.print(stack.pop());
					
					stack.push(ch); //다 뺀 상태에 이제 push를 해준다.
				}
				else
					stack.push(ch);
			}
			else if (ch == '*' || ch == '/')
			{
				stack.push(ch);
			}
			else if (ch >= 'A' && ch <= 'Z')
				System.out.print(ch);
			else if (ch == ')' || ch == '}' || ch == ']')
			{
				while (stack.top.data != '(' && stack.top.data != '{' && stack.top.data != '[') { 
					System.out.print(stack.pop());
				}
				stack.pop();
			} 
			
			i = i + 1;
		}
		while (stack.top != null)
		{
			System.out.print(stack.pop());
		}
		
	}
}
