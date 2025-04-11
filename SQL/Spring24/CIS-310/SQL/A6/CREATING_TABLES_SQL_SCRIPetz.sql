--====BEFORE WE START===================================

COMMENTING IN SQL
METHOD 1  
METHOD 2 

--VIEW SAMPLE TABLE
--RIGHT CLICK TABLE--> SELECT TOP 1000 (2MILL)
--SELECT * FROM tablename


--=======================================
--=====DDL: Data Definition Language=====
--========TABLE CREATION================
--=======================================


--==========TABLE CREATION ============
--LISTS OR CONTENTS ARE CONTAINED WITHIN PARATHESES: ()
--LIST ITEMS ARE SEPERATED BY COMMA DELIMITERS: ,
--TABLE CREATION SYNTAX--
/*
CREATE TABLE tablename 
( 
columnname1 datatype(length) additional_properties,
columnname2 datatype(length) additional_properties,
......
columnnamex datatype(length) additional_properties
);
*/

--EXAMPLE OF TABLE CREATION WITH PRIMARY KEY DEFINITION

--EXAMPLE OF TABLE CREATION WITH FOREIGN DEFINITION

 
--==========ADDING DATA TO TABLE ============
--TEXT DATA 
--DATE DATA 
--NUMERIC DATA 


--METHOD 1: INSERT FULL DATA RECORD
/*INSERT INTO tablename VALUES (value1,value2,value3...);*/

--METHOD 2: INSERT SPECIFIED COLUMN BY STATED ORDER
/*INSERT INTO tablename (column1, column2, column3...) VALUES (value1,value2,value3...);*/

--INSERT RECORDS WITH NULLS
--METHOD 1 

--METHOD 2 


--==========VIEW/SELECT TABLE CONTENT ============
/*SELECT * FROM tablename;*/


--==========VIEW TABLE METADATA ============
/*EXEC SP_COLUMNS tablename;*/


--==========REMOVE TABLE ============
/*DROP TABLE tablename;*/ --NOTE DROP ORDER & ERROR MESSAGE
