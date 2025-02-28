﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IMessegeDL
    {
        Task<List<Messege>> GetAllMessegesByDriverId(int driverId);
         Task<Messege> AddNewMessege(Messege newMessege);
        Task isRead(int id);
    }
}