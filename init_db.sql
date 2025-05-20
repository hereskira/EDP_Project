
ALTER USER 'root'@'localhost' IDENTIFIED BY 'mike';
CREATE DATABASE libsys;
GRANT ALL PRIVILEGES ON libsys.* TO 'root'@'localhost';
FLUSH PRIVILEGES;
