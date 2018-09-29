IF NOT EXISTS (SELECT 1 FROM [Settings] WHERE [Name] = 'BearerToken') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (1, 'BearerToken', 'Doesnt Matter');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgyNTQ2MTksIm5iZiI6MTUzODI1MTAxOSwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODI1MTAxOSwiYXV0aF90aW1lIjoxNTM4MjUxMDE5LCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.bok9fkeiN8-4uxUxSehvCXKMtNTgAq57mXe_9_U9vNujdvdOPkFTUh4EqmBjGT7rU-lhG5ocXjeD9iW-4eW2eN-ckJe8t9o891MgMS886W0wccRpekxtliPLSYtVqcSbP1ouZLsnaaiuqjf9aqXnFmyaZDbRvePCyLubvx9G5Mq97s8OsdwiGWcCXOYjicbSBovHSi09jaUYqcLKmpaVCYabWQ-hBkGcEptA__m4z8PRpdh7t33rjWsm5xjjP8jUftxOz2NBx-6Jixjitohxa07PnnhbgqCSLDYSL-Npf2ZkshhPMtgQIZaugzBM2ztP3qQl5T_PFG4LCFuUcLYV2Q' WHERE [Name] = 'BearerToken'

IF NOT EXISTS (SELECT 2 FROM [Settings] WHERE [Name] = 'AverageDailyCost') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (2, 'AverageDailyCost', '4.69');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = '4.69' WHERE [Name] = 'AverageDailyCost'