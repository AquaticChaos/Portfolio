--============================== 
--===Single Table Queries=======
--==============================

SELECT		COLUMNS, EXPRESSIONS
FROM		TABLENAME
WHERE		CONDITIONS
GROUP BY	COLUMNS
HAVING		CONDITIONS FOR GROUPS
ORDER BY	SORT KEY COLUMNS


--SQL Basic - SIMPLE SELECT STATEMENT------------

------------------REQUIRED CLAUSES----------------

------------------OPTIONAL CLAUSES----------------


--==========SELECT & FROM CLAUSE============
--1. Show/Select all the data from the CUSTOMER table
--RETRIEVE ALL COLUMNS FROM TABLE USING WILDCARD CHARACTER



--1.1 RETRIVE TOP ROWS OF ALL COLUMNS USING THE OBJECT EXPLORER 

--2. Show all CUST_ID, First_Name and Last_Name of Customers.
--RETREVE SPECIFIC COLUMN(S) 



--==========WHERE CLAUSE: SIMPLE CONDITION============
--1. What is the last name of the customer with the customer ID 125?
--For CHAR data type, use single quotation mark around 'value'


--2. Find first name, last name, balance, 
--and credit limit for all customers with balances that exceed their credit limits.
--with a BALANCE that exceeds their CREDIT_LIMIT


/*
Comparison Operator	Description
=					Equal to
>					Less than
<					Greater than
< =					Less than or equal to
> =					Greater than or equal to
< > or !=			Not equal to
*/

--==========WHERE CLAUSE: COMPOUND CONDITION============
/*
AND operator: All simple conditions must be true
OR operator: One simple condition must be true
NOT operator: Reverses the truth of the original condition
*/

--1. List the descriptions of all items that are 
--stored in location B and for which there are more than 15 units on hand.

--2.List the descriptions of all items that are 
--stored in location B or for which there are more than 15 units on hand.

--3. List the descriptions of all items that are not stored in location B.

--4. List the descriptions of all items that are 
--stored in location B or C, 
--and for which there are more than 15 units on hand.

--5. List the descriptions of all items that are 
--stored in location B, 
--or in location C for which there are more than 15 units on hand.



--======================BETWEEN Operator=======================
--1. List the customer ID, first name, last name, and balance 
--of all customers with balances greater than or equal to $125 
--and less than or equal to $250.

--======================IN Operator=======================
--1. List the customer ID, first name, last name, and credit limit 
--for each customer with a credit limit of $500, $750, or $1,000.

--======================LIKE Operator=======================
--1. List the customer ID, first name, last name, and complete address 
--of each customer located at an address that contains the letters “Rock.”

--======================IS NULL Operator=======================
--1. Show all Customer records without EMAIL (EMAIL null).
--2. Show all Customer records with EMAIL (EMAIL not null).




--======================COMPUTED  Columns=======================
--SELECT CLAUSE
--Does not exist in DB, but...
/*
Arithmetic operators
+ for addition
− for subtraction
* for multiplication
/ for division
*/

--1. Find the number, first and last name, 
--and available credit (the credit limit minus the balance) for each customer.


--AS clause:

--2. Find the customer ID, first name, last name, 
--and available credit for each customer with at least $400 of available credit.
--Note the error message:

--Corrected query:


--========================FUNCTIONS ==============================

FUNCTION		DESCRIPTION
COUNT			Determines the number of rows in a table
MIN				Determines the minimum value in a column
MAX				Determines the maximum value in a column
SUM				Calculates the total of the values in a column
AVG				Calculates the average value in a column

--1. How many items are in the category DOG?

--2.Find the sum of all balances, the average balance, 
--the maximum balance, and the minimum balance 
--of all KimTay Pet Supplies customers.

--======================== DISTINCT OPERATOR ==============================
--
--3. Find the customer ID of each customer that currently has an invoice 
--(that is, an invoice currently in the INVOICES table).


--4. Find the customer ID of each customer that currently has an invoice 
--(that is, an invoice currently in the INVOICES table). 
--List each customer ID only once.


--5. Count the number of customers that currently have invoices.


--========================Nesting Queries ==============================
--1. List the customer ID, first name, last name, and balance for each customer 
-- whose balance exceeds the average balance of all customers.


--2. List the invoice numbers that contain an invoice line for an item in category HOR.

--======================== Grouping ==============================
--Group By and Having Clauses
/*
SELECT		COLUMNS
FROM		TABLENAME
WHERE		CONDITIONS
GROUP BY	COLUMNS
HAVING		CONDITIONS FOR GROUPS
*/
--1.For each sales rep, list the rep ID and the average balance of the rep’s customers.


--HAVING VS WHERE
--2. List each credit limit and the number of customers having each credit limit.
--3. Same as above, but list only those credit limits held by more than two customers.
--4. List each credit limit and the number of customers of sales rep 05 that have this limit.
--5. Same as above, but list only those credit limits held by fewer than two customers.


--========================Sorting ==============================
--Order By Clause
--ASC vs DESC
--1.List the customer ID, first name, last name, and balance of each customer. 
--Order (sort) the output in ascending (increasing) order by balance.

--Major, Minor Sort Keys
/*2. List the customer ID, first name, last name, and credit limit of each customer. 
Order the customers by last name within descending credit limit. 
(In other words, first sort the customers by credit limit in descending order. 
Within each group of customers that have a common credit limit, 
sort the customers by last name in ascending order.)*/

