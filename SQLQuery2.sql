CREATE TABLE rooms 
(
 id INT PRIMARY KEY IDENTITY (1,1),
 room_id VARCHAR(MAX) NULL,
 type VARCHAR(MAX) NULL,
 room_name VARCHAR(MAX) NULL,
 price float NULL,
 image_path VARCHAR(MAX) NULL,
 status VARCHAR(MAX) NULL,
 date_register DATE NULL,
 date_update DATE NULL,
 date_delete DATE NULL
)

select * from rooms;
