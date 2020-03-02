use test1007
go

select *
from instructor;

/*과제 1번*/
update instructor
set dept_name = 'School of S.W'
where dept_name = 'Comp.Sci.'

select *
from instructor;

/*과제 2번*/
select *
from course

update course
set dept_name = 'School of S.W'
where dept_name = 'Comp.Sci.'

/*과제 3번*/
insert into course
values('CS-145', 'Relational Database Programming', 'School of S.W.', '3')

select *
from course

/*과제 4번: 총 수정: 7개(3개이상 수정하면 패스)*/

select distinct 설치시군구명
from 전국무료와이파이표준데이터
where 설치시군구명 not like '%시' and	
	설치시군구명 not like '%군' and
	설치시군구명 not like '%구' and
	소재지도로명주소 not like '%세종%'
	or 설치시군구명 like '% %'


select distinct *
from 전국무료와이파이표준데이터
where 설치시군구명 not like '%시' and	
	설치시군구명 not like '%군' and
	설치시군구명 not like '%구' and
	소재지도로명주소 not like '%세종%'
	or 설치시군구명 like '% %'

update 전국무료와이파이표준데이터
set 설치시군구명 = '진안군'
where 설치시군구명 = '전라북도 진안군'

update 전국무료와이파이표준데이터
set 설치시군구명 = '진주시'
where 소재지도로명주소 like '%진주시%'
	and 설치시군구명 = '경상남도'

update 전국무료와이파이표준데이터
set 설치시군구명 = '창원시'
where 소재지도로명주소 like '%창원시%'
	and 설치시군구명 = '경상남도'

update 전국무료와이파이표준데이터
set 설치시군구명 = '동구'
where 설치시군구명 = '동구청'

update 전국무료와이파이표준데이터
set 설치시군구명 = '도봉구'
where 설치시군구명 = '서울특별시 도봉구'
