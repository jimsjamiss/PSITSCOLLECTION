USE DBCollection

create procedure sp_Update @id int, @IDNumber int, @FName varchar(255), @LName varchar(255), @Course varchar(255)
AS
UPDATE Student
SET 
IDNumber = @IDNumber,
FName = @FName,
LName = @LName,
Course = @Course
WHERE id = @id;

EXEC  sp_Update 3,125,'b','a','BSCS'



Create Procedure sp_DeleteUser
(
 @uId int
)
As
Begin
Delete From Student Where id = @uId
End

EXEC sp_Delete 4