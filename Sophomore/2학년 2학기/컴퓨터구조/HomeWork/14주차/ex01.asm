.data
.text
.globl main

main:
	#$s0 = amount, $s1 = fee
	beq #$s0, 20, case_20
	beq #$s0, 30, case_30	
	j default
	
case_20:
	addi $s1, $0, 2
	j done

case_30:
	addi $s1, $s0, 3
	j done

default:
	addi $s1, $s0, 0
	j done
	
done:
	li $v0, 10			
	syscall