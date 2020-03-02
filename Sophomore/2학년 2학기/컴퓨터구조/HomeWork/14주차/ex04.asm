.data
.text
.globl main

main:
	addi $s1, $0, 0
	addi $s0, $0, 1
	addi $t0, $0, 101
	
loop: 
	slt $t1, $s0, $t0
	beq $t1, $0, done
	add $s1, $s1, $s0
	sll $s0, $s0, 1
	j loop

doen:
	li $v0, 10			
	syscall