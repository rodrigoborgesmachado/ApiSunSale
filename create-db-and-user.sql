-- Check if the database exists before creating it
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SUNSALE')
BEGIN
    CREATE DATABASE [SUNSALE];
    PRINT 'Database created successfully!';
END
ELSE
BEGIN
    PRINT 'Database already exists.';
END
GO

-- Switch to the new database
USE [SUNSALE];
GO

-- Check if the login already exists before creating it
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'padrao')
BEGIN
    -- Create the 'padrao' login
    CREATE LOGIN padrao WITH PASSWORD = '}u+LhDa-Tc_%26V=';
    PRINT 'Login created successfully!';
END
ELSE
BEGIN
    PRINT 'Login already exists.';
END
GO

-- Check if the user already exists before creating it
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'padrao')
BEGIN
    -- Create the 'padrao' user
    CREATE USER padrao FOR LOGIN padrao;
    PRINT 'User created successfully!';
    
    -- Grant 'padrao' user the 'db_owner' role in the SUNSALE database
    EXEC sp_addrolemember 'db_owner', 'padrao';
    PRINT 'User granted db_owner role.';
END
ELSE
BEGIN
    PRINT 'User already exists.';
END
GO
