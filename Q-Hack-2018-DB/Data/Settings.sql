IF NOT EXISTS (SELECT 1 FROM [Settings] WHERE [Name] = 'BearerToken') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (1, 'BearerToken', 'Doesnt Matter');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgyNDYxOTcsIm5iZiI6MTUzODI0MjU5NywidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODI0MjU5NywiYXV0aF90aW1lIjoxNTM4MjQyNTk3LCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.MpIS2UhQQOwqjolYhc6lbL3kLxdfPnO9kelKx_7g40U1LnzzkfYYH0ImUO5QjB5TMllyPxEavOiwvlE-4R2lgJHOYhsykkBypnyGZseahkDP6gtNUlYJnaykSn1yI74fSCkVmcVdOik-FCuojjrm3Kwyycs39I6EwmIvqp-Vq0eNaf2odd8AR8ahF1gyB3-n9eF4l8QyBfxyzx0Y-uqt5hcB0w3F4hK52E4LEbQCcb5-HE5V3KYkK5cCBmRKc-lo_cj9HaGXa9Khe2bH3ogal4uwUEno69x8D_qLx_G6-BHgn9PjuI9VvP3sKHTE9QA9u74k6jHl8keKVc-Ae6QChg' WHERE [Name] = 'BearerToken'

IF NOT EXISTS (SELECT 2 FROM [Settings] WHERE [Name] = 'AverageDailyCost') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (2, 'AverageDailyCost', '4.69');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = '4.69' WHERE [Name] = 'AverageDailyCost'