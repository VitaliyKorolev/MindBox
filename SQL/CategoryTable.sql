
CREATE TABLE Category (
 Id INT PRIMARY KEY IDENTITY(1,1),
 Name NVARCHAR(100) NOT NULL,
)

INSERT INTO Category 
VALUES  ('Electronics'),
        ('Furniture');

