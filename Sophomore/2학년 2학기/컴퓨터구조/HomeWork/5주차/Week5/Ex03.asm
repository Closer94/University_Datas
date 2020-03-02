.text
.globl main

main:
	la $s0, 0xffffffff # 0xffffffff == -1
	
	sll $s1, $s0, 4 # $s1 <- $s0 << 4
	srl $s2, $s0, 4 # $s2 <- $s0 >>> 4
	sra $s3, $s0, 4 # $s3 <- $s0 >> 4
	
	li $v0, 10
	syscall