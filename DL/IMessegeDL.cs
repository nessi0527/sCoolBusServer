﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IMessegeDL
    {
        Task<List<Messege>> GetAllMessegesByDriverId(int id);
         Task<int> AddNewMessege(Messege newMessege);
    }
}