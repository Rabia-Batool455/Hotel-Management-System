Use HMS;
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
