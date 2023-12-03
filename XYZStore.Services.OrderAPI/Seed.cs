using XYZStore.Services.OrderAPI.Data;
using XYZStore.Services.OrderAPI.Models;

namespace XYZStore.Services.OrderAPI
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
            if (!_appDbContext.Orders.Any())
            {
                var Orders = new List<Order>()
                {
                    new Order()
                    {
                        OrderID = 1,
                        CustomerID = 1,
                        MerchantID = 1,
                        OrderDate = DateTime.Now,
                        Products = new List<OrderProduct>()
                        {
                            new OrderProduct()
                            {
                                ProductID = 1,
                                OrderID = 1
                            },
                            new OrderProduct()
                            {
                                ProductID = 2,
                                OrderID = 1
                            }
                        }
                    },
                    new Order()
                    {
                        OrderID = 3,
                        CustomerID = 1,
                        MerchantID = 2,
                        OrderDate = DateTime.Now,
                        Products = new List<OrderProduct>()
                        {
                            new OrderProduct()
                            {
                                ProductID = 1,
                                OrderID = 3
                            },
                            new OrderProduct()
                            {
                                ProductID = 2,
                                OrderID = 3
                            }
                        }
                    },
                    new Order()
                    {
                        OrderID = 3,
                        CustomerID = 1,
                        MerchantID = 2,
                        OrderDate = DateTime.Now,
                        Products = new List<OrderProduct>()
                        {
                            new OrderProduct()
                            {
                                ProductID = 1,
                                OrderID = 3
                            },
                            new OrderProduct()
                            {
                                ProductID = 2,
                                OrderID = 3
                            }
                        }
                    }
                };
                _appDbContext.Orders.AddRange(Orders);
                _appDbContext.SaveChanges();
            }
        }
    }
}
