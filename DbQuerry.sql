CREATE DATABASE DanaosDB
GO

CREATE TABLE Students(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE Grades(
Student_Id INT NOT NULL,
Course_Id INT NOT NULL,
Course_Name NVARCHAR(50) NOT NULL,
Grade Numeric(4,2) NOT NULL,
CONSTRAINT Composite_Key PRIMARY KEY(Student_Id,Course_Id )
)
GO

INSERT INTO Students 
VALUES
('Nikos'),
('Giannis'),
('Panagiotis')
GO

SELECT * FROM Students

INSERT INTO Grades
VALUES
(1, 1, 'Mathimatika', 11.99),
(1, 2, 'Fysiki', 14.45 ),
(2, 1, 'Mathimatika', 14.99),
(2, 2, 'Fysiki', 09.45 ),
(3, 1, 'Mathimatika', 05.88),
(3, 2, 'Fysiki', 03.47 )
GO

SELECT * FROM Grades