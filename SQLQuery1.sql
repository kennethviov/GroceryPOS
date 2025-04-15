-- Create the database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'protoDB')
    CREATE DATABASE protoDB;
GO

USE protoDB;
GO

-- Drop tables if they exist for a clean redo
DROP TABLE IF EXISTS Sales_Details;
DROP TABLE IF EXISTS Sales;
DROP TABLE IF EXISTS Items;
DROP TABLE IF EXISTS Inventory;
GO



IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Inventory')
BEGIN
    CREATE TABLE Inventory (
        inventory_id INT IDENTITY(1,1) PRIMARY KEY,
        category_id INT NOT NULL UNIQUE,
        category_name VARCHAR(50) NOT NULL
    );
END


IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Items')
BEGIN
    CREATE TABLE Items (
        item_id INT IDENTITY(1000,100) PRIMARY KEY,
        item_name VARCHAR(50) NOT NULL,
        item_price DECIMAL(10,2) NOT NULL,
        item_unit VARCHAR(50) NOT NULL,
        item_stocks INT DEFAULT 0 CHECK (item_stocks >= 0),
        category_id INT NOT NULL, 
        inventory_id INT NOT NULL,
        FOREIGN KEY (category_id) REFERENCES Inventory(category_id),
        FOREIGN KEY (inventory_id) REFERENCES Inventory(inventory_id)
    );
END


INSERT INTO Inventory (category_id, category_name)
SELECT category_id, category_name FROM 
(VALUES 
    (1, 'Vegetables'), 
    (2, 'Meats'), 
    (3, 'Fruits'), 
    (4, 'Drinks'), 
    (5, 'Liquor')
) AS C(category_id, category_name)
WHERE NOT EXISTS (SELECT 1 FROM Inventory WHERE category_name = C.category_name);


INSERT INTO Items (item_name, item_price, item_unit, item_stocks, category_id, inventory_id)
SELECT item_name, item_price, item_unit, item_stocks, category_id, category_id FROM 
(VALUES 
    -- Vegetables
    ('Tomato', 10.00, 'per piece', 100, 1),
    ('Kamunggay', 10.00, 'per bundle', 50, 1),
    ('Onion', 10.00, 'per piece', 200, 1),
    ('Garlic', 10.00, 'per piece', 150, 1),
    ('Ginger', 20.00, 'per 10 grams', 75, 1),
    ('Lettuce', 100.00, 'per 250 grams', 60, 1),
    ('Carrot', 20.00, 'per 250 grams', 90, 1),
    ('Bell Pepper', 199.00, 'per 250 grams', 40, 1),
    ('Squash', 99.00, 'per Kilo', 30, 1),
    ('Eggplant', 75.00, 'per Kilo', 25, 1),
    ('Potato', 80.00, 'per Kilo', 70, 1),
    ('Green Onion', 50.00, 'per 100 grams', 80, 1),

    -- Meats
    ('Beef Ribeye', 580.00, 'per kilo', 50, 2),
    ('Pork Belly', 280.00, 'per kilo', 50, 2),
    ('Beef Flank', 575.00, 'per grams', 50, 2),
    ('A5 Wagyu', 13069.00, 'per grams', 50, 2),
    ('Chicken Thigh', 280.00, 'per kilo', 50, 2),
    ('Whole Chicken', 155.00, 'per piece', 50, 2),
    ('Chicken Wings', 295.00, 'per kilo', 50, 2),
    ('Chicken Drumsticks', 228.00, 'per kilo', 50, 2),

    -- Fruits
    ('Apple', 10.00, 'per piece', 50, 3),
    ('Orange', 10.00, 'per piece', 50, 3),
    ('Banana', 80.00, 'per grams', 50, 3),
    ('Mango', 155.00, 'per kilo', 50, 3),
    ('Grapes', 300.00, 'per kilo', 50, 3),
    ('Pineapple', 170.00, 'per kilo', 50, 3),
    ('Watermelon', 120.00, 'per kilo', 50, 3),
    ('Strawberry', 250.00, 'per kilo', 50, 3),
    ('Blueberry', 195.00, 'per kilo', 50, 3),
    ('Avocado', 150.00, 'per kilo', 50, 3),
    ('Mangosteen', 300.00, 'per kilo', 50, 3),
    ('Kiwi', 150.00, 'per grams', 50, 3),

    -- Drinks
    ('Water 500ml', 20.00, 'per bottle', 50, 4),
    ('Water 1L', 30.00, 'per bottle', 50, 4),
    ('Gatorade', 35.00, 'per bottle', 50, 4),
    ('Coke', 35.00, 'per can', 50, 4),
    ('Coke 1L', 70.00, 'per bottle', 50, 4),
    ('Sprite', 35.00, 'per can', 50, 4),
    ('Sprite 1L', 70.00, 'per bottle', 50, 4),
    ('Fanta', 35.00, 'per can', 50, 4),
    ('Fanta 1L', 70.00, 'per bottle', 50, 4),
    ('Apple C2', 16.00, 'per bottle', 50, 4),
    ('Classic C2', 16.00, 'per bottle', 50, 4),
    ('Kopiko Lucky Day', 30.00, 'per bottle', 50, 4),
    
    -- Liquor
    ('Bacardi Rum', 275.00, 'per bottle', 50, 5),
    ('Absolut Vodka', 800.00, 'per bottle', 50, 5),
    ('Red Horse 1L', 120.00, 'per bottle', 50, 5),
    ('Sauvignon Blanc', 3400.00, 'per bottle', 50, 5),
    ('Casamigos Tequila', 2500.00, 'per bottle', 50, 5)
) AS I(item_name, item_price, item_unit, item_stocks, category_id)
WHERE NOT EXISTS (SELECT 1 FROM Items WHERE item_name = I.item_name);


SELECT
    I.item_id,
    I.item_name,
    I.item_price,
    I.item_unit,
    I.item_stocks,
    C.category_name AS category_description
FROM Items I
JOIN Inventory C ON I.category_id = C.category_id;


--
--
--- Sales and Sales Details table
--
--

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Sales')
BEGIN
    CREATE TABLE Sales (
        sales_id INT IDENTITY(20000,10) PRIMARY KEY,
        sales_date DATETIME DEFAULT GETDATE(),
        sales_total DECIMAL(10,2) NOT NULL
    );
END

    --
    --
    --- Data Integrity Checks for 'Sales' Table
    --
    --

   -- Drop the constraint if it exists
IF EXISTS (
    SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS 
    WHERE CONSTRAINT_NAME = 'check_sales_total' AND TABLE_NAME = 'Sales'
)
BEGIN
    ALTER TABLE Sales DROP CONSTRAINT check_sales_total;
END

-- Add the constraint
ALTER TABLE Sales ADD CONSTRAINT check_sales_total CHECK (sales_total >= 0);


IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Sales_Details')
BEGIN
    CREATE TABLE Sales_Details (
        sales_details_id INT IDENTITY(30000,10) PRIMARY KEY,
        sales_id INT NOT NULL, 
        item_name INT NOT NULL,   
        item_quantity INT NOT NULL,
        price_per_item DECIMAL(10,2) NOT NULL,
        sales_subtotal DECIMAL(10,2) NOT NULL,
        sales_discount DECIMAL(10,2) DEFAULT 0,
        FOREIGN KEY (sales_id) REFERENCES Sales(sales_id),
        FOREIGN KEY (item_name) REFERENCES Items(item_id)
    );
END



INSERT INTO Sales (sales_total)
VALUES (70.00),
       (40.00),
       (300.00);

DECLARE @SalesID1 INT = (SELECT MIN(sales_id)FROM Sales WHERE sales_total = 70.00);
DECLARE @SalesID2 INT = (SELECT MIN(sales_id)FROM Sales WHERE sales_total = 40.00);
DECLARE @SalesID3 INT = (SELECT MIN(sales_id)FROM Sales WHERE sales_total = 300.00);


INSERT INTO Sales_Details(sales_id, item_name, item_quantity,  price_per_item, sales_subtotal, sales_discount)
    VALUES
    (@SalesID1, 1000, 2, 10.00, 20.00, 0.00),
    (@SalesID1, 1100, 5, 10.00, 50.00, 0.00),

    (@SalesID2, 1200, 3, 10.00, 30.00, 0.00),  
    (@SalesID2, 1300, 1, 10.00, 10.00, 0.00), 
    
    (@SalesID3, 1400, 5, 20.00, 100.00, 10.00),
    (@SalesID3, 1500, 2, 100.00, 200.00, 10.00);

-- Display the Tables
SELECT * FROM Sales;
SELECT 
    SD.sales_details_id, 
    SD.sales_id, 
    I.item_name,  
    SD.item_quantity, 
    SD.price_per_item, 
    SD.sales_subtotal, 
    SD.sales_discount
FROM Sales_Details SD
JOIN Items I ON SD.item_name = I.item_id;  -- Join on item_id to get the product name