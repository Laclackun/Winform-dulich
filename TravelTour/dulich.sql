Create database dulich;
Go

Use dulich
Go

-- Account => AccountManager Form (Customer) and StaffManager Form.
-- Travel => Tour Form.
-- Tour => Order Form.

CREATE TABLE account (
	ID smallint NOT NULL PRIMARY KEY IDENTITY(1, 1),
	username nvarchar(50) NOT NULL,
	password varchar(64) NOT NULL,
	role nvarchar(20) NOT NULL,
);

INSERT INTO account (username, password, role)
VALUES 
    ('quyquynh', '12345', 'Manager'), 
    ('trantran', '09876', 'Staff'),
    ('uyduong', 'ABC', 'Customer');

CREATE TABLE infor (
    ID smallint NOT NULL,
    Name nvarchar(100),      
    ImageUrl VARCHAR(100),               
    Date datetime,                        
    Location nvarchar(255),               
    Sex nvarchar(10),                    
    Age smallint,
	CONSTRAINT FK_User_Account FOREIGN KEY (ID) REFERENCES account(ID)
);
INSERT INTO infor (ID, Name, ImageUrl, Date, Location, Sex, Age)
VALUES 
    (1, N'Bùi Thị Như Quỳnh', '1.jpg', '2024-06-01', N'Hà Nội', N'Nữ', 20),
    (2, N'Ngô Ngọc Bảo Trân', '2.jpg', '2024-06-15', N'Đà Nẵng', N'Nữ', 21),
    (3, N'Bùi Thị Thùy Dương', '3.jpg', '2024-07-01', N'TP.HCM', N'Nữ', 30);

CREATE TABLE travel (
    IDtv smallint NOT NULL PRIMARY KEY IDENTITY(1, 1),
    Nametv nvarchar(255),     
    datestart datetime,
    dateend datetime,
    description nvarchar(500),       
    location nvarchar(100),          
    typetv nvarchar(100),              
    ImageUrl VARCHAR(255),     
    quantity int
);

INSERT INTO travel (Nametv, datestart, dateend, description, location, typetv, ImageUrl, quantity)
VALUES 
    (N'Tour đến Đà Nẵng', '2024-12-01 09:00:00', '2024-12-05 18:00:00', N'Khám phá thành phố Đà Nẵng với những bãi biển đẹp và các điểm du lịch nổi tiếng.', N'Đà Nẵng', N'Du lịch biển', 'danang.jpg', 30),
    (N'Khám Phá Hà Nội', '2024-11-10 08:00:00', '2024-11-15 20:00:00', N'Trải nghiệm văn hóa và ẩm thực đặc trưng của thủ đô Hà Nội.', N'Hà Nội', N'Du lịch văn hóa', 'hanoi.jpg', 25),
    (N'Chuyến Đi Về Nguồn', '2024-10-15 07:00:00', '2024-10-20 19:00:00', N'Hành trình về nguồn, tìm hiểu về lịch sử và văn hóa dân tộc.', N'Hà Giang', N'Du lịch lịch sử', 'hagiang.jpg', 15),
    (N'Tour Phú Quốc', '2024-12-20 10:00:00', '2024-12-27 17:00:00', N'Thư giãn trên bãi biển tuyệt đẹp và tham gia các hoạt động thể thao nước.', N'Phú Quốc', N'Du lịch biển', 'phuquoc.jpg', 40);


CREATE TABLE tour (
    IDtour smallint NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    ID smallint NOT NULL,                               
    IDtv smallint NOT NULL,                               
    booking_date datetime NOT NULL DEFAULT GETDATE(),      
    quantity int NOT NULL,                                  
    CONSTRAINT FK_Tour_Customer FOREIGN KEY (ID) REFERENCES account(ID),  
    CONSTRAINT FK_Tour_Travel FOREIGN KEY (IDtv) REFERENCES travel(IDtv) 
);
INSERT INTO tour (ID, IDtv, booking_date, quantity)
VALUES 
    (1, 1, GETDATE(), 2),
    (2, 2, GETDATE(), 1),
    (3, 3, GETDATE(), 4);



