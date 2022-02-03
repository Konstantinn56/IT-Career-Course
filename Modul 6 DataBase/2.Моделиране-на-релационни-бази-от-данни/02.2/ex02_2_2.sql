/*One-To-Many*/

CREATE DATABASE ex02_2_2;
USE ex02_2_2;

CREATE TABLE manufacturers
(
	manufacturer_id INT AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(20) NOT NULL,
    established_on DATE
);

CREATE TABLE models
(
	model_id INT AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(20) NOT NULL,
    manufacturer_id INT,
    
    CONSTRAINT fk_models_manufacturers
    FOREIGN KEY (manufacturer_id)
    REFERENCES manufacturers(manufacturer_id)
);
