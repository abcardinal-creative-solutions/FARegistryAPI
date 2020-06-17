using FARegistryAPI.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FARegistryAPI.Data
{
    public class LiveFARegistryRepo : IFARegistryRepo

    {

        private readonly RegistryContext _context;
        public LiveFARegistryRepo(RegistryContext context)
        {
            _context = context;
        }

        public void CreateRegistryRecord(RegistryRecord registryrecord)
        {
            if (registryrecord == null)
                throw new ArgumentNullException(nameof(registryrecord));

            else
                _context.RegistryRecords.Add(registryrecord);
        }

        public void DeleteRegistryRecord(RegistryRecord registryRecord)
        {
            if(registryRecord == null)
            {
                throw new ArgumentNullException(nameof(registryRecord));
            }
            
            _context.RegistryRecords.Remove(registryRecord);

        }

        public IEnumerable<RegistryRecord> GetAllRegistryRecords()
        {
            return _context.RegistryRecords.ToList();
        }

        public RegistryRecord GetRegistryRecordById(int id)
        {
            return _context.RegistryRecords.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateRegistryRecord(RegistryRecord registryrecord)
        {
            //Do nothing
        }
    }
}
