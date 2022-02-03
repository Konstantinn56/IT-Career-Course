/*03.03 Exercises*/

/*Problem 2*/
SELECT *
FROM departments;

/*Problem 3*/



/*Problem 6*/
SELECT 
concat(first_name,".", last_name,"@softuni.bg") AS "full_email_address"
FROM employees;


/*Problem 7*/
SELECT
DISTINCT salary AS "Salary"
FROM employees 
ORDER BY salary;


/*Problem 8*/
SELECT
*
FROM employees
WHERE job_title = "Sales Representative";


/*Problem 9*/
SELECT first_name, last_name, job_title AS "JobTitle", salary
FROM employees
WHERE salary BETWEEN 20000 AND 30000
ORDER BY salary;


/*Problem 10*/
SELECT
	concat(first_name," ", middle_name," ", last_name) AS "full_name"
FROM employees
/*WHERE salary = 25000 OR salary = 14000 OR salary = 12500 OR salary = 23600;*/
WHERE salary IN(25000,  14000,12500,23600);


/*Problem 11*/
SELECT first_name, last_name, manager_id
FROM employees
WHERE manager_id IS NULL;


/*Problem 12*/
SELECT first_name,last_name,salary
FROM employees
WHERE salary > 50000
ORDER BY salary DESC;


/*Problem 13*/
SELECT
	first_name,
	last_name
FROM employees
ORDER BY salary DESC LIMIT 5;


/*Problem 14*/
SELECT 	first_name, last_name
FROM employees
WHERE department_id != 4;


/*Problem 15*/
SELECT
	DISTINCT job_title
FROM employees
ORDER BY job_title;


/*Problem 16*/
SELECT *
FROM projects
ORDER BY start_date AND name
LIMIT 10;


/*Problem 17*/
SELECT first_name,last_name, hire_date
FROM employees
ORDER BY hire_date DESC
LIMIT 7;


/*Problem 18*/
SELECT 
	* 
FROM departments
WHERE name IN("Engineering","Tool Design","Marketing","Information Services");

UPDATE employees
SET salary = salary + salary * 0.12
WHERE department_id IN(1,2,4,11);

SELECT
*
FROM employees
WHERE department_id IN(1,2,4,11) ORDER BY salary;


/*Problem 19*/



/*Problem 20*/



/*Problem 21*/
USE geography;
SELECT 
	country_name,
	country_code,
CASE 
WHEN currency_code = "EUR" 
THEN "Euro"
ELSE "Not Euro" 
END AS currency
FROM countries 
ORDER BY country_name;



/*Problem 22*/





/*03.04*/

/*Problem 1*/
INSERT INTO towns(name) VALUES("Sara Zagora"),("Burgas");
INSERT INTO towns(name) VALUES("Sofia");
SELECT * FROM towns;

/*Problem 4*/
 UPDATE employees
 SET salary = salaray + salary * 0.1;