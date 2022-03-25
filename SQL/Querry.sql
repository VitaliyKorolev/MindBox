SELECT Product.Name, Category.Name
FROM Product LEFT JOIN Category 
ON Product.CategoryId = Category.Id