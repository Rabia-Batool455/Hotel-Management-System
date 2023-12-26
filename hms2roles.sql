-- 1. Create roles/groups for security in the database.
CREATE ROLE AdminRole1;
CREATE ROLE ManagerRole1;
CREATE ROLE StaffRole1;

-- 2. Modify access for those roles/groups.
--  Grant AdminRole the ability to view tables relevant

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.RoomType TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Room TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Guest TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Staff TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Servicess TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Reservation TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Payment TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Invoice TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.RoomService TO AdminRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.RoomBooking TO AdminRole1;


--  Grant ManagerRole the ability to view relevant table

GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Room TO ManagerRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Guest TO ManagerRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Servicess TO ManagerRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Reservation TO ManagerRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Payment TO ManagerRole1;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.Invoice TO ManagerRole1;



--  Grant StaffRole the ability to view relevant tables

GRANT SELECT, INSERT ON dbo.Reservation TO StaffRole1;
GRANT SELECT, INSERT ON dbo.RoomService TO StaffRole1;
GRANT SELECT ON dbo.Guest TO StaffRole1;

-- 3. Create three new database users:
-- 4. Add each user to the appropriate role\group.
-- Create new database users and add them to roles/groups

-- Create User_ADMIN and add to AdminRole
CREATE LOGIN User_ADMIN1 WITH PASSWORD = 'User_ADMIN1';
CREATE USER User_ADMIN1 FOR LOGIN User_ADMIN1;
ALTER ROLE AdminRole1 ADD MEMBER User_ADMIN1;

-- Create User_MANAGER and add to ManagerRole
CREATE LOGIN User_MANAGER1 WITH PASSWORD = 'User_MANAGER1';
CREATE USER User_MANAGER1 FOR LOGIN User_MANAGER1;
ALTER ROLE ManagerRole1 ADD MEMBER User_MANAGER1;

-- Create User_Staff and add to StaffRole
CREATE LOGIN User_Staff1 WITH PASSWORD = 'User_Staff1';
CREATE USER User_Staff1 FOR LOGIN User_Staff1;
ALTER ROLE StaffRole1 ADD MEMBER User_Staff1;
