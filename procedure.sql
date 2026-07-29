 
CREATE PROCEDURE [dbo].[Customer_Insert]
(
      @BranchCode        NVARCHAR(20)
    , @CustomerName      NVARCHAR(200)
    , @Gender            NVARCHAR(20)      = NULL
    , @Phone             NVARCHAR(50)      = NULL
    , @Email             NVARCHAR(200)     = NULL
    , @Address           NVARCHAR(500)     = NULL
    , @Remark            NVARCHAR(500)     = NULL
    , @CreatedBy         NVARCHAR(100)
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY

        BEGIN TRAN;

        DECLARE @CustomerID NVARCHAR(50);

        ------------------------------------------------------
        -- Generate Customer ID
        ------------------------------------------------------
        EXEC dbo.NextNumber_Get
                @BranchCode     = @BranchCode,
                @DocumentType   = 'CUSTOMER',
                @NextNumber     = @CustomerID OUTPUT;

        ------------------------------------------------------
        -- Insert
        ------------------------------------------------------
        INSERT INTO dbo.Customer
        (
              CustomerID
            , CustomerName
            , Gender
            , Phone
            , Email
            , Address
            , Remark
            , IsActive
            , CreatedDate
            , CreatedBy
        )
        VALUES
        (
              @CustomerID
            , @CustomerName
            , @Gender
            , @Phone
            , @Email
            , @Address
            , @Remark
            , 1
            , GETDATE()
            , @CreatedBy
        );

        COMMIT TRAN;

        SELECT
            CustomerID = @CustomerID;

    END TRY

    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRAN;

        THROW;

    END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[garage_customer_save]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[garage_customer_save]
(
      @CMD             NVARCHAR(20)
    , @BranchCode      NVARCHAR(50)
    , @CustomerID      NVARCHAR(50) = NULL
    , @CustomerName    NVARCHAR(250)
    , @Gender          NVARCHAR(50)  = NULL
    , @DOB             DATE          = NULL
    , @Phone           NVARCHAR(100) = NULL
    , @Email           NVARCHAR(100) = NULL
    , @Remark          NVARCHAR(250) = NULL
    , @CreatedBy       NVARCHAR(50)
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRAN;

    IF UPPER(@CMD) = 'I'
    BEGIN
        EXEC dbo.NextNumber_Get
             @BranchCode   = @BranchCode,
             @DocumentType = 'CUSTOMER',
             @NextCode     = @CustomerID OUTPUT;

        INSERT INTO dbo.garage_tbl_customer
        (
              cus_id
            , branch_code
            , cus_name
            , phone
            , email
            , gender
            , dob
            , is_active
            , remark
            , inputter
            , inputdate
        )
        VALUES
        (
              @CustomerID
            , @BranchCode
            , @CustomerName
            , @Phone
            , @Email
            , @Gender
            , @DOB
            , 1
            , @Remark
            , @CreatedBy
            , GETDATE()
        );
    END
    ELSE IF UPPER(@CMD) = 'U'
    BEGIN
        UPDATE dbo.garage_tbl_customer
           SET cus_name   = @CustomerName,
               phone      = @Phone,
               email      = @Email,
               gender     = @Gender,
               dob        = @DOB,
               remark     = @Remark,
               updater    = @CreatedBy,
               updatedate = GETDATE()
         WHERE branch_code = @BranchCode
           AND cus_id      = @CustomerID;
    END

    COMMIT TRAN;

    SELECT CustomerID = @CustomerID;
END
GO
/****** Object:  StoredProcedure [dbo].[garage_sp_get]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[garage_sp_get]
(
    @CMD           NVARCHAR(50),
    @vBranchCode   NVARCHAR(100) = NULL,
    @vCon1         NVARCHAR(100) = NULL,
    @vCon2         NVARCHAR(100) = NULL,
    @vCon3         NVARCHAR(100) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    ------------------------------------------------------------
    -- Brand
    ------------------------------------------------------------
    IF UPPER(@CMD) = 'BRAND'
    BEGIN
        SELECT
            brand_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_brand
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Model
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'MODEL'
    BEGIN
        SELECT
            M.model_id,
            M.branch_code,
            M.brand_id,
            B.title AS brand_name,
            M.year_id,
            M.title AS model_name,
            M.is_active,
            M.inputdate
        FROM dbo.garage_tbl_models M
        INNER JOIN dbo.garage_tbl_brand B
            ON M.brand_id = B.brand_id
           AND M.branch_code = B.branch_code
        WHERE (@vBranchCode IS NULL OR M.branch_code = @vBranchCode)
        ORDER BY
            B.title,
            M.title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Model By Brand
    -- EXEC dbo.garage_sp_get
    --      @CMD='MODEL_BY_BRAND',
    --      @vBranchCode='0001',
    --      @vCon1='BR000071'
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'MODEL_BY_BRAND'
    BEGIN
        SELECT
            model_id,
            branch_code,
            brand_id,
            title
        FROM dbo.garage_tbl_models
        WHERE brand_id = @vCon1
          AND (@vBranchCode IS NULL OR branch_code = @vBranchCode)
          AND is_active = 1
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Color
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'COLOR'
    BEGIN
        SELECT
            color_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_colors
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Year
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'YEAR'
    BEGIN
        SELECT
            year_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_year
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title DESC;

        RETURN;
    END

    ------------------------------------------------------------
    -- Fuel Type
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'FUEL'
    BEGIN
        SELECT
            fuel_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_fuel_type
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Transmission
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'TRANSMISSION'
    BEGIN
        SELECT
            transmission_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_transmission
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Body Type
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'BODY_TYPE'
    BEGIN
        SELECT
            body_type_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_body_type
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Drive Type
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'DRIVE_TYPE'
    BEGIN
        SELECT
            drive_type_id,
            branch_code,
            title,
            is_active,
            inputdate
        FROM dbo.garage_tbl_drive_type
        WHERE (@vBranchCode IS NULL OR branch_code = @vBranchCode)
        ORDER BY title;

        RETURN;
    END

    ------------------------------------------------------------
    -- Unknown Command
    ------------------------------------------------------------
    ELSE
    BEGIN
        RAISERROR('garage_sp_get : Unknown command.',16,1);
        RETURN;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[garage_sp_save]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[garage_sp_save]
(
    @CMD            NVARCHAR(50),
    @vBranchCode    NVARCHAR(100) = NULL,
    @id             NVARCHAR(50) = NULL,
    @title          NVARCHAR(100) = NULL,

    @brand_id       NVARCHAR(50) = NULL,
    @model_id       NVARCHAR(50) = NULL,
    @year_id        NVARCHAR(50) = NULL,

    @is_active      BIT = 1
)
AS
BEGIN
    SET NOCOUNT ON;

    ------------------------------------------------------------
    -- Brand
    ------------------------------------------------------------
    IF UPPER(@CMD)='BRAND_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_brand
        (
            brand_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='BRAND_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_brand
        SET
            title      = @title,
            is_active  = @is_active
        WHERE brand_id    = @id
          AND branch_code = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Color
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='COLOR_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_colors
        (
            color_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='COLOR_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_colors
        SET
            title      = @title,
            is_active  = @is_active
        WHERE color_id    = @id
          AND branch_code = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Model
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='MODEL_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_models
        (
            model_id,
            branch_code,
            brand_id,
            year_id,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @brand_id,
            @year_id,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='MODEL_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_models
        SET
            brand_id   = @brand_id,
            year_id    = @year_id,
            title      = @title,
            is_active  = @is_active
        WHERE model_id    = @id
          AND branch_code = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Year
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='YEAR_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_year
        (
            year_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='YEAR_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_year
        SET
            title      = @title,
            is_active  = @is_active
        WHERE year_id     = @id
          AND branch_code = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Fuel
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='FUEL_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_fuel_type
        (
            fuel_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='FUEL_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_fuel_type
        SET
            title      = @title,
            is_active  = @is_active
        WHERE fuel_id     = @id
          AND branch_code = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Transmission
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='TRANSMISSION_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_transmission
        (
            transmission_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='TRANSMISSION_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_transmission
        SET
            title      = @title,
            is_active  = @is_active
        WHERE transmission_id = @id
          AND branch_code     = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Body Type
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='BODY_TYPE_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_body_type
        (
            body_type_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='BODY_TYPE_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_body_type
        SET
            title      = @title,
            is_active  = @is_active
        WHERE body_type_id = @id
          AND branch_code  = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Drive Type
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD)='DRIVE_TYPE_INSERT'
    BEGIN

        INSERT INTO dbo.garage_tbl_drive_type
        (
            drive_type_id,
            branch_code,
            title,
            is_active
        )
        VALUES
        (
            @id,
            @vBranchCode,
            @title,
            @is_active
        );

        RETURN;
    END

    ELSE IF UPPER(@CMD)='DRIVE_TYPE_UPDATE'
    BEGIN

        UPDATE dbo.garage_tbl_drive_type
        SET
            title      = @title,
            is_active  = @is_active
        WHERE drive_type_id = @id
          AND branch_code   = @vBranchCode;

        RETURN;
    END

    ------------------------------------------------------------
    -- Unknown Command
    ------------------------------------------------------------
    ELSE
    BEGIN
        RAISERROR('garage_sp_save : Unknown command.',16,1);
        RETURN;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[Global_Get]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Global_Get]
(
    @CMD           NVARCHAR(30),
    @vBranchCode   NVARCHAR(100) = NULL,
    @vCon1         NVARCHAR(100) = NULL,
    @vCon2         NVARCHAR(100) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    ------------------------------------------------------------
    -- Last Login User
    ------------------------------------------------------------
    IF UPPER(@CMD) = 'USER_LAST_LOGIN'
    BEGIN
        SELECT TOP (1)
               user_id
        FROM dbo.sys_user_logins
        WHERE branch_code = @vBranchCode
        ORDER BY last_sync DESC;

        RETURN;
    END

    ------------------------------------------------------------
    -- Languages
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'SYS_LANGUAGE'
    BEGIN
        SELECT
            id,
            language_code,
            culture_code,
            language_name,
            native_name,
            resource_file,
            flag_icon,
            sort_order,
            is_default,
            is_active
        FROM dbo.sys_languages
        WHERE is_active = 1
        ORDER BY sort_order;

        RETURN;
    
    END

    ------------------------------------------------------------
    -- System Constants
    -- Example:
    -- EXEC dbo.Global_Get @CMD='SYS_CONSTANT', @vCon1='STATUS'
    -- EXEC dbo.Global_Get @CMD='SYS_CONSTANT', @vCon1='GENDER'
    -- EXEC dbo.Global_Get @CMD='SYS_CONSTANT', @vCon1='PAYMENT_METHOD'
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'SYS_CONSTANT'
    BEGIN
        SELECT
            con_line    AS Code,
            con_display AS Name
        FROM dbo.sysconstants
        WHERE UPPER(con_id) = UPPER(@vCon1)
          AND ISNULL(disable,0) = 0
        ORDER BY con_display;

        RETURN;
    END

    ELSE IF @CMD = 'SYS_LANGUAGE_DEFAULT'
BEGIN
    SELECT TOP (1)
        id,
        language_code,
        culture_code,
        language_name,
        native_name,
        resource_file,
        flag_icon,
        sort_order,
        is_default,
        is_active
    FROM dbo.sys_languages
    WHERE is_default = 1
      AND is_active = 1;

    RETURN;
END

    ------------------------------------------------------------
    -- SQL Server Date & Time
    ------------------------------------------------------------
    ELSE IF UPPER(@CMD) = 'SERVER_TIME'
    BEGIN
        SELECT
            GETDATE() AS ServerDateTime;

        RETURN;
    END

    ------------------------------------------------------------
    -- Unknown Command
    ------------------------------------------------------------
    ELSE
    BEGIN
        RAISERROR('Global_Get : Unknown command.',16,1);
        RETURN;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[NextNumber_Get]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NextNumber_Get]
(
    @BranchCode     NVARCHAR(20),
    @DocumentType   NVARCHAR(50),
    @NextCode       NVARCHAR(100) OUTPUT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE
        @CurrentNumber INT,
        @FormatType NVARCHAR(20),
        @Prefix NVARCHAR(20),
        @Padding INT,
        @Separator NVARCHAR(5);

    SET @BranchCode = UPPER(LTRIM(RTRIM(@BranchCode)));
    SET @DocumentType = UPPER(LTRIM(RTRIM(@DocumentType)));

    BEGIN TRY

        BEGIN TRANSACTION;

        IF NOT EXISTS
        (
            SELECT 1
            FROM dbo.sys_running_numbers
            WHERE branch_code = @BranchCode
              AND document_type = @DocumentType
        )
        BEGIN
            INSERT INTO dbo.sys_running_numbers
            (
                branch_code,
                document_type,
                current_number,
                format_type,
                prefix,
                padding,
                separator,
                description,
                is_active
            )
            SELECT
                @BranchCode,
                document_type,
                0,
                format_type,
                prefix,
                padding,
                separator,
                description,
                is_active
            FROM dbo.sys_running_numbers_template
            WHERE document_type = @DocumentType
              AND is_active = 1;

            IF @@ROWCOUNT = 0
                THROW 50001, 'Running number template not found.', 1;
        END

        UPDATE dbo.sys_running_numbers
           SET current_number = current_number + 1
        WHERE branch_code = @BranchCode
          AND document_type = @DocumentType
          AND is_active = 1;

        IF @@ROWCOUNT = 0
            THROW 50002, 'Running number is not configured.', 1;

        SELECT
            @CurrentNumber = current_number,
            @FormatType = format_type,
            @Prefix = ISNULL(prefix, ''),
            @Padding = ISNULL(padding, 6),
            @Separator = ISNULL(separator, '')
        FROM dbo.sys_running_numbers WITH (UPDLOCK, HOLDLOCK)
        WHERE branch_code = @BranchCode
          AND document_type = @DocumentType
          AND is_active = 1;

        IF @FormatType = '0'
            SET @NextCode =
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);
        ELSE IF @FormatType = '1'
            SET @NextCode =
                @BranchCode + @Separator +
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);
        ELSE IF @FormatType = '2'
            SET @NextCode =
                @Prefix +
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);
        ELSE IF @FormatType = '3'
            SET @NextCode =
                LEFT(@Prefix, 1) +
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);
        ELSE IF @FormatType = '9'
            SET @NextCode =
                CONVERT(CHAR(8), GETDATE(), 112) +
                @Separator +
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);
        ELSE
            SET @NextCode =
                RIGHT(REPLICATE('0', @Padding) + CAST(@CurrentNumber AS NVARCHAR(20)), @Padding);

        COMMIT TRANSACTION;

    END TRY
    BEGIN CATCH

        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        THROW;

    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[RunningNumber_Sync]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RunningNumber_Sync]
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    INSERT INTO dbo.sys_running_numbers
    (
        branch_code,
        document_type,
        current_number,
        format_type,
        prefix,
        padding,
        separator,
        description,
        is_active
    )
    SELECT
        B.branch_code,
        T.document_type,
        0,
        T.format_type,
        T.prefix,
        T.padding,
        T.separator,
        T.description,
        T.is_active
    FROM
    (
        SELECT DISTINCT branch_code
        FROM dbo.sys_running_numbers
    ) AS B
    CROSS JOIN dbo.sys_running_numbers_template AS T
    WHERE NOT EXISTS
    (
        SELECT 1
        FROM dbo.sys_running_numbers AS R
        WHERE R.branch_code = B.branch_code
          AND UPPER(LTRIM(RTRIM(R.document_type)))
            = UPPER(LTRIM(RTRIM(T.document_type)))
    );

    UPDATE R
       SET
            R.format_type = T.format_type,
            R.prefix      = T.prefix,
            R.padding     = T.padding,
            R.separator   = T.separator,
            R.description = T.description,
            R.is_active   = T.is_active
    FROM dbo.sys_running_numbers AS R
    INNER JOIN dbo.sys_running_numbers_template AS T
        ON UPPER(LTRIM(RTRIM(R.document_type)))
         = UPPER(LTRIM(RTRIM(T.document_type)));

    UPDATE R
       SET R.is_active = 0
    FROM dbo.sys_running_numbers AS R
    WHERE NOT EXISTS
    (
        SELECT 1
        FROM dbo.sys_running_numbers_template AS T
        WHERE UPPER(LTRIM(RTRIM(T.document_type)))
            = UPPER(LTRIM(RTRIM(R.document_type)))
    );

    COMMIT TRANSACTION;
END
GO
/****** Object:  StoredProcedure [dbo].[SystemLog_Save]    Script Date: 30/07/2026 1:13:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SystemLog_Save]
(
    @LogLevel        NVARCHAR(50),
    @Title           NVARCHAR(200),
    @Message         NVARCHAR(MAX),

    @ExceptionType   NVARCHAR(500) = NULL,
    @StackTrace      NVARCHAR(MAX) = NULL,
    @Source          NVARCHAR(500) = NULL,

    @MachineName     NVARCHAR(100) = NULL,
    @UserName        NVARCHAR(100) = NULL,
    @ApplicationName NVARCHAR(200) = NULL,

    @SqlStatement    NVARCHAR(MAX) = NULL,
    @Parameters      NVARCHAR(MAX) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO SystemLogs
    (
        LogDate,
        LogLevel,
        Title,
        Message,
        ExceptionType,
        StackTrace,
        Source,
        MachineName,
        UserName,
        ApplicationName,
        SqlStatement,
        Parameters
    )
    VALUES
    (
        GETDATE(),
        @LogLevel,
        @Title,
        @Message,
        @ExceptionType,
        @StackTrace,
        @Source,
        @MachineName,
        @UserName,
        @ApplicationName,
        @SqlStatement,
        @Parameters
    );
END
GO
