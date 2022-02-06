alter PROCEDURE PROC_INSERTPERSON 
@fisrt_name VARCHAR(100),
@email VARCHAR(100),
@username VARCHAR(100)	
AS

BEGIN 
declare @ret int

IF NOT EXISTS(SELECT * FROM Person WHERE fisrt_name = @fisrt_name and email=@email and username=@username)
begin
  insert into Person(fisrt_name,email,username)values(@fisrt_name,@email,@username)
  set @ret =1
  Select 'Dado cadastrado'
end
ELSE 
  set @ret = 0

END