IF NOT EXISTS (SELECT 1 FROM [Settings] WHERE [Name] = 'BearerToken') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (1, 'BearerToken', 'Doesnt Matter');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgzMDEwNTIsIm5iZiI6MTUzODI5NzQ1MiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODI5NzQ1MiwiYXV0aF90aW1lIjoxNTM4Mjk3NDUyLCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.YBuAEiIivm1lkiojj2rAsrOkcZyECdfuYVPRl2yaQ03tswPZCx4YLWFzqpDMPEXlbG8xA4j-C1R9xYtDVYDcs7f6qW1-sYiunO-82neWBWkGJdeF_XL1jx7M9Lnt6cJMBC6IzXThYuWCHs4Oeqg4rH-5eB4Hn-RrkpdXqZquyE9gvCg6TIWVC6_-Q4t9scptTFm79UHqftRGJM7-Pqt4tX3jn5tiL_Yq4nU91C1uvCXxqZyQweI7z9GKib55qYF548iTJf_C-Zyr2WQhNsH4g_eJihwx9OGsSN0qpvZ6Fho431H1aQbQZeg5ZKxdkI-90BLxtZ3FSRmTNGBEWGWbuw' WHERE [Name] = 'BearerToken'

IF NOT EXISTS (SELECT 2 FROM [Settings] WHERE [Name] = 'AverageDailyCost') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (2, 'AverageDailyCost', '4.69');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = '4.69' WHERE [Name] = 'AverageDailyCost'