CREATE DATABASE demo;
USE demo;

CREATE TABLE teachers
(
	id_teachers INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30) NOT NULL,
    age INT
    /*PRIMARY KEY(id_teachers)*/
    /*town VARCHAR(20) NOT NULL*/
);

SELECT * FROM teachers;

ALTER TABLE teachers
ADD town VARCHAR(30) NOT NULL;
/*================================================================*/ 
/* */ 


