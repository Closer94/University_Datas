.text
.globl main

main:
	# 첫번째 계산.. 0xABCDEF * 0xABCD
	# $t1 <- 0xABCDEF
	# $t2 <- $0 or 0xABCD
	la $t1, 0xABCDEF
	ori $t2, $0, 0xABCD
	
	# $t1과 $t2은 곱셈이 될 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s1으로 옮겨질 것이다.
	# lo레지스터의 값은 $s2으로 옮겨질 것이다.
	mult $t1, $t2
	mfhi $s1
	mflo $s2
	
	# 두번째 계산.. 0xFFFFFFFF * 0xABCD
	# $t1 <- 0xFFFFFFFF
	# st2 <- $s0 or 0xABCD
	la $t1, 0xFFFFFFFF
	ori $t2, $0, 0xABCD
	
	# $t1과 $t2 곱셈이 될 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s3으로 옮겨질 것이다.
	# lo레지스터의 값은 $s4으로 옮겨질 것이다.
	mult $t1, $t2
	mfhi $s3
	mflo $s4
	
	# 마지막 계산.. 0xCDEF * 0xCDEF
	# $t1 <- 0xCDEF
	# $t2 <- $0 or 0xCDEF
	la $t1, 0xCDEF
	ori $t2, $0, 0xCDEF
	
	# $t1과 $t2 곱셈이 될 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s5으로 옮겨질 것이다.
	# lo레지스터의 값은 $s6으로 옮겨질 것이다.
	mult $t1, $t2
	mfhi $s5
	mflo $s6
	
	# system code 10: 프로그램 종료
	li $v0, 10
	syscall
	