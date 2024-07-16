using OOP_NguyenDinhCong.Entity;

namespace OOP_NguyenDinhCong.DAO
{
    public class CategoryDAO : BaseDao<Category>
    {
        protected override string TableName => "category";
    }
}
