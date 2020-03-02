.data
.text
.globl main

main:
	#$s0 = i, $s1 = sum
	
	addi $s1, $0, 0
	add $s0, $0, $0
	addi $t0, $0, 10

for:
	beq $s0, $t0, done
	add $s1, $s1, $s0
	addi $s0, $s0, 10
	j for

done:
	li $v0, 10			
	syscall
	
	