use MagicCorp
go

select * 
from employee

select *
from department

select * 
from SALGRADE


/*1번*/
select d.dname "부서명", count(d.dname) "직원 수"
from employee e, department d
where d.dno = e.dno
group by d.dname

/*2번*/
select d.dname "부서명", avg(s.grade) "평균급여등급"
from employee e, department d ,salgrade s
where e.dno = d.dno and salary >= lowsal and salary <= highsal
group by d.dname



/*3번*/
select e.ename "사원명", d.dname "소속부서명", s.grade "급여등급",
	dense_rank() over(order by s.grade) "순위"
from employee e, department d, salgrade s
where e.dno = d.dno and e.salary between s.lowsal and s.highsal


/*4번*/
select distinct salary "급여"
from employee


/*5번*/
select min(hiredate) "입사일"
from employee


/*6번*/
select min(salary) "급여"
from employee


/*7번*/
select 
	d.dno "부서번호", 
	d.dname "부서명",
	d.loc "부서 위치",
	count(d.dno) "소속 직원 수",
	avg(e.salary) "소속 직원 평균 급여",
	sum(e.salary) "소속 직원 급여 합",
	avg(s.grade) "소속 직원 평균 급여 등급"
from employee e, department d, salgrade s
where e.dno = d.dno and e.salary between s.lowsal and s.highsal
group by d.dno, d.dname, d.loc








/*8번*/
use test1007
go

select * from course
select * from instructor
select * from teaches

/*8번*/
select 
	i.name "성함",
	i.dept_name "학과",
	c.title "강의 이름",
	c.credits "이수학점",
	t.years "개설년도",
	t.semester "계절정보"
from course c, instructor i, teaches t
where i.id = t.id and t.course_id = c.course_id
