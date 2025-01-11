create database cardb2;
use cardb2;

CREATE TABLE Cars (
    CarId INT AUTO_INCREMENT PRIMARY KEY,
    Model VARCHAR(50),
    PlateNumber VARCHAR(50),
    IsAvailable BOOLEAN
);
CREATE TABLE Drivers1 (
    DriverId INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(50),
    ContactNumber VARCHAR(50),
    Password VARCHAR(50),
    IsAvailable BOOLEAN
);
CREATE TABLE Customers1 (
    CustomerId INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(50),
    ContactNumber VARCHAR(50),
    Password VARCHAR(50) NOT NULL
    
);

CREATE TABLE Users (
    UserId INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(10) NOT NULL  -- 'Admin', 'Driver', or 'Customer'
);
CREATE TABLE Orders3 (
    OrderId INT AUTO_INCREMENT PRIMARY KEY,
    CustomerId INT,
    DriverId INT,
    CarId INT,
    CurrentLocation VARCHAR(100),
    Destination VARCHAR(100),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (DriverId) REFERENCES Drivers1(DriverId),
    FOREIGN KEY (CarId) REFERENCES Cars(CarId)
);




INSERT INTO Cars (CarId, Model, PlateNumber, IsAvailable) VALUES ( 1, 'Toyota Prius', 'ABC123', true);
INSERT INTO Cars (CarId, Model, PlateNumber, IsAvailable) VALUES ( 2, 'Honda Civic', 'XYZ789', true);



INSERT INTO Drivers1 (DriverId, Name, ContactNumber, Password, IsAvailable) VALUES (1,'pancha', '1234567890','pancha', true);
INSERT INTO Drivers1 (DriverId, Name, ContactNumber, Password, IsAvailable) VALUES (2,'kavija', '0987654321', 'kavija' , true);

INSERT INTO Customers1 (CustomerId, Name, ContactNumber, Password) VALUES (1, 'senith', '5551234', 'senith');
INSERT INTO Customers1 (CustomerId, Name, ContactNumber,  Password) VALUES (2, 'ruchira', '5551234', 'ruchira');
INSERT INTO Customers1 (CustomerId, Name, ContactNumber,  Password) VALUES (3, 'wasath', '5551234', 'wasath');

INSERT INTO Users (Username, Password, Role) VALUES ('Admin', 'admin', 'Admin');
INSERT INTO Users (Username, Password, Role) VALUES ('Driver1', 'driverpass', 'Driver');
INSERT INTO Users (Username, Password, Role) VALUES ('Customer1', 'customerpass', 'Customer');

INSERT INTO Orders3 (OrderId, CustomerId, DriverId, CarId, CurrentLocation, Destination) VALUES (1, 1, 2, 2, 'Colombo', 'Kandy');

select * from Cars;
select * from Drivers1;
select * from Customers1;
select * from Orders3;

