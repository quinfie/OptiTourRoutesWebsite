using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OptiTourRoutesWebsite.DB;
using OptiTourRoutesWebsite.Models;
using System.Diagnostics;
using System.Linq;

namespace OptiTourRoutesWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}
        //[ApiController]
        //[Route("api/[controller]")]
        //public class Privacy : ControllerBase
        //{
        //    private readonly TourDbContext _context;

        //    public Privacy(TourDbContext context)
        //    {
        //        _context = context;
        //    }

        //    [HttpPost]
        //    public IActionResult GetRoute([FromBody] TouristSpot request)
        //    {
        //        if (request.SelectedSpotIds == null || !request.SelectedSpotIds.Any())
        //        {
        //            return BadRequest("SelectedSpotIds cannot be null or empty.");
        //        }
        //        // Lấy tất cả các điểm tham quan từ cơ sở dữ liệu
        //        var touristSpots = _context.TouristSpots
        //           .Where(spot => request.SelectedSpotIds.Contains(spot.SpotId))
        //           .ToList();

        //        // Tính toán đường đi ngắn nhất
        //        var routeCoordinates = CalculateShortestRoute(request.Latitude, request.Longitude, touristSpots);

        //        return Ok(new { routeCoordinates });
        //    }

        //    private List<(double Latitude, double Longitude)> CalculateShortestRoute(double userLat, double userLng, List<TouristSpot> spots)
        //    {
        //        // 1. Khởi tạo danh sách lưu trữ các tọa độ của lộ trình
        //        var routeCoordinates = new List<(double, double)>();

        //        // 2. Thêm vị trí người dùng vào danh sách lộ trình
        //        routeCoordinates.Add((userLat, userLng));

        //        // 3. Xây dựng đồ thị từ TouristRoutes
        //        var routes = _context.TouristRoutes.ToList(); // Lấy tất cả các đường đi từ cơ sở dữ liệu
        //        var graph = new Dictionary<Guid, List<(Guid EndSpotId, double Distance)>>();

        //        foreach (var route in routes)
        //        {
        //            if (!graph.ContainsKey(route.StartSpotId))
        //            {
        //                graph[route.StartSpotId] = new List<(Guid, double)>();
        //            }
        //            graph[route.StartSpotId].Add((route.EndSpotId, route.Distance));
        //        }

        //        // 4. Tính toán lộ trình ngắn nhất bằng thuật toán Dijkstra
        //        var selectedSpotIds = spots.Select(s => s.SpotId).ToList();
        //        var shortestPath = Dijkstra(graph, userLat, userLng, selectedSpotIds);

        //        // 5. Thêm tọa độ của lộ trình vào danh sách
        //        foreach (var spotId in shortestPath)
        //        {
        //            var spot = spots.First(s => s.SpotId == spotId);
        //            routeCoordinates.Add((spot.Latitude, spot.Longitude));
        //        }

        //        return routeCoordinates;
        //    }

        //    // Hàm Dijkstra (hoặc A*)
        //    private List<Guid> Dijkstra(Dictionary<Guid, List<(Guid EndSpotId, double Distance)>> graph, double userLat, double userLng, List<Guid> targetSpots)
        //    {
        //        var priorityQueue = new SortedSet<(double Distance, Guid SpotId)>();
        //        var distances = new Dictionary<Guid, double>();
        //        var previous = new Dictionary<Guid, Guid>();

        //        // Khởi tạo khoảng cách cho các điểm
        //        foreach (var target in targetSpots)
        //        {
        //            distances[target] = double.MaxValue; // Khoảng cách vô cực
        //        }

        //        // Bạn sẽ cần một điểm bắt đầu, ở đây tôi sử dụng điểm đầu tiên trong targetSpots
        //        var startSpotId = targetSpots.First();

        //        // Đặt khoảng cách cho điểm bắt đầu
        //        distances[startSpotId] = 0;
        //        priorityQueue.Add((0, startSpotId));

        //        while (priorityQueue.Any())
        //        {
        //            var current = priorityQueue.First();
        //            priorityQueue.Remove(current);
        //            var currentSpotId = current.SpotId;

        //            // Nếu chúng ta đã đến đích, thoát
        //            if (!targetSpots.Contains(currentSpotId))
        //                continue;

        //            // Khôi phục lộ trình
        //            var path = new List<Guid>();
        //            while (previous.TryGetValue(currentSpotId, out var prev))
        //            {
        //                path.Add(currentSpotId);
        //                currentSpotId = prev;
        //            }
        //            path.Reverse();
        //            return path; // Trả về lộ trình
        //        }

        //        return new List<Guid>(); // Nếu không tìm thấy
        //    }

        //}
        public IActionResult Route()
        {
            return View();
        }
        public IActionResult Destinations()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult AboutUS()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
