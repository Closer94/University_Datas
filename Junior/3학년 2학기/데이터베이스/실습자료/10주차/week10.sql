insert into department
(dno, dname, loc)

values(50, '토목부', '일산')

select *
from department

select *
into department2
from department where 0=1

insert into department2
select top(3) *
from department

select * 
from department2

select * 
into employee01
from employee

select *
from employee01

update employee01
set dno = 30

select *
from employee01

update employee01
set salary = salary * 1.1

select *
from employee01

update employee01
set hiredate = getdate()

select *
from employee01

select *
into employee02
from employee

update employee02
set dno = 30
where dno = 10

update employee02
set salary = salary * 1.1
where salary >= 500

update employee02
set hiredate = getdate()
where hiredate like '%2005%'

drop table employee01

select * 
into employee01 
from employee

select *
from employee01

update employee01
set dno=20, job='이사'
where ename='이문세'

select *
from employee01

update employee01
set hiredate = getdate(), salary = 700, commission = 100
where ename = '이문세'

select *
from employee01
where ename = '이문세'



select *
into department01
from department

select *
from department01

update department01
set loc = (select loc
		   from department01
		   where dno = 40)
where dno = 20

select *
from department01

delete from employee01

insert into employee01
select * from employee

select * from employee01

delete from employee01
where dno= (select dno
			from department
			where dname = '영업부')

select * from employee01

delete from department01

insert into department01
select * from department

select * 
from department01 

begin tran

delete from department01

select *
from department01

rollback tran

select *
from department01

begin tran
delete from department01
where dno = 20

select *
from department01

commit tran

begin tran
rollback tran

select *
from department01