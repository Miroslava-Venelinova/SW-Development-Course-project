CREATE DATABASE DB
GO
USE DB
GO

CREATE TABLE Addresses(
address_id INT IDENTITY(1,1) PRIMARY KEY, 
city NVARCHAR(30) NOT NULL, 
street NVARCHAR(30) NOT NULL
)
GO

CREATE TABLE Majors(
major_id INT IDENTITY(1,1) PRIMARY KEY,
major_name NVARCHAR(30) NOT NULL
)
GO

CREATE TABLE Majors_Fees(
major INT REFERENCES Majors(major_id) NOT NULL,
major_fee DECIMAL(7,2) NOT NULL
) 
GO

CREATE TABLE Students(
faculty_number VARCHAR(10) PRIMARY KEY, 
first_name NVARCHAR(30) NOT NULL,
middle_name NVARCHAR(30) NOT NULL, 
last_name NVARCHAR(30) NOT NULL, 
[address] INT REFERENCES Addresses(address_id) NOT NULL,
phone_number VARCHAR(10) NOT NULL,
major INT REFERENCES Majors(major_id) NOT NULL,
degree_type NVARCHAR(10) NOT NULL,
[group] INT NOT NULL, 
[stream] INT NOT NULL,
average_grade DECIMAL(3,2) NULL,
enrollment_date DATETIME NOT NULL, 
unpaid_fees DECIMAL(7, 2) NULL
)
GO

CREATE TABLE Subjects(
subject_id INT IDENTITY(1,1) PRIMARY KEY,
subject_name NVARCHAR(30) NOT NULL
)
GO

CREATE TABLE Students_Subjects(
student VARCHAR(10) REFERENCES Students(faculty_number) NOT NULL,
[subject] INT REFERENCES Subjects(subject_id) NOT NULL
)
GO

CREATE TABLE Teachers(
teacher_id INT IDENTITY(1,1) PRIMARY KEY,
first_name NVARCHAR(30) NOT NULL,
last_name NVARCHAR(30) NOT NULL,
)
GO

CREATE TABLE Teachers_Subjects(
teacher INT REFERENCES Teachers(teacher_id) NOT NULL, 
[subject] INT REFERENCES Subjects(subject_id) NOT NULL,
)
GO

CREATE TABLE Grades(
grade_id INT IDENTITY(1,1) PRIMARY KEY,
entry_date DATETIME NOT NULL, 
student_id VARCHAR(10) REFERENCES Students(faculty_number) NOT NULL,
teacher_id INT REFERENCES Teachers(teacher_id) NOT NULL,
subject_id INT REFERENCES Subjects(subject_id) NOT NULL, 
grade_value DECIMAL(3,2) NOT NULL
)
GO