--创建老师表
CREATE TABLE teachers(
	tid varchar(30) PRIMARY KEY,
	tname varchar(30),
	tsex  varchar(30),
	tdept varchar(30),
	title varchar(30),
	tsalary int,
	temail varchar(30),
	ttel  varchar(30)
	--tlastlogin datetime DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

select * from teachers

alter table teachers 
add  UPDTIM datetime DEFAULT CURRENT_TIMESTAMP

update teachers
set title = 'Professor' where title = 'Prof.'

-- 指定使用的库名
USE [xmu]
GO 
-- 国际惯例
SET ANSI_NULLS ON 
GO
 
-- 创建触发器
CREATE TRIGGER [dbo].[tgr_teachers_updtim2]
ON [dbo].[teachers]
 
-- 触发时机、条件
AFTER UPDATE AS 
 
BEGIN 
	SET NOCOUNT ON;
	UPDATE dbo.[teachers]
	SET UPDTIM=SYSDATETIME()
	WHERE tid IN (SELECT DISTINCT tid FROM inserted)
END 
GO 
 

-- 启动触发器

ALTER TABLE [dbo].[teachers] ENABLE TRIGGER tgr_teachers_updtim2

