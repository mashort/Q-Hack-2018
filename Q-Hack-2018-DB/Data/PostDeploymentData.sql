﻿/*
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
:r .\CalculationHistory.sql
:r .\CalculationRules.sql
:r .\Categories.sql
:r .\CategorisationMatches.sql
:r .\GivingHistory.sql
:r .\Settings.sql
:r .\TransactionTypes.sql