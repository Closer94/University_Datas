use MagicCorp
go

select sum(salary) "급여 총액"
from employee

select sum(commission) "커미션 총액"
from employee

select avg(salary) "급여 평균"
from employee

select max(salary) "최대 급여", min(salary) "최소 급여"
from employee

select count(commission) "커미션을 받는 사원의 수"
from employee

select count(*) "전체 사원의 수", count(commission) "커미션을 받는 사원의 수"
from employee

select job from employee
order by employee

select count(job) "부서수(중복O)"
from employee

select distinct job from employee
order by job


select count(distinct job) "부서수(중복X)"
from employee

select dno from employee
group by dno

select dno, avg(salary) "급여평균"
from employee
group by dno

select dno, sum(salary) "급여총액", avg(salary) "급여 평균"
from employee
group by dno

select dno, max(salary) "최대 급여", min(salary) "최소 급여"
from employee
group by dno

select dno, count(*) "부서별 사원수", count(commission) "커미션받는 사원수"
from employee
group by dno

select dno, avg(salary)
from employee
group by dno
having avg(salary) >= 500

select dno, max(salary) "최대급여", min(salary) "최소급여"
from employee
group by dno
having max(salary) > 500

select dno, job, avg(salary) 
from employee
group by dno, job
order by dno asc

select dno, job, sum(salary) "급여합계" 
from employee
group by dno, job with rollup
order by dno 


select dno, job, sum(salary) "급여총액" 
from employee
group by dno, job with rollup

select dno, job, sum(salary) "급여총액"
from employee
group by dno, job with cube
order by dno 

select dno, job, sum(salary) "급여총액"
from employee
group by dno, job with rollup

select dno, job, sum(salary) "급여총액"
from employee
group by dno, job with cube
order by dno desc, job desc

select dno, job, sum(salary) "총액"
from employee group by dno, job with cube
order by dno desc, sum(salary) asc

select ename, dno, 
	case when dno=10 then '경리부'
	when dno=20 then '영업부'
	when dno=30 then '인사부'
	end "dname"
from employee

USE test_week06
go

select * from test

select year, [1], [2], [3], [4]
from test
pivot(sum(amount)
for quarter
in([1], [2], [3], [4])) as pvt

create table test2
(
	year int,
	Q1 decimal(2,1),
	Q2 decimal(2,1),
	Q3 decimal(2,1),
	Q4 decimal(2,1)
)

insert into test2 values(2009, 1.1, 1.2, 1.3, 1.4)
insert into test2 values(2010, 2.1, 2.2, 2.3, 2.4)

select * from test2

select year, quarter, amount
from test2
unpivot(amount
for quarter 
in([Q1], [Q2], [Q3], [Q4])) as unpvt

select year, quarter, amount,
	rank() over(order by amount desc) "순위"
from test

select year, quarter, amount,
	dense_rank() over(order by amount desc) "순위"
from test

select year, quarter, amount,
	row_number() over(order by amount desc) "순위"
from test

select year, quarter, amount,
	ntile(6) over(order by amount desc) "순위"
from test

select year, quarter, amount,
	ntile(5) over(order by amount desc) "순위"
from test

select year, quarter, amount,
	rank() over(partition by year order by amount desc) "순위"
from test