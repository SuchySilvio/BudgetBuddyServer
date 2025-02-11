CREATE TABLE Accounts (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    AccountId NVARCHAR(100) NOT NULL,
    Balance DECIMAL(18, 2) NOT NULL
);

CREATE TABLE Transactions (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Amount DECIMAL(18, 2) NOT NULL,
    Date DATETIME NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    Channel NVARCHAR(100) NOT NULL
);