/*
Кофигурация базы данных:
  Product
    ID (int, key)
    Name (text)
  Category
    ID (int, key)
    Name (text)
  Product-Category
    ID (int, key)
    ID_Product (int)
    ID_Category (int)
*/

SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN [Product-Category] ON Product.ID = [Product-Category].ID_Product
LEFT JOIN Category ON Category.ID = [Product-Category].ID_Category
