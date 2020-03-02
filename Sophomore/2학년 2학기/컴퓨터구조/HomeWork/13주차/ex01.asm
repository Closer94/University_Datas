.data
ask:		.asciiz "Type a character string (<50 chars long): "
bye:		.asciiz "Press enter to exit..."
len:		.word 50
inputStr:	.space 50
copyStr:	.space 50

.text
.globl main
main:
	li $v0, 4 			# system code 4: print a string
	la $a0, ask			# '$a0' will point out 'ask'
	syscall
	
	la $a0, inputStr	# '$a0' will point out 'inputStr' 
	lw $a1, len			# Load word-0 from 'len' into '$a1'
	li $v0, 8			# system code 8: read a string
	syscall
	
	li $t2, 96			# '$t2' will store the value 97 (97 == ASCII 'a')
	li $t3, 123			# '$t3' will store the value 122(122 == ASCII 'z')
	add $t0, $0, 0		# '$t0' will store the value 0 	('$t0' is the index)
	
loop:
	lb $t1, inputStr($t0)	# Load byte-$t0 from 'inputStr' into '$t1'
							# Fetch a character from 'inputStr' into '$t1'
	ble $t1, $t2, skip		# if($t1 < $t2) then go to the label 'skip'
	bge $t1, $t3, skip		# if($t1 > $t3) then go to the label 'skip'
	
	addi $t1, $t1, -32		# $t1 <- $tt1 - 32
							# Cover to upper case
							#the gap between lower case and upper case is 32

skip:
	sb $t1, copyStr($t0)  	# Store a byte in '$t1' into byte-$t0 from 'copyStr'
	addi $t0, $t0, 1		# $t0 <- $t0 + 1(Increase index)
	bne $t1, $0, loop		# if($t1 != 0) then go to the label 'loop'
	
finish:
	li $v0, 4		# system code 4: print a string
	la $a0, copyStr # '$a0' will point out 'copyStr'
	syscall
	
	li $v0, 4		# system code 4: print a string
	la $a0, bye # '$a0' will point out 'bye'
	syscall
	
	li $v0, 10		# exit program
	syscall
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	