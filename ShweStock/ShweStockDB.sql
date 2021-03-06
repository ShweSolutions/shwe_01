USE [ShweStock]
GO
/****** Object:  Table [dbo].[SaleOrderHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleOrderHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[Date] [datetime] NULL,
	[CustomerId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[VouDiscountAmt] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_SaleOrderHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleOrderDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleOrderDetails](
	[SaleOrderDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SaleOrderDetails] PRIMARY KEY CLUSTERED 
(
	[SaleOrderDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[SaleOrderId] [int] NULL,
	[Date] [datetime] NULL,
	[CustomerId] [int] NULL,
	[PaymentId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[VouDiscountAmt] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_SaleHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SaleDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_SaleDetails] PRIMARY KEY CLUSTERED 
(
	[SaleDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnOutHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnOutHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[PurchaseId] [int] NULL,
	[Date] [datetime] NULL,
	[SupplierId] [int] NULL,
	[PaymentId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[VouDiscountAmt] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_ReturnOutHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnOutDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnOutDetails](
	[ReturnOutDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ReturnOutDetails] PRIMARY KEY CLUSTERED 
(
	[ReturnOutDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnInHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnInHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[SaleId] [int] NULL,
	[Date] [datetime] NULL,
	[CustomerId] [int] NULL,
	[PaymentId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[VouDiscountAmt] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_ReturnInHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnInDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnInDetails](
	[ReturnInDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ReturnInDetails] PRIMARY KEY CLUSTERED 
(
	[ReturnInDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[Date] [datetime] NULL,
	[SupplierId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_PurchaseOrderHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrderDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderDetails](
	[PurchaseOrderDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PurchaseOrderDetails] PRIMARY KEY CLUSTERED 
(
	[PurchaseOrderDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseHead]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseHead](
	[TranId] [int] NOT NULL,
	[VoucherNo] [nvarchar](100) NULL,
	[InvoiceNo] [nvarchar](100) NULL,
	[PurchaseOrderId] [int] NULL,
	[Date] [datetime] NULL,
	[SupplierId] [int] NULL,
	[PaymentId] [int] NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[TotalQty] [int] NULL,
	[VouDiscountAmt] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_PurchaseHead] PRIMARY KEY CLUSTERED 
(
	[TranId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetails]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetails](
	[PurchaseDetId] [int] NOT NULL,
	[TranId] [int] NULL,
	[StockId] [int] NULL,
	[UnitId] [int] NULL,
	[PurPrice] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[Qty] [int] NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PurchaseDetails] PRIMARY KEY CLUSTERED 
(
	[PurchaseDetId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[UserName] [nvarchar](100) NULL,
	[Password] [varchar](32) NOT NULL,
	[UserRoleId] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([UserId], [UserName], [Password], [UserRoleId], [IsActive], [CreatedDate], [CreatedBy], [UpdatedDate], [UpdatedBy]) VALUES (1, N'Moe Zaw', N'cGFzc3dvcmQ=', 2, 1, CAST(0x0000A66A00000000 AS DateTime), 0, NULL, NULL)
/****** Object:  Table [dbo].[UserRole]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserRoleId] [int] IDENTITY(1,1) NOT NULL,
	[UserRoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserRoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (1, N'Cashier')
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (2, N'Manager')
INSERT [dbo].[UserRole] ([UserRoleId], [UserRoleName]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
/****** Object:  Table [dbo].[Unit]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitId] [int] NOT NULL,
	[ShortName] [nvarchar](10) NULL,
	[UnitName] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierId] [int] NOT NULL,
	[SupplierName] [nvarchar](100) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockUnit]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockUnit](
	[StockUnitId] [int] NOT NULL,
	[StockId] [int] NULL,
	[FromQty] [int] NULL,
	[FirstUnitId] [int] NULL,
	[ToQty] [int] NULL,
	[SecondUnitId] [int] NULL,
 CONSTRAINT [PK_StockUnit] PRIMARY KEY CLUSTERED 
(
	[StockUnitId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 08/22/2016 22:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockId] [int] NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[MinQty] [int] NULL,
	[MaxQty] [int] NULL,
	[UnitId] [int] NULL,
	[PurPirce] [decimal](10, 2) NULL,
	[SalePrice] [decimal](10, 2) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_getUserAndPassword]    Script Date: 08/22/2016 22:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Zan Zan Koe>
-- Create date: <Create Date,,27/FEB/2014>
-- Description:	<Description,,getting User Name and Password for Login Form>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getUserAndPassword]
	-- Add the parameters for the stored procedure here
	@UserId int,
	@UserName nvarchar(100),
	@Password varchar(32),
	@UserRoleId int,
	@CreatedDate datetime,
	@CreatedBy int,
	@UpdatedDate datetime,
	@UpdatedBy int,
	@IsActive bit,
	@Action int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--IF EXISTS (SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password) 
	--SELECT 1
	--ELSE
	--SELECT 0
	
	SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllUsers]    Script Date: 08/22/2016 22:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Zan Zan Koe>
-- Create date: <Create Date,,25/FEB/2014>
-- Description:	<Description,,retrieving all Users>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getAllUsers] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	  Select  ROW_NUMBER() OVER(ORDER BY UserId DESC) AS 'No',UserId,UserName,UserRoleName,u.Password,u.UserRoleId
	  From Users u,UserRole ur
      Where u.IsActive=1 AND u.UserRoleId = ur.UserRoleId
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getAllUserRoles]    Script Date: 08/22/2016 22:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Zan Zan Koe>
-- Create date: <Create Date,,25/FEB/2014>
-- Description:	<Description,,retrieving User Roles >
-- =============================================
CREATE PROCEDURE [dbo].[sp_getAllUserRoles]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserRoleId,UserRoleName FROM UserRole 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CUUsers]    Script Date: 08/22/2016 22:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Zan Zan Koe>
-- Create date: <Create Date,,25/FEB/2014>
-- Description:	<Description,,Insert, Update and Delete User>
-- =============================================
CREATE PROCEDURE [dbo].[sp_CUUsers] 
	-- Add the parameters for the stored procedure here
	@UserId int,
	@UserName nvarchar(100),
	@Password varchar(32),
	@UserRoleId int,
	@CreatedDate datetime,
	@CreatedBy int,
	@UpdatedDate datetime,
	@UpdatedBy int,
	@IsActive bit,
	@Action int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @Action = 1
	BEGIN
		--SET @UserId = (Select MAX(ISNULL(0,UserId))+1 From Users Where IsActive=1 )
		--SET @UserId  = (Select isnull(userid) from Users where IsActive = 1)
		Set @UserId=(Select ISNULL( MAX(UserId),0)+1 From Users WHERE IsActive = 1)
	
		INSERT INTO Users (UserId,UserName,Password,UserRoleId,IsActive,CreatedDate,CreatedBy )
		VALUES (@UserId,@UserName,@Password,@UserRoleId,@IsActive,@CreatedDate,@CreatedBy )
	END
	ELSE IF @Action = 2
	BEGIN
		UPDATE Users SET UserName = @UserName,Password = @Password,UserRoleId = @UserRoleId, UpdatedDate = @UpdatedDate,UpdatedBy = @UpdatedBy 
		WHERE UserId = @UserId
	END
	ELSE IF @Action = 3
	BEGIN
		UPDATE Users SET IsActive = 0 WHERE UserId = @UserId  
	END
END
GO
/****** Object:  Default [DF_Customer_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_PurchaseHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[PurchaseHead] ADD  CONSTRAINT [DF_PurchaseHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_PurchaseOrderHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[PurchaseOrderHead] ADD  CONSTRAINT [DF_PurchaseOrderHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_ReturnInHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[ReturnInHead] ADD  CONSTRAINT [DF_ReturnInHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_ReturnOutHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[ReturnOutHead] ADD  CONSTRAINT [DF_ReturnOutHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SaleHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[SaleHead] ADD  CONSTRAINT [DF_SaleHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_SaleOrderHead_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[SaleOrderHead] ADD  CONSTRAINT [DF_SaleOrderHead_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Stock_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[Stock] ADD  CONSTRAINT [DF_Stock_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Supplier_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Unit_IsActive]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[Unit] ADD  CONSTRAINT [DF_Unit_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
/****** Object:  Default [DF_Users_IsActive_1]    Script Date: 08/22/2016 22:51:03 ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsActive_1]  DEFAULT ((1)) FOR [IsActive]
GO
