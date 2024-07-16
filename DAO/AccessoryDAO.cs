using OOP_NguyenDinhCong.Entity;

namespace OOP_NguyenDinhCong.DAO
{
    public class AccessoryDAO : BaseDao<Accessory>
    {
        protected override string TableName => "accessory";
    }
}
