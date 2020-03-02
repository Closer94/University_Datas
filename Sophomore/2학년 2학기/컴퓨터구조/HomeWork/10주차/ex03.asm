	.data
X:	.word 5
	.text
	.globl main

main:
		lw $s5, X
		li $s0, 0x10010004
		sw $s5, 0($s0)
		addi $s4, $0, 'a' #$s4 == ch
		addi $sp, $sp, -20
		addi $t9, $0, 'a'
		sw $t9, 16($sp) #stackPoint 16에 'a'를 넣어준다.
		addi $t9, $0, 'b'
		sw $t9, 12($sp)
		addi $t9, $0, 'c'
		sw $t9, 8($sp)
		addi $t9, $0, 'd'
		sw $t9, 4($sp)
		addi $t9, $0, 'e'
		sw $t9, 0($sp)
		
		jal coint_char
		move $t1, $v0
		beq $t1, $0, done #return값이 없으면 ($t1 == 0이면) done
		sw $t1, 4($s0) # 값 저장
		j done
		
		

coint_char:
		la $t0, 0($sp)
		addi $s1, $s1, 0
		addi $t1 $t1, 0
		addi $t8, $t8, 4 # i * 4
		
		
loop:	
		slt $t4, $t2, $t5 # i < size
		beq $t4, $0, loopend
		mult $t2, $t8
		mult $t2, $t8
		mflo $t7 # 4, 8, 12... 로 계산됨
		add $t7, $t7, $t0 #기본 주소값 더하기 4, 8, 12...
		lw $t9, 0($t7)
		addi $t2, $t2, 1 # i값 1증가
		div $t9, $s4 # str[i] % ch
		mfhi $t5 #나머지는 하위값에 계산 저장됨
		bne $t5, $s0, loop #str[i] % ch == 0
		addi $s1, $s1, 1 #같지 않으면 그냥 i를 1증가하고 다시 루프 돌린다.
		j loop


		
looped:
		add $v0, $0, $s1
		jr $ra
		
done:
		addi $sp, $sp, 20
		li $v0, 10
		syscall

		