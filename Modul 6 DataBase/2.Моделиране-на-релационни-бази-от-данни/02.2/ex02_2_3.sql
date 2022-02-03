/*Many-To-Many*/
CREATE DATABASE ex02_2_3;
USE ex02_2_3;

CREATE TABLE students
(
	student_id INT AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(20) NOT NULL
);
CREATE TABLE exams
(
	exam_id INT AUTO_INCREMENT PRIMARY KEY,
    `name` VARCHAR(20) NOT NULL
);

CREATE TABLE students_exams
(
	student_id INT,
    exam_id INT,

    CONSTRAINT pk_students_exams 
    PRIMARY KEY(student_id, exam_id),
    
    CONSTRAINT fk_students_exams_students
    FOREIGN KEY(student_id)
    REFERENCES students(student_id),
    
    CONSTRAINT fk_students_exams_exams
    FOREIGN KEY(exam_id)
    REFERENCES exams(exam_id)
);