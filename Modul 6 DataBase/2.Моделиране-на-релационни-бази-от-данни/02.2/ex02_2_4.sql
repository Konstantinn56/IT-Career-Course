/* ex02_2_4 */
CREATE DATABASE ex02_2_4;
USE ex02_2_4;

CREATE TABLE teachers
(
	 teacher_id INT AUTO_INCREMENT PRIMARY KEY,
	 `name` VARCHAR(20),
	 manager_id INT,
     
     CONSTRAINT fk_teachers_teachers
     FOREIGN KEY(manager_id) 
     REFERENCES teachers(teacher_id)
);

INSERT INTO teachers(teacher_id, name, manager_id) VALUES(101,'John', NULL);

SELECT * FROM teachers;

UPDATE teachers
SET manager_id = 101
WHERE teacher_id IN (105,106);

