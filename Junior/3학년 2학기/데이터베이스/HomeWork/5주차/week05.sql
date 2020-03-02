select *
from EMPLOYEE


select top(1) eno, ename, hiredate
from employee
order by hiredate asc



select top(1) * 
from employee
where manager is not null
order by eno desc


select *
from employee
where commission is not null

select ename, job
from employee
where eno >= 1004 and eno <= 1008

select ename, job
from employee
where job = '과장' or job = '차장' or job = '부장' or job = '사장'


select eno "사번", ename "이름", salary * (DATEDIFF(DD, hiredate, '2019-09-27')/ 365) "퇴직금"
from employee

