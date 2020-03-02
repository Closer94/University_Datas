.data
str: .asciiz "20135151 / 이갑성"
newline: .asciiz "\n"

.text
.globl main

main:
	li $v0 4;
	la $a0 str
	syscall
	li $v0, 4
	la $a0, newline
	syscall
	
	la $s1, 30 #$s1레지스터에 30(상수)을 저장한다.
	la $s2, 40 #$s1레지스터에 40(상수)을 저장한다.
	
	add $s3, $s1, $s2 #$s1레지스터의 값과 $s2레지스터의 값을 더해서 $s3레지스터에 넣어라
	sub $s4, $s1, $s2 #$s1레지스터의 값과 $s2레지스터의 값을 빼서 $s4레지스터에 넣어라
	
	li $v0, 1 #$v0레지스터에 1번 코드를 불러와라
	move $a0, $s3 #$s3레지스터를 $a0레지스터로 이동(저장)
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 4 #$v0레지스터에 4번 코드를 불러와라
	la $a0, newline #newline 주소를 $a0에 불러와라
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 1 #1번 코드를 $v0레지스터에 넣어라
	move $a0, $s4 #$s4레지스터를 $a0레지스터로 이동(저장)
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 4 #4번 코드를 $v0레지스터에 넣어라
	la $a0, newline #$a0에 newline 주소를 불러와라
	syscall #$v0에 설정된 레지스터 값 수행
	
	li $v0, 10 #$v0레지스터에 10번 코드를 불러와라
	syscall #$v0에 설정된 레지스터 값 수행