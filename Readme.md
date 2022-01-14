# Exam Dotnet

this project expose API request and get result in homepage

## Requirement
- dotnet 6
- Mysql

## How to use
```bash
    #intall dependencies
    dotnet restore
    #create table and database
    dotnet ef database update
    #run app
    dotnet run
```
## Populate data
```sql
INSERT INTO `products` (`Code`, `Designation`, `Quantity`, `UnitPrice`) VALUES
	('p-859', 'Product 1', 45, 25.8),
	('p-892', 'Product 2', 45, 28.9);
```