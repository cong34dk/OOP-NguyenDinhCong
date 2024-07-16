using System;

namespace OOP_NguyenDinhCong.Entity
{
    public abstract class BaseRow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Phương thức abstract để hiển thị thông tin, sẽ được implement ở các lớp con
        public abstract void DisplayInfo();
    }
}
