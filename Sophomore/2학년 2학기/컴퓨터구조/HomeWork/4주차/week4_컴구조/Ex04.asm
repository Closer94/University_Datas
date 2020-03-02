.data
str: .asciiz "20135151 / 이갑성"
newline: .asciiz "\n"

.text
.globl main

main:
	li $v0, 4
	la $a0, str
	syscall
	li $v0, 4
	la $a0, newline
	syscall
	
	la $s0, 30 #$s0레지스터에 코드값 30번을 불러와라
	
	addi $s1, $s0, 5 #$s0레지스터와 상수값 5를 더한 결과를 $s1레지스터에 저장해라
	li $v0, 1 #$v0레지스터에 코드값 1번을 불러와라
	move $a0, $s1 #$s1레지스터를 $a0레지스터로 이동해라(저장) 
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 4 #$v0레지스터에 코드값 4번을 불러와라
	la $a0, newline #$a0레지스터에 newline을 저장해라
	syscall #$v0에 설정된 레지스터 값 수행
	
	addi $s2, $s0, -50 #$s0레지스터와 상수값 -50을 더한 결과를 $s2레지스터에 저장해라
	li $v0, 1 #$v0레지스터에 코드값 1번을 불러와라
	move $a0, $s2 #$s2레지스터를 $a0레지스터로 이동해라(저장)
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 10 #$v0레지스터에 코드값 10번을 불러와라
	syscall #$v0에 설정된 레지스터 값 수행
	