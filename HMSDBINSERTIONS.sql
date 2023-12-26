USE HMS;

-- Insert dummy data into RoomTypes
INSERT INTO RoomType (RoomTypeID, TypeName, Description)
VALUES
    (1, 'Standard Room', 'Basic amenities, suitable for short stays'),
    (2, 'Deluxe Room', 'Enhanced features, more spacious'),
    (3, 'Suite', 'Luxurious accommodations with additional services');

-- Insert dummy data into Rooms
INSERT INTO Room (RoomID, RoomNumber, RoomTypeID, IsOccupied)
VALUES
    (101, '101', 1, 0),
    (102, '102', 1, 0),
    (201, '201', 2, 0),
    (202, '202', 2, 1),
    (301, '301', 3, 0),
    (302, '302', 3, 0);

-- Insert dummy data into Guests
INSERT INTO Guest (GuestID, FirstName, LastName, Email, PhoneNumber, Nationality)
VALUES
    (1, 'John', 'Doe', 'john.doe@example.com', '123-456-7890', 'US'),
    (2, 'Jane', 'Smith', 'jane.smith@example.com', '987-654-3210', 'UK'),
    (3, 'Alice', 'Johnson', 'alice.johnson@example.com', '555-123-4567', 'Canada');

-- Insert dummy data into Staff
INSERT INTO Staff (StaffID, FirstName, LastName, Email, PhoneNumber, Position)
VALUES
    (1, 'Manager', 'Smith', 'manager@example.com', '111-222-3333', 'Manager'),
    (2, 'Receptionist', 'Johnson', 'receptionist@example.com', '444-555-6666', 'Front Desk');

-- Insert dummy data into Services
INSERT INTO Services (ServiceID, ServiceName, Description, Price)
VALUES
    (1, 'Breakfast', 'Continental breakfast', 20.00),
    (2, 'Airport Shuttle', 'Pickup and drop-off', 50.00),
    (3, 'Wi-Fi', 'High-speed internet access', 10.00);

-- Insert dummy data into Reservations
INSERT INTO Reservation (ReservationID, RoomID, GuestID, StaffID, ServiceID, CheckInDate, CheckOutDate, TotalAmount)
VALUES
    (1, 101, 1, 1, 1, '2023-01-01', '2023-01-05', 500.00),
    (2, 202, 2, 2, 2, '2023-02-10', '2023-02-15', 800.00),
    (3, 301, 3, 1, 3, '2023-03-20', '2023-03-25', 1200.00);

-- Insert dummy data into Payments
INSERT INTO Payment (PaymentID, ReservationID, AmountPaid, PaymentDate)
VALUES
    (1, 1, 500.00, '2023-01-05'),
    (2, 2, 800.00, '2023-02-15'),
    (3, 3, 1200.00, '2023-03-25');

-- Insert dummy data into Invoices
INSERT INTO Invoice (InvoiceID, ReservationID, TotalAmount, IssueDate, DueDate, IsPaid)
VALUES
    (1, 1, 500.00, '2023-01-05', '2023-01-15', 1),
    (2, 2, 800.00, '2023-02-15', '2023-02-25', 1),
    (3, 3, 1200.00, '2023-03-25', '2023-04-04', 0);