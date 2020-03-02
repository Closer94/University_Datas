.text
.globl main

main:
	la $s1, 0x80000001
	la $s2, 0x80000001
	
	add $s, $s1, $s2 # $s3 <- $s1 + $s2 (overflow) 맨 앞의 4개의 bit에서 1111 + 1111 을 하면 올림값때문에 4자리수를 넘어가는 값이 나오므로 오버플러가 된다.
	addu $s4, $s1, $s2 # $s4 <- $s1 + $s2 (done)
	
	# I-type uses a 16-bit constant value. (e.g 0x1234)
	la $s5, 0xefffffff
	addiu $s6, $s5, 0x0fff # $s6 <- $s5 + 0x0fff 
	
	li $v0, 10
	syscall
	
	
	