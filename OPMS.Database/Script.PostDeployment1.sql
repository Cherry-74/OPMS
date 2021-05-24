/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryId], [CountryName], [IsActive]) VALUES (1, N'India', 1)
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([StateId], [StateName], [CountryId], [IsActive]) VALUES (1, N'Odisha', 1, 1)
SET IDENTITY_INSERT [dbo].[State] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityId], [Name], [StateId], [IsActive]) VALUES (1, N'Bhubaneswar', 1, 1)
INSERT [dbo].[City] ([CityId], [Name], [StateId], [IsActive]) VALUES (2, N'Puri', 1, 1)
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[ParkingAddress] ON 

INSERT [dbo].[ParkingAddress] ([ParkingAddressId], [Address1], [Address2], [CityId], [IsActive]) VALUES (1, N'Durga Mandap', N'Sahid Nagar', 1, 1)
INSERT [dbo].[ParkingAddress] ([ParkingAddressId], [Address1], [Address2], [CityId], [IsActive]) VALUES (2, N'Market', N'Bapuji Nagar', 1, 1)
SET IDENTITY_INSERT [dbo].[ParkingAddress] OFF
GO

SET IDENTITY_INSERT [dbo].[ParkingFees] ON 

INSERT [dbo].[ParkingFees] ([ParkingFeesId], [Fees], [IsActive]) VALUES (1, CAST(20.00 AS Numeric(5, 2)), 1)
INSERT [dbo].[ParkingFees] ([ParkingFeesId], [Fees], [IsActive]) VALUES (2, CAST(40.00 AS Numeric(5, 2)), 1)
INSERT [dbo].[ParkingFees] ([ParkingFeesId], [Fees], [IsActive]) VALUES (3, CAST(60.00 AS Numeric(5, 2)), 1)
SET IDENTITY_INSERT [dbo].[ParkingFees] OFF
GO

SET IDENTITY_INSERT [dbo].[VechileType] ON 

INSERT [dbo].[VechileType] ([VechileTypeId], [TypeName], [ParkingFeesId], [IsActive]) VALUES (1, N'2-Wheeler', 1, 1)
INSERT [dbo].[VechileType] ([VechileTypeId], [TypeName], [ParkingFeesId], [IsActive]) VALUES (2, N'4-Wheeler', 2, 1)
INSERT [dbo].[VechileType] ([VechileTypeId], [TypeName], [ParkingFeesId], [IsActive]) VALUES (3, N'6-Wheeler', 3, 1)
SET IDENTITY_INSERT [dbo].[VechileType] OFF
GO


SET IDENTITY_INSERT [dbo].[ParkingDetails] ON 

INSERT [dbo].[ParkingDetails] ([ParkingdetailId], [ParkingAddressId], [VechileTypeId], [MaxSlot], [IsActive]) VALUES (1, 1, 1, 10, 1)
INSERT [dbo].[ParkingDetails] ([ParkingdetailId], [ParkingAddressId], [VechileTypeId], [MaxSlot], [IsActive]) VALUES (2, 1, 2, 5, 1)
INSERT [dbo].[ParkingDetails] ([ParkingdetailId], [ParkingAddressId], [VechileTypeId], [MaxSlot], [IsActive]) VALUES (3, 1, 3, 2, 1)
INSERT [dbo].[ParkingDetails] ([ParkingdetailId], [ParkingAddressId], [VechileTypeId], [MaxSlot], [IsActive]) VALUES (4, 2, 1, 5, 1)
INSERT [dbo].[ParkingDetails] ([ParkingdetailId], [ParkingAddressId], [VechileTypeId], [MaxSlot], [IsActive]) VALUES (5, 2, 2, 5, 1)
SET IDENTITY_INSERT [dbo].[ParkingDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [Password], [ContactNo], [Email], [IsActive], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (1, N'admin', N'admin', NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [ContactNo], [Email], [IsActive], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (2, N'user', N'user', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [ContactNo], [Email], [IsActive], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (3, N'tc1', N'tc1', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [ContactNo], [Email], [IsActive], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (4, N'tc2', N'tc2', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [UserName], [Password], [ContactNo], [Email], [IsActive], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn]) VALUES (5, N'tc3', N'tc3', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserParkingAddress] ON 

INSERT [dbo].[UserParkingAddress] ([UserParkingAddressId], [UserId], [ParkingAddressId], [IsActive]) VALUES (1, 3, 1, NULL)
INSERT [dbo].[UserParkingAddress] ([UserParkingAddressId], [UserId], [ParkingAddressId], [IsActive]) VALUES (2, 4, 2, NULL)
INSERT [dbo].[UserParkingAddress] ([UserParkingAddressId], [UserId], [ParkingAddressId], [IsActive]) VALUES (3, 5, 1, NULL)
SET IDENTITY_INSERT [dbo].[UserParkingAddress] OFF
GO


SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (1, N'Admin', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Role] ([RoleId], [RoleName], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (2, N'User', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Role] ([RoleId], [RoleName], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (3, N'TicketCollector', NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([UserRoleId], [UserId], [RoleId], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (1, 1, 1, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[UserRole] ([UserRoleId], [UserId], [RoleId], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (2, 2, 2, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[UserRole] ([UserRoleId], [UserId], [RoleId], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (3, 3, 3, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[UserRole] ([UserRoleId], [UserId], [RoleId], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (4, 4, 3, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[UserRole] ([UserRoleId], [UserId], [RoleId], [CreatedBy], [CreatedOn], [UpdatedBy], [UpdatedOn], [IsActive]) VALUES (5, 5, 3, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[UserRole] OFF
GO