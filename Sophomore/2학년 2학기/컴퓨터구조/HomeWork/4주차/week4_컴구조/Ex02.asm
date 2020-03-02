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
	
	la $s1, 0x1234 #$s1레지스터에 0x1234를 저장
	la $s2, 0xABCD #$s2레지스터에 0xABCD를 저장
	
	and $s3, $s1, $s2 #$s1레지스터와 $s2레지스터의 and 한 결과 값을 $s3레지스터에 저장
	or $s4, $s1, $s2 #$s1레지스터와 $s2레지스터의 or 한 결과 값을 $s4레지스터에 저장
	xor $s5, $s1, $s2 #$s1레지스터와 $s2레지스터의 xor 한 결과 값을 $s5레지스터에 저장
	nor $s6, $s1, $s2 #$s1레지스터와 $s2레지스터의 nor 한 결과 값을 $s6레지스터에 저장
	
	li $v0, 10 #$vo레지스터에 코드값 10번을 불러온다
	syscall #$v0에 설정된 레지스터 값 수행
	
	