IF NOT EXISTS (SELECT 1 FROM [Settings] WHERE [Name] = 'BearerToken') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (1, 'BearerToken', 'Doesnt Matter');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = 'Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImtpZCI6Ilg1ZVhrNHh5b2pORnVtMWtsMll0djhkbE5QNC1jNTdkTzZRR1RWQndhTmsifQ.eyJleHAiOjE1MzgyMzcxODQsIm5iZiI6MTUzODIzMzU4NCwidmVyIjoiMS4wIiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi5taWNyb3NvZnRvbmxpbmUuY29tL2Q1Zjg1NjgyLWY2N2EtNDQ0NC05MzY5LTJjNWVjMWEwZThjZC92Mi4wLyIsInN1YiI6IjQ4MjI3ODRkLTBjMzUtNDg2Yi1hZjYwLWViZGE3NjE4ZDA2MiIsImF1ZCI6ImEwNmE3NGM1LWRlYTgtNGY4Ny1iYTc3LTlkZjZkMDMwODcyNSIsImlhdCI6MTUzODIzMzU4NCwiYXV0aF90aW1lIjoxNTM4MjMzNTg0LCJvaWQiOiI0ODIyNzg0ZC0wYzM1LTQ4NmItYWY2MC1lYmRhNzYxOGQwNjIiLCJnaXZlbl9uYW1lIjoibXNiYiIsImZhbWlseV9uYW1lIjoieGFtdGVzdCIsIm5hbWUiOiJtc2JieGFtdGVzdCIsImVtYWlscyI6WyJtYXJ0aW4uc2hvcnRAYmx1ZWJhbmsuaW8iXSwidGZwIjoiQjJDXzFfU0kifQ.fltWgEhm6xr-Rzs5fsVDfTg3TyVqsx9NlqIpWVHT_NrZufTg3ceFaNAO4IkpIvXdpgUZ19U8dJSXxAYO18uxyDCku3UdXG3N1dZmgnVYOyflmXgHAsv5t_Yf2OQEsh45fjvU8q-ZPM0XBG_MH_IMnc8pEKe72KIOSY6HNEx1PA2s5FbEU8YLxnLpIouK4DTnUJqcudsnxpFfp4EnlL3qmUI6h9aihvnRp-sR11hTeNCP3zSQ9UBWssHdhmeaoNmK_ahtSrzlo99ML1VuxFg3h3oGDYEmfXvx9pXBFETA0VmtcTZddYJJphRfnGM1TXwKIpL7x0hqdxei3pi-d5X5Ww' WHERE [Name] = 'BearerToken'

IF NOT EXISTS (SELECT 2 FROM [Settings] WHERE [Name] = 'AverageDailyCost') INSERT INTO [Settings] ([Id], [Name], [Value]) VALUES (2, 'AverageDailyCost', '4.69');

-- Always do an update. Change this value below.
UPDATE [Settings] SET [Value] = '4.69' WHERE [Name] = 'AverageDailyCost'