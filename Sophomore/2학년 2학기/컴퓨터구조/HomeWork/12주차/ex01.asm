.data
year: .word 0
askyear: .asciiz "Enter year: "
ansleap: .asciiz " is a leap year \n"
ansordi: .asciiz " is an ordinary year \n"

.text
.globl main

main:
	li $v0, 4 #문자열을 출력한다.
	la $a0, askyear #$a0에 askyear을 가르킬 것이다.
	syscall
	
	li $v0, 5 #정수값을 읽어온다.
	syscall
	sw $v0, year #$v0에 데이터 값을 year에 넣어준다.
	
	lw $t0, year #year에 있는 레지스터 값을 $t0에 넣어준다.
	li $t1, 4 #$t1에 정수 4를 넣어준다.
	div $t0, $t1 #$t0과 $t1을 나눈다.
	mfhi $t1 #$t1에 나눈 몫이 저장된다.
	bne $t1, $0, ordinary #$t1와 $0이 같다면 ordinary으로 이동
	
	li $t1, 100 #$t1에 100을 넣어준다.
	div $t0, $t1 #$t0과 $t1을 나눈다.
	mfhi $t1 #$t1에 나눈 몫이 저장된다.
	bne $t1, $0, leap #$t1와 $0이 같다면 leap으로 이동
	
	li $t1, 400 #$t1에 400을 넣어준다.
	div $t0, $t1 #$t0과 $t0을 나눈다.
	mfhi $t1 #$t1에 나눈 몫이 저장된다.
	bne $t1, $0, ordinary #$t1와 $0이 같다면 ordinary으로 이동
	
leap: 
	li $v0, 1 #정수형 값을 찍는다
	lw $a0, year #$a0에 year의 같은 값을 가질 것이다.
	syscall
	
	li $v0, 4 #문자열을 찍는다.
	la $a0, ansleap #$a0에 ansleap을 가르킬 것이다.
	syscall
	j finish #finish로 점프

ordinary:
	li $v0, 1 #정수형 값을 찍는다
	lw $a0, year #$a0에 year의 같은 값을 가질 것이다.
	syscall
	
	li $v0, 4 #문자열을 찍는다.
	la $a0, ansordi #$a0에 ansordi을 가르킬 것이다.
	syscall

finish: 
	j main #main으로 점프
	
	
	
	
	
	
	
	
	
	
	
	