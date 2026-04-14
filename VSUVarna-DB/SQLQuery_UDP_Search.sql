CREATE OR ALTER PROC udp_GetStudentByFacultyNumber @faculty_number VARCHAR(10) 
AS
	SELECT * FROM Students 
	WHERE faculty_number = @faculty_number
GO

CREATE OR ALTER PROC udp_GetStudentByName @first_name NVARCHAR(30), 
@middle_name NVARCHAR(30), @last_name NVARCHAR(30) 
AS
	SELECT * FROM Students
	WHERE first_name = @first_name AND
		middle_name = @middle_name AND
		last_name = @last_name
GO

CREATE OR ALTER PROC udp_GetStudentBySubject @subject_id INT
AS
	SELECT s.* FROM Students AS s
	JOIN Students_Subjects AS ssub
		ON s.faculty_number = ssub.student
	JOIN Subjects AS sub
		ON sub.subject_id = ssub.[subject]
	WHERE ssub.[subject] = @subject_id
GO

CREATE OR ALTER PROC udp_GetStudentByAverageGrades @average_grade DECIMAL(3,2)
AS
	SELECT * FROM Students
	WHERE average_grade = @average_grade
GO

CREATE OR ALTER PROC udp_GetGradesByFacultyNumber @faculty_number NVARCHAR(10)
AS
	SELECT * FROM Grades
	WHERE student_id = @faculty_number
GO

CREATE OR ALTER PROC udp_GetStudentsWith1000UnpaidFees
AS
	SELECT * FROM Students
	WHERE unpaid_fees > 1000 
GO

CREATE OR ALTER PROC udp_GetAverageGradeByTeacher @teacher_id INT
AS
	SELECT AVG(s.average_grade) AS AverageGrade FROM Students AS s
	JOIN Students_Subjects AS stsub
		ON s.faculty_number = stsub.student
	JOIN Subjects AS sub
		ON sub.subject_id = stsub.[subject]
	JOIN Teachers_Subjects AS tsub
		ON sub.subject_id = tsub.[subject]
	JOIN Teachers AS t
		ON t.teacher_id = tsub.teacher
	WHERE teacher_id = @teacher_id
GO

CREATE OR ALTER PROC udp_GetGradeCount @period_start DATETIME, @period_end DATETIME
AS
	SELECT COUNT(*) AS GradeCount FROM Grades
	WHERE entry_date BETWEEN @period_start AND @period_end
GO

CREATE OR ALTER PROC udp_GetLastEnrolledStudents
AS
	SELECT TOP 10 * FROM Students
	ORDER BY enrollment_date ASC
GO

