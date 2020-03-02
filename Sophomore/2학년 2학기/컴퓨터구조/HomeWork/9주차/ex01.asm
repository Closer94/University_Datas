.text
.globl main

main:
		addi $t0, $0, 20
		sw  $t0, 0x10010000
		
		addi $t1, $0, 5	
		mult $t0, $t1
		mfhi $t2
		mflo $t3
		addi $t4, $t3, -99
		
		sw $t4, 0x10010001
		
		li $v0, 10
		syscall