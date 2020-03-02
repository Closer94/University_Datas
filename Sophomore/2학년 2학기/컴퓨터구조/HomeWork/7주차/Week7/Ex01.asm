.data
std_id: .asciiz "ID: "
std_ret: .asciiz "Your ID is: "

.text
.globl main

main:
	# system code 4: 문자열 찍어라.
	# $a0에 'std_id'을 가르킬 것이다.
	li $v0, 4
	la $a0, std_id
	syscall 
	
	# system code 5: 정수형으로 읽어라.
	# $v0은 값이 들어갈 것이다.
	li $v0, 5  
	syscall  
	
	#아래에 세개의 문장들을 같은 행동을 나타낸다.
	# $s1 == $v0 -- $s1 <- $v0 or $0
	# $s2 == $v0 -- $s2 <- $v0
	# $s3 == $v0 -- $s3 <- $v0 add $0
	#
	# 이 세 문장들은 $v0의 다른 레지스터들로 변경될 것이다. ($s1-$s3 각각)
	
	or $s1, $v0, $0 
	move $s2, $v0
	add $s3, $v0, $0
	
	# system code 4: 문자열로 찍어라.
	# $a0은 std_ret을 가르킬 것이다.
	li $v0, 4
	la $a0, std_ret
	syscall
	
	# system code 1: 정수형 값을 찍는다.
	# $a0은 $s1의 같은 값을 가질 것이다.
	li $v0, 1
	move $a0, $s1
	syscall
	
	# system code 10: 프로그램 종료
	li $v0, 10
	syscall