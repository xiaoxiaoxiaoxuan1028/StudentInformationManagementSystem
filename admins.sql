--IF OBJECT_aid(N'dbo.admins', N'U') IS  NOT  NULL 
DROP TABLE admins;
CREATE TABLE admins(
	aid   varchar(30) PRIMARY KEY,
	aname varchar(30),
	asex  varchar(30),
 
	--CRTTIM datetime DEFAULT CURRENT_TIMESTAMP,  
 	UPDTIM datetime DEFAULT CURRENT_TIMESTAMP, 
);
-- 添加表注释
 /*EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户信息表',  @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'admins'; 
 -- 添加字段注释
 EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号',  @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'admins', @level2type=N'column', @level2name=N'aid';
 EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别',  @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'admins', @level2type=N'column', @level2name=N'aname';
 EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'姓名',  @level0type=N'SCHEMA', @level0name=N'dbo', @level1type=N'TABLE', @level1name=N'admins', @level2type=N'column', @level2name=N'asex';
 */
-- 指定使用的库名
USE [xmu]
GO 
-- 国际惯例
SET ANSI_NULLS ON 
GO
 
 
-- 创建触发器
CREATE TRIGGER [dbo].[tgr_admins_updtim]
ON [dbo].[admins]
 
-- 触发时机、条件
AFTER UPDATE AS 
 
BEGIN 
	SET NOCOUNT ON;
	UPDATE dbo.[admins]
	SET UPDTIM=SYSDATETIME()
	WHERE aid IN (SELECT DISTINCT aid FROM inserted)
END 
GO 
 

-- 启动触发器

ALTER TABLE [dbo].[admins] ENABLE TRIGGER tgr_admins_updtim

 
INSERT INTO admins(aid, aname, asex) VALUES 
('100001','admin1','F'),
('100002','admin2','M'),
('100003','admin3','F');
 
 select * from admins