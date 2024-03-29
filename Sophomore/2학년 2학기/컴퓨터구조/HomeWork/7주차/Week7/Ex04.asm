.text
.globl main

main:
	# 첫번째 계산.. 811 / 10
	# $t1 <- 811
	# $t2 <- $0 or 10
	la $t1, 811
	ori $t2, $0, 10
	
	# $t1과 $t2는 나누어 질 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s1으로 이동할 것이다.
	# lo레지스터의 값은 $s2으로 이동할 것이다.
	div $t1, $t2
	mfhi $s1
	mflo $s2
	
	#두번째 계산.. -6 / 2
	# $t1 <- -6
	# $t2 <- $0 or 2
	la $t1, -6
	ori $t2, $0, 2
	
	# $t1과 $t2는 나누어 질 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s3으로 이동할 것이다.
	# lo레지스터의 값은 $s4으로 이동할 것이다.
	div $t1, $t2
	mfhi $s3
	mflo $s4
	
	#세번째 계산.. 100 / 100
	# $t1 <- 100
	# $t2 <- $0 or 100
	la $t1, 100
	ori $t2, $0, 100
	
	# $t1과 $t2는 나누어 질 것이다.
	# 그 결과는 hi와 lo 레지스터에 저장될 것이다.
	# hi레지스터의 값은 $s5으로 이동할 것이다.
	# lo레지스터의 값은 $s6으로 이동할 것이다.
	div $t1, $t2
	mfhi $s5
	mflo $s6
	
	
	# system code 10: 프로그램 종료
	li $v0, 10
	syscall
	