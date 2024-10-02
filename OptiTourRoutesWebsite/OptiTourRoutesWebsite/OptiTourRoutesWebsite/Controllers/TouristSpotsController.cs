//    using Microsoft.AspNetCore.Mvc;
//using OptiTourRoutesWebsite.Services;

//namespace OptiTourRoutesWebsite.Controllers
//{
//    public class TouristSpotsController : Controller
//    {
//        // Giả sử bạn có một service để lấy dữ liệu
//        private readonly ITouristSpotService _touristSpotService;

//        public TouristSpotsController(ITouristSpotService touristSpotService)
//        {
//            _touristSpotService = touristSpotService;
//        }

//        // Phương thức này sẽ trả về danh sách các điểm du lịch dưới dạng JSON
//        public IActionResult GetTouristSpots()
//        {
//            var spots = _touristSpotService.GetAllSpots(); // Lấy dữ liệu từ service
//            return Json(spots); // Trả về dữ liệu dưới dạng JSON
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//    }
//}
