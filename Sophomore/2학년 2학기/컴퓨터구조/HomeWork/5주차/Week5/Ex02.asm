.text
.globl main

main:
	la $s1, 0x90000001
	la $s2, 0x70000001
	
	sub $s3, $s1, $s2 # $s3 <- $s1 - $s2 (overflow) 부호를 확인하는 sub경우 1001(9) 과 0111(7)을 빼주어야하는데 1001을 부호확인하면 -1 이고 0111을 2의 보수로 취하면 1001(-7)이되고 서로 더해주면 오버플러워 되는 값이 발생한다.
	subu $s4, $s1, $s2 # $s4 <- $s1 - $s2
	
	li $v0, 10
	syscall