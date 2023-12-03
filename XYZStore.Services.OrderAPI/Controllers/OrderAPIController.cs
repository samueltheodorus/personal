using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XYZStore.Services.OrderAPI.Data;
using XYZStore.Services.OrderAPI.Models;
using XYZStore.Services.OrderAPI.Models.Dto;

namespace XYZStore.Services.OrderAPI.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public OrderAPIController(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Order> objList = _db.Orders.ToList();
                _response.Result = _mapper.Map<IEnumerable<OrderDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Order obj = _db.Orders.First(u => u.OrderID == id);
                _response.Result = _mapper.Map<OrderDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] OrderDto couponDto)
        {
            try
            {
                Order obj = _mapper.Map<Order>(couponDto);
                _db.Orders.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<OrderDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] OrderDto couponDto)
        {
            try
            {
                Order obj = _mapper.Map<Order>(couponDto);
                _db.Orders.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<OrderDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                Order obj = _db.Orders.First(u => u.OrderID == id);
                _db.Orders.Remove(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
