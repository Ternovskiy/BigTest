CREATE DATABASE [test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'test', FILENAME = N'D:\Materials\BigTest\Sql\Data\test.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'test_log', FILENAME = N'D:\Materials\BigTest\Sql\Data\test_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
