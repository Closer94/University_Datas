.text
.globl main

main:
	# $s1 <- 0xABCDEF
	# $s2 <- $0 or 10
	la $s1, 0xABCDEF
	ori $s2, $0, 10
	  
	# $s1과 $s2은 곱셈이 될 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s3으로 옮겨질 것이다.
	# lo레지스터의 값은 $s4으로 옮겨질 것이다.
	mult $s1, $s2
	mfhi $s3
	mflo $s4
	
	# $s1과 $s2는 나누어 질 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s5으로 이동할 것이다.
	# lo레지스터의 값은 $s6으로 이동할 것이다.
	div $s1, $s2
	mfhi $s5
	mflo $s6
	
	# 프로그램 종료
	li $v0, 10
	syscall