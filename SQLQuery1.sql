CREATE DATABASE DBCollection;

USE DBCollection;

CREATE TABLE Student (
    id INT PRIMARY KEY AUTO_INCREMENT,
    IDNumber INT,
    FName VARCHAR(255),
    LName VARCHAR(255),
    Course VARCHAR(255),
    year_id INT
);

CREATE TABLE Event (
    id INT PRIMARY KEY AUTO_INCREMENT,
    eventName VARCHAR(255),
    eventDate DATEx
);

CREATE TABLE Officer (
    id INT PRIMARY KEY AUTO_INCREMENT,
    officerName VARCHAR(255),
    position VARCHAR(255)
);

CREATE TABLE Admin (
    id INT PRIMARY KEY AUTO_INCREMENT,
    adminName VARCHAR(255),
    role VARCHAR(255)
);

CREATE TABLE Year (
    id INT PRIMARY KEY AUTO_INCREMENT,
    yearLevel int
);

