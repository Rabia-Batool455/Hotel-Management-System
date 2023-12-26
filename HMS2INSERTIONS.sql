
USE HMS2;

-- Create table for room types
CREATE TABLE RoomType (
    RoomTypeID INT PRIMARY KEY,
    TypeName VARCHAR(50) NOT NULL,
    Description TEXT
);

-- Create table for rooms
CREATE TABLE Room (
    RoomID INT PRIMARY KEY,
    RoomNumber VARCHAR(10) NOT NULL,
    RoomTypeID INT,
    IsOccupied BIT DEFAULT 0,
    FOREIGN KEY (RoomTypeID) REFERENCES RoomType(RoomTypeID)
);

-- Create table for guests
CREATE TABLE Guest (
    GuestID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    Nationality VARCHAR(50)
);

-- Create table for staff
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    Position VARCHAR(50) NOT NULL
);


-- Create table for services
CREATE TABLE Servicess (
    ServiceID INT PRIMARY KEY,
    ServiceName VARCHAR(50) NOT NULL,
    Description TEXT,
    Price DECIMAL(10, 2) NOT NULL
);
  


-- Create table for reservations
CREATE TABLE Reservation (
    ReservationID INT PRIMARY KEY,
    RoomID INT,
    GuestID INT,
    StaffID INT, -- Added StaffID
    ServiceID INT, -- Added ServiceID
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
    FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID), -- Added foreign key constraint
    FOREIGN KEY (ServiceID) REFERENCES Servicess(ServiceID) -- Added foreign key constraint
);



-- Create table for payments
CREATE TABLE Payment (
    PaymentID INT PRIMARY KEY,
    ReservationID INT,
    AmountPaid DECIMAL(10, 2) NOT NULL,
    PaymentDate DATE NOT NULL,
    FOREIGN KEY (ReservationID) REFERENCES Reservation(ReservationID)
);



-- Create table for invoices
CREATE TABLE Invoice(
    InvoiceID INT PRIMARY KEY,
    ReservationID INT,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    IssueDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    IsPaid BIT DEFAULT 0,
    FOREIGN KEY (ReservationID) REFERENCES Reservation(ReservationID)
);
-- Create table for room bookings
CREATE TABLE RoomBooking (
    BookingID INT PRIMARY KEY,
    RoomID INT,
    GuestID INT,
    StaffID INT,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    TotalAmount DECIMAL(10, 2),
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
    FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

-- Create table for room services
CREATE TABLE RoomService (
    ServiceID INT PRIMARY KEY,
    ReservationID INT,
    ServiceName VARCHAR(50) NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ReservationID) REFERENCES Reservation(ReservationID)
);
