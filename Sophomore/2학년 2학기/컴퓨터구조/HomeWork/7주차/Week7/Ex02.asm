.data
std_ask:	.asciiz "Name: "
std_ret:	.asciiz "Your name is "
std_name:	.space 20	# 버퍼를 비워둔다.

.text
.globl main
main:
	# system code 4: 문자열 프린트
	# $a0은 std_id 를 가르킬 것이다.
	li $v0, 4
	la $a0, std_ask
	syscall
	
	# $a0 std_name을 가르킬 것이다.
	# 우리는 오직 20바이트만 넣을 것이다(19 아스키 코드 문자)
	la $a0, std_name
	li $a1, 20
	
	# system code 8: 문자열 읽어라
	#
	# $a0 : 문자열을 저장할 주소
	# $a1 : 문자열 버퍼 길이
	li $v0, 8
	syscall
	
	# system code 4: 문자열 읽어라
	# $a0은 std_ret을 가르킬 것이다.
	li $v0, 4
	la $a0, std_ret
	syscall
	
	# system code 4: 문자열 읽어라
	# $a0은 std_name을 가르킬 것이다.
	li $v0, 4
	la $a0, std_name
	syscall
	
	# system code 10: 프로그램 종료
	li $v0, 10
	syscall
	