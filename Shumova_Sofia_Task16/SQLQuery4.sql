
Use [PersonAward]
Go

CREATE PROCEDURE GetPersons
As
	RETURN SELECT *
		FROM Person
Go

CREATE PROCEDURE GetPersonByID(@id int)
As
	RETURN SELECT ID, FirstName, LastName, DateBirth
		FROM Person
			WHERE ID = @id
Go

CREATE PROCEDURE AddPerson(
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@birthdate datetime)
As
	--DECLARE @insertedUsers TABLE (UserId int);
	INSERT INTO Person(FirstName, LastName, DateBirth)
		--OUTPUT INSERTED.ID INTO @insertedUsers(UserId)
			VALUES(@firstName, @lastName, @birthdate)
	--RETURN SELECT UserId FROM @insertedUsers

Go

CREATE PROCEDURE DeletePerson(@personId int)
As
	DELETE FROM Person WHERE ID = @personId;
Go

CREATE PROCEDURE UpdatePersonByID(@id int, @newFirstName nvarchar(50), @newLastName nvarchar(50), @newDateDirth date)
AS
  UPDATE Person
   SET FirstName = @newFirstName, LastName=@newLastName, DateBirth = @newDateDirth
   WHERE ID = @id
GO

CREATE PROCEDURE UpdateAwardByID(@id int, @newName nvarchar(50), @newDesc nvarchar(250))
AS
  UPDATE Award
   SET Name = @newName, Description=@newDesc
   WHERE ID = @id
GO

CREATE PROCEDURE GetAwards
As
	RETURN SELECT *
		FROM Award
Go

CREATE PROCEDURE AddAward (@nameAward nvarchar(50), @descAward nvarchar(250))
As
	INSERT INTO Award
		 VALUES (@nameAward, @descAward);
Go

CREATE PROCEDURE DeleteAward(@id int)
AS
  DELETE FROM PersonAndAwards WHERE ID_Award = @id
   DELETE FROM Award WHERE ID = @id
GO

CREATE PROCEDURE GetAwardsForPerson(@id_person int)
AS
	RETURN SELECT Award.*
			FROM PersonAndAwards INNER JOIN Award ON Award.ID = PersonAndAwards.ID_Award
			WHERE ID_Person = @id_person;
GO

CREATE PROCEDURE AddAwardForPerson(@id_person int,@id_award int)
AS
	if(NOT EXISTS(SELECT * FROM PersonAndAwards WHERE ID_Award =@id_award AND ID_Person = @id_person))
	INSERT INTO PersonAndAwards
		 VALUES (@id_award, @id_person);
GO



EXEC AddAwardForPerson @id_person = 1, @id_award = 6
EXEC DeleteAward @id = 1

GetAwardsForPerson

DROP PROCEDURE AddAward

SELECT * FROM Person
SELECT * FROM Award
SELECT * FROM PersonAndAwards