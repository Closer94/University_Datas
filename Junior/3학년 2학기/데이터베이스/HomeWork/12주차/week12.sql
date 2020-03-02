select *
from course

select * 
from department

select * 
from instructor

select *
from teaches

/*苞力1*/
create view homework01
as
select c.course_id, c.title, t.sec_id, c.credits, i.name 
from course c, teaches t, instructor i
where c.course_id = t.course_id and t.ID = i.ID
 
select * 
from homework01

/*苞力2*/
select h.course_id, h.title, h.sec_id, h.credits, h.name, t.years, t.semester
from homework01 h, teaches t
where h.course_id = t.course_id and t.semester = 'Spring'
and t.years = '2010'

/*苞力3*/
alter view homework01 
as 
select c.course_id, c.title, t.sec_id, c.credits, i.name, t.years, t.semester
from course c, teaches t, instructor i
where c.course_id = t.course_id and t.ID = i.ID

select * from homework01

/*苞力4*/
select distinct dept_name
from course
where title in ( select title
				from homework01
				where semester = 'Fall' and years = '2009' 
				)