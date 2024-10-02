CREATE DATABASE OptiTourRoutesWebsite
USE OptiTourRoutesWebsite

CREATE TABLE UserLocations (
    UserId UNIQUEIDENTIFIER PRIMARY KEY,                 -- Mã định danh người dùng
    CurrentLatitude DECIMAL(9, 6) NOT NULL,            -- Vĩ độ hiện tại
    CurrentLongitude DECIMAL(9, 6) NOT NULL,           -- Kinh độ hiện tại
    UpdatedAt DATETIME DEFAULT GETDATE()                 -- Thời gian cập nhật
);

CREATE TABLE TouristSpots (
    SpotId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(), -- Mã định danh điểm tham quan
    SpotName NVARCHAR(255) NOT NULL,                     -- Tên điểm tham quan
    Latitude DECIMAL(9, 6) NOT NULL,                     -- Vĩ độ (Latitude)
    Longitude DECIMAL(9, 6) NOT NULL,                    -- Kinh độ (Longitude)
    Description NVARCHAR(MAX),                            -- Mô tả điểm tham quan
    CreatedAt DATETIME DEFAULT GETDATE(),                 -- Thời gian tạo
    UpdatedAt DATETIME DEFAULT GETDATE()                  -- Thời gian cập nhật
);

CREATE TABLE UserTours (
    TourId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),   -- Mã định danh tour
    UserId UNIQUEIDENTIFIER NOT NULL,                      -- Mã định danh người dùng
    TourName NVARCHAR(255) NOT NULL,                      -- Tên tour
    StartLocation NVARCHAR(255) NOT NULL,                 -- Địa điểm bắt đầu
    CreatedAt DATETIME DEFAULT GETDATE(),                  -- Thời gian tạo
    UpdatedAt DATETIME DEFAULT GETDATE()                   -- Thời gian cập nhật
);

CREATE TABLE TouristSpotVisits (
    VisitId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),  -- Mã định danh lượt thăm
    TourId UNIQUEIDENTIFIER NOT NULL,                       -- Mã định danh tour (khóa ngoại)
    SpotId UNIQUEIDENTIFIER NOT NULL,                       -- Mã định danh điểm tham quan (khóa ngoại)
    VisitOrder INT NOT NULL,                                -- Thứ tự thăm
    CreatedAt DATETIME DEFAULT GETDATE(),                   -- Thời gian tạo
    FOREIGN KEY (TourId) REFERENCES UserTours(TourId),
    FOREIGN KEY (SpotId) REFERENCES TouristSpots(SpotId)
);

-- Bảng lưu trữ thông tin về các đường đi giữa các điểm tham quan
CREATE TABLE TouristRoutes (
    RouteId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),  -- Mã định danh đường đi
    StartSpotId UNIQUEIDENTIFIER NOT NULL,                 -- Điểm khởi đầu
    EndSpotId UNIQUEIDENTIFIER NOT NULL,                   -- Điểm kết thúc
    Distance DECIMAL(10, 2) NOT NULL,                      -- Khoảng cách
    Duration DECIMAL(10, 2) NOT NULL,                      -- Thời gian di chuyển
    RoadType NVARCHAR(50),                                 -- Loại đường (Main, Secondary, etc.)
    CreatedAt DATETIME DEFAULT GETDATE(),                  -- Thời gian tạo
    UpdatedAt DATETIME DEFAULT GETDATE(),                  -- Thời gian cập nhật
    FOREIGN KEY (StartSpotId) REFERENCES TouristSpots(SpotId),
    FOREIGN KEY (EndSpotId) REFERENCES TouristSpots(SpotId)
);



-- Dữ liệu TouristSpots
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Dinh Độc Lập', 10.776888, 106.695360, 'Dinh Độc Lập là một trong những công trình kiến trúc nổi tiếng, có vai trò lịch sử quan trọng trong chiến tranh Việt Nam.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Bến Nhà Rồng', 10.766222, 106.705213, 'Bến Nhà Rồng là nơi Chủ tịch Hồ Chí Minh rời Việt Nam để tìm đường cứu nước vào năm 1911.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Nhà thờ Đức Bà', 10.779783, 106.699613, 'Nhà thờ Đức Bà là biểu tượng kiến trúc Pháp và là địa điểm du lịch nổi tiếng ở TP. Hồ Chí Minh.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Chợ Bến Thành', 10.772331, 106.698139, 'Chợ Bến Thành là một trong những biểu tượng nổi tiếng của Sài Gòn và là nơi mua sắm sầm uất.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Địa đạo Củ Chi', 11.143200, 106.464311, 'Địa đạo Củ Chi là một hệ thống đường hầm được sử dụng trong chiến tranh Việt Nam.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Bảo tàng Chứng tích Chiến tranh', 10.779650, 106.692272, 'Bảo tàng Chứng tích Chiến tranh trưng bày những hiện vật và tài liệu liên quan đến chiến tranh Việt Nam.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Chùa Giác Lâm', 10.780161, 106.635596, 'Chùa Giác Lâm là một trong những ngôi chùa cổ nhất tại TP. Hồ Chí Minh, xây dựng từ thế kỷ 18.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Bảo tàng Lịch sử', 10.784235, 106.702025, 'Bảo tàng Lịch sử Việt Nam lưu giữ nhiều hiện vật quý giá về văn hóa và lịch sử Việt Nam.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Nhà hát lớn', 10.776942, 106.703445, 'Nhà hát lớn TP. Hồ Chí Minh là một công trình kiến trúc nổi bật, thường tổ chức các buổi biểu diễn nghệ thuật.');
INSERT INTO TouristSpots (SpotId, SpotName, Latitude, Longitude, Description)
VALUES (NEWID(), 'Chùa Xá Lợi', 10.776140, 106.684303, 'Chùa Xá Lợi là ngôi chùa nổi tiếng và là trụ sở chính của Giáo hội Phật giáo Việt Nam tại TP. Hồ Chí Minh.');
