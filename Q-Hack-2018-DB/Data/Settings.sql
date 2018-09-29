IF NOT EXISTS (SELECT 1 FROM [Settings] WHERE [Name] = 'BearerToken') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (1, 'BearerToken', 'Doesnt Matter');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgyNTAwMDYsIm5iZiI6MTUzODI0NjQwNiwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODI0NjQwNiwiYXV0aF90aW1lIjoxNTM4MjQ2NDA2LCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.KYFREExj3mZxBv7yLzLBIIsf3McOHasFbkYws61CU4RztNcJoQoFOaENj5u_RerH1_N2QptqYfOXnqxSFcjcBZrBdbLG-6SS1_gtdl83fF7b7bTbezt6oHq82rBC-l31mvVAUiPHQxH3XQoLWuRYKPWfii63rshWTwkDSNXryJfv3CXseWrPC9rJBGbAnfde19_XVixSkDNaQp85Lch45RzNZe_k7ldnw359tMEEb-4tsU3-NMQF0EJ1lcTYp1db1uOvZKP3nSbzKHp7_OykLE13mTB3BPydaCwp_baneNEsCpfOMildi6RRk5xj4xrjFoBygxAh5xYM8jL6ED46sg' WHERE [Name] = 'BearerToken'

IF NOT EXISTS (SELECT 2 FROM [Settings] WHERE [Name] = 'AverageDailyCost') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (2, 'AverageDailyCost', '4.69');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = '4.69' WHERE [Name] = 'AverageDailyCost'