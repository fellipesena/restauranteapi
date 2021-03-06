CREATE TABLE [Order]
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	TableId INT FOREIGN KEY REFERENCES [Table](Id),
	BillId INT FOREIGN KEY REFERENCES Bill(Id),
	WaiterId INT FOREIGN KEY REFERENCES Waiter(Id),
	DateTime DATETIME NOT NULL,
	Value MONEY NOT NULL
)