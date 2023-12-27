-- Создание таблиц условия
CREATE TABLE Products
(
    ProductID int PRIMARY KEY,
    ProductName varchar(255) NOT NULL
);

CREATE TABLE Categories
(
    CategoryID int PRIMARY KEY,
    CategoryName varchar(255) NOT NULL
);

CREATE TABLE ProductCategories
(
    ProductID int,
    CategoryID int,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    PRIMARY KEY (ProductID, CategoryID)
);

-- Запрос
SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;
