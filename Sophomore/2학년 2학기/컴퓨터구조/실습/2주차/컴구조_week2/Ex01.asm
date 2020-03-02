.text # 코드 세그먼트를 정의하는 것이다. 
.globl main # main함수를 선언하는 것이다.

main: # main함수.
	li $v0, 4 # $v0 레지스터에 4번 코드를 불러와라!
	la $a0, str # str의 주소를 $a0 레지스터에 불러와라! 
	syscall # $v0에 설정된 레지스터 값을 수행!
	
	li $v0, 10 # $v0 레지스터에 10번 코드를 불러와라!
	syscall # $v0에 설정된 레지스터 값을 수행!

.data # 프로그램에서 쓰일 데이터 부분을 지정해주는 것입니다.

str: .asciiz "Hello Computer Architecture !" # .asciiz는 아스키코드가 들어간다는 것을 알려주는 것이고,
                                             # 아스키코드가 들어가있는 값을 str로 정의를 하는 것이다.

											 # .asciiz 는 자료형, 뒤에는 데이터 값, str 은 자료형의 이름이다.

