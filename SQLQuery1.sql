CREATE DATABASE DBCollection;

USE DBCollection;

CREATE TABLE Student (
    id INT PRIMARY KEY,
    IDNumber INT,
    FName VARCHAR(255),
    LName VARCHAR(255),
    Course VARCHAR(255),
);

CREATE TABLE Event (
    id INT PRIMARY KEY,
    eventName VARCHAR(255),
    eventDate DATE
);

CREATE TABLE Officer (
    id INT PRIMARY KEY,
    officerName VARCHAR(255),
    position VARCHAR(255)
);

CREATE TABLE Admin (
    id INT PRIMARY KEY,
    adminName VARCHAR(255),
    role VARCHAR(255)
);

CREATE TABLE Year (
    id INT PRIMARY KEY,
    yearLevel int
);

