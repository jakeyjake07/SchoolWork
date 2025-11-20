using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MotherLoadDB.Models;

namespace MotherLoadDB.Data
{
    public class DbService
    {
        private readonly AppDbContext _context;

        public DbService(AppDbContext context)
        {
            _context = context;
        }


        //CREATE
        public async Task<Company> CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        //READ 1
        public async Task<Company> GetCompany(int id)
        {
            return await _context.Companies.FindAsync(id);

        }


        //Read all
        public async Task<List<Company>> GetCompanies()
        {
            return await _context.Companies.ToListAsync();
        }



        //Update
        public async Task<Company> UpdateCompany(Company company)
        {
            _context.Companies.Update(company);
            await _context.SaveChangesAsync();
            return company;
        }


        //Delete
        public async Task<bool> DeleteCompany(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return false;
            }
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return true;
        }

    }

}