using System;
using System.Collections.Generic;
using FARegistryAPI.Models;

namespace FARegistryAPI.Data
{
    public interface IFARegistryRepo
    {
        bool SaveChanges();
        IEnumerable<RegistryRecord> GetAllRegistryRecords();
        RegistryRecord GetRegistryRecordById(int id);
        void CreateRegistryRecord(RegistryRecord registryrecord);
        void UpdateRegistryRecord(RegistryRecord registryrecord);
        void DeleteRegistryRecord(RegistryRecord registryRecord);
    }
}
