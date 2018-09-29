ALTER TABLE [dbo].[CategorisationMatches]
	ADD CONSTRAINT [FKCategorisationMatchCategoryID]
	FOREIGN KEY (CategoryID)
	REFERENCES [Categories] (Id)
