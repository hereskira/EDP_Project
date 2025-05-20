
ALTER USER 'root'@'localhost' IDENTIFIED BY 'mysqlkira';
CREATE DATABASE libsys;
GRANT ALL PRIVILEGES ON demodb.* TO 'root'@'localhost';
FLUSH PRIVILEGES;
