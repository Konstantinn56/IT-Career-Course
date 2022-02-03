USE shirts_db;

/*02.6*/
/*Ex 1*/
CREATE TABLE cities
(
	city_id INT PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE customers
(
	customer_id INT PRIMARY KEY,
    name VARCHAR(50),
    birthday DATE,
    city_id INT,
		CONSTRAINT fk_customers_cities FOREIGN KEY(city_id)
        REFERENCES cities(city_id)
);

CREATE TABLE orders
(
	order_id INT PRIMARY KEY,
	customer_id INT,
		CONSTRAINT fk_orders_customers FOREIGN KEY(customer_id)
        REFERENCES customers(customer_id)
);

CREATE TABLE item_types
(
	item_type_id INT PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE items
(
	item_id INT PRIMARY KEY,
    name VARCHAR(50),
    item_type_id INT,
		CONSTRAINT fk_items_types FOREIGN KEY(item_type_id)
        REFERENCES item_types(item_type_id)
);

CREATE TABLE order_items
(
	order_id INT,
    item_id INT,
    CONSTRAINT pk_order_items PRIMARY KEY(order_id, item_id),
    CONSTRAINT fk_order_items_orders FOREIGN KEY(order_id)
    REFERENCES orders(order_id),
    CONSTRAINT fk_order_items_items FOREIGN KEY(item_id)
    REFERENCES items(item_id)
);


/*Ex 2*/
CREATE TABLE majors
(
	major_id INT PRIMARY KEY,
    name VARCHAR(50)
);

CREATE TABLE students
(
	student_id INT PRIMARY KEY,
    student_number VARCHAR(12),
    student_name VARCHAR(50),
    major_id INT,
		CONSTRAINT fk_students_major_id FOREIGN KEY(major_id)
        REFERENCES majors(major_id)
);

CREATE TABLE payments
(
	payment_id INT PRIMARY KEY,
    payment_date DATE,
    payment_amount DECIMAL(8.2),
    student_id INT,
		CONSTRAINT fk_payments_student FOREIGN KEY(student_id)
        REFERENCES students(student_id)
);

CREATE TABLE subjects
(
	subject_id INT PRIMARY KEY,
    subject_name VARCHAR(50)
);

CREATE TABLE agenta
(
	student_id INT,
    subject_id INT,
    CONSTRAINT pk_agenta_student_subject PRIMARY KEY(student_id, subject_id),
    CONSTRAINT fk_agenta_student FOREIGN KEY(student_id)
    REFERENCES students(student_id),
    CONSTRAINT fk_agenta_subject FOREIGN KEY(subject_id)
    REFERENCES subjects(subject_id)
);