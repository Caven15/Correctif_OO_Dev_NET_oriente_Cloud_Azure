﻿using GesetionBanque7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBanque7.Interfaces
{
    public interface IBanker : ICustomer
    {
        Personne Titulaire { get; }
        string Numero { get; }
        void AppliquerInteret();
    }
}
