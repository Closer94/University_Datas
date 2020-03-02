use MagicCorp
go

select dname "부서명"
from department
where dno = (
	select dno
	from employee
	where ename = '이문세'
)

select dno
from employee
where ename = '이문세'

select avg(salary)
from employee

select ename, salary
from employee
where salary > (select avg(salary)
				from employee
)

select distinct dno
from employee
where salary > 500

select ename, salary, dno
from employee
where dno in (
	select distinct dno
	from employee
	where salary >= 500
)

select max(salary)
from employee
where dno = 30

select ename, salary
from employee
where salary > (
	select max(salary)
	from employee
	where dno = 30
)

select salary 
from employee
where dno = 30

select ename, salary 
from employee 
where salary > all ( select salary
				  from employee
				  where dno = 30
)


select *
from department
where exists(select * 
			 from employee
			 where employee.dno = 10) 

select * 
from employee, department
where employee.dno = department.dno

select * 
from department
where exists(select * 
			 from employee
			 where employee.dno = department.dno)