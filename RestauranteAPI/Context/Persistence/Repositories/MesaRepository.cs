﻿using RestauranteAPI.Context.Core.Repositories;
using RestauranteAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteAPI.Context.Persistence.Repositories
{
    public class MesaRepository : Repository<Mesa>, IMesaRepository
    {
        public MesaRepository(RestauranteContext context) : base(context) { }

    }
}
