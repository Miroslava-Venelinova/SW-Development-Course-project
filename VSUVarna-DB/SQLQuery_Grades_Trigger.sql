CREATE OR ALTER TRIGGER tr_AddGradeCalculateAverage
ON Grades AFTER INSERT 
AS
	DECLARE @id VARCHAR(10)
	DECLARE @average_grade DECIMAL(3,2)

	SET @id = (SELECT student_id FROM inserted)
	SET @average_grade = (SELECT AVG(grade_value) FROM Grades WHERE student_id = @id)

	UPDATE Students
	SET average_grade = @average_grade
	WHERE faculty_number = @id
GO
