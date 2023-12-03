using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XYZStore.Service.CustomerAPI.Data;
using XYZStore.Service.CustomerAPI.Models;
using XYZStore.Service.CustomerAPI.Models.Dto;

namespace XYZStore.Service.CustomerAPI.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public CustomerAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Customer> objList = _db.Customers.ToList();
                _response.Result = _mapper.Map<IEnumerable<CustomerDto>>(objList);
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
                Customer obj = _db.Customers.First(u => u.CustomerID == id);
                _response.Result = _mapper.Map<CustomerDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public ResponseDto GetByName(string name)
        {
            try
            {
                ICollection<Customer> obj = _db.Customers.Where(u => u.CustomerName.ToLower().Contains(name.ToLower())).ToList();
                _response.Result = _mapper.Map<ICollection<Customer>>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] CustomerDto couponDto)
        {
            try
            {
                Customer obj = _mapper.Map<Customer>(couponDto);
                _db.Customers.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CustomerDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] CustomerDto couponDto)
        {
            try
            {
                Customer obj = _mapper.Map<Customer>(couponDto);
                _db.Customers.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<CustomerDto>(obj);
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
                Customer obj = _db.Customers.First(u => u.CustomerID == id);
                _db.Customers.Remove(obj);
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
