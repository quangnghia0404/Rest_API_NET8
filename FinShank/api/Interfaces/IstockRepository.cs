using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;


namespace api.Interfaces
{
    public interface IstockRepository
    {
        Task<List<Stock>> GetAllAsync();
    }
}