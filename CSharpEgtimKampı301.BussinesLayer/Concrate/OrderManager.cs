using CSharpEgtimKampı301.BussinesLayer.Abstract;
using CSharpEğtimKampı301.DataAccessLayer.Abstarct;
using CSharpEğtimKampı301.EntityLayer.concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtimKampı301.BussinesLayer.Concrate
{
    public class OrderManager : IOrderService
    {
        public readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity); 
        }

        public Order TGet(int id)
        {
            return _orderDal.Get(id);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
