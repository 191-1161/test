CREATE TABLE usersss
(
	id int PRIMARY KEY IDENTITY (1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
)
INSERT INTO usersss (username, password, role, status) VALUES('Dan','admin123','Cashier','Active')

 SELECT * FROM usersss

 DELETE FROM usersss WHERE id =5

 INSERT INTO usersss(username, password, role, status, date) VALUES('admin', 'admin123', 'Admin', 'Active', '2024 - 5 -5')

 CREATE TABLE categories
 (
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	date DATE NULL
 )

 SELECT * FROM categories

 CREATE TABLE productss
 (
	id INT PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	price FLOAT NULL,
	stock INT NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
 )

 SELECT * FROM productss