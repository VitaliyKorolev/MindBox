
CREATE TABLE Product (
 Id INT PRIMARY KEY IDENTITY(1,1),
 Name NVARCHAR(100) NOT NULL,
 CategoryId INT REFERENCES Category (Id)
)

INSERT INTO Product 
VALUES  ('Iphone', 1),
        ('Iphone', 2),
		('Car', null),
        ('Sofa', 2);

