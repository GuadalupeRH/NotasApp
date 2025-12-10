using BussinessLayer.Interfaces;
using DataAccessLayer.Datos;
using DataAccessLayer.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BussinessLayer.Servicios
{
    public class NotaServicio : INotaServicio
    {
        private readonly AppNoteDbContext _dbContext;

        public NotaServicio(AppNoteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Nota nota)
        {
            try
            {
                await _dbContext.Notas.AddAsync(nota);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al crear la nota.");
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                Nota? nota = await GetById(id);

                if (nota == null)
                    throw new Exception("La nota no existe.");

                _dbContext.Notas.Remove(nota);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al eliminar la nota.");
            }
        }

        public async Task<List<Nota>> GetAll()
        {
            try
            {
                return await _dbContext.Notas.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener las notas.");
            }
        }

        public async Task<Nota?> GetById(int id)
        {
            try
            {
                return await _dbContext.Notas.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al obtener la nota.");
            }
        }

        public async Task Update(Nota nota)
        {
            try
            {
                _dbContext.Notas.Update(nota);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al actualizar la nota.");
            }
        }
    }
}
