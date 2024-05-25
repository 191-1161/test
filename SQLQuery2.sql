CREATE TABLE userss
(
id int PRIMARY KEY IDENTITY(1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
role VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date DATE NULL
)
SELECT * FROM userss

INSERT INTO userss (username, password, role,status, date) VALUES('admin', 'admin123', 'Admin', 'Active', '2024-5-12')

CREATE TABLE categories
(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	date DATE NULL
)

SELECT * FROM categories

CREATE TABLE products
(
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price FLOAT NULL,
	stock INT NULL,
	image_path VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
)

SELECT * FROM products