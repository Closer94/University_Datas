
public class Formula {

	
	public boolean testPair(String data)
	{
		boolean result = true;
		int i = 0;
		char ch;
		Node stack = new Node();
		while(i < data.length())
		{
			ch = data.charAt(i); // 문자열을 문자로 나누어서 실시
			if(ch == '[')
			{
				stack.push(ch);
			}
			else if(ch == '{')
			{
				stack.push(ch);
			}
			else if(ch == '(')
			{
				stack.push(ch);
			}
			
			else if(ch == ']')
			{
				if(stack.pop() != '['){
					result = false;
					return result;
				}
			}
			else if(ch == '}')
			{
				if(stack.pop() != '{'){
					result = false;
					return result;
				}
			}
			else if(ch == ')')
			{
				
				if(stack.pop() != '('){
					result = false;
					return result;
				}
			}
			i = i + 1;
		}
		if(stack.top != null) // 만약에 스택에 괄호가 있는 경우에는 수식이 올바르지 않은 것이기 때문에 false를 리턴
		{
			return false;
			
		}
		return result;
	}
}
