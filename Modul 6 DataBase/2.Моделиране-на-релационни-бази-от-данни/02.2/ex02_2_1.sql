/* Exercises 02.2.1 One-To-One */ 

CREATE DATABASE ex02_2_1;
USE ex02_2_1;

CREATE TABLE passports
(
	passport_id INT AUTO_INCREMENT PRIMARY KEY,
    passport_number VARCHAR(8)
    /*
    CONSTRAINT pk_passports_passports_id
    PRIMARY KEY(passport_id)
    */ 
);

CREATE TABLE persons
(
	person_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(20) NOT NULL,
    salary DECIMAL(10,2),
    passport_id INT UNIQUE,
    CONSTRAINT fk_persons_passports
    FOREIGN KEY(passport_id)
    REFERENCES passports(passport_id)
);
INSERT INTO passports(passport_id , passport_number) VALUE(101,'N34FG21B'),(102,'K29AS19D');
INSERT INTO passports(passport_number) VALUE('ADASDASD');
SELECT * FROM passports;