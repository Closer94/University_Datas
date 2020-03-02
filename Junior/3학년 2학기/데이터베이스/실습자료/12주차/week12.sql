use magicCorp
go

select * into emp_copy
from employee

select * 
from emp_copy


create view emp_view30
as
select eno, ename, dno
from emp_copy
where dno = 30

select * from emp_view30

exec sp_helptext emp_view30

insert into emp_view30
values(1111, 'aaaa', 30)

select * from emp_view30

select * from emp_copy

create view emp_view_dept
as
select e.eno, e.ename, e.salary, e.dno, d.dname, d.loc
from emp_copy e, department d
where e.dno = d.dno

select * from emp_view_dept

create view emp_view20
with encryption
as 
select eno, ename, dno
from emp_copy
where dno = 20

exec sp_helptext emp_view20

create view emp_view10
with schemabinding
as
select eno, ename, dno
from dbo.emp_copy
where dno = 10

alter table emp_copy
alter column ename nvarchar(50)

create view emp_view30_nochk
as
select eno, ename, salary, commission, dno
from emp_copy
where dno=30

select * from emp_view30_nochk

drop view

update emp_view30_nochk 
set dno = 20
where salary >= 300

update emp_view30_nochk 
set dno = 20
where eno = 1003

select * from emp_view30_nochk
rollback

drop view emp_view_dept

select * from emp_view_dept