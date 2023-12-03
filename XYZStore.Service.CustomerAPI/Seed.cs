using XYZStore.Service.CustomerAPI.Data;
using XYZStore.Service.CustomerAPI.Models;

namespace XYZStore.Service.CustomerAPI
{
    public class Seed
    {
        private readonly AppDbContext _appDbContext;
        public Seed(AppDbContext context)
        {
            _appDbContext = context;
        }

        public void SeedDataContext()
        {
            if(!_appDbContext.Customers.Any())
            {
                var Customers = new List<Customer>()
                {
                    new Customer()
                    {
                        CustomerID = 1,
                        CustomerName = "SAM",
                        CreatedDate = DateTime.Now,
                        CustomerAddress = "TES",
                        CustomerBalance = 0,
                        Coupons = new List<CustomerCoupon>()
                        {
                            new CustomerCoupon()
                            {
                                CouponID = 1,
                                CustomerID = 1
                            },
                            new CustomerCoupon()
                            {
                                CouponID = 2,
                                CustomerID = 1
                            }
                        }
                    },
                    new Customer()
                    {
                        CustomerID = 2,
                        CustomerName = "THEO",
                        CreatedDate = DateTime.Now,
                        CustomerAddress = "TES",
                        CustomerBalance = 0,
                        Coupons = new List<CustomerCoupon>()
                        {
                            new CustomerCoupon()
                            {
                                CouponID = 1,
                                CustomerID =2
                            },
                            new CustomerCoupon()
                            {
                                CouponID = 2,
                                CustomerID = 2
                            }
                        }
                    },
                    new Customer()
                    {
                        CustomerID = 3,
                        CustomerName = "juns",
                        CreatedDate = DateTime.Now,
                        CustomerAddress = "TES",
                        CustomerBalance = 0,
                        Coupons = new List<CustomerCoupon>()
                        {
                            new CustomerCoupon()
                            {
                                CouponID = 1,
                                CustomerID = 3
                            }
                        }
                    }
                };
                _appDbContext.Customers.AddRange(Customers);
                _appDbContext.SaveChanges();
            }
        }
    }
}
