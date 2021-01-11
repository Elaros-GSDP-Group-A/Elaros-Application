SET IDENTITY_INSERT [dbo].[Questions] ON
INSERT INTO [dbo].[Questions] ([QuestionId], [Content], [NumberOfAnswers]) VALUES (NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Questions] OFF
DBCC CHECKIDENT ('[TestTable]', RESEED, 0);