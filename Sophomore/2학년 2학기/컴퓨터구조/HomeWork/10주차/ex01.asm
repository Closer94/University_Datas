.text
.globl main

main:
		sw $t0, 0x10010000
		sw $t1, 0x10010000
		addi $t0 $0 20
		addi $t1 $0 8
		
		add $t3, $t0, $t1
		sub $t4, $t0, $t1
		div $t3, $t4
		mfhi $t4
		mflo $t5
		
		sw $t4, 0x10010004
		sw $t5, 0x10010008
		li $v0, 10
		syscall

		
		