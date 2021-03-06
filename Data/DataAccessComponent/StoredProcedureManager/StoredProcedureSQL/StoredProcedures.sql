Use [DataTier.Net.Database.Dev]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Insert >>>'

    End

GO

Create PROCEDURE Admin_Insert

    -- Add the parameters for the stored procedure here
    @CheckForUpdates bit,
    @CodeVersion nvarchar(20),
    @GitCommit nvarchar(10),
    @LastUpdated datetime,
    @SchemaHash nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Admin]
    ([CheckForUpdates],[CodeVersion],[GitCommit],[LastUpdated],[SchemaHash])

    -- Begin Values List
    Values(@CheckForUpdates, @CodeVersion, @GitCommit, @LastUpdated, @SchemaHash)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Update >>>'

    End

GO

Create PROCEDURE Admin_Update

    -- Add the parameters for the stored procedure here
    @AdminId int,
    @CheckForUpdates bit,
    @CodeVersion nvarchar(20),
    @GitCommit nvarchar(10),
    @LastUpdated datetime,
    @SchemaHash nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Admin]

    -- Update Each field
    Set [CheckForUpdates] = @CheckForUpdates,
    [CodeVersion] = @CodeVersion,
    [GitCommit] = @GitCommit,
    [LastUpdated] = @LastUpdated,
    [SchemaHash] = @SchemaHash

    -- Update Matching Record
    Where [AdminId] = @AdminId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Find >>>'

    End

GO

Create PROCEDURE Admin_Find

    -- Primary Key Paramater
    @AdminId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AdminId],[CheckForUpdates],[CodeVersion],[GitCommit],[LastUpdated],[SchemaHash]

    -- From tableName
    From [Admin]

    -- Find Matching Record
    Where [AdminId] = @AdminId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing Admin
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_Delete >>>'

    End

GO

Create PROCEDURE Admin_Delete

    -- Primary Key Paramater
    @AdminId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Admin]

    -- Delete Matching Record
    Where [AdminId] = @AdminId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Admin_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all Admin objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Admin_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Admin_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Admin_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Admin_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Admin_FetchAll >>>'

    End

GO

Create PROCEDURE Admin_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AdminId],[CheckForUpdates],[CodeVersion],[GitCommit],[LastUpdated],[SchemaHash]

    -- From tableName
    From [Admin]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfo_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new ControlInfo
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfo_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfo_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfo_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfo_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfo_Insert >>>'

    End

GO

Create PROCEDURE ControlInfo_Insert

    -- Add the parameters for the stored procedure here
    @Name nvarchar(50),
    @PackageName nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ControlInfo]
    ([Name],[PackageName])

    -- Begin Values List
    Values(@Name, @PackageName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfo_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing ControlInfo
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfo_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfo_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfo_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfo_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfo_Update >>>'

    End

GO

Create PROCEDURE ControlInfo_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(50),
    @PackageName nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ControlInfo]

    -- Update Each field
    Set [Name] = @Name,
    [PackageName] = @PackageName

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfo_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing ControlInfo
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfo_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfo_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfo_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfo_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfo_Find >>>'

    End

GO

Create PROCEDURE ControlInfo_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[PackageName]

    -- From tableName
    From [ControlInfo]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfo_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing ControlInfo
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfo_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfo_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfo_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfo_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfo_Delete >>>'

    End

GO

Create PROCEDURE ControlInfo_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ControlInfo]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfo_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all ControlInfo objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfo_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfo_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfo_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfo_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfo_FetchAll >>>'

    End

GO

Create PROCEDURE ControlInfo_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[PackageName]

    -- From tableName
    From [ControlInfo]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfoDetail_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new ControlInfoDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfoDetail_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfoDetail_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfoDetail_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfoDetail_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfoDetail_Insert >>>'

    End

GO

Create PROCEDURE ControlInfoDetail_Insert

    -- Add the parameters for the stored procedure here
    @CodeText nvarchar(255),
    @DisplayOrder int,
    @UIControlId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ControlInfoDetail]
    ([CodeText],[DisplayOrder],[UIControlId])

    -- Begin Values List
    Values(@CodeText, @DisplayOrder, @UIControlId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfoDetail_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing ControlInfoDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfoDetail_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfoDetail_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfoDetail_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfoDetail_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfoDetail_Update >>>'

    End

GO

Create PROCEDURE ControlInfoDetail_Update

    -- Add the parameters for the stored procedure here
    @CodeText nvarchar(255),
    @DisplayOrder int,
    @Id int,
    @UIControlId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ControlInfoDetail]

    -- Update Each field
    Set [CodeText] = @CodeText,
    [DisplayOrder] = @DisplayOrder,
    [UIControlId] = @UIControlId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfoDetail_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing ControlInfoDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfoDetail_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfoDetail_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfoDetail_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfoDetail_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfoDetail_Find >>>'

    End

GO

Create PROCEDURE ControlInfoDetail_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeText],[DisplayOrder],[Id],[UIControlId]

    -- From tableName
    From [ControlInfoDetail]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfoDetail_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing ControlInfoDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfoDetail_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfoDetail_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfoDetail_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfoDetail_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfoDetail_Delete >>>'

    End

GO

Create PROCEDURE ControlInfoDetail_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ControlInfoDetail]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ControlInfoDetail_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all ControlInfoDetail objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ControlInfoDetail_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ControlInfoDetail_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ControlInfoDetail_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ControlInfoDetail_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ControlInfoDetail_FetchAll >>>'

    End

GO

Create PROCEDURE ControlInfoDetail_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [CodeText],[DisplayOrder],[Id],[UIControlId]

    -- From tableName
    From [ControlInfoDetail]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CustomReader_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new CustomReader
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CustomReader_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CustomReader_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CustomReader_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CustomReader_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CustomReader_Insert >>>'

    End

GO

Create PROCEDURE CustomReader_Insert

    -- Add the parameters for the stored procedure here
    @ClassName nvarchar(40),
    @FieldSetId int,
    @FileName nvarchar(255),
    @ReaderName nvarchar(40),
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [CustomReader]
    ([ClassName],[FieldSetId],[FileName],[ReaderName],[TableId])

    -- Begin Values List
    Values(@ClassName, @FieldSetId, @FileName, @ReaderName, @TableId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CustomReader_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing CustomReader
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CustomReader_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CustomReader_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CustomReader_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CustomReader_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CustomReader_Update >>>'

    End

GO

Create PROCEDURE CustomReader_Update

    -- Add the parameters for the stored procedure here
    @ClassName nvarchar(40),
    @CustomReaderId int,
    @FieldSetId int,
    @FileName nvarchar(255),
    @ReaderName nvarchar(40),
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [CustomReader]

    -- Update Each field
    Set [ClassName] = @ClassName,
    [FieldSetId] = @FieldSetId,
    [FileName] = @FileName,
    [ReaderName] = @ReaderName,
    [TableId] = @TableId

    -- Update Matching Record
    Where [CustomReaderId] = @CustomReaderId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CustomReader_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing CustomReader
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CustomReader_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CustomReader_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CustomReader_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CustomReader_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CustomReader_Find >>>'

    End

GO

Create PROCEDURE CustomReader_Find

    -- Primary Key Paramater
    @CustomReaderId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClassName],[CustomReaderId],[FieldSetId],[FileName],[ReaderName],[TableId]

    -- From tableName
    From [CustomReader]

    -- Find Matching Record
    Where [CustomReaderId] = @CustomReaderId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CustomReader_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing CustomReader
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CustomReader_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CustomReader_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CustomReader_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CustomReader_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CustomReader_Delete >>>'

    End

GO

Create PROCEDURE CustomReader_Delete

    -- Primary Key Paramater
    @CustomReaderId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [CustomReader]

    -- Delete Matching Record
    Where [CustomReaderId] = @CustomReaderId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: CustomReader_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all CustomReader objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('CustomReader_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure CustomReader_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.CustomReader_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure CustomReader_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure CustomReader_FetchAll >>>'

    End

GO

Create PROCEDURE CustomReader_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClassName],[CustomReaderId],[FieldSetId],[FileName],[ReaderName],[TableId]

    -- From tableName
    From [CustomReader]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNDatabase_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new DTNDatabase
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNDatabase_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNDatabase_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNDatabase_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNDatabase_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNDatabase_Insert >>>'

    End

GO

Create PROCEDURE DTNDatabase_Insert

    -- Add the parameters for the stored procedure here
    @AuthenticationType int,
    @ConnectionString nvarchar(255),
    @DatabaseName nvarchar(50),
    @DatabaseType int,
    @DBPassword nvarchar(50),
    @Exclude int,
    @Path nvarchar(255),
    @ProjectId int,
    @Serializable bit,
    @ServerName nvarchar(50),
    @UserId nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DTNDatabase]
    ([AuthenticationType],[ConnectionString],[DatabaseName],[DatabaseType],[DBPassword],[Exclude],[Path],[ProjectId],[Serializable],[ServerName],[UserId])

    -- Begin Values List
    Values(@AuthenticationType, @ConnectionString, @DatabaseName, @DatabaseType, @DBPassword, @Exclude, @Path, @ProjectId, @Serializable, @ServerName, @UserId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNDatabase_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing DTNDatabase
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNDatabase_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNDatabase_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNDatabase_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNDatabase_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNDatabase_Update >>>'

    End

GO

Create PROCEDURE DTNDatabase_Update

    -- Add the parameters for the stored procedure here
    @AuthenticationType int,
    @ConnectionString nvarchar(255),
    @DatabaseId int,
    @DatabaseName nvarchar(50),
    @DatabaseType int,
    @DBPassword nvarchar(50),
    @Exclude int,
    @Path nvarchar(255),
    @ProjectId int,
    @Serializable bit,
    @ServerName nvarchar(50),
    @UserId nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DTNDatabase]

    -- Update Each field
    Set [AuthenticationType] = @AuthenticationType,
    [ConnectionString] = @ConnectionString,
    [DatabaseName] = @DatabaseName,
    [DatabaseType] = @DatabaseType,
    [DBPassword] = @DBPassword,
    [Exclude] = @Exclude,
    [Path] = @Path,
    [ProjectId] = @ProjectId,
    [Serializable] = @Serializable,
    [ServerName] = @ServerName,
    [UserId] = @UserId

    -- Update Matching Record
    Where [DatabaseId] = @DatabaseId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNDatabase_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing DTNDatabase
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNDatabase_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNDatabase_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNDatabase_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNDatabase_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNDatabase_Find >>>'

    End

GO

Create PROCEDURE DTNDatabase_Find

    -- Primary Key Paramater
    @DatabaseId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AuthenticationType],[ConnectionString],[DatabaseId],[DatabaseName],[DatabaseType],[DBPassword],[Exclude],[Path],[ProjectId],[Serializable],[ServerName],[UserId]

    -- From tableName
    From [DTNDatabase]

    -- Find Matching Record
    Where [DatabaseId] = @DatabaseId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNDatabase_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing DTNDatabase
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNDatabase_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNDatabase_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNDatabase_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNDatabase_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNDatabase_Delete >>>'

    End

GO

Create PROCEDURE DTNDatabase_Delete

    -- Primary Key Paramater
    @DatabaseId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DTNDatabase]

    -- Delete Matching Record
    Where [DatabaseId] = @DatabaseId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNDatabase_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all DTNDatabase objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNDatabase_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNDatabase_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNDatabase_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNDatabase_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNDatabase_FetchAll >>>'

    End

GO

Create PROCEDURE DTNDatabase_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AuthenticationType],[ConnectionString],[DatabaseId],[DatabaseName],[DatabaseType],[DBPassword],[Exclude],[Path],[ProjectId],[Serializable],[ServerName],[UserId]

    -- From tableName
    From [DTNDatabase]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNField_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new DTNField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNField_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNField_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNField_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNField_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNField_Insert >>>'

    End

GO

Create PROCEDURE DTNField_Insert

    -- Add the parameters for the stored procedure here
    @AccessMode int,
    @Caption nvarchar(50),
    @DatabaseId int,
    @DataType int,
    @DecimalPlaces int,
    @DefaultValue nvarchar(50),
    @EnumDataTypeName nvarchar(40),
    @Exclude bit,
    @FieldName nvarchar(64),
    @FieldOrdinal int,
    @FieldSize int,
    @IsEnumeration bit,
    @IsNullable int,
    @PrimaryKey bit,
    @ProjectId int,
    @Required bit,
    @Scope int,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DTNField]
    ([AccessMode],[Caption],[DatabaseId],[DataType],[DecimalPlaces],[DefaultValue],[EnumDataTypeName],[Exclude],[FieldName],[FieldOrdinal],[FieldSize],[IsEnumeration],[IsNullable],[PrimaryKey],[ProjectId],[Required],[Scope],[TableId])

    -- Begin Values List
    Values(@AccessMode, @Caption, @DatabaseId, @DataType, @DecimalPlaces, @DefaultValue, @EnumDataTypeName, @Exclude, @FieldName, @FieldOrdinal, @FieldSize, @IsEnumeration, @IsNullable, @PrimaryKey, @ProjectId, @Required, @Scope, @TableId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNField_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing DTNField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNField_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNField_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNField_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNField_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNField_Update >>>'

    End

GO

Create PROCEDURE DTNField_Update

    -- Add the parameters for the stored procedure here
    @AccessMode int,
    @Caption nvarchar(50),
    @DatabaseId int,
    @DataType int,
    @DecimalPlaces int,
    @DefaultValue nvarchar(50),
    @EnumDataTypeName nvarchar(40),
    @Exclude bit,
    @FieldId int,
    @FieldName nvarchar(64),
    @FieldOrdinal int,
    @FieldSize int,
    @IsEnumeration bit,
    @IsNullable int,
    @PrimaryKey bit,
    @ProjectId int,
    @Required bit,
    @Scope int,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DTNField]

    -- Update Each field
    Set [AccessMode] = @AccessMode,
    [Caption] = @Caption,
    [DatabaseId] = @DatabaseId,
    [DataType] = @DataType,
    [DecimalPlaces] = @DecimalPlaces,
    [DefaultValue] = @DefaultValue,
    [EnumDataTypeName] = @EnumDataTypeName,
    [Exclude] = @Exclude,
    [FieldName] = @FieldName,
    [FieldOrdinal] = @FieldOrdinal,
    [FieldSize] = @FieldSize,
    [IsEnumeration] = @IsEnumeration,
    [IsNullable] = @IsNullable,
    [PrimaryKey] = @PrimaryKey,
    [ProjectId] = @ProjectId,
    [Required] = @Required,
    [Scope] = @Scope,
    [TableId] = @TableId

    -- Update Matching Record
    Where [FieldId] = @FieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNField_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing DTNField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNField_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNField_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNField_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNField_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNField_Find >>>'

    End

GO

Create PROCEDURE DTNField_Find

    -- Primary Key Paramater
    @FieldId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AccessMode],[Caption],[DatabaseId],[DataType],[DecimalPlaces],[DefaultValue],[EnumDataTypeName],[Exclude],[FieldId],[FieldName],[FieldOrdinal],[FieldSize],[IsEnumeration],[IsNullable],[PrimaryKey],[ProjectId],[Required],[Scope],[TableId]

    -- From tableName
    From [DTNField]

    -- Find Matching Record
    Where [FieldId] = @FieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNField_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing DTNField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNField_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNField_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNField_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNField_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNField_Delete >>>'

    End

GO

Create PROCEDURE DTNField_Delete

    -- Primary Key Paramater
    @FieldId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DTNField]

    -- Delete Matching Record
    Where [FieldId] = @FieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNField_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all DTNField objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNField_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNField_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNField_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNField_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNField_FetchAll >>>'

    End

GO

Create PROCEDURE DTNField_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [AccessMode],[Caption],[DatabaseId],[DataType],[DecimalPlaces],[DefaultValue],[EnumDataTypeName],[Exclude],[FieldId],[FieldName],[FieldOrdinal],[FieldSize],[IsEnumeration],[IsNullable],[PrimaryKey],[ProjectId],[Required],[Scope],[TableId]

    -- From tableName
    From [DTNField]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNProcedure_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new DTNProcedure
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNProcedure_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNProcedure_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNProcedure_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNProcedure_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNProcedure_Insert >>>'

    End

GO

Create PROCEDURE DTNProcedure_Insert

    -- Add the parameters for the stored procedure here
    @Active bit,
    @Name nvarchar(50),
    @ProjectId int,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DTNProcedure]
    ([Active],[Name],[ProjectId],[TableId])

    -- Begin Values List
    Values(@Active, @Name, @ProjectId, @TableId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNProcedure_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing DTNProcedure
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNProcedure_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNProcedure_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNProcedure_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNProcedure_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNProcedure_Update >>>'

    End

GO

Create PROCEDURE DTNProcedure_Update

    -- Add the parameters for the stored procedure here
    @Active bit,
    @Name nvarchar(50),
    @ProcedureId int,
    @ProjectId int,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DTNProcedure]

    -- Update Each field
    Set [Active] = @Active,
    [Name] = @Name,
    [ProjectId] = @ProjectId,
    [TableId] = @TableId

    -- Update Matching Record
    Where [ProcedureId] = @ProcedureId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNProcedure_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing DTNProcedure
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNProcedure_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNProcedure_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNProcedure_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNProcedure_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNProcedure_Find >>>'

    End

GO

Create PROCEDURE DTNProcedure_Find

    -- Primary Key Paramater
    @ProcedureId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[Name],[ProcedureId],[ProjectId],[TableId]

    -- From tableName
    From [DTNProcedure]

    -- Find Matching Record
    Where [ProcedureId] = @ProcedureId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNProcedure_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing DTNProcedure
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNProcedure_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNProcedure_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNProcedure_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNProcedure_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNProcedure_Delete >>>'

    End

GO

Create PROCEDURE DTNProcedure_Delete

    -- Primary Key Paramater
    @ProcedureId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DTNProcedure]

    -- Delete Matching Record
    Where [ProcedureId] = @ProcedureId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNProcedure_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all DTNProcedure objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNProcedure_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNProcedure_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNProcedure_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNProcedure_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNProcedure_FetchAll >>>'

    End

GO

Create PROCEDURE DTNProcedure_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[Name],[ProcedureId],[ProjectId],[TableId]

    -- From tableName
    From [DTNProcedure]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNTable_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new DTNTable
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNTable_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNTable_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNTable_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNTable_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNTable_Insert >>>'

    End

GO

Create PROCEDURE DTNTable_Insert

    -- Add the parameters for the stored procedure here
    @ClassFileName nvarchar(255),
    @ClassName nvarchar(50),
    @CreateBindingCallback bit,
    @DatabaseId int,
    @Exclude bit,
    @Excluded bit,
    @IsView bit,
    @ProjectId int,
    @Scope int,
    @Serializable bit,
    @TableName nvarchar(64)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [DTNTable]
    ([ClassFileName],[ClassName],[CreateBindingCallback],[DatabaseId],[Exclude],[Excluded],[IsView],[ProjectId],[Scope],[Serializable],[TableName])

    -- Begin Values List
    Values(@ClassFileName, @ClassName, @CreateBindingCallback, @DatabaseId, @Exclude, @Excluded, @IsView, @ProjectId, @Scope, @Serializable, @TableName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNTable_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing DTNTable
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNTable_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNTable_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNTable_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNTable_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNTable_Update >>>'

    End

GO

Create PROCEDURE DTNTable_Update

    -- Add the parameters for the stored procedure here
    @ClassFileName nvarchar(255),
    @ClassName nvarchar(50),
    @CreateBindingCallback bit,
    @DatabaseId int,
    @Exclude bit,
    @Excluded bit,
    @IsView bit,
    @ProjectId int,
    @Scope int,
    @Serializable bit,
    @TableId int,
    @TableName nvarchar(64)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [DTNTable]

    -- Update Each field
    Set [ClassFileName] = @ClassFileName,
    [ClassName] = @ClassName,
    [CreateBindingCallback] = @CreateBindingCallback,
    [DatabaseId] = @DatabaseId,
    [Exclude] = @Exclude,
    [Excluded] = @Excluded,
    [IsView] = @IsView,
    [ProjectId] = @ProjectId,
    [Scope] = @Scope,
    [Serializable] = @Serializable,
    [TableName] = @TableName

    -- Update Matching Record
    Where [TableId] = @TableId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNTable_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing DTNTable
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNTable_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNTable_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNTable_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNTable_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNTable_Find >>>'

    End

GO

Create PROCEDURE DTNTable_Find

    -- Primary Key Paramater
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClassFileName],[ClassName],[CreateBindingCallback],[DatabaseId],[Exclude],[Excluded],[IsView],[ProjectId],[Scope],[Serializable],[TableId],[TableName]

    -- From tableName
    From [DTNTable]

    -- Find Matching Record
    Where [TableId] = @TableId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNTable_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing DTNTable
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNTable_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNTable_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNTable_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNTable_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNTable_Delete >>>'

    End

GO

Create PROCEDURE DTNTable_Delete

    -- Primary Key Paramater
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [DTNTable]

    -- Delete Matching Record
    Where [TableId] = @TableId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: DTNTable_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all DTNTable objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('DTNTable_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure DTNTable_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.DTNTable_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure DTNTable_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure DTNTable_FetchAll >>>'

    End

GO

Create PROCEDURE DTNTable_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ClassFileName],[ClassName],[CreateBindingCallback],[DatabaseId],[Exclude],[Excluded],[IsView],[ProjectId],[Scope],[Serializable],[TableId],[TableName]

    -- From tableName
    From [DTNTable]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Enumeration_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new Enumeration
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Enumeration_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Enumeration_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Enumeration_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Enumeration_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Enumeration_Insert >>>'

    End

GO

Create PROCEDURE Enumeration_Insert

    -- Add the parameters for the stored procedure here
    @EnumerationName nvarchar(255),
    @FieldName nvarchar(64),
    @ProjectId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Enumeration]
    ([EnumerationName],[FieldName],[ProjectId])

    -- Begin Values List
    Values(@EnumerationName, @FieldName, @ProjectId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Enumeration_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing Enumeration
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Enumeration_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Enumeration_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Enumeration_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Enumeration_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Enumeration_Update >>>'

    End

GO

Create PROCEDURE Enumeration_Update

    -- Add the parameters for the stored procedure here
    @EnumerationId int,
    @EnumerationName nvarchar(255),
    @FieldName nvarchar(64),
    @ProjectId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Enumeration]

    -- Update Each field
    Set [EnumerationName] = @EnumerationName,
    [FieldName] = @FieldName,
    [ProjectId] = @ProjectId

    -- Update Matching Record
    Where [EnumerationId] = @EnumerationId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Enumeration_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing Enumeration
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Enumeration_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Enumeration_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Enumeration_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Enumeration_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Enumeration_Find >>>'

    End

GO

Create PROCEDURE Enumeration_Find

    -- Primary Key Paramater
    @EnumerationId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [EnumerationId],[EnumerationName],[FieldName],[ProjectId]

    -- From tableName
    From [Enumeration]

    -- Find Matching Record
    Where [EnumerationId] = @EnumerationId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Enumeration_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing Enumeration
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Enumeration_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Enumeration_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Enumeration_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Enumeration_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Enumeration_Delete >>>'

    End

GO

Create PROCEDURE Enumeration_Delete

    -- Primary Key Paramater
    @EnumerationId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Enumeration]

    -- Delete Matching Record
    Where [EnumerationId] = @EnumerationId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Enumeration_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all Enumeration objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Enumeration_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Enumeration_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Enumeration_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Enumeration_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Enumeration_FetchAll >>>'

    End

GO

Create PROCEDURE Enumeration_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [EnumerationId],[EnumerationName],[FieldName],[ProjectId]

    -- From tableName
    From [Enumeration]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSet_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new FieldSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSet_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSet_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSet_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSet_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSet_Insert >>>'

    End

GO

Create PROCEDURE FieldSet_Insert

    -- Add the parameters for the stored procedure here
    @DatabaseId int,
    @Name nvarchar(50),
    @OrderByMode bit,
    @ParameterMode bit,
    @ProjectId int,
    @ReaderMode bit,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [FieldSet]
    ([DatabaseId],[Name],[OrderByMode],[ParameterMode],[ProjectId],[ReaderMode],[TableId])

    -- Begin Values List
    Values(@DatabaseId, @Name, @OrderByMode, @ParameterMode, @ProjectId, @ReaderMode, @TableId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSet_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing FieldSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSet_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSet_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSet_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSet_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSet_Update >>>'

    End

GO

Create PROCEDURE FieldSet_Update

    -- Add the parameters for the stored procedure here
    @DatabaseId int,
    @FieldSetId int,
    @Name nvarchar(50),
    @OrderByMode bit,
    @ParameterMode bit,
    @ProjectId int,
    @ReaderMode bit,
    @TableId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [FieldSet]

    -- Update Each field
    Set [DatabaseId] = @DatabaseId,
    [Name] = @Name,
    [OrderByMode] = @OrderByMode,
    [ParameterMode] = @ParameterMode,
    [ProjectId] = @ProjectId,
    [ReaderMode] = @ReaderMode,
    [TableId] = @TableId

    -- Update Matching Record
    Where [FieldSetId] = @FieldSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSet_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing FieldSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSet_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSet_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSet_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSet_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSet_Find >>>'

    End

GO

Create PROCEDURE FieldSet_Find

    -- Primary Key Paramater
    @FieldSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DatabaseId],[FieldSetId],[Name],[OrderByMode],[ParameterMode],[ProjectId],[ReaderMode],[TableId]

    -- From tableName
    From [FieldSet]

    -- Find Matching Record
    Where [FieldSetId] = @FieldSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSet_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing FieldSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSet_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSet_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSet_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSet_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSet_Delete >>>'

    End

GO

Create PROCEDURE FieldSet_Delete

    -- Primary Key Paramater
    @FieldSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [FieldSet]

    -- Delete Matching Record
    Where [FieldSetId] = @FieldSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSet_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all FieldSet objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSet_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSet_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSet_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSet_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSet_FetchAll >>>'

    End

GO

Create PROCEDURE FieldSet_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DatabaseId],[FieldSetId],[Name],[OrderByMode],[ParameterMode],[ProjectId],[ReaderMode],[TableId]

    -- From tableName
    From [FieldSet]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetField_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new FieldSetField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetField_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetField_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetField_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetField_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetField_Insert >>>'

    End

GO

Create PROCEDURE FieldSetField_Insert

    -- Add the parameters for the stored procedure here
    @FieldId int,
    @FieldOrdinal int,
    @FieldSetId int,
    @OrderByDescending bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [FieldSetField]
    ([FieldId],[FieldOrdinal],[FieldSetId],[OrderByDescending])

    -- Begin Values List
    Values(@FieldId, @FieldOrdinal, @FieldSetId, @OrderByDescending)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetField_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing FieldSetField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetField_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetField_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetField_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetField_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetField_Update >>>'

    End

GO

Create PROCEDURE FieldSetField_Update

    -- Add the parameters for the stored procedure here
    @FieldId int,
    @FieldOrdinal int,
    @FieldSetFieldId int,
    @FieldSetId int,
    @OrderByDescending bit

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [FieldSetField]

    -- Update Each field
    Set [FieldId] = @FieldId,
    [FieldOrdinal] = @FieldOrdinal,
    [FieldSetId] = @FieldSetId,
    [OrderByDescending] = @OrderByDescending

    -- Update Matching Record
    Where [FieldSetFieldId] = @FieldSetFieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetField_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing FieldSetField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetField_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetField_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetField_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetField_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetField_Find >>>'

    End

GO

Create PROCEDURE FieldSetField_Find

    -- Primary Key Paramater
    @FieldSetFieldId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FieldId],[FieldOrdinal],[FieldSetFieldId],[FieldSetId],[OrderByDescending]

    -- From tableName
    From [FieldSetField]

    -- Find Matching Record
    Where [FieldSetFieldId] = @FieldSetFieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetField_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing FieldSetField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetField_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetField_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetField_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetField_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetField_Delete >>>'

    End

GO

Create PROCEDURE FieldSetField_Delete

    -- Primary Key Paramater
    @FieldSetFieldId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [FieldSetField]

    -- Delete Matching Record
    Where [FieldSetFieldId] = @FieldSetFieldId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetField_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all FieldSetField objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetField_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetField_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetField_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetField_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetField_FetchAll >>>'

    End

GO

Create PROCEDURE FieldSetField_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FieldId],[FieldOrdinal],[FieldSetFieldId],[FieldSetId],[OrderByDescending]

    -- From tableName
    From [FieldSetField]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldSetFieldView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all FieldSetFieldView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldSetFieldView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldSetFieldView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldSetFieldView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldSetFieldView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldSetFieldView_FetchAll >>>'

    End

GO

Create PROCEDURE FieldSetFieldView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DatabaseId],[DataType],[DecimalPlaces],[DefaultValue],[EnumDataTypeName],[FieldId],[FieldName],[FieldOrdinal],[FieldSetFieldId],[FieldSetId],[FieldSetName],[FieldSize],[IsEnumeration],[IsNullable],[OrderByDescending],[ParameterMode],[PrimaryKey],[ProjectId],[Required],[Scope],[TableId]

    -- From tableName
    From [FieldSetFieldView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: FieldView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all FieldView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('FieldView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure FieldView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.FieldView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure FieldView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure FieldView_FetchAll >>>'

    End

GO

Create PROCEDURE FieldView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [FieldName],[IsNullable],[ProjectId],[TableId],[TableName]

    -- From tableName
    From [FieldView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Method_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new Method
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Method_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Method_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Method_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Method_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Method_Insert >>>'

    End

GO

Create PROCEDURE Method_Insert

    -- Add the parameters for the stored procedure here
    @Active bit,
    @CustomReaderId int,
    @MethodType int,
    @Name nvarchar(50),
    @OrderByDescending bit,
    @OrderByFieldId int,
    @OrderByFieldSetId int,
    @OrderByType int,
    @ParameterFieldId int,
    @Parameters nvarchar(255),
    @ParametersFieldSetId int,
    @ParameterType int,
    @ProcedureName nvarchar(128),
    @ProcedureText nvarchar(max),
    @ProjectId int,
    @PropertyName nvarchar(32),
    @TableId int,
    @TopRows int,
    @UpdateProcedureOnBuild bit,
    @UseCustomReader bit,
    @UseCustomWhere bit,
    @WhereText nvarchar(max)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Method]
    ([Active],[CustomReaderId],[MethodType],[Name],[OrderByDescending],[OrderByFieldId],[OrderByFieldSetId],[OrderByType],[ParameterFieldId],[Parameters],[ParametersFieldSetId],[ParameterType],[ProcedureName],[ProcedureText],[ProjectId],[PropertyName],[TableId],[TopRows],[UpdateProcedureOnBuild],[UseCustomReader],[UseCustomWhere],[WhereText])

    -- Begin Values List
    Values(@Active, @CustomReaderId, @MethodType, @Name, @OrderByDescending, @OrderByFieldId, @OrderByFieldSetId, @OrderByType, @ParameterFieldId, @Parameters, @ParametersFieldSetId, @ParameterType, @ProcedureName, @ProcedureText, @ProjectId, @PropertyName, @TableId, @TopRows, @UpdateProcedureOnBuild, @UseCustomReader, @UseCustomWhere, @WhereText)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Method_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing Method
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Method_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Method_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Method_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Method_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Method_Update >>>'

    End

GO

Create PROCEDURE Method_Update

    -- Add the parameters for the stored procedure here
    @Active bit,
    @CustomReaderId int,
    @MethodId int,
    @MethodType int,
    @Name nvarchar(50),
    @OrderByDescending bit,
    @OrderByFieldId int,
    @OrderByFieldSetId int,
    @OrderByType int,
    @ParameterFieldId int,
    @Parameters nvarchar(255),
    @ParametersFieldSetId int,
    @ParameterType int,
    @ProcedureName nvarchar(128),
    @ProcedureText nvarchar(max),
    @ProjectId int,
    @PropertyName nvarchar(32),
    @TableId int,
    @TopRows int,
    @UpdateProcedureOnBuild bit,
    @UseCustomReader bit,
    @UseCustomWhere bit,
    @WhereText nvarchar(max)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Method]

    -- Update Each field
    Set [Active] = @Active,
    [CustomReaderId] = @CustomReaderId,
    [MethodType] = @MethodType,
    [Name] = @Name,
    [OrderByDescending] = @OrderByDescending,
    [OrderByFieldId] = @OrderByFieldId,
    [OrderByFieldSetId] = @OrderByFieldSetId,
    [OrderByType] = @OrderByType,
    [ParameterFieldId] = @ParameterFieldId,
    [Parameters] = @Parameters,
    [ParametersFieldSetId] = @ParametersFieldSetId,
    [ParameterType] = @ParameterType,
    [ProcedureName] = @ProcedureName,
    [ProcedureText] = @ProcedureText,
    [ProjectId] = @ProjectId,
    [PropertyName] = @PropertyName,
    [TableId] = @TableId,
    [TopRows] = @TopRows,
    [UpdateProcedureOnBuild] = @UpdateProcedureOnBuild,
    [UseCustomReader] = @UseCustomReader,
    [UseCustomWhere] = @UseCustomWhere,
    [WhereText] = @WhereText

    -- Update Matching Record
    Where [MethodId] = @MethodId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Method_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing Method
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Method_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Method_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Method_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Method_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Method_Find >>>'

    End

GO

Create PROCEDURE Method_Find

    -- Primary Key Paramater
    @MethodId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[CustomReaderId],[MethodId],[MethodType],[Name],[OrderByDescending],[OrderByFieldId],[OrderByFieldSetId],[OrderByType],[ParameterFieldId],[Parameters],[ParametersFieldSetId],[ParameterType],[ProcedureName],[ProcedureText],[ProjectId],[PropertyName],[TableId],[TopRows],[UpdateProcedureOnBuild],[UseCustomReader],[UseCustomWhere],[WhereText]

    -- From tableName
    From [Method]

    -- Find Matching Record
    Where [MethodId] = @MethodId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Method_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing Method
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Method_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Method_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Method_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Method_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Method_Delete >>>'

    End

GO

Create PROCEDURE Method_Delete

    -- Primary Key Paramater
    @MethodId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Method]

    -- Delete Matching Record
    Where [MethodId] = @MethodId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Method_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all Method objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Method_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Method_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Method_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Method_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Method_FetchAll >>>'

    End

GO

Create PROCEDURE Method_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Active],[CustomReaderId],[MethodId],[MethodType],[Name],[OrderByDescending],[OrderByFieldId],[OrderByFieldSetId],[OrderByType],[ParameterFieldId],[Parameters],[ParametersFieldSetId],[ParameterType],[ProcedureName],[ProcedureText],[ProjectId],[PropertyName],[TableId],[TopRows],[UpdateProcedureOnBuild],[UseCustomReader],[UseCustomWhere],[WhereText]

    -- From tableName
    From [Method]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Insert >>>'

    End

GO

Create PROCEDURE Project_Insert

    -- Add the parameters for the stored procedure here
    @BindingCallbackOption int,
    @ControllerFolder nvarchar(255),
    @ControllerNamespace nvarchar(100),
    @ControllerReferencesSetId int,
    @DataManagerFolder nvarchar(255),
    @DataManagerNamespace nvarchar(100),
    @DataManagerReferencesSetId int,
    @DataOperationsFolder nvarchar(255),
    @DataOperationsNamespace nvarchar(100),
    @DataOperationsReferencesSetId int,
    @DataWriterFolder nvarchar(255),
    @DataWriterNamespace nvarchar(100),
    @DataWriterReferencesSetId int,
    @DateModified datetime,
    @EnableBlazorFeatures bit,
    @ObjectFolder nvarchar(255),
    @ObjectNamespace nvarchar(100),
    @ObjectReferencesSetId int,
    @ProjectFolder nvarchar(255),
    @ProjectName nvarchar(50),
    @ReaderFolder nvarchar(255),
    @ReaderNamespace nvarchar(100),
    @ReaderReferencesSetId int,
    @ServicesFolder nvarchar(512),
    @StoredProcedureObjectFolder nvarchar(255),
    @StoredProcedureObjectNamespace nvarchar(100),
    @StoredProcedureReferencesSetId int,
    @StoredProcsFolder nvarchar(255),
    @TargetFramework int,
    @UIFolderPath nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Project]
    ([BindingCallbackOption],[ControllerFolder],[ControllerNamespace],[ControllerReferencesSetId],[DataManagerFolder],[DataManagerNamespace],[DataManagerReferencesSetId],[DataOperationsFolder],[DataOperationsNamespace],[DataOperationsReferencesSetId],[DataWriterFolder],[DataWriterNamespace],[DataWriterReferencesSetId],[DateModified],[EnableBlazorFeatures],[ObjectFolder],[ObjectNamespace],[ObjectReferencesSetId],[ProjectFolder],[ProjectName],[ReaderFolder],[ReaderNamespace],[ReaderReferencesSetId],[ServicesFolder],[StoredProcedureObjectFolder],[StoredProcedureObjectNamespace],[StoredProcedureReferencesSetId],[StoredProcsFolder],[TargetFramework],[UIFolderPath])

    -- Begin Values List
    Values(@BindingCallbackOption, @ControllerFolder, @ControllerNamespace, @ControllerReferencesSetId, @DataManagerFolder, @DataManagerNamespace, @DataManagerReferencesSetId, @DataOperationsFolder, @DataOperationsNamespace, @DataOperationsReferencesSetId, @DataWriterFolder, @DataWriterNamespace, @DataWriterReferencesSetId, @DateModified, @EnableBlazorFeatures, @ObjectFolder, @ObjectNamespace, @ObjectReferencesSetId, @ProjectFolder, @ProjectName, @ReaderFolder, @ReaderNamespace, @ReaderReferencesSetId, @ServicesFolder, @StoredProcedureObjectFolder, @StoredProcedureObjectNamespace, @StoredProcedureReferencesSetId, @StoredProcsFolder, @TargetFramework, @UIFolderPath)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Update >>>'

    End

GO

Create PROCEDURE Project_Update

    -- Add the parameters for the stored procedure here
    @BindingCallbackOption int,
    @ControllerFolder nvarchar(255),
    @ControllerNamespace nvarchar(100),
    @ControllerReferencesSetId int,
    @DataManagerFolder nvarchar(255),
    @DataManagerNamespace nvarchar(100),
    @DataManagerReferencesSetId int,
    @DataOperationsFolder nvarchar(255),
    @DataOperationsNamespace nvarchar(100),
    @DataOperationsReferencesSetId int,
    @DataWriterFolder nvarchar(255),
    @DataWriterNamespace nvarchar(100),
    @DataWriterReferencesSetId int,
    @DateModified datetime,
    @EnableBlazorFeatures bit,
    @ObjectFolder nvarchar(255),
    @ObjectNamespace nvarchar(100),
    @ObjectReferencesSetId int,
    @ProjectFolder nvarchar(255),
    @ProjectId int,
    @ProjectName nvarchar(50),
    @ReaderFolder nvarchar(255),
    @ReaderNamespace nvarchar(100),
    @ReaderReferencesSetId int,
    @ServicesFolder nvarchar(512),
    @StoredProcedureObjectFolder nvarchar(255),
    @StoredProcedureObjectNamespace nvarchar(100),
    @StoredProcedureReferencesSetId int,
    @StoredProcsFolder nvarchar(255),
    @TargetFramework int,
    @UIFolderPath nvarchar(255)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Project]

    -- Update Each field
    Set [BindingCallbackOption] = @BindingCallbackOption,
    [ControllerFolder] = @ControllerFolder,
    [ControllerNamespace] = @ControllerNamespace,
    [ControllerReferencesSetId] = @ControllerReferencesSetId,
    [DataManagerFolder] = @DataManagerFolder,
    [DataManagerNamespace] = @DataManagerNamespace,
    [DataManagerReferencesSetId] = @DataManagerReferencesSetId,
    [DataOperationsFolder] = @DataOperationsFolder,
    [DataOperationsNamespace] = @DataOperationsNamespace,
    [DataOperationsReferencesSetId] = @DataOperationsReferencesSetId,
    [DataWriterFolder] = @DataWriterFolder,
    [DataWriterNamespace] = @DataWriterNamespace,
    [DataWriterReferencesSetId] = @DataWriterReferencesSetId,
    [DateModified] = @DateModified,
    [EnableBlazorFeatures] = @EnableBlazorFeatures,
    [ObjectFolder] = @ObjectFolder,
    [ObjectNamespace] = @ObjectNamespace,
    [ObjectReferencesSetId] = @ObjectReferencesSetId,
    [ProjectFolder] = @ProjectFolder,
    [ProjectName] = @ProjectName,
    [ReaderFolder] = @ReaderFolder,
    [ReaderNamespace] = @ReaderNamespace,
    [ReaderReferencesSetId] = @ReaderReferencesSetId,
    [ServicesFolder] = @ServicesFolder,
    [StoredProcedureObjectFolder] = @StoredProcedureObjectFolder,
    [StoredProcedureObjectNamespace] = @StoredProcedureObjectNamespace,
    [StoredProcedureReferencesSetId] = @StoredProcedureReferencesSetId,
    [StoredProcsFolder] = @StoredProcsFolder,
    [TargetFramework] = @TargetFramework,
    [UIFolderPath] = @UIFolderPath

    -- Update Matching Record
    Where [ProjectId] = @ProjectId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Find >>>'

    End

GO

Create PROCEDURE Project_Find

    -- Primary Key Paramater
    @ProjectId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [BindingCallbackOption],[ControllerFolder],[ControllerNamespace],[ControllerReferencesSetId],[DataManagerFolder],[DataManagerNamespace],[DataManagerReferencesSetId],[DataOperationsFolder],[DataOperationsNamespace],[DataOperationsReferencesSetId],[DataWriterFolder],[DataWriterNamespace],[DataWriterReferencesSetId],[DateModified],[EnableBlazorFeatures],[ObjectFolder],[ObjectNamespace],[ObjectReferencesSetId],[ProjectFolder],[ProjectId],[ProjectName],[ReaderFolder],[ReaderNamespace],[ReaderReferencesSetId],[ServicesFolder],[StoredProcedureObjectFolder],[StoredProcedureObjectNamespace],[StoredProcedureReferencesSetId],[StoredProcsFolder],[TargetFramework],[UIFolderPath]

    -- From tableName
    From [Project]

    -- Find Matching Record
    Where [ProjectId] = @ProjectId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing Project
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_Delete >>>'

    End

GO

Create PROCEDURE Project_Delete

    -- Primary Key Paramater
    @ProjectId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Project]

    -- Delete Matching Record
    Where [ProjectId] = @ProjectId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Project_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all Project objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Project_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Project_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Project_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Project_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Project_FetchAll >>>'

    End

GO

Create PROCEDURE Project_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [BindingCallbackOption],[ControllerFolder],[ControllerNamespace],[ControllerReferencesSetId],[DataManagerFolder],[DataManagerNamespace],[DataManagerReferencesSetId],[DataOperationsFolder],[DataOperationsNamespace],[DataOperationsReferencesSetId],[DataWriterFolder],[DataWriterNamespace],[DataWriterReferencesSetId],[DateModified],[EnableBlazorFeatures],[ObjectFolder],[ObjectNamespace],[ObjectReferencesSetId],[ProjectFolder],[ProjectId],[ProjectName],[ReaderFolder],[ReaderNamespace],[ReaderReferencesSetId],[ServicesFolder],[StoredProcedureObjectFolder],[StoredProcedureObjectNamespace],[StoredProcedureReferencesSetId],[StoredProcsFolder],[TargetFramework],[UIFolderPath]

    -- From tableName
    From [Project]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReference_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new ProjectReference
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReference_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReference_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReference_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReference_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReference_Insert >>>'

    End

GO

Create PROCEDURE ProjectReference_Insert

    -- Add the parameters for the stored procedure here
    @ReferenceName nvarchar(128),
    @ReferencesSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ProjectReference]
    ([ReferenceName],[ReferencesSetId])

    -- Begin Values List
    Values(@ReferenceName, @ReferencesSetId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReference_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing ProjectReference
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReference_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReference_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReference_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReference_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReference_Update >>>'

    End

GO

Create PROCEDURE ProjectReference_Update

    -- Add the parameters for the stored procedure here
    @ReferenceName nvarchar(128),
    @ReferencesId int,
    @ReferencesSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ProjectReference]

    -- Update Each field
    Set [ReferenceName] = @ReferenceName,
    [ReferencesSetId] = @ReferencesSetId

    -- Update Matching Record
    Where [ReferencesId] = @ReferencesId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReference_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing ProjectReference
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReference_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReference_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReference_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReference_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReference_Find >>>'

    End

GO

Create PROCEDURE ProjectReference_Find

    -- Primary Key Paramater
    @ReferencesId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ReferenceName],[ReferencesId],[ReferencesSetId]

    -- From tableName
    From [ProjectReference]

    -- Find Matching Record
    Where [ReferencesId] = @ReferencesId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReference_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing ProjectReference
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReference_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReference_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReference_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReference_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReference_Delete >>>'

    End

GO

Create PROCEDURE ProjectReference_Delete

    -- Primary Key Paramater
    @ReferencesId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ProjectReference]

    -- Delete Matching Record
    Where [ReferencesId] = @ReferencesId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReference_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all ProjectReference objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReference_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReference_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReference_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReference_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReference_FetchAll >>>'

    End

GO

Create PROCEDURE ProjectReference_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ReferenceName],[ReferencesId],[ReferencesSetId]

    -- From tableName
    From [ProjectReference]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ProjectReferencesView_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all ProjectReferencesView objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ProjectReferencesView_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ProjectReferencesView_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ProjectReferencesView_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ProjectReferencesView_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ProjectReferencesView_FetchAll >>>'

    End

GO

Create PROCEDURE ProjectReferencesView_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ControllerReferencesSetId],[DataManagerReferencesSetId],[DataWriterReferencesSetId],[ObjectReferencesSetId],[ProjectId],[ProjectName],[ReaderReferencesSetId],[ReferenceName],[ReferencesSetId],[ReferencesSetName],[StoredProcedureReferencesSetId]

    -- From tableName
    From [ProjectReferencesView]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencesSet_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new ReferencesSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencesSet_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencesSet_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencesSet_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencesSet_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencesSet_Insert >>>'

    End

GO

Create PROCEDURE ReferencesSet_Insert

    -- Add the parameters for the stored procedure here
    @ProjectId int,
    @ReferencesSetName nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [ReferencesSet]
    ([ProjectId],[ReferencesSetName])

    -- Begin Values List
    Values(@ProjectId, @ReferencesSetName)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencesSet_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing ReferencesSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencesSet_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencesSet_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencesSet_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencesSet_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencesSet_Update >>>'

    End

GO

Create PROCEDURE ReferencesSet_Update

    -- Add the parameters for the stored procedure here
    @ProjectId int,
    @ReferencesSetId int,
    @ReferencesSetName nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [ReferencesSet]

    -- Update Each field
    Set [ProjectId] = @ProjectId,
    [ReferencesSetName] = @ReferencesSetName

    -- Update Matching Record
    Where [ReferencesSetId] = @ReferencesSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencesSet_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing ReferencesSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencesSet_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencesSet_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencesSet_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencesSet_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencesSet_Find >>>'

    End

GO

Create PROCEDURE ReferencesSet_Find

    -- Primary Key Paramater
    @ReferencesSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ProjectId],[ReferencesSetId],[ReferencesSetName]

    -- From tableName
    From [ReferencesSet]

    -- Find Matching Record
    Where [ReferencesSetId] = @ReferencesSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencesSet_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing ReferencesSet
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencesSet_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencesSet_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencesSet_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencesSet_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencesSet_Delete >>>'

    End

GO

Create PROCEDURE ReferencesSet_Delete

    -- Primary Key Paramater
    @ReferencesSetId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [ReferencesSet]

    -- Delete Matching Record
    Where [ReferencesSetId] = @ReferencesSetId

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: ReferencesSet_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all ReferencesSet objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('ReferencesSet_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure ReferencesSet_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.ReferencesSet_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure ReferencesSet_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure ReferencesSet_FetchAll >>>'

    End

GO

Create PROCEDURE ReferencesSet_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ProjectId],[ReferencesSetId],[ReferencesSetName]

    -- From tableName
    From [ReferencesSet]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlDetail_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UIControlDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlDetail_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlDetail_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlDetail_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlDetail_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlDetail_Insert >>>'

    End

GO

Create PROCEDURE UIControlDetail_Insert

    -- Add the parameters for the stored procedure here
    @Indent int,
    @LineNumber int,
    @LineText nvarchar(512),
    @UIControlId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UIControlDetail]
    ([Indent],[LineNumber],[LineText],[UIControlId])

    -- Begin Values List
    Values(@Indent, @LineNumber, @LineText, @UIControlId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlDetail_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UIControlDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlDetail_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlDetail_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlDetail_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlDetail_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlDetail_Update >>>'

    End

GO

Create PROCEDURE UIControlDetail_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @Indent int,
    @LineNumber int,
    @LineText nvarchar(512),
    @UIControlId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UIControlDetail]

    -- Update Each field
    Set [Indent] = @Indent,
    [LineNumber] = @LineNumber,
    [LineText] = @LineText,
    [UIControlId] = @UIControlId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlDetail_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UIControlDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlDetail_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlDetail_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlDetail_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlDetail_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlDetail_Find >>>'

    End

GO

Create PROCEDURE UIControlDetail_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Indent],[LineNumber],[LineText],[UIControlId]

    -- From tableName
    From [UIControlDetail]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlDetail_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UIControlDetail
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlDetail_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlDetail_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlDetail_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlDetail_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlDetail_Delete >>>'

    End

GO

Create PROCEDURE UIControlDetail_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UIControlDetail]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlDetail_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UIControlDetail objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlDetail_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlDetail_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlDetail_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlDetail_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlDetail_FetchAll >>>'

    End

GO

Create PROCEDURE UIControlDetail_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Indent],[LineNumber],[LineText],[UIControlId]

    -- From tableName
    From [UIControlDetail]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlTemplate_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UIControlTemplate
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlTemplate_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlTemplate_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlTemplate_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlTemplate_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlTemplate_Insert >>>'

    End

GO

Create PROCEDURE UIControlTemplate_Insert

    -- Add the parameters for the stored procedure here
    @ControlType int,
    @DesignerTemplateId int,
    @GlobalUsingsTemplateId int,
    @Name nvarchar(50),
    @NugetPackage nvarchar(100),
    @Path nvarchar(512),
    @ProgramFileTemplateId int,
    @ProjectTemplateId int,
    @ResourcesTemplateId int,
    @ResxTemplateId int,
    @Version nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UIControlTemplate]
    ([ControlType],[DesignerTemplateId],[GlobalUsingsTemplateId],[Name],[NugetPackage],[Path],[ProgramFileTemplateId],[ProjectTemplateId],[ResourcesTemplateId],[ResxTemplateId],[Version])

    -- Begin Values List
    Values(@ControlType, @DesignerTemplateId, @GlobalUsingsTemplateId, @Name, @NugetPackage, @Path, @ProgramFileTemplateId, @ProjectTemplateId, @ResourcesTemplateId, @ResxTemplateId, @Version)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlTemplate_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UIControlTemplate
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlTemplate_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlTemplate_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlTemplate_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlTemplate_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlTemplate_Update >>>'

    End

GO

Create PROCEDURE UIControlTemplate_Update

    -- Add the parameters for the stored procedure here
    @ControlType int,
    @DesignerTemplateId int,
    @GlobalUsingsTemplateId int,
    @Id int,
    @Name nvarchar(50),
    @NugetPackage nvarchar(100),
    @Path nvarchar(512),
    @ProgramFileTemplateId int,
    @ProjectTemplateId int,
    @ResourcesTemplateId int,
    @ResxTemplateId int,
    @Version nvarchar(50)

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UIControlTemplate]

    -- Update Each field
    Set [ControlType] = @ControlType,
    [DesignerTemplateId] = @DesignerTemplateId,
    [GlobalUsingsTemplateId] = @GlobalUsingsTemplateId,
    [Name] = @Name,
    [NugetPackage] = @NugetPackage,
    [Path] = @Path,
    [ProgramFileTemplateId] = @ProgramFileTemplateId,
    [ProjectTemplateId] = @ProjectTemplateId,
    [ResourcesTemplateId] = @ResourcesTemplateId,
    [ResxTemplateId] = @ResxTemplateId,
    [Version] = @Version

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlTemplate_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UIControlTemplate
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlTemplate_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlTemplate_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlTemplate_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlTemplate_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlTemplate_Find >>>'

    End

GO

Create PROCEDURE UIControlTemplate_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ControlType],[DesignerTemplateId],[GlobalUsingsTemplateId],[Id],[Name],[NugetPackage],[Path],[ProgramFileTemplateId],[ProjectTemplateId],[ResourcesTemplateId],[ResxTemplateId],[Version]

    -- From tableName
    From [UIControlTemplate]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlTemplate_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UIControlTemplate
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlTemplate_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlTemplate_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlTemplate_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlTemplate_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlTemplate_Delete >>>'

    End

GO

Create PROCEDURE UIControlTemplate_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UIControlTemplate]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIControlTemplate_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UIControlTemplate objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIControlTemplate_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIControlTemplate_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIControlTemplate_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIControlTemplate_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIControlTemplate_FetchAll >>>'

    End

GO

Create PROCEDURE UIControlTemplate_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ControlType],[DesignerTemplateId],[GlobalUsingsTemplateId],[Id],[Name],[NugetPackage],[Path],[ProgramFileTemplateId],[ProjectTemplateId],[ResourcesTemplateId],[ResxTemplateId],[Version]

    -- From tableName
    From [UIControlTemplate]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIField_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UIField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIField_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIField_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIField_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIField_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIField_Insert >>>'

    End

GO

Create PROCEDURE UIField_Insert

    -- Add the parameters for the stored procedure here
    @Caption nvarchar(40),
    @ControlType int,
    @DataType int,
    @DefaultValue nvarchar(50),
    @DisplayOrder int,
    @DTNFieldId int,
    @FieldOrdinal int,
    @Height int,
    @Left int,
    @MaxLength int,
    @MaxRange float,
    @MinLength int,
    @MinRange float,
    @Required bit,
    @RequiredMessage nvarchar(128),
    @Top int,
    @UIObjectId int,
    @UserInterfaceId int,
    @ValidationMessage nvarchar(128),
    @Width int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UIField]
    ([Caption],[ControlType],[DataType],[DefaultValue],[DisplayOrder],[DTNFieldId],[FieldOrdinal],[Height],[Left],[MaxLength],[MaxRange],[MinLength],[MinRange],[Required],[RequiredMessage],[Top],[UIObjectId],[UserInterfaceId],[ValidationMessage],[Width])

    -- Begin Values List
    Values(@Caption, @ControlType, @DataType, @DefaultValue, @DisplayOrder, @DTNFieldId, @FieldOrdinal, @Height, @Left, @MaxLength, @MaxRange, @MinLength, @MinRange, @Required, @RequiredMessage, @Top, @UIObjectId, @UserInterfaceId, @ValidationMessage, @Width)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIField_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UIField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIField_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIField_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIField_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIField_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIField_Update >>>'

    End

GO

Create PROCEDURE UIField_Update

    -- Add the parameters for the stored procedure here
    @Caption nvarchar(40),
    @ControlType int,
    @DataType int,
    @DefaultValue nvarchar(50),
    @DisplayOrder int,
    @DTNFieldId int,
    @FieldOrdinal int,
    @Height int,
    @Id int,
    @Left int,
    @MaxLength int,
    @MaxRange float,
    @MinLength int,
    @MinRange float,
    @Required bit,
    @RequiredMessage nvarchar(128),
    @Top int,
    @UIObjectId int,
    @UserInterfaceId int,
    @ValidationMessage nvarchar(128),
    @Width int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UIField]

    -- Update Each field
    Set [Caption] = @Caption,
    [ControlType] = @ControlType,
    [DataType] = @DataType,
    [DefaultValue] = @DefaultValue,
    [DisplayOrder] = @DisplayOrder,
    [DTNFieldId] = @DTNFieldId,
    [FieldOrdinal] = @FieldOrdinal,
    [Height] = @Height,
    [Left] = @Left,
    [MaxLength] = @MaxLength,
    [MaxRange] = @MaxRange,
    [MinLength] = @MinLength,
    [MinRange] = @MinRange,
    [Required] = @Required,
    [RequiredMessage] = @RequiredMessage,
    [Top] = @Top,
    [UIObjectId] = @UIObjectId,
    [UserInterfaceId] = @UserInterfaceId,
    [ValidationMessage] = @ValidationMessage,
    [Width] = @Width

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIField_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UIField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIField_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIField_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIField_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIField_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIField_Find >>>'

    End

GO

Create PROCEDURE UIField_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Caption],[ControlType],[DataType],[DefaultValue],[DisplayOrder],[DTNFieldId],[FieldOrdinal],[Height],[Id],[Left],[MaxLength],[MaxRange],[MinLength],[MinRange],[Required],[RequiredMessage],[Top],[UIObjectId],[UserInterfaceId],[ValidationMessage],[Width]

    -- From tableName
    From [UIField]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIField_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UIField
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIField_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIField_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIField_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIField_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIField_Delete >>>'

    End

GO

Create PROCEDURE UIField_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UIField]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIField_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UIField objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIField_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIField_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIField_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIField_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIField_FetchAll >>>'

    End

GO

Create PROCEDURE UIField_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Caption],[ControlType],[DataType],[DefaultValue],[DisplayOrder],[DTNFieldId],[FieldOrdinal],[Height],[Id],[Left],[MaxLength],[MaxRange],[MinLength],[MinRange],[Required],[RequiredMessage],[Top],[UIObjectId],[UserInterfaceId],[ValidationMessage],[Width]

    -- From tableName
    From [UIField]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIObject_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UIObject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIObject_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIObject_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIObject_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIObject_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIObject_Insert >>>'

    End

GO

Create PROCEDURE UIObject_Insert

    -- Add the parameters for the stored procedure here
    @ControlType int,
    @DisplayOrder int,
    @FormType int,
    @Height int,
    @IsControl bit,
    @IsForm bit,
    @Left int,
    @Name nvarchar(50),
    @ParentId int,
    @Top int,
    @Width int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UIObject]
    ([ControlType],[DisplayOrder],[FormType],[Height],[IsControl],[IsForm],[Left],[Name],[ParentId],[Top],[Width])

    -- Begin Values List
    Values(@ControlType, @DisplayOrder, @FormType, @Height, @IsControl, @IsForm, @Left, @Name, @ParentId, @Top, @Width)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIObject_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UIObject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIObject_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIObject_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIObject_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIObject_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIObject_Update >>>'

    End

GO

Create PROCEDURE UIObject_Update

    -- Add the parameters for the stored procedure here
    @ControlType int,
    @DisplayOrder int,
    @FormType int,
    @Height int,
    @Id int,
    @IsControl bit,
    @IsForm bit,
    @Left int,
    @Name nvarchar(50),
    @ParentId int,
    @Top int,
    @Width int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UIObject]

    -- Update Each field
    Set [ControlType] = @ControlType,
    [DisplayOrder] = @DisplayOrder,
    [FormType] = @FormType,
    [Height] = @Height,
    [IsControl] = @IsControl,
    [IsForm] = @IsForm,
    [Left] = @Left,
    [Name] = @Name,
    [ParentId] = @ParentId,
    [Top] = @Top,
    [Width] = @Width

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIObject_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UIObject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIObject_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIObject_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIObject_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIObject_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIObject_Find >>>'

    End

GO

Create PROCEDURE UIObject_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ControlType],[DisplayOrder],[FormType],[Height],[Id],[IsControl],[IsForm],[Left],[Name],[ParentId],[Top],[Width]

    -- From tableName
    From [UIObject]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIObject_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UIObject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIObject_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIObject_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIObject_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIObject_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIObject_Delete >>>'

    End

GO

Create PROCEDURE UIObject_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UIObject]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIObject_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UIObject objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIObject_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIObject_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIObject_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIObject_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIObject_FetchAll >>>'

    End

GO

Create PROCEDURE UIObject_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [ControlType],[DisplayOrder],[FormType],[Height],[Id],[IsControl],[IsForm],[Left],[Name],[ParentId],[Top],[Width]

    -- From tableName
    From [UIObject]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIProject_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UIProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIProject_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIProject_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIProject_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIProject_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIProject_Insert >>>'

    End

GO

Create PROCEDURE UIProject_Insert

    -- Add the parameters for the stored procedure here
    @IsBlazor bit,
    @IsWindowsForm bit,
    @Name nvarchar(50),
    @UIControlTemplateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UIProject]
    ([IsBlazor],[IsWindowsForm],[Name],[UIControlTemplateId])

    -- Begin Values List
    Values(@IsBlazor, @IsWindowsForm, @Name, @UIControlTemplateId)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIProject_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UIProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIProject_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIProject_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIProject_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIProject_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIProject_Update >>>'

    End

GO

Create PROCEDURE UIProject_Update

    -- Add the parameters for the stored procedure here
    @Id int,
    @IsBlazor bit,
    @IsWindowsForm bit,
    @Name nvarchar(50),
    @UIControlTemplateId int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UIProject]

    -- Update Each field
    Set [IsBlazor] = @IsBlazor,
    [IsWindowsForm] = @IsWindowsForm,
    [Name] = @Name,
    [UIControlTemplateId] = @UIControlTemplateId

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIProject_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UIProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIProject_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIProject_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIProject_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIProject_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIProject_Find >>>'

    End

GO

Create PROCEDURE UIProject_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[IsBlazor],[IsWindowsForm],[Name],[UIControlTemplateId]

    -- From tableName
    From [UIProject]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIProject_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UIProject
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIProject_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIProject_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIProject_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIProject_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIProject_Delete >>>'

    End

GO

Create PROCEDURE UIProject_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UIProject]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UIProject_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UIProject objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UIProject_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UIProject_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UIProject_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UIProject_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UIProject_FetchAll >>>'

    End

GO

Create PROCEDURE UIProject_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[IsBlazor],[IsWindowsForm],[Name],[UIControlTemplateId]

    -- From tableName
    From [UIProject]

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UserInterface_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Insert a new UserInterface
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UserInterface_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UserInterface_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UserInterface_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UserInterface_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UserInterface_Insert >>>'

    End

GO

Create PROCEDURE UserInterface_Insert

    -- Add the parameters for the stored procedure here
    @DataSourceName nvarchar(64),
    @DataSourceType int,
    @Name nvarchar(50),
    @Path nvarchar(255),
    @ProjectId int,
    @UIType int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [UserInterface]
    ([DataSourceName],[DataSourceType],[Name],[Path],[ProjectId],[UIType])

    -- Begin Values List
    Values(@DataSourceName, @DataSourceType, @Name, @Path, @ProjectId, @UIType)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UserInterface_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Update an existing UserInterface
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UserInterface_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UserInterface_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UserInterface_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UserInterface_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UserInterface_Update >>>'

    End

GO

Create PROCEDURE UserInterface_Update

    -- Add the parameters for the stored procedure here
    @DataSourceName nvarchar(64),
    @DataSourceType int,
    @Id int,
    @Name nvarchar(50),
    @Path nvarchar(255),
    @ProjectId int,
    @UIType int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [UserInterface]

    -- Update Each field
    Set [DataSourceName] = @DataSourceName,
    [DataSourceType] = @DataSourceType,
    [Name] = @Name,
    [Path] = @Path,
    [ProjectId] = @ProjectId,
    [UIType] = @UIType

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UserInterface_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Find an existing UserInterface
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UserInterface_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UserInterface_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UserInterface_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UserInterface_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UserInterface_Find >>>'

    End

GO

Create PROCEDURE UserInterface_Find

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DataSourceName],[DataSourceType],[Id],[Name],[Path],[ProjectId],[UIType]

    -- From tableName
    From [UserInterface]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UserInterface_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Delete an existing UserInterface
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UserInterface_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UserInterface_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UserInterface_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UserInterface_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UserInterface_Delete >>>'

    End

GO

Create PROCEDURE UserInterface_Delete

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [UserInterface]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: UserInterface_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   5/7/2022
-- Description:    Returns all UserInterface objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('UserInterface_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure UserInterface_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.UserInterface_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure UserInterface_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure UserInterface_FetchAll >>>'

    End

GO

Create PROCEDURE UserInterface_FetchAll

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [DataSourceName],[DataSourceType],[Id],[Name],[Path],[ProjectId],[UIType]

    -- From tableName
    From [UserInterface]

END

-- Thank you for using DataTier.Net.

