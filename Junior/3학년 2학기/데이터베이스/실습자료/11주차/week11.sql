drop table customer

create table customer(
	id varchar(20),
	pwd varchar(20),
	name varchar(20),
	phone1 varchar(3),
	phone2 varchar(8),
	birthYear int,
	address varchar(100)
)

select * from customer

insert into customer
values(null, null, null, '010', '77727777', 1988, '서울시 성동구 성수동');

select * from customer

drop table customer

create table customer(
	id varchar(20) not null,
	pwd varchar(20) not null,
	name varchar(20) not null,
	phone1 varchar(3) null,
	phone2 varchar(8) null,
	birthYear int null,
	address varchar(100) null
)

insert into customer
values(null, null, null, '010', '7772777', 1988, '서울시 성동구 성수동');

insert into customer
values('one', '1111', '김나리', '010', '77727777', 1988, '서울시 성동구 성수동');

drop table customer

create table customer(
	id varchar(20) constraint uk_id unique,
	pwd varchar(20) constraint NN_pwd not null,
	name varchar(20) constraint NN_name not null,
	phone1 varchar(3) null,
	phone2 varchar(8) null,
	birthYear int null,
	address varchar(100) null
)

insert into customer
values('one', '1111', '김나리', '010', '77727777', 1988, '서울시 성동구 성수동');

insert into customer
values('one', '2222', '이백합', '010', '1234567', 1979, '서울시 송파구 잠실동');

drop table customer

create table customer(
	id varchar(20) constraint PK_id primary key,
	pwd varchar(20) constraint NN_pwd not null,
	name varchar(20) constraint NN_name not null,
	phone1 varchar(3) null,
	phone2 varchar(8) null,
	birthYear int null,
	address varchar(100) null
)

insert into customer
values(null, '1111', '김나리', '010', '77727777', 1988, '서울시 송동구 성수동');

insert into customer
values('one', '2222', '이백합', '010', '1234567', 1979, '서울시 송파구 잠실동');


create table products(
	pcode varchar(20) primary key,
	pname varchar(100) default '0',
	price int default 0
)

create table orders(
	oseq int identity(1,1) constraint PK_oseq primary key,
	quantity varchar(20) null,
	indate datetime null,
	id varchar(20) constraint FK_id references customer(id),
	pcode varchar(20) constraint FK_pcode references products(pcode)
)

insert into products 
values('P1', '바지', 55000)

insert into products 
values('P2', '점퍼', 58000)

insert into products 
values('P3', '니트', 53000)

select * from products

insert into customer
values('two', '2222', '이백합', '010', '1234567', 1979, '서울시 송파구 잠실동')

select* from customer

update customer
set pwd='1111', name ='김나리', phone2='77727777' , birthYear = 1988, address = '서울시 성동구 성수동'
where id = 'one'

insert into orders(quantity, id, pcode)
values(5, 'one', 'P1')

select * from orders


create table customer2(
	id varchar(20) constraint pk_id2 primary key,
	pwd varchar(20) not null,
	name varchar(20) not null,
	phone1 varchar(3) null
	check(phone1 in('010', '011', '016', '017', '018', '019')),
	phone2 varchar(8) null,
	birthYear int null
	check(birthYear >= 1900 and birthYear <=(getdate())),
	address varchar(100) null
)

insert into customer2
values('three', '3333', '김장미', '010', '32127654', 2000, '서울시 강남구 압구정동')


create table orders2(
	id varchar(20) not null,
	pcode varchar(20) not null, 
	oseq int identity,
	quantity varchar(20) null default '1',
	indate datetime null default current_timestamp
)

insert into orders2(id, pcode)
values('one', 'p1')


insert into orders2(id, pcode)
values('two', 'p2')

select * from orders2

create table orders3(
	oseq int identity(1,1) constraint PK_oseq3 primary key,
	quantity varchar(20) null,
	indate datetime null,
	id varchar(20) constraint FK_id3 references customer(id),
	pcode varchar(20) constraint FK_pcode3 references products(pcode)
)

create table orders4(
	oseq int identity(1,1),
	quantity varchar(20) null,
	indate datetime null,
	id varchar(20) null,
	pcode varchar(20),

	constraint p_oseq4 primary key(oseq),
	constraint fk_id4 foreign key(id) references customer(id),
	constraint fk_pcode4 foreign key(pcode) references products(pcode)
)

create table customer3(
	name varchar(20),
	phone varchar(11),
	birhday datetime,
	address varchar(100),
	constraint customer3_combo_pk primary key(name, phone)
)

select * from customer3