namespace MealPass.Data.Queries
{
    public static class EmployeeQuery
    {
        public const string GetLoginInfo = @"
            SELECT Password, RoleID, FailedAttempts, IsLocked
              FROM dbo.Employees
             WHERE Username = @Username";

        public const string ResetFailedAttempts = @"
            UPDATE dbo.Employees
               SET FailedAttempts = 0
             WHERE Username = @Username";

        public const string SetFailedAttempts = @"
            UPDATE dbo.Employees
               SET FailedAttempts = @FailedAttempts,
                   IsLocked       = @IsLocked
             WHERE Username = @Username";

        public const string UsernameExists = @"
            SELECT COUNT(*) FROM dbo.Employees WHERE Username = @Username";

        public const string Insert = @"
            INSERT INTO dbo.Employees (
                   FirstName
                  ,MiddleName
                  ,LastName
                  ,NameExtension
                  ,Gender
                  ,Birthdate
                  ,ContactNo
                  ,CivilStatusID
                  ,Username
                  ,Password
                  ,RoleID
                  ,EmploymentStatus)
           VALUES (
                   @FirstName
                  ,@MiddleName
                  ,@LastName
                  ,@NameExtension
                  ,@Gender
                  ,@Birthdate
                  ,@ContactNo
                  ,@CivilStatusID
                  ,@Username
                  ,@Password
                  ,@RoleID
                  ,@EmploymentStatus);";

        public const string FilterAllEmployees = @"
            SELECT
                    FirstName + ' ' +
                        CASE
                            WHEN MiddleName IS NULL OR LTRIM(RTRIM(MiddleName)) = ''
                                THEN LastName
                            ELSE LEFT(MiddleName, 1) + '. ' + LastName
                        END +
                        CASE
                            WHEN NameExtension IS NULL OR LTRIM(RTRIM(NameExtension)) = ''
                                THEN ''
                            ELSE ' ' + NameExtension
                        END AS EmployeeName,
                          DATEDIFF(YEAR, e.Birthdate, GETDATE())
                        -CASE
                            WHEN (MONTH(GETDATE()) < MONTH(e.Birthdate))
                                  OR (MONTH(GETDATE()) = MONTH(e.Birthdate)
                                      AND DAY(GETDATE()) < DAY(e.Birthdate))
                            THEN 1
                            ELSE 0
                          END AS Age,
                          cs.CivilStatusName AS CivilStatus,
                          e.ContactNo,
                          e.Username,
                          r.RoleName,
                    CASE
                        WHEN EmploymentStatus = 1 THEN 'Active'
                        ELSE 'In-Active'
                    END AS EmploymentStatus,
                 CASE
                     WHEN IsLocked = 1 THEN 'Locked'
                     ELSE 'Unlocked'
                END AS IsLocked
                FROM dbo.Employees e
                LEFT JOIN dbo.Roles r ON r.RoleID = e.RoleID
                LEFT JOIN dbo.CivilStatus cs
                ON cs.CivilStatusID = e.CivilStatusID
                ORDER BY EmployeeID;";

        public const string FilterEmployeeData = @"
            SELECT EmployeeID
                  ,FirstName
                  ,MiddleName
                  ,LastName
                  ,NameExtension
                  ,Gender
                  ,Birthdate
                  ,DATEDIFF(YEAR, Birthdate, GETDATE())
                   -CASE
                        WHEN (MONTH(GETDATE()) < MONTH(Birthdate))
                          OR (MONTH(GETDATE()) = MONTH(Birthdate)
                              AND DAY(GETDATE()) < DAY(Birthdate))
                        THEN 1
                        ELSE 0
                    END AS Age
                  ,ContactNo
                  ,cs.CivilStatusName AS CivilStatus
                  ,e.CivilStatusID
                  ,Username
                  ,e.RoleID
                  ,r.RoleName
                  ,EmploymentStatus
                  ,FailedAttempts
                  ,IsLocked
              FROM dbo.Employees e
              LEFT JOIN dbo.Roles r ON r.RoleID = e.RoleID
              LEFT JOIN dbo.CivilStatus cs
                ON cs.CivilStatusID = e.CivilStatusID
             WHERE Username = @Username;";

        public const string Update = @"
            UPDATE dbo.Employees
               SET RoleID            = @RoleID,
                   FirstName         = @FirstName,
                   MiddleName        = @MiddleName,
                   LastName          = @LastName,
                   NameExtension     = @NameExtension,
                   CivilStatusID     = @CivilStatusID,
                   Gender            = @Gender,
                   Birthdate         = @Birthdate,
                   ContactNo         = @ContactNo,
                   Username          = @Username,
                   EmploymentStatus  = @EmploymentStatus,
                   IsLocked          = @IsLocked,
                   FailedAttempts    = CASE WHEN @IsLocked = 0 THEN 0 ELSE FailedAttempts END
             WHERE Username = @OriginalUsername";

        public const string DeleteByUsername = @"
            DELETE FROM dbo.Employees WHERE Username = @Username";

        public const string UpdatePassword = @"
            UPDATE dbo.Employees
               SET Password       = @Password,
                   FailedAttempts = 0,
                   IsLocked       = 0
             WHERE Username = @Username";
    }
}
