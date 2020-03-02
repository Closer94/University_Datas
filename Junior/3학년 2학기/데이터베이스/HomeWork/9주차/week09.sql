select *
from 전국주차장표준데이터

select [소재지지번주소]
from [전국주차장표준데이터]
where [소재지지번주소]like '충청남도 계룡시%'

SELECT CONVERT(INT,[1일주차권요금]) AS 칼럼명 from 전국주차장표준데이터

select 주차장명, [1일주차권요금]
from 전국주차장표준데이터
where 소재지지번주소 like '%서울%'	and [1일주차권요금] between 1 and 3000 /* == [1일주차권요금] >= 1 and [1일주차권요금] <= 3000*/


select distinct *
from [전국무료와이파이표준데이터]

/*1번*/
select distinct [설치시군구명]
from [전국무료와이파이표준데이터]
where [설치시군구명] not like '%시' and
	 [설치시군구명] not like '%군' and 
	 [설치시군구명] not like '%구'

/*2번*/
select 설치시도명, count(*) '설치 개수'
from 전국무료와이파이표준데이터
where 설치년월 in ( select 설치년월
				   from 전국무료와이파이표준데이터
				   where 설치장소명 like '%보건소%' 
				   	)
and [설치년월] != ''
group by 설치시도명
order by 설치시도명 asc


select 설치년월
from 전국무료와이파이표준데이터
where 설치장소명 like '%보건소%'