--Task2(1)
CREATE TABLE Students (
	StudentID INT PRIMARY KEY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Age INT,
	Course VARCHAR(50));
Go
--Task2(2)
CREATE TABLE Courses (
	CourseID INT PRIMARY KEY,
	CourseName VARCHAR(50));
Go
SELECT * FROM Courses;
--ALTER TABLE Students
--drop table Students;
ALTER TABLE Students
ADD Course_ID INT;
Go


UPDATE Students
SET Course_ID =(SELECT CourseID FROM Courses WHERE CourseName = Students.Course);


ALTER TABLE Students
ADD CONSTRAINT FK_Courses
FOREIGN KEY (Course_ID) REFERENCES Courses(CourseID);
Go
--Task3(1)
INSERT INTO Courses(CourseID, CourseName)
VALUES (1, 'English'),
       (2, 'Urdu'),
       (3, 'Biology'),
	   (4, 'Maths'),
	   (5, 'General Science');
GO
--Task3(2)
INSERT INTO Students(StudentID,FirstName,LastName,Age,Course)
VALUES (1, 'Ayesha','Ali',20,'English'),
	   (2, 'Fatima','Bashir',18,'Maths'),
	   (3, 'Maliha','Usman',20,'Biology'),
	   (4, 'Kainat','Fatima',21,'Maths'),
	   (5, 'Zainab','Batool',19,'General Science'),
	   (6, 'Jannat','Kamran',22,'English'),
	   (7, 'Noor','Fatima',20,'Biology'),
	   (8, 'Eshal','Mujahid',21,''),
	   (9, 'Fatima','Ali',17,'English'),
	   (10, 'Rida','Fatima',18,'');
Go
--Task4(1)
UPDATE Students
SET Age=23
WHERE StudentID=7;
Go
--Task4(2)
DELETE FROM Students
WHERE StudentID=10;
GO
--Task5(1)
SELECT * FROM Students
Where Age>20;
Go
--Task5(2)
SELECT FirstName,LastName,Course FROM Students
Where Course='English';
Go
--Task6(1)
SELECT Count (*) FROM Students;
Go
--Task6(2)
SELECT AVG (Age) FROM Students;
Go
--Task7(1)
SELECT FirstName, LastName FROM Students
Where Course='';
Go
--Task7(2)
SELECT TOP 1 Students.Course_ID,
Count (Course_ID) AS CourseCount, Course

FROM Students
GROUP BY Course,Students.Course_ID
ORDER BY CourseCount DESC;
Go

--Task7(3)
SELECT * FROM Students
WHERE Age> (SELECT AVG (Age) FROM Students);
Go
--TASK (4)
SELECT Courses.CourseID, CourseName ,
COUNT(Students.StudentID) AS Total_Students,
AVG (Students.Age) AS Age
FROM Courses
JOIN Students
ON Courses.CourseID=Students.Course_ID
GROUP BY Courses.CourseID,CourseName;


--Task7(5)
SELECT CourseID FROM Courses
WHERE CourseID NOT IN (SELECT Course_ID from Students);
Go
--TASK 6
SELECT StudentID,FirstName FROM Students
Where Course_ID=(SELECT Course_ID FROM Students WHERE StudentID=1);

--Task 7(7)
SELECT Course_ID,
MIN(Age) AS Y_Age,
MAX(Age) AS O_Age
FROM Students
GROUP BY Course_ID;
Go
----4
--CREATE PROCEDURE GetAllStudents
--AS
--BEGIN
--    SELECT * FROM Students;
--END;
--GO
--GetAllStudents;
--Go
----1
--CREATE PROCEDURE AddStudent
--	@id INT,
--    @FirstName VARCHAR(50),
--	@LastName VARCHAR(50),
--    @Age INT,
--	@Course VARCHAR(50),
--	@CourseID INT
    
--AS
--BEGIN
--    INSERT INTO Students (StudentID,FirstName,LastName,Age,Course,Course_ID)
--    VALUES (@id,@FirstName,@LastName,@Age,@Course,@CourseID);
--END;
--GO
--AddStudent 11,Ghania,Bushra,21,Biology,3;
--Select *from Students;
--Go
----2
--CREATE PROCEDURE UpdateStudentAge
--    @ID INT,
--    @NewAge INT
--AS
--BEGIN
--    UPDATE Students
--    SET Age = @NewAge
--    WHERE StudentID = @ID;
--END;
--GO
--UpdateStudentAge 14,11;
--Go
----3
--CREATE PROCEDURE DeleteStudent
--    @ID INT
--AS
--BEGIN
--    DELETE FROM Students
--    WHERE StudentID = @ID;
--END;
--GO
----DeleteStudent 11;
drop Table Students;
drop Table Courses;
----drop Procedure GetallStudents;

