using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }
        
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;  //Cria Consulta SQL
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value); //Filtra objetos que sejam maiores que a menor data
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value); //Filtra objetos que sejam menores que a maior data
            }
            return await result
                .Include(x => x.Seller) //Amarração de tabelas Inner Join
                .Include(x => x.Seller.Department)  //Amarração de tabelas Inner Join
                .OrderByDescending(x => x.Date) //Ordenação
                .ToListAsync();
        }

        public async Task<List<IGrouping<Department,SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj; //Cria Consulta SQL
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value); //Filtra objetos que sejam maiores que a menor data
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value); //Filtra objetos que sejam menores que a maior data
            }
            return await result
                .Include(x => x.Seller) //Amarração de tabelas Inner Join
                .Include(x => x.Seller.Department) //Amarração de tabelas Inner Join
                .OrderByDescending(x => x.Date) //Ordenação
                .GroupBy(x => x.Seller.Department) //Agrupamento por departamento
                .ToListAsync();
        }
    }
}
