USE MagicCorp
go

select * 
from employee, department

select *
from employee, department
where employee.dno = department.dno

select ename, dname
from employee, department
where employee.dno = department.dno

select ename, dname
from employee, department
where employee.dno = department.dno
and ename='이문세'

select employee.ename, department.dname, employee.dno
from employee, department
where employee.dno = department.dno
and ename='이문세'

select ename, dname, employee.dno
from employee, department
where employee.dno = department.dno
and ename='이문세'

select * from salgrade

select ename, salary, grade
from employee, salgrade
where salary between lowsal and highsal

select e.ename, e.salary, s.grade "등급"
from employee "e", salgrade "s"
where salary >= lowsal and salary <= highsal 

select member.ename "사원이름", manager.ename "직속상관이름"
from employee member, employee manager
where member.manager = manager.eno

select dno, dname into dept01
from department
where dno in(10, 20)

select * from dept01

select dno, dname into dept02
from department
where dno in(10, 30)

select * from dept02

select *
from dept01 INNER JOIN dept02
ON dept01.dno = dept02.dno

select * 
from dept01 LEFT OUTER JOIN dept02
ON dept01.dno = dept02.dno

select *
from dept01 RIGHT OUTER JOIN dept02
ON dept01.dno = dept02.dno

select *
from dept01 FULL OUTER JOIN dept02
ON dept01.dno = dept02.dno