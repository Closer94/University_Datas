.data
array: .word 0:10 #array크기는 0~10인 10개이다.
endmark: .word -999
ask: .asciiz "Enter an integer (-999 for exit): "
resstr: .asciiz "The number of inpuuted figures is "
minstr: .asciiz " / Minimum: "
maxstr: .asciiz " / Maximum: "
newline: .asciiz "\n"
bye: .asciiz "Press enter to exit.."

.text
.globl main

main:
	la $s0, array #$s0을 array의 레지스터를 가르킨다.
	li $s1, 0 #1을 $s1에 넣어준다.
	
loop_1:
	li $v0, 4 #문자열을 출력한다.
	la $a0, ask #$a0에 ask을 가르킬 것이다.
	syscall
	
	li $v0, 5 #정수값을 읽어온다.
	syscall
	
	lw $t0, endmark #endmark에 있는 레지스터 값을 $t0에 넣어준다.
	beq $v0, $t0, exit #$v0과 $t0이 같으면 exit로 이동
	
	sw $v0, 0($s0) #0($s)에 있는 레지스터를 $v0에 넣어준다. 
	
	addi $s0, $s0, 4 #$s0 = $s0 + 4
	
	addi $s1, $s1, 1 #$s1 = $s1 + 1
	j loop_1 #loop_1으로 이동
	
exit:
	li $v0, 4 #문자열을 출력한다.
	la $a0, resstr #$a0에 resstr을 가르킬 것이다.
	syscall
	
	li $v0, 1 정수형 값을 찍는다
	add $a0, $0, $s1 #$0과 $s1을 더한 값을 $a0에 넣어준다.
	syscall
	
	la $s0, array #$s0을 array의 레지스터를 가르킨다.
	lw $t0, 0($s0) #0($s0)에 있는 레지스터 값을 $t0에 넣어준다.
	
	lw $t1, 0($s0) #0($s0)에 있는 레지스터 값을 $t1에 넣어준다.

loop_2:
	lw $t3, 0($s0) #0($s0)에 있는 레지스터 값을 $t3에 넣어준다.
	bge $t3, $t0, notmin #$t3과 $t0과 비교했을때 $t3이 크면 notmin으로 이동

	add $t0, $0, $t3 #$t0 = $0 + $t3

notmin:
	ble $t3, $t1, notmax #$t3과 $t1과 비교했을때 $t1이 크면 notmax으로 이동
	add $t1, $0, $t3 #$t1 = $0 + $t3
	
notmax: 
	add $s0, $s0, 4 # $s0 = $s0 + 4
	addi $s1, $s1, -1 #$s1 = $s1 - 1
	bne $s1, $0, loop_2 #$s1과 $0이 같으면 loop_2
	
	li $v0, 4 #문자열을 출력한다.
	la $a0, minstr #$a0에 minstr을 가르킬 것이다.
	syscall
	
	li $v0, 1 #정수형 값을 찍는다
	add $a0, $0, $t0 #$0과 $t1을 더해서 $a0에 넣어준다.
	syscall
	
	li $v0, 4 #문자열을 출력한다
	la $a0, maxstr #$a0에 maxstr을 가르킬 것이다.
	syscall
	
	li $v0, 1 #정수형 값을 찍는다
	add $a0, $0, $t1 #$a0과 $t1을 더해서 $0에 넣어준다.
	syscall
	
	li $v0, 4 #문자열을 출력한다
	la $a0, newline #$a0에 newline을 가르킬 것이다.
	syscall
	
	li $v0, 4 #문자열을 출력한다
	la $a0, bye #$a0에 bye을 가르킬 것이다.
	syscall
	
	li $v0, 5 #정수값을 읽어온다.
	syscall
	
	li $v0, 10 #프로그램 종료
	syscall
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	