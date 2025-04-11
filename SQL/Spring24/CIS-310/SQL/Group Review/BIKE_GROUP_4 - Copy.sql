--======================================================================================================================
--====================================================Bike Exercise Part 2=====================================================
--======================================================================================================================

--CIS 310
--Group: 4
--Submitter's note: Tested all code through a new 'BIKE' database query file. Any compilation errors can be solved through changing the database in the top left menu to 'BIKE'

--1. List the customers from California who bought red mountain bikes in September 2003. 
--Use order date as date bought. Multi-color bikes with red are considered red bikes.
SELECT CU.CUSTOMERID, CU.LASTNAME, CU.FIRSTNAME, BI.MODELTYPE, PA.COLORLIST, ORDERDATE, SALESTATE
	FROM BIKE..CUSTOMER CU INNER JOIN BIKE..Bicycle BI ON CU.CustomerID = BI.CustomerID
		INNER JOIN BIKE..Paint PA ON BI.PaintID=PA.PaintID
			WHERE PA.ColorList LIKE '%RED%'
				AND BI.ModelType LIKE '%MOUNTAIN%'
					AND SaleState ='CA'
						AND YEAR(BI.OrderDate) = '2003' AND MONTH(BI.OrderDate)=09;


--2. List the employees who sold race bikes shipped to Wisconsin without the help of a retail store in 2001, 
--Without help of retail store means rders completed without the help of a retail store are walk-in or direct sales.
SELECT e.EmployeeID, e.LastName, b.SaleState, b.ModelType, b.StoreID, b.OrderDate
FROM Bicycle b inner join Employee e on e.EmployeeID = b.EmployeeID
WHERE modeltype = 'race' and SaleState = 'wi' and OrderDate like '%2001%';


--3. List all of the (distinct) rear derailleurs installed on road bikes sold in Florida in 2002.
--ComponentID	ManufacturerName	ProductNumber
SELECT DISTINCT COMP.COMPONENTID, MAN.ManufacturerNAME, ProductNumber
	FROM BIKE..Component COMP INNER JOIN BIKE..Manufacturer MAN ON COMP.ManufacturerID = MAN.ManufacturerID
		INNER JOIN BIKE..BikeParts BP ON COMP.ComponentID = BP.ComponentID
			INNER JOIN BIKE..Bicycle BI ON BP.SerialNumber = BI.SerialNumber
				WHERE BI.ModelType LIKE '%ROAD%'
					AND COMP.Category LIKE '%REAR DERAILLEUR%'
						AND BI.SaleState ='FL'
							AND YEAR(BI.OrderDate) = 2002;	


--4. Who bought the largest (frame size) full suspension mountain bike sold in Georgia in 2004?
--CustomerID	LastName	FirstName	ModelType	SaleState	FrameSize	OrderDate
SELECT CU.CUSTOMERID, CU.LASTNAME, CU.FIRSTNAME, BI.MODELTYPE, BI.SALESTATE, BI.FRAMESIZE, BI.ORDERDATE
	FROM BIKE..Customer CU INNER JOIN BIKE..Bicycle BI ON CU.CustomerID = BI.CustomerID
		WHERE BI.ModelType ='Mountain full'
			AND BI.SaleState = 'GA'
				AND YEAR(BI.ORDERDATE) = 2004
				AND BI.FrameSize = (SELECT MAX(BI.FrameSize)
										FROM BIKE..Bicycle BI
											WHERE BI.ModelType = 'Mountain full'
												AND BI.SaleState ='GA'
													AND YEAR(OrderDate) = 2004);


--5. Which manufacturer gave us the largest discount on an order in 2003?
--ManufacturerID	ManufacturerName
SELECT MAN.ManufacturerID, ManufacturerName, OrderDate
	FROM BIKE..Manufacturer MAN INNER JOIN BIKE..PurchaseOrder PO ON MAN.ManufacturerID = PO.ManufacturerID
		WHERE YEAR(PO.OrderDate)= 2003
			AND PO.Discount = (SELECT MAX(DISCOUNT)
								FROM BIKE..PurchaseOrder
									WHERE YEAR(OrderDate) =2003);


--6. What is the most expensive road bike component we stock that has a quantity on hand greater than 200 units?
--ComponentID	ManufacturerName	ProductNumber	Road	Category	ListPrice	QuantityOnHand
SELECT COMP.ComponentID, MAN.ManufacturerName, COMP.ProductNumber, COMP.Road, COMP.Category, COMP.ListPrice, COMP.QuantityOnHand
	FROM BIKE..Component COMP INNER JOIN BIKE..Manufacturer MAN ON COMP.ManufacturerID = MAN.ManufacturerID
		WHERE COMP.QuantityOnHand > 200
			AND COMP.Road ='ROAD'
				AND COMP.ListPrice = (SELECT MAX(LISTPRICE)
										FROM BIKE..Component
											WHERE QuantityOnHand >200
												AND ROAD = 'ROAD');


--9. What was the most popular letter style on race bikes in 2003?
--LetterStyleID	CountOfSerialNumber
SELECT LetterStyleId, Count(SerialNumber) FROM Bicycle WHERE ModelType = 'race' AND OrderDate = '2003' GROUP BY LetterStyleId;


--13. Which employee painted the most red race bikes in May 2003?
--EmployeeID	LastName	Number Painted
SELECT Employee.EmployeeID, EMPLOYEE.LastName, Count(SerialNumber) AS Num_Painted
FROM Employee INNER JOIN Bicycle ON Employee.EmployeeID = Bicycle.EmployeeID INNER JOIN Paint ON Bicycle.PaintID = Paint.PaintID
WHERE Paint.ColorList = 'red' AND Bicycle.ModelType = 'race' AND YEAR(StartDate) = '2003' AND MONTH(StartDate) = 05
GROUP BY Employee.EmployeeID, EMPLOYEE.LastName


--14. Which California bike shop helped sell the most bikes (by value) in 2003?
--StoreID	StoreName	City	SumOfSalePrice
SELECT RetailStore.StoreID, RetailStore.StoreName, RetailStore.CityID, Sum(Bicycle.SalePrice) AS SumOfSalePrice
FROM RetailStore JOIN Bicycle ON RetailStore.StoreID = Bicycle.StoreID JOIN City ON RetailStore.CityID = City.CityID 
WHERE City.State = 'Ca' AND YEAR(Bicycle.OrderDate) = '2003'
GROUP BY RetailStore.StoreID, RetailStore.StoreName,RetailStore.CityID;


--16. What is the total list price of all items in the 2002 Campy Record groupo?
--GroupName	SumOfListPrice
SELECT GROUPNAME, SUM(LISTPRICE) AS SumOfListPrice
	FROM BIKE..Groupo GR INNER JOIN BIKE..GroupComponents GC ON GR.ComponentGroupID = GC.GroupID
		INNER JOIN BIKE..Component COMP ON GC.ComponentID = COMP.ComponentID
			WHERE GroupName ='Campy Record 2002'
				GROUP BY GroupName;


--19. What is the average top tube length for a 54 cm (frame size) road bike built in 1999?
--AvgOfTopTube
SELECT AVG(TOPTUBE) AS AvgOfTopTube
	FROM BIKE..Bicycle
		WHERE FrameSize ='54'
			AND ModelType ='ROAD'
				AND YEAR(StartDate) = 1999;


--21. In May 2003, which employees sold road bikes that they also painted?
--EmployeeID	LastName
SELECT Employee.EmployeeID, LastName
FROM Employee FULL OUTER JOIN Bicycle ON Employee.EmployeeID = Bicycle.EmployeeID
WHERE YEAR(Bicycle.StartDate) = 2003 AND MONTH(Bicycle.StartDate) = 05 AND Employee.EMPLOYEEID = Bicycle.Painter AND Bicycle.ModelType = 'race';


--22. In 2002, was the Old English letter style more popular with some paint jobs?
--PaintID	ColorName	Number of Bikes Painted
SELECT TOP 1 Paint.PaintID, Paint.ColorName, Count(Bicycle.SerialNumber) AS Number_Painted 
FROM Bicycle JOIN Paint ON Bicycle.PaintID = Paint.PaintID 
WHERE Bicycle.StartDate = '2003'
GROUP BY Paint.PaintID , Paint.ColorName
ORDER BY Count(Bicycle.SerialNumber) DESC;


--23. Which race bikes in 2003 sold for more than the average price of race bikes in 2002?
--SerialNumber	ModelType	OrderDate	SalePrice
SELECT SerialNumber, ModelType, OrderDate, SalePrice
	FROM BIKE..Bicycle
		WHERE ModelType LIKE '%RACE%'
			AND YEAR(OrderDate)= 2003
				AND SalePrice > (SELECT AVG(SalePrice)
									FROM BIKE..Bicycle
										WHERE ModelType LIKE '%RACE%'
											AND YEAR(OrderDate) = 2003);


--26. List all of the employees who report to Venetiaan.
--LastName	EmployeeID	LastName	FirstName	Title
SELECT EMPLOYEEID, LASTNAME, FIRSTNAME, TITLE
	FROM BIKE..EMPLOYEE
		WHERE CurrentManager =(SELECT EmployeeID
								FROM BIKE..Employee
									WHERE LastName ='Venetiaan');

