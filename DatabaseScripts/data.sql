SET IDENTITY_INSERT [dbo].[Song] ON
INSERT INTO [dbo].[Song] ([Id], [SongTitle], [Band], [Album]) VALUES (1, N'Some where I belong', N'Linkin Park', N'Meteora')
INSERT INTO [dbo].[Song] ([Id], [SongTitle], [Band], [Album]) VALUES (2, N'No Matter What', N'Boyzone', N'Where we belong')
SET IDENTITY_INSERT [dbo].[Song] OFF
