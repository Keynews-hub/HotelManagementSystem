CREATE TABLE users (
	id INT PRIMARY KEY IDENTITY (1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX)NULL,
	role VARCHAR(MAX)NULL,
	status VARCHAR(MAX) NULL,
	date_register DATE NULL
);

select * from users;


INSERT INTO users (username, password, role, status, date_register) VALUES ('admin', 'admin1234', 'admin', 'active', '2026-01-19');