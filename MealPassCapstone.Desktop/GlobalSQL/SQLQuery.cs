using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPassCapstone.Desktop.GlobalSQL
{
    public class SQLQuery
    {
        public static string connectionString = @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = MealPassDB;Integrated Security = True;";
        //public static string connectionString = @"Data Source = PAGALING\SQLEXPRESS;Initial Catalog = MealPassDB;Integrated Security = True;";

        public static string InsertAccount = @"
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

        public static string FilterAllEmployees = @"
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

        public static string FilterEmployeeData = @"SELECT EmployeeID
                                                          ,FirstName
                                                          ,MiddleName
                                                          ,LastName
                                                          ,NameExtension
                                                          ,Gender
                                                          ,Birthdate,                          
                                                           DATEDIFF(YEAR, Birthdate, GETDATE()) 
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

        public static string UpdateAccount = @"
            UPDATE dbo.Employees
            SET 
                RoleID = @RoleID,
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                LastName = @LastName,
                NameExtension = @NameExtension,
                CivilStatusID = @CivilStatusID,
                Gender = @Gender,
                Birthdate = @Birthdate,
                ContactNo = @ContactNo,
                Username = @Username,
                EmploymentStatus = @EmploymentStatus,
                IsLocked = @IsLocked,
                FailedAttempts = CASE WHEN @IsLocked = 0 THEN 0 ELSE FailedAttempts END
                WHERE Username = @OriginalUsername";

    }
}
