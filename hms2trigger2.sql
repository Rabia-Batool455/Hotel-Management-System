CREATE TRIGGER tr_RoomsInsert 
ON  RoomType
FOR INSERT
AS
BEGIN
DECLARE @Id INT 

	SELECT @Id =  RoomTypeID FROM inserted

	INSERT INTO AuditRooms VALUES ('New hotel with RoomTypeID = ' + CAST(@Id AS NVARCHAR) + ' inserted on ' + CAST(GETDATE() AS NVARCHAR))
END
GO

CREATE TRIGGER tr_RoomsDelete 
ON  RoomType
FOR DELETE
AS
BEGIN
DECLARE @Id INT 

	SELECT @Id = RoomTypeID FROM deleted

	INSERT INTO AuditRooms VALUES ('Existing hotel with RoomTypeID= ' + CAST(@Id AS NVARCHAR) + ' deleted on ' + CAST(GETDATE() AS NVARCHAR))
END