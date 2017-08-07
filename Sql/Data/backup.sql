--run 
USE [master]
ALTER DATABASE [test] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
RESTORE DATABASE [test] FROM  DISK = N'D:\Materials\BigTest\Sql\Data\test.bak' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5
ALTER DATABASE [test] SET MULTI_USER




--create 
--BACKUP DATABASE [test] TO  DISK = N'D:\Materials\BigTest\Sql\Data\test.bak' WITH NOFORMAT, NOINIT,  NAME = N'test-Полная База данных Резервное копирование', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
