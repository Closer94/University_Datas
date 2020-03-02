
public class Formula {
	
	public void testPair(String data)
	{
		Node stack = new Node();
		int i = 0;
		char ch;
		
		while(i < data.length())
		{
			ch = data.charAt(i);
			if(ch == '+')
			{
				stack.push(ch);
			}
			else if(ch == '-')
			{
				stack.push(ch);
			}
			else if(ch == '/')
			{
				stack.push(ch);
			}
			else if(ch == '*')
			{
				stack.push(ch);
			}
			else if(ch >= 'A' && ch <= 'Z')
			{
				System.out.print(ch);
			}
			
			if(ch == ')' || ch == '}' || ch == ']')
			{
				while(stack.top != null)
					System.out.print(stack.pop());

			}
			i = i+1;
		}
	}
	
	
}
