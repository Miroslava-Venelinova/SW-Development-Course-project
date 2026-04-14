CREATE OR ALTER PROC udp_ChargeNewTermFee @faculty_number VARCHAR(10)
AS
	DECLARE @major_fee DECIMAL(7,2)
	DECLARE @major INT

	SET @major = (
	SELECT m.major_id FROM Students s 
	JOIN Majors m ON s.major = m.major_id
	WHERE faculty_number = @faculty_number)
	
	SET @major_fee = (
	SELECT major_fee FROM Majors_Fees AS mfee
	JOIN Majors AS m
		ON mfee.major = m.major_id
	WHERE mfee.major = @major)

	UPDATE Students
	SET unpaid_fees = unpaid_fees + @major_fee
	WHERE faculty_number = @faculty_number 
GO

CREATE OR ALTER PROC udp_MakeTermFeeDeposit @faculty_number VARCHAR(10), @deposit_amount DECIMAL
AS

	IF @deposit_amount >= (SELECT unpaid_fees FROM Students WHERE faculty_number = @faculty_number) 
		UPDATE Students 
		SET unpaid_fees = 0.0
		WHERE faculty_number = @faculty_number
	ELSE	
		UPDATE Students
		SET unpaid_fees = unpaid_fees - @deposit_amount
		WHERE faculty_number = @faculty_number
GO
