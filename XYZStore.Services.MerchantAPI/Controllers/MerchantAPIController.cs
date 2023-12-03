using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XYZStore.Services.MerchantAPI.Data;
using XYZStore.Services.MerchantAPI.Models;
using XYZStore.Services.MerchantAPI.Models.Dto;

namespace XYZStore.Services.MerchantAPI.Controllers
{

    [Route("api/merchant")]
    [ApiController]
    public class MerchantAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public MerchantAPIController(AppDbContext db, IMapper mapper)
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
                IEnumerable<Merchant> objList = _db.Merchants.ToList();
                _response.Result = _mapper.Map<IEnumerable<MerchantDto>>(objList);
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
                Merchant obj = _db.Merchants.First(u => u.MerchantID == id);
                _response.Result = _mapper.Map<MerchantDto>(obj);
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
        public ResponseDto GetByCode(string name)
        {
            try
            {
                Merchant obj = _db.Merchants.First(u => u.MerchantName.ToLower() == name.ToLower());
                _response.Result = _mapper.Map<MerchantDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpPost]
        public ResponseDto Post([FromBody] MerchantDto merchantDto)
        {
            try
            {
                Merchant obj = _mapper.Map<Merchant>(merchantDto);
                _db.Merchants.Add(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<MerchantDto>(obj);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] MerchantDto couponDto)
        {
            try
            {
                Merchant obj = _mapper.Map<Merchant>(couponDto);
                _db.Merchants.Update(obj);
                _db.SaveChanges();

                _response.Result = _mapper.Map<MerchantDto>(obj);
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
                Merchant obj = _db.Merchants.First(u => u.MerchantID == id);
                _db.Merchants.Remove(obj);
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
