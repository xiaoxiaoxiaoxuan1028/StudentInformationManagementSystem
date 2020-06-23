--创建学生表
drop table student

CREATE TABLE students(
	sid varchar(30) PRIMARY KEY,
	sname varchar(30),
	ssex  varchar(30),
	sgrade varchar(30),
	sdept varchar(30),
	syear varchar(30),
	sage int,
	
	--UPDTIM datetime DEFAULT CURRENT_TIMESTAMP
);

--此时导入excel中的值
select * from students 
update students 
set sage = 20 where sgrade >= '1995'
--然后再加一列updatetime
alter table students 
add  UPDTIM datetime DEFAULT CURRENT_TIMESTAMP

-- 指定使用的库名
USE [xmu]
GO 
-- 国际惯例
SET ANSI_NULLS ON 
GO
 
-- 创建触发器
CREATE TRIGGER [dbo].[tgr_students_updtim1]
ON [dbo].[students]
 
-- 触发时机、条件
AFTER UPDATE AS 
 
BEGIN 
	SET NOCOUNT ON;
	UPDATE dbo.[students]
	SET UPDTIM=SYSDATETIME()
	WHERE sid IN (SELECT DISTINCT sid FROM inserted)
END 
GO 
 

-- 启动触发器

ALTER TABLE [dbo].[students] ENABLE TRIGGER tgr_students_updtim1

