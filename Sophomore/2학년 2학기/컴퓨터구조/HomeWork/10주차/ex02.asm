.text
.globl main

main:
		sw $t0, 0x10010000 # x값
		sw $t1, 0x10010000 # y값
		addi $t0 $0 20
		addi $t1 $0 8
		
		jal same
		
		add $t2, $0, $v0
		sw $t2, 0x10010004 # rst
		
		li $v0, 10
		syscall
		
same:
		bne $t0, $t1, target
		la $v0, 'y'
		jr $ra

		
target:
		la $v0, 'n'
		jr $ra


	


