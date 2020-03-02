.data
  star: .asciiz "*"
  newLine: .asciiz "\n"
.text
.globl main

main:
	li $t0, 5 # n = 5 
	li $t1, 1 # i = 1
	li $t2, 1 # j = 1

loop1: #두번째 for문
	bgt $t2, $t1, loop2 #$t2(j) > $t1(i) 일때 loop2로 이동 
	
	li $v0, 4 #찍기위한 명령실행코드
	la $a0, star #q 별을 찍는다
	syscall
	
	addi $t2, $t2, 1 #j값 +1 증가
	j loop1 
	
loop2: #첫번째 for문
	beq $t1, $t0, finish # $t1(i) == $t0(n) 일때 finish로 이동
	
	li $v0, 4
	la $a0, newLine #새로운 줄로 넘어간다.
	syscall
	
	addi $t1, $t1, 1 #i값을 1증가
	addi $t2, $0, 1 #j값을 다시 1로 초기화(j = 1) 시켜준다.
	j loop1

finish:
	li $v0, 10
	syscall