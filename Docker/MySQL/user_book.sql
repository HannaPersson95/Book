# CREATE USER AND GRANT RIGHTS

CREATE USER IF NOT EXISTS 'book-api-user'@'localhost' IDENTIFIED BY '5ecret-b00k'; 
CREATE USER IF NOT EXISTS 'book-api-user'@'%' IDENTIFIED BY '5ecret-b00k'; 

GRANT ALL privileges ON book_db.* TO 'book-api-user'@'%'; 
GRANT ALL privileges ON book_db.* TO 'book-api-user'@'localhost'; 

FLUSH PRIVILEGES;