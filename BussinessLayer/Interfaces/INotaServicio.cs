using DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    public interface INotaServicio
    {
        Task<List<Nota>> GetAll();
        Task<Nota?> GetById(int id);
        Task Create(Nota nota);
        Task Update(Nota nota);
        Task Delete(int id);
    }
}
