CREATE DATABASE ECOMM

USE ECOMM

-- Customers table
CREATE TABLE Customers
(
  customer_id INT IDENTITY(1,1) PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  email VARCHAR(100) NOT NULL,
  password VARCHAR(50) NOT NULL
);

-- Products table
CREATE TABLE Products
(
  product_id INT IDENTITY(1,1) PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  price DECIMAL(10,2) NOT NULL,
  description VARCHAR(MAX),
  stockQuantity INT NOT NULL
);

-- Cart table
CREATE TABLE Cart
(
  cart_id INT IDENTITY(1,1) PRIMARY KEY,
  customer_id INT NOT NULL,
  product_id INT NOT NULL,
  quantity INT,
  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id),
  FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

-- Orders table
CREATE TABLE Orders
(
  order_id INT IDENTITY(1,1) PRIMARY KEY,
  customer_id INT NOT NULL,
  order_date DATE NOT NULL,
  total_price DECIMAL(10,2) NOT NULL,
  shipping_address VARCHAR(255) NOT NULL,
  FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);

-- Order_items table
CREATE TABLE Order_items
(
  order_item_id INT IDENTITY(1,1) PRIMARY KEY,
  order_id INT NOT NULL,
  product_id INT NOT NULL,
  quantity INT,
  FOREIGN KEY (order_id) REFERENCES Orders(order_id),
  FOREIGN KEY (product_id) REFERENCES Products(product_id)
);


-- Inserting 10 sample values into the Customers table
INSERT INTO Customers (name, email, password)
VALUES
  ('John Doe', 'john.doe@example.com', 'password1'),
  ('Jane Smith', 'jane.smith@example.com', 'password2'),
  ('Bob Johnson', 'bob.johnson@example.com', 'password3'),
  ('Alice Brown', 'alice.brown@example.com', 'password4'),
  ('Charlie Davis', 'charlie.davis@example.com', 'password5'),
  ('Eva White', 'eva.white@example.com', 'password6'),
  ('Frank Lee', 'frank.lee@example.com', 'password7'),
  ('Grace Taylor', 'grace.taylor@example.com', 'password8'),
  ('Henry Clark', 'henry.clark@example.com', 'password9'),
  ('Ivy Turner', 'ivy.turner@example.com', 'password10');

-- Inserting 10 sample values into the Products table
INSERT INTO Products (name, price, description, stockQuantity)
VALUES
  ('Product A', 19.99, 'Description for Product A', 50),
  ('Product B', 29.99, 'Description for Product B', 30),
  ('Product C', 39.99, 'Description for Product C', 20),
  ('Product D', 49.99, 'Description for Product D', 10),
  ('Product E', 59.99, 'Description for Product E', 40),
  ('Product F', 69.99, 'Description for Product F', 25),
  ('Product G', 79.99, 'Description for Product G', 15),
  ('Product H', 89.99, 'Description for Product H', 35),
  ('Product I', 99.99, 'Description for Product I', 5),
  ('Product J', 109.99, 'Description for Product J', 30);

-- Inserting 10 sample values into the Cart table
INSERT INTO Cart (customer_id, product_id, quantity)
VALUES
  (1, 1, 2),
  (2, 3, 1),
  (3, 5, 3),
  (4, 2, 2),
  (5, 4, 1),
  (6, 6, 4),
  (7, 8, 2),
  (8, 10, 3),
  (9, 7, 1),
  (10, 9, 2);

-- Inserting 10 sample values into the Orders table
INSERT INTO Orders (customer_id, order_date, total_price, shipping_address)
VALUES
  (1, '2023-01-01', 39.98, '123 Main St, Cityville'),
  (2, '2023-01-02', 119.97, '456 Oak St, Townsville'),
  (3, '2023-01-03', 119.97, '789 Pine St, Villageton'),
  (4, '2023-01-04', 99.98, '101 Elm St, Hamletville'),
  (5, '2023-01-05', 59.99, '202 Maple St, Riverside'),
  (6, '2023-01-06', 279.96, '303 Cedar St, Lakeside'),
  (7, '2023-01-07', 159.98, '404 Birch St, Mountainside'),
  (8, '2023-01-08', 269.97, '505 Walnut St, Seaside'),
  (9, '2023-01-09', 79.99, '606 Pine St, Hilltop'),
  (10, '2023-01-10', 219.98, '707 Oak St, Countryside');

-- Inserting 10 sample values into the Order_items table
INSERT INTO Order_items (order_id, product_id, quantity)
VALUES
  (1, 1, 2),
  (2, 3, 1),
  (3, 5, 3),
  (4, 2, 2),
  (5, 4, 1),
  (6, 6, 4),
  (7, 8, 2),
  (8, 10, 3),
  (9, 7, 1),
  (10, 9, 2);


  select * from Customers
  select * from Products
  select * from Order_items
  select * from Orders
  select * from Cart