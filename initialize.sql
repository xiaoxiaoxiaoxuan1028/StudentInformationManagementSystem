--常用功能
/*
use master;
drop database xmu;

drop table admins;
drop table teachers;
drop table students;
drop table users;
drop table choices;
drop table costea;



select * from admins;
select * from teachers;
select * from students;
select * from users;
*/


------------------------------1
create database xmu;


------------------------------2
use xmu;
use xmu;

--初始化


--创建users表
CREATE TABLE users(
	uid varchar(30) PRIMARY KEY,
	upasswd varchar(30),
	ugroup int,
	CONSTRAINT chk_uid_gruop CHECK (ugroup = convert(int,SUBSTRING(uid,1,1)))
);

--创建courses
CREATE TABLE courses(
	cid varchar(30) PRIMARY KEY,
	cname varchar(30),
	cterm int,
	cpoint int
);

--创建choices
CREATE TABLE choices(
	sid varchar(30) FOREIGN KEY REFERENCES students(sid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	cscore int,
	CONSTRAINT pk_choiceid PRIMARY KEY (sid,tid,cid)
);

--创建开课表
CREATE TABLE costea(
	cid varchar(30) FOREIGN KEY REFERENCES courses(cid),
	tid varchar(30) FOREIGN KEY REFERENCES teachers(tid),
	CONSTRAINT pk_costea PRIMARY KEY (tid,cid)
);



--管理员表的触发器
--插入时
go
create trigger tgr_admin_insert
on admins
for insert
as
INSERT INTO users
select inserted.aid , '123456',1 from inserted;
--删除时
go
create trigger tgr_admin_delete
on admins
for delete
as
DELETE FROM users
where uid = (select deleted.aid from deleted);


--老师表的触发器
--插入时
go
create trigger tgr_tea_insert
on teachers
for insert
as
INSERT INTO users
select inserted.tid , '123456',2 from inserted;
--删除时
go
create trigger tgr_tea_delete
on teachers
for delete
as
DELETE FROM users
where uid = (select deleted.tid from deleted);


--学生表的触发器
--插入时
/*没把学生插入user里，太多了
go
create trigger tgr_stu_insert
on students
for insert
as
INSERT INTO users
select inserted.sid , '123456',3 from inserted;

--删除时
go
create trigger tgr_stu_delete
on students
for delete
as
DELETE FROM users
where uid = (select deleted.sid from deleted);*/


select * from admins;
select * from teachers;
select * from students;
select * from users;


------------------------------3


/*--插入老师数据
INSERT INTO teachers
VALUES ('200001','teacher1','teacher1@xmu.edu.cn',1000);
INSERT INTO teachers
VALUES ('200002','teacher2','teacher2@xmu.edu.cn',2000);
INSERT INTO teachers
VALUES ('200003','teacher3','teacher3@xmu.edu.cn',3000);


--插入学生数据
INSERT INTO students
VALUES ('300001','student1','student1@xmu.edu.cn','2021');
INSERT INTO students
VALUES ('300002','student2','student2@xmu.edu.cn','2022');
INSERT INTO students
VALUES ('300003','student3','student3@xmu.edu.cn','2023');

*/

--测试触发器
/*
select * from admins
select * from users

INSERT INTO admins
VALUES ('100004','admin4','admin4@xmu.edu.cn');

select * from admins
select * from users

DELETE FROM admins
WHERE aid='100004';

select * from admins
select * from users
*/


--插入课程数据
INSERT INTO courses
VALUES ('c001','算法',1,2);
INSERT INTO courses
VALUES ('c002','数据库',2,3);
INSERT INTO courses
VALUES ('c003','数据结构',3,4);


INSERT INTO choices VALUES
 ('12345','19999998','c001',91),
 ('12345','199999999','c002',92),
 ('12345','199999999','c003',93);
 
 --select * from choices
 
 --插入开课数据
INSERT INTO costea values
 ('c001','19999998'),
 ('c002','199999999'),
 ('c003','199999999');



select * from admins;
select * from teachers;
select * from students;
select * from users;

select * from courses;
select * from choices;
select * from costea;


--创建存储过程
create procedure sp_StudentQuery
 @sid varchar(30),
 @cterm varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数
 from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 and courses.cterm = @cterm
 group by cterm, courses.cid, cname, cpoint, cscore
 order by courses.cid
 return;
 
 
create procedure sp_StudentQuery_all
 @sid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数 
 from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 group by cterm, courses.cid, cname, cpoint, cscore
 order by courses.cid
 return;

create procedure sp_StudentQuery_with_cid
 @sid varchar(30),
 @cterm varchar(30),
 @cid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数  from courses, choices
 where courses.cid = choices.cid
 and choices.cid = @cid
 and choices.sid = @sid
 and courses.cterm = @cterm
 order by courses.cid
 return;
 
create procedure sp_StudentQuery_all_with_cid
 @sid varchar(30),
 @cid varchar(30)
as 
 select cterm as 学期,  courses.cid as 课程号, cname as 课程名, cpoint as 学分, cscore as 分数  from courses, choices
 where courses.cid = choices.cid
 and choices.sid = @sid
 and choices.cid = @cid
 order by courses.cid
 return;
 
drop procedure sp_StudentQuery_all_with_cid
drop procedure sp_StudentQuery_all
drop procedure sp_StudentQuery_with_cid
drop procedure sp_StudentQuery
 