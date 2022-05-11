

SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN [Product-Category] ON Product.ID = [Product-Category].ID_Product
LEFT JOIN Category ON Category.ID = [Product-Category].ID_Category
