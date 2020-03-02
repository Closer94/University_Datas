.data
  star: .asciiz "*"
  newLine: .asciiz "\n"
  sapce: .asciiz " "
.text
.globl main

main:
	li $t0, 5 # n = 5
	li $t1, 0 # i = 0
	li $t2, 0 # j = 0
	li $t8, 0 # k = 0
	li $t9, 0 # m = 0
	
#이등변삼각형	

loop2: #두번째 루프 for(j = 0; j < 5 - i; j++)
		addi $t7 $0, 5 #$t7 == 5
		sub $t6 $t7, $t1 # $t6 == 5-i
		bgt $t2, $t6, loop1 #$t2(j) > $t6(5-i) 일때 loop1로 이동
		
		li $v0, 4
		la $a0, sapce #공백 찍는다
		syscall
		
		addi $t2, $t2, 1 #j값 +1 증가
		j loop2	

loop1: #세번째 루프 for(k = 0; k < 2*i-1; k++)
		addi $t3, $0, 2 # $t3 == 2
		mult $t3, $t1 # 2*a
		mflo $t4 
	
		bgt $t8, $t4, loop3 #$t8(k) > $t4((2*a)-1) 일때 loop2로 이동
		
		li $v0, 4 #찍기위한 명령실행코드
		la $a0, star #별을 찍는다
		syscall
	
		addi $t8, $t8, 1 #k값 +1 증가
		j loop1 

loop3: #첫번째 루프 for(i = 1; i < 5; i++)
		beq $t1, $t0, loop4 # $t1(i) == $t0(n) 일때 finish로 이동
		
		li $v0, 4
		la $a0, newLine #새로운 줄로 넘어간다.
		syscall
		
		addi $t1, $t1, 1 #i값을 1증가
		addi $t2, $0, 0 #j값을 다시 1로 초기화(j = 0) 시켜준다.
		addi $t8, $0, 0 #k값을 다시 1로 초기화(k = 0) 시켜준다.
		j loop2

		
#역이등변삼각형		

loop4: #두번째 루프 for(j = 0; j < 5 - i; j++)
		addi $t7 $0, 5 #$t7 == 5
		sub $t6 $t7, $t1 # $t6 == 5-i
		bgt $t2, $t6, loop5 #$t2(j) > $t6(5-i) 일때 loop1로 이동
		
		li $v0, 4
		la $a0, sapce #공백 찍는다
		syscall
		
		addi $t2, $t2, 1 #j값 +1 증가
		j loop4

loop5: #세번째 루프 for(k = 0; k < 2*i-1; k++)
		addi $t3, $0, 2 # $t3 == 2
		mult $t3, $t1 # 2*a
		mflo $t4 
	
		bgt $t8, $t4, loop6 #$t8(k) > $t4((2*a)-1) 일때 loop2로 이동
		
		li $v0, 4 #찍기위한 명령실행코드
		la $a0, star #별을 찍는다
		syscall
	
		addi $t8, $t8, 1 #k값 +1 증가
		j loop5

loop6: #첫번째 루프 for(i = 4; i > 0; i--)
		beq $t1, $t9, finish # $t1(i) == $t0(n) 일때 finish로 이동
		
		li $v0, 4
		la $a0, newLine #새로운 줄로 넘어간다.
		syscall
		
		addi $t1, $t1, -1 #i값을 1감소
		addi $t2, $0, 0 #j값을 다시 1로 초기화(j = 0) 시켜준다.
		addi $t8, $0, 0 #k값을 다시 1로 초기화(k = 0) 시켜준다.
		j loop4


finish:
		li $v0, 10
		syscall

