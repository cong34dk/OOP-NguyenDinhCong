using OOP_NguyenDinhCong.Entity;

namespace OOP_NguyenDinhCong.DAO
{
    public class ProductDAO : BaseDao<Product>
    {
        protected override string TableName => "product";
    }
}
