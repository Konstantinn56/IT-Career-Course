/*04.1*/
USE soft_uni;

SELECT
*
FROM employees
WHERE department_id IN
(
SELECT
department_id
FROM departments
WHERE name ="sales"
);



SELECT e.first_name,e.salary,e.department_id
FROM employees
AS e
WHERE NOT EXISTS
(
	SELECT d.department_id 
	FROM departments
    AS d
	WHERE e.department_id = d.department_id
    AND d.name = "Finance"
);


#Namirane na vs slujuteli s department id 1
SELECT * FROM employees;
SELECT employee_id, first_name
FROM employees
WHERE department_id = 1;

#Izvajdane na slujutelite s manager
SELECT first_name, employee_id, manager_id
FROM employees
WHERE manager_id IN
(
	SELECT employee_id
	FROM employees
	WHERE department_id = 1
);


(SELECT peak_name, elevation
FROM peaks)
UNION
(SELECT country_name, capital
FROM countries);

/*-------------------------------------------------------------------------*/
/*-------------------------------------------------------------------------*/
/*-------------------------------------------------------------------------*/
/*-------------------------------------------------------------------------*/
/*04.1 Exercises*/

/*Problem 1*/
SELECT first_name, last_name, salary AS "Salary"
FROM employees
WHERE salary IN
(
	SELECT salary 
    FROM employees
    WHERE salary > 50000
)
ORDER BY salary DESC;

/*Problem 2*/
SELECT first_name, last_name
FROM employees
ORDER BY salary DESC
LIMIT 5;

/*Problem 3*/
SELECT * FROM employees
ORDER BY salary DESC, first_name, last_name DESC, middle_name;

/*Problem 4*/
SELECT * FROM projects
ORDER BY start_date , name
LIMIT 10;

/*Problem 5*/
SELECT first_name, last_name, hire_date
FROM employees
ORDER BY hire_date DESC
LIMIT 7;

/*Problem 6*/
USE geography;
SELECT peak_name
FROM peaks
ORDER BY peak_name;

/*Problem 7*/
SELECT country_name, population
FROM countries
WHERE continent_code = "EU"
ORDER BY population DESC, country_name 
LIMIT 30;

/*Problem 8*/
SELECT 
		country_name, country_code,
        (CASE WHEN currency_code='EUR' THEN 'Euro' ELSE 'Not Euro' END) AS currency
FROM countries
ORDER BY country_name;
        

/*-------------------------------------------------------------------------*/
/*04.2 Exercises*/
SELECT * FROM employees;

/*Problem 1*/
SELECT e.first_name, e.last_name, e.salary
FROM employees AS e
WHERE e.salary = (SELECT salary
				  FROM employees
                  ORDER BY salary
                  LIMIT 1);

/*Problem 2*/
SELECT e.first_name, e.last_name, e.salary
FROM employees AS e
WHERE e.salary < 1.1 * (SELECT salary
						FROM employees
                        ORDER BY salary
                        LIMIT 1)
ORDER BY salary,first_name;

/*Problem 3*/
SELECT e.first_name, e.last_name, e.job_title
FROM employees AS e
WHERE e.employee_id IN(SELECT DISTINCT manager_id
					   FROM employees
					  )
ORDER BY first_name,last_name;

/*Problem 4*/
SELECT e.employee_id , 
concat(e.first_name , " ", e.last_name) AS "employee_name"
FROM employees AS e
WHERE e.address_id IN(SELECT a.address_id
					  FROM addresses AS a
					  WHERE a.town_id = (SELECT town_id
										   FROM towns
										   WHERE name = "San Francisco"))
ORDER BY e.employee_id;

/*-------------------------------------------------------------------------*/
/*04.3 Exercises*/

/*Problem 1*/
SELECT DISTINCT e.job_title, e.salary
FROM employees AS e
WHERE e.salary = (SELECT es.salary
				  FROM employees AS es
                  WHERE e.job_title = es.job_title
                  ORDER BY es.salary DESC 
                  LIMIT 1)
ORDER BY e.salary DESC, e.job_title; 

/*Problem 2*/
SELECT e.first_name, e.last_name, e.salary, 
											(SELECT d.name
											 FROM departments AS d
											 WHERE e.department_id = d.department_id) AS department
FROM employees AS e
WHERE e.salary = (SELECT es.salary
				  FROM employees AS es
				  WHERE e.first_name = es.first_name
                  ORDER BY es.salary
                  LIMIT 1)
ORDER BY e.salary, e.first_name, e.last_name;

/*Problem 3*/
SELECT m.first_name, m.last_name
FROM employees AS m
WHERE m.employee_id IN (SELECT DISTINCT manager_id FROM employees )
	AND EXISTS (SELECT 1 FROM employees AS e
				WHERE e.manager_id = m.employee_id
				AND e.middle_name = m.middle_name)
ORDER BY m.first_name, m.last_name;
                       
/*Problem 4*/
SELECT m.first_name , m.last_name
FROM employees AS m
WHERE m.employee_id IN (SELECT DISTINCT manager_id FROM employees)
AND m.salary < ANY(SELECT e.salary 
				   FROM employees AS e
                   WHERE e.manager_id = m.employee_id);

/*Problem 5*/
SELECT m.first_name , m.last_name
FROM employees AS m
WHERE m.employee_id IN (SELECT DISTINCT manager_id FROM employees)
AND EXISTS (SELECT 1 
			FROM employees AS e
            WHERE manager_id = m.employee_id
            LIMIT 4,1)
AND NOT EXISTS (SELECT 1
				FROM employees
                WHERE manager_id = m.employee_id
                LIMIT 5 , 1)
ORDER BY m.first_name, m.last_name;

/*Problem 6*/
SELECT m.mountain_range , p.peak_name, p.elevation
FROM mountains AS m
LEFT JOIN peaks AS p 
	ON m.id = p.mountain_id
WHERE m.id IN (SELECT mc.mountain_id 
			FROM mountains_countries AS mc
			WHERE mc.country_code = "BG")
AND (p.id IS NULL
	 OR p.id = (SELECT id
				FROM peaks
                WHERE mountain_id = m.id
                ORDER BY elevation DESC
                LIMIT 1))
ORDER BY elevation DESC;

/*Problem 7*/
SELECT m.mountain_range
FROM mountains AS m
LEFT JOIN peaks AS p
	ON m.id = p.mountain_id
WHERE m.id IN (SELECT mountain_id
			   FROM mountains_countries
               WHERE country_code = "BG")
AND p.id IS NULL
ORDER BY m.mountain_range;


/*-------------------------------------------------------------------------*/
/*04.4 Exercises*/

/*01*/
(SELECT first_name , last_name , "(no manager)" AS manager_name
FROM employees AS e
WHERE manager_id IS NULL)
UNION
(SELECT first_name, last_name, (SELECT concat(first_name, " ", last_name)
							    FROM employees
                                WHERE e.manager_id = employee_id)
FROM employees AS e
WHERE e.manager_id IS NOT NULL)
ORDER BY manager_name;

/*02*/
(SELECT m.first_name , m.last_name , "manager" AS status , m.salary
FROM employees AS m
WHERE m.employee_id IN (SELECT DISTINCT manager_id
						FROM employees
                        WHERE manager_id IS NOT NULL)
LIMIT 3)
UNION
(SELECT e.first_name, e.last_name, "employee" AS status, e.salary
FROM employees AS e
WHERE e.employee_id  NOT IN (SELECT DISTINCT manager_id
							 FROM employees
                             WHERE manager_id IS NOT NULL)
LIMIT 3)
ORDER BY salary DESC, first_name, last_name;

/*03*/
SELECT m.mountain_range,
(CASE WHEN p.peak_name IS NULL THEN "no" ELSE p.peak_name END) AS peak_name,
(CASE WHEN p.elevation IS NULL THEN "info" ELSE p.elevation END) AS elevation
FROM mountains AS m
LEFT JOIN peaks AS p
	ON m.id = p.mountain_id
WHERE m.id IN(SELECT mountain_id 
			  FROM mountains_countries 
              WHERE country_code = 'BG')
AND (p.id IS NULL 
				  OR p.id =  (SELECT id 
							  FROM peaks
                              WHERE mountain_id = m.id 
                              ORDER BY elevation DESC 
							  LIMIT 1))
ORDER BY m.mountain_range;

/*04*/
(SELECT m.mountain_range AS name, "mountain" AS type, p.elevation AS info
FROM mountains AS m
JOIN mountains_countries AS mc
	ON mc.mountain_id = m.id
JOIN peaks AS p
	ON mc.mountain_id = p.mountain_id
WHERE mc.country_code = "BG"
AND (p.id  = (SELECT id
				FROM peaks
                WHERE mountain_id = m.id
                ORDER BY elevation DESC
                LIMIT 1))
)
UNION
(SELECT p.peak_name AS name, "peak" AS type, p.elevation AS info
FROM peaks AS p
JOIN mountains_countries AS mc
	ON mc.mountain_id = p.mountain_id
WHERE mc.country_code = "BG")
UNION
(SELECT r.river_name AS name, "river" AS type, r.length AS info
 FROM rivers AS r
 JOIN countries_rivers AS cr
	ON cr.river_id = r.id
 WHERE cr.country_code = "BG")
ORDER BY name;
























