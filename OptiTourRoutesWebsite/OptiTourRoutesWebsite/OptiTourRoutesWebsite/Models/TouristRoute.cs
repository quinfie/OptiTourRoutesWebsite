namespace OptiTourRoutesWebsite.Models
{
    public class TouristRoute
    {
        public Guid RouteId { get; set; }                 // Mã định danh đường đi
        public Guid StartSpotId { get; set; }             // Điểm khởi đầu
        public Guid EndSpotId { get; set; }               // Điểm kết thúc
        public decimal Distance { get; set; }              // Khoảng cách
        public decimal Duration { get; set; }              // Thời gian di chuyển
        public string? RoadType { get; set; }               // Loại đường (Main, Secondary, etc.)
        public DateTime CreatedAt { get; set; }            // Thời gian tạo
        public DateTime UpdatedAt { get; set; }            // Thời gian cập nhật
    }
}
