CREATE DATABASE dealershipDB CHARACTER SET UTF8 COLLATE utf8_general_ci;

USE dealershipDB;

CREATE TABLE USERS(
    user_id INT NOT NULL AUTO_INCREMENT,
    name varchar(30) NOT NULL,
    surname varchar(30) NOT NULL,
    PRIMARY KEY (user_id)
);

CREATE TABLE ADMIN(
    admin_id INT NOT NULL AUTO_INCREMENT,
    admin_username VARCHAR(50) NOT NULL,
    admin_password VARCHAR(128) NOT NULL,
    user_id INT NOT NULL,
    PRIMARY KEY(admin_id),
    FOREIGN KEY (user_id) REFERENCES USERS(user_id);
);

CREATE TABLE CARS(
    car_id INT NOT NULL AUTO_INCREMENT,
    car_make VARCHAR(25) NOT NULL,
    car_year TINYINT(4) NOT NULL,
    car_mileage VARCHAR(10) NOT NULL,
    car_price DOUBLE NOT NULL,
    car_colour VARCHAR(10) NOT NULL,
    car_used ENUM('used', 'new'),
    car_image VARCHAR(128) NOT NULL,
    PRIMARY KEY(car_id)
);

CREATE TABLE ADVERT_STATE(
    advert_id INT NOT NULL AUTO_INCREMENT,
    advert_status ENUM('published', 'pending', 'removed'),
    advert_created_at datetime NOT NULL DEFAULT current_timestamp(),
    car_id INT NOT NULL,
    admin_id INT NOT NULL,
    admin_username VARCHAR(50) NOT NULL,
    PRIMARY KEY (advert_id),
    FOREIGN KEY (car_id) REFERENCES CARS(car_id),
    FOREIGN KEY (admin_id) REFERENCES ADMIN(admin_id)
);
