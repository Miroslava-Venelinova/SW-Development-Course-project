CREATE OR ALTER PROC usp_AddAddress @city NVARCHAR(30), @street NVARCHAR(30)
AS
	INSERT INTO Addresses 
	VALUES (@city, @street)
GO

CREATE OR ALTER PROC usp_UpdateAddress 
@address_id INT, @city NVARCHAR(30), @street NVARCHAR(30)
AS 
	UPDATE Addresses
	SET city = @city, street = @street 
	WHERE address_id = @address_id
GO

CREATE OR ALTER PROC usp_AddMajor @major_name NVARCHAR(30)
AS
	INSERT INTO Majors
	VALUES (@major_name)
GO

CREATE OR ALTER PROC usp_DeleteMajor @major_id INT 
AS
	DELETE FROM Majors_Fees
	WHERE major = @major_id

	DELETE FROM Students
	WHERE major = @major_id

	DELETE FROM Majors
	WHERE major_id = @major_id
GO

CREATE OR ALTER PROC usp_UpdateMajor @major_id INT, @major_name NVARCHAR(30)
AS
	UPDATE Majors
	SET major_name = @major_name
	WHERE major_id = @major_id
GO

CREATE OR ALTER PROC usp_AddMajorFee @major_id INT, @term_fee DECIMAL(5,2)
AS
	INSERT INTO Majors_Fees
	VALUES (@major_id, @term_fee)
GO

CREATE OR ALTER PROC usp_UpdateMajorFee @major_id INT, @new_term_fee DECIMAL(5,2)
AS
	UPDATE Majors_Fees
	SET major_fee = @new_term_fee
	WHERE major = @major_id
GO

CREATE OR ALTER PROC usp_AddTeacher @first_name NVARCHAR(30), @last_name NVARCHAR(30) 
AS
	INSERT INTO Teachers
	VALUES (@first_name, @last_name)
GO

CREATE OR ALTER PROC usp_DeleteTeacher @teacher_id INT
AS
	DELETE FROM Grades
	WHERE teacher_id = @teacher_id

	DELETE FROM Teachers_Subjects
	WHERE teacher = @teacher_id

	DELETE FROM Teachers
	WHERE teacher_id = @teacher_id
GO

CREATE OR ALTER PROC usp_UpdateTeacherFistName @teacher_id INT, @first_name NVARCHAR(30)
AS
	UPDATE Teachers
	SET first_name = @first_name
	WHERE teacher_id = @teacher_id
GO

CREATE OR ALTER PROC usp_UpdateTeacherLastName @teacher_id INT, @last_name NVARCHAR(30)
AS
	UPDATE Teachers
	SET last_name = @last_name
	WHERE teacher_id = @teacher_id
GO

CREATE OR ALTER PROC usp_AddSubject @subject_name NVARCHAR(30)
AS
	INSERT INTO Subjects
	VALUES (@subject_name)
GO

CREATE OR ALTER PROC usp_DeleteSubject @subject_id INT
AS
	DELETE FROM Students_Subjects
	WHERE [subject] = @subject_id

	DELETE FROM Teachers_Subjects 
	WHERE [subject] = @subject_id

	DELETE FROM Grades
	WHERE subject_id = @subject_id

	DELETE FROM Subjects
	WHERE subject_id = @subject_id
GO

CREATE OR ALTER PROC usp_UpdateSubject @subject_id INT, @subject_name NVARCHAR(30)
AS
	UPDATE Subjects
	SET subject_name = @subject_name
	WHERE subject_id = @subject_id
GO

CREATE OR ALTER PROC usp_AddTeacherSubjectPair @teacher_id INT, @subject_id INT
AS
	INSERT INTO Teachers_Subjects
	VALUES (@teacher_id, @subject_id)
GO

CREATE OR ALTER PROC usp_UpdateTeachersSubject @teacher_id INT, @subject_id INT, @new_subject INT
AS
	UPDATE Teachers_Subjects
	SET [subject] = @new_subject
	WHERE teacher = @teacher_id AND [subject] = @subject_id
GO

CREATE OR ALTER PROC usp_UpdateSubjectTeacher @subject_id INT, @teacher_id INT, @new_teacher INT
AS
	UPDATE Teachers_Subjects
	SET teacher = @new_teacher
	WHERE teacher = @teacher_id AND [subject] = @subject_id
GO

CREATE OR ALTER PROC usp_AddStudentSubjectPair @student_id VARCHAR(10), @subject_id INT 
AS
	INSERT INTO Students_Subjects
	VALUES (@student_id, @subject_id)
GO

CREATE OR ALTER PROC usp_UpdateStudentsSubject @student_id VARCHAR(10), @subject_id INT, @new_subject INT
AS
	UPDATE Students_Subjects
	SET [subject] = @new_subject
	WHERE student = @student_id AND [subject] = @subject_id
GO

CREATE OR ALTER PROC usp_UpdateSubjectStudent @subject_id INT, @student_id VARCHAR(10)
AS
	UPDATE Students_Subjects
	SET student = @student_id
	WHERE [subject] = @subject_id
GO

CREATE OR ALTER PROC usp_AddGrade @entry_date DATETIME, @student VARCHAR(10), @teacher INT, @subject INT, @grade DECIMAL(3,2)
AS
	INSERT INTO Grades 
	VALUES (@entry_date, @student, @teacher, @subject, @grade)
GO

CREATE OR ALTER PROC usp_DeleteGrade @grade_id INT
AS
	DELETE FROM Grades
	WHERE grade_id = @grade_id
GO

CREATE OR ALTER PROC usp_UpdateGrade @grade_id INT, @change_date DATE, @grade DECIMAL(3,2)
AS
	UPDATE Grades
	SET entry_date = @change_date, grade_value = @grade
	WHERE grade_id = @grade_id
GO

CREATE OR ALTER PROC usp_AddStudent @faculty_number VARCHAR(10), @first_name NVARCHAR(30),
@middle_name NVARCHAR(30), @last_name NVARCHAR(30), @address_id INT, @phone_number VARCHAR(10),
@major_id INT, @degree_type NVARCHAR(10), @group INT, @stream INT, @entrollment_date DATETIME
AS
	INSERT INTO Students
	VALUES (@faculty_number, @first_name, @middle_name, @last_name, @address_id, @phone_number,
	@major_id, @degree_type, @group, @stream, NULL, @entrollment_date, NULL)
GO

CREATE OR ALTER PROC usp_DeleteStudent @student_id VARCHAR(10)
AS
	DELETE FROM Students_Subjects
	WHERE student = @student_id

	DELETE FROM Grades
	WHERE student_id = @student_id

	DELETE FROM Students
	WHERE faculty_number = @student_id
GO

CREATE OR ALTER PROC usp_UpdateStudentFirstName @faculty_number VARCHAR(10), @first_name NVARCHAR(30)
AS
	UPDATE Students
	SET first_name = @first_name
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentMiddleName @faculty_number VARCHAR(10), @middle_name NVARCHAR(30)
AS
	UPDATE Students
	SET middle_name = @middle_name
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentLastName @faculty_number VARCHAR(10), @last_name NVARCHAR(30)
AS
	UPDATE Students
	SET last_name = @last_name
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentAddress @faculty_number VARCHAR(10), @address INT
AS
	UPDATE Students
	SET [address] = @address
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentPhoneNumber @faculty_number VARCHAR(10), @phone_number VARCHAR(10)
AS
	UPDATE Students
	SET phone_number = @phone_number
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentGroup @faculty_number VARCHAR(10), @group INT 
AS
	UPDATE Students
	SET [group] = @group
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC usp_UpdateStudentEnrollmentDate @faculty_number VARCHAR(10), @new_date DATE
AS
	UPDATE Students
	SET enrollment_date = @new_date
	WHERE faculty_number = @faculty_number
GO
