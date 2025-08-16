CREATE TABLE [Logger](
	[Id] [bigint] IDENTITY(1,1)             NOT NULL PRIMARY KEY,
	[Created] DATETIME NOT NULL DEFAULT GETDATE(),
	[Updated] DATETIME NOT NULL DEFAULT GETDATE(),
	[IsActive] [tinyint] NOT NULL DEFAULT 1,
	[IsDeleted] [tinyint] NOT NULL DEFAULT 0,
	[Message] [nvarchar](max) NOT NULL,
	[AdminId] [bigint] NULL,	
	[ClassName] [nvarchar](255) NULL,
	[MethodName] [nvarchar](255) NULL,
	[MethodSignature] [nvarchar](255) NULL,
	[MethodParameters] [nvarchar](255) NULL,
	[StackTrace] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] 