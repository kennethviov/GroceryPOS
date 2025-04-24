-- Create the database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'protoDB')
    CREATE DATABASE protoDB;
GO

USE protoDB;
GO

-- Drop tables for a clean redo
DROP TABLE IF EXISTS Sales_Details;
DROP TABLE IF EXISTS Sales;
DROP TABLE IF EXISTS Items;
DROP TABLE IF EXISTS Inventory;
GO

-- Create Inventory table
CREATE TABLE Inventory (
    inventory_id INT IDENTITY(1,1) PRIMARY KEY,
    category_id INT NOT NULL UNIQUE,
    category_name VARCHAR(50) NOT NULL
);

-- Create Items table with item_description
CREATE TABLE Items (
    item_id INT IDENTITY(1000,100) PRIMARY KEY,
    item_name VARCHAR(50) NOT NULL,
    item_price DECIMAL(10,2) NOT NULL,
    item_unit VARCHAR(50) NOT NULL,
    item_stocks INT DEFAULT 0 CHECK (item_stocks >= 0),
    category_id INT NOT NULL,
    inventory_id INT NOT NULL,
    item_description VARCHAR(255),
    FOREIGN KEY (category_id) REFERENCES Inventory(category_id),
    FOREIGN KEY (inventory_id) REFERENCES Inventory(inventory_id)
);

-- Function to get the amount of a given product
CREATE FUNCTION getAmt (@item_name NVARCHAR(50))
RETURNS INT
AS
BEGIN
    DECLARE @amt INT

    SELECT @amt = Amount
    FROM items
    WHERE item_name = @item_name

    RETURN @amt
END
GO

-- Stored procedure to decrement the amount by 1
CREATE PROCEDURE decrement @productname NVARCHAR(50)
AS
BEGIN
    DECLARE @curramt INT

    -- Get the current amount
    SET @curramt = dbo.getAmt(@productname)

    -- Check if amount is greater than 0 before decrementing
    IF @curramt > 0
    BEGIN
        UPDATE products
        SET Amount = Amount - 1
        WHERE productname = @productname
    END
END
GO


INSERT INTO Inventory (category_id, category_name)
VALUES 
    (1, 'Vegetables'), 
    (2, 'Meats'), 
    (3, 'Fruits'), 
    (4, 'Drinks'), 
    (5, 'Liquor');


INSERT INTO Items (item_name, item_price, item_unit, item_stocks, category_id, inventory_id, item_description)
VALUES 
    -- Vegetables
    ('Tomato', 10.00, 'per piece', 100, 1, 1, 'Freshly picked tomato from the hills of Italy.'),
    ('Kamunggay', 10.00, 'per bundle', 50, 1, 1, 'Nutritious kamunggay bundles great for soup.'),
    ('Onion', 10.00, 'per piece', 200, 1, 1, 'Crisp onions perfect for sautéing and garnishing.'),
    ('Garlic', 10.00, 'per piece', 150, 1, 1, 'Strong-flavored garlic ideal for marinating.'),
    ('Ginger', 20.00, 'per 10 grams', 75, 1, 1, 'Spicy ginger good for tea and cooking.'),
    ('Lettuce', 100.00, 'per 250 grams', 60, 1, 1, 'Crunchy lettuce fresh from organic farms.'),
    ('Carrot', 20.00, 'per 250 grams', 90, 1, 1, 'Bright orange carrots full of nutrients.'),
    ('Bell Pepper', 199.00, 'per 250 grams', 40, 1, 1, 'Colorful and sweet bell peppers.'),
    ('Squash', 99.00, 'per Kilo', 30, 1, 1, 'Hearty squash for soups and stews.'),
    ('Eggplant', 75.00, 'per Kilo', 25, 1, 1, 'Glossy eggplants ideal for grilling.'),
    ('Potato', 80.00, 'per Kilo', 70, 1, 1, 'Starchy potatoes for fries and mash.'),
    ('Green Onion', 50.00, 'per 100 grams', 80, 1, 1, 'Zesty green onions for topping dishes.'),

    -- Meats
    ('Beef Ribeye', 580.00, 'per kilo', 50, 2, 2, 'Juicy beef ribeye cut for grilling.'),
    ('Pork Belly', 280.00, 'per kilo', 50, 2, 2, 'Tender pork belly for roasting.'),
    ('Beef Flank', 575.00, 'per grams', 50, 2, 2, 'Lean beef flank for stir-fry dishes.'),
    ('A5 Wagyu', 13069.00, 'per grams', 50, 2, 2, 'Premium A5 wagyu for gourmet steaks.'),
    ('Chicken Thigh', 280.00, 'per kilo', 50, 2, 2, 'Boneless chicken thigh cut.'),
    ('Whole Chicken', 155.00, 'per piece', 50, 2, 2, 'Whole chicken fresh and ready.'),
    ('Chicken Wings', 295.00, 'per kilo', 50, 2, 2, 'Crispy chicken wings for frying.'),
    ('Chicken Drumsticks', 228.00, 'per kilo', 50, 2, 2, 'Juicy drumsticks for BBQ.'),

    -- Fruits
    ('Apple', 10.00, 'per piece', 50, 3, 3, 'Crisp and sweet red apples.'),
    ('Orange', 10.00, 'per piece', 50, 3, 3, 'Juicy oranges full of vitamin C.'),
    ('Banana', 80.00, 'per grams', 50, 3, 3, 'Soft and sweet bananas.'),
    ('Mango', 155.00, 'per kilo', 50, 3, 3, 'Golden mangoes perfect for smoothies.'),
    ('Grapes', 300.00, 'per kilo', 50, 3, 3, 'Sweet grapes for snacking.'),
    ('Pineapple', 170.00, 'per kilo', 50, 3, 3, 'Tropical pineapples with juicy core.'),
    ('Watermelon', 120.00, 'per kilo', 50, 3, 3, 'Refreshing watermelons for summer.'),
    ('Strawberry', 250.00, 'per kilo', 50, 3, 3, 'Bright red strawberries full of flavor.'),
    ('Blueberry', 195.00, 'per kilo', 50, 3, 3, 'Sweet and tangy blueberries.'),
    ('Avocado', 150.00, 'per kilo', 50, 3, 3, 'Creamy avocados for toast or salad.'),
    ('Mangosteen', 300.00, 'per kilo', 50, 3, 3, 'Exotic mangosteen with sweet flesh.'),
    ('Kiwi', 150.00, 'per grams', 50, 3, 3, 'Tangy green kiwi rich in nutrients.'),

    -- Drinks
    ('Water 500ml', 20.00, 'per bottle', 50, 4, 4, 'Pure bottled water for hydration.'),
    ('Water 1L', 30.00, 'per bottle', 50, 4, 4, 'One liter purified drinking water.'),
    ('Gatorade', 35.00, 'per bottle', 50, 4, 4, 'Electrolyte drink for recovery.'),
    ('Coke', 35.00, 'per can', 50, 4, 4, 'Classic Coca-Cola refreshment.'),
    ('Coke 1L', 70.00, 'per bottle', 50, 4, 4, 'Large bottle of Coke.'),
    ('Sprite', 35.00, 'per can', 50, 4, 4, 'Lemon-lime soda for refreshment.'),
    ('Sprite 1L', 70.00, 'per bottle', 50, 4, 4, 'Big bottle of Sprite drink.'),
    ('Fanta', 35.00, 'per can', 50, 4, 4, 'Fruity Fanta orange soda.'),
    ('Fanta 1L', 70.00, 'per bottle', 50, 4, 4, 'Big bottle of fruity Fanta.'),
    ('Apple C2', 16.00, 'per bottle', 50, 4, 4, 'Apple flavored iced tea.'),
    ('Classic C2', 16.00, 'per bottle', 50, 4, 4, 'Classic green tea flavor.'),
    ('Kopiko Lucky Day', 30.00, 'per bottle', 50, 4, 4, 'Iced coffee drink.'),

    -- Liquor
    ('Bacardi Rum', 275.00, 'per bottle', 50, 5, 5, 'Classic white rum for mixing.'),
    ('Absolut Vodka', 800.00, 'per bottle', 50, 5, 5, 'Premium Swedish vodka.'),
    ('Red Horse 1L', 120.00, 'per bottle', 50, 5, 5, 'Strong Filipino beer.'),
    ('Sauvignon Blanc', 3400.00, 'per bottle', 50, 5, 5, 'Crisp white wine.'),
    ('Casamigos Tequila', 2500.00, 'per bottle', 50, 5, 5, 'Premium tequila for parties.');


--
--
--- Sales and Sales Details table
--
--


CREATE TABLE Sales (
    sales_id INT IDENTITY(20000,10) PRIMARY KEY,
    sales_date DATETIME DEFAULT GETDATE(),
    sales_total DECIMAL(10,2) NOT NULL CHECK (sales_total >= 0)
);


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


INSERT INTO Sales (sales_total)
VALUES (70.00), (40.00), (300.00);


DECLARE @SalesID1 INT = (SELECT MIN(sales_id) FROM Sales WHERE sales_total = 70.00);
DECLARE @SalesID2 INT = (SELECT MIN(sales_id) FROM Sales WHERE sales_total = 40.00);
DECLARE @SalesID3 INT = (SELECT MIN(sales_id) FROM Sales WHERE sales_total = 300.00);


INSERT INTO Sales_Details(sales_id, item_name, item_quantity, price_per_item, sales_subtotal, sales_discount)
VALUES
    (@SalesID1, 1000, 2, 10.00, 20.00, 0.00),
    (@SalesID1, 1100, 5, 10.00, 50.00, 0.00),
    (@SalesID2, 1200, 3, 10.00, 30.00, 0.00),
    (@SalesID2, 1300, 1, 10.00, 10.00, 0.00),
    (@SalesID3, 1400, 5, 20.00, 100.00, 10.00),
    (@SalesID3, 1500, 2, 100.00, 200.00, 10.00);

--  display of Items
SELECT
    I.item_id,
    I.item_name,
    I.item_price,
    I.item_unit,
    I.item_stocks,
    C.category_name AS category_description,
    I.item_description
FROM Items I
JOIN Inventory C ON I.category_id = C.category_id;

-- display of Sales and Sales Details
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
