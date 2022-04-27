using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api/ship")]
    public class ShipController : ControllerBase
    {

        private readonly ILogger<ShipController> _logger;

        private List<ShipModel> _data = new List<ShipModel>()
            {
                new ShipModel() { GlobalName = "Reefer ship",Name = "Tàu chở hàng đông lạnh", Id = 1 },
                new ShipModel() { GlobalName = "Container ship",Name = "Tàu Container", Id = 2 },
                new ShipModel() { GlobalName = "Bulk carrier",Name = "Tàu chở hàng rời", Id = 3 },
                new ShipModel() { GlobalName = "Ro-Ro ship",Name = "Tàu Roro", Id = 4 },
            };
        public ShipController(ILogger<ShipController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Lấy về danh sách
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public List<ShipModel> Get()
        {
            return _data;
        }
        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost("")]
        public ActionResult<bool> Create([FromBody] ShipModel data)
        {
            _data.Add(data);
            return true;
        }
        /// <summary>
        /// Lấy về 1 theo mã
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<ShipModel> GetById([FromRoute] int id)
        {
            var current = _data.FirstOrDefault(x => x.Id == id);
            if (current == null)
            {
                return NotFound();
            }
            return current;
        }
        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult<bool> Update([FromRoute] int id, [FromBody] ShipModel data)
        {
            var current = _data.FirstOrDefault(x => x.Id == id);
            if (current != null)
            {
                current.Name = data.Name;
                current.GlobalName = data.GlobalName;
            }
            else
            {
                return NotFound();
            }
            return true;
        }
        /// <summary>
        /// Cập nhật từng phần
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public ActionResult<bool> Patch([FromRoute] int id, [FromBody] ShipModel data)
        {
            var current = _data.FirstOrDefault(x => x.Id == id);
            if (current != null)
            {

                if (!string.IsNullOrEmpty(data.Name)) current.Name = data.Name;
                if (!string.IsNullOrEmpty(data.GlobalName)) current.GlobalName = data.GlobalName;
            }
            else
            {
                return NotFound();
            }
            return true; ;
        }
        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete([FromRoute] int id)
        {
            var current = _data.FirstOrDefault(x => x.Id == id);
            if (current != null)
            {

                _data.Remove(current);
            }
            else
            {
                return NotFound();
            }
            return true;
        }
    }
    public class ShipModel
    {
        /// <summary>
        /// Mã
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Tên tiếng việt
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Tên quốc tế
        /// </summary>
        public string? GlobalName { get; set; }
    }
}