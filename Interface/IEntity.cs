﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NguyenDinhCong.Interface
{
    public interface IEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        void DisplayInfo();
    }
}
