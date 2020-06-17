using System;
using System.Collections.Generic;
using FARegistryAPI.Models;

namespace FARegistryAPI.Data
{
    public class TestRegistryRepo : IFARegistryRepo
    {
        public void CreateRegistryRecord(RegistryRecord registryrecord)
        {
            throw new NotImplementedException();
        }

        public void DeleteRegistryRecord(RegistryRecord registryRecord)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegistryRecord> GetAllRegistryRecords()
        {
            var RegistryRecords = new List<RegistryRecord>
            {
                new RegistryRecord
                {
                Id = 1,
                PATHNoNoduSAPH = "12-HCAA-CA7-00007",
                TitleTitre = "Sabina, Back River Project, Kitikmeot Region, Nunavut",
                ProvinceTerritory = "Nunavut",
                ProvinceTerritoire = "Nunavut",
                LatitudeLatitude = "65.557032",
                LongitudeLongitude = "-106.452691",
                WatershedNomduBassin = "Coronation Gulf and Dease Strait",
                PrimaryWork = "Mineral Aggregate, Oil & Gas Exploration, Extraction, Production",
                Ouvrageprincipal = "Exploration, extraction et production de minÈrais, d'agrÈgats, de pÈtrole & gaz",
                Status = "Monitoring (Effects and/or Compliance)",
                Etat = "Surveillance  (Effets et/ou conformitÈ)",
                ProponentOrganization = "Sabina Gold and Silver Corporation",
                PromoteurOrganisme = "Sabina Gold and Silver Corporation",
                RegistryContactduRegistre = "Registry - Enregistrement,CNA (DO NOT UPDATE)",
                ContactURL = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-eng.html",
                URLdecontact = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-fra.html",
                AuthDateDatedeauth = "22-NOV-19",
                EffectiveDateDateenvigueur = "22-NOV-19",
                ExpiryDateDatedexpire = "31-DEC-31",
                AuthorizationType = "Authorized - Fisheries Act Authorization Issued",
                Typedeauthorization = "AutorisÈ - Autorisation - Loi sur les pÍches",
                ProjectDescDescduprojet = "The Back River Project is a proposed gold mining and milling operation located in the Kitikmeot region of Nunavut. The Project requires the construction, operation and closure of a mine site and a Marine Laydown Area. It is estimated that the project will yield approximately 350,000 ounces per year, over a 10-year span.The Project is comprised of two main areas connected by winter ice road access: the Goose Property and the Marine Laydown Area. The Marine Laydown Area will be use for annual resupply and seasonal transport of materials, and mining will occur in the Goose Property through open and underground mining methods. Four open-pit mines are proposed to be build. The decommissioning of Llama Lake will be required to allow the construction of the Llama Pit and Umwelt Lake for the saline pond. Other components of the Project include the construction of contact and non-contact water diversion berms and dams for water management into the mining area.",
                LocationDescAutreinfogeo = "Project located at: 65.544444, -106.425556, approx. 100 km north of the Hamlet of Kugluktuk, Nunavut",
                FederalStakeholders = "Environment and Climate Change Canada|Fisheries and Oceans Canada|Indigenous and Northern Affairs Canada|Natural Resources Canada|Transport Canada",
                Lespartiesprenantesfed = "Environnement et Changement climatique Canada|PÍches et OcÈans Canada|Affaires autochtones et du Nord Canada|Ressources naturelles Canada|Transports Canada",
                ProvincialStakeholders = "",
                Lespartiesprenantesprov = "",
                ProgramActivity = "Referrals and EA's - Habitat",
                REGION = "Central & Arctic",
                RGION = "Centre et Arctique"
                },

                new RegistryRecord
                {
                Id = 2,
                PATHNoNoduSAPH = "14-HCAA-00225",
                TitleTitre = "Bruce A and B Nuclear Generating Stations, Lake Huron, Tiverton",
                ProvinceTerritory = "Ontario",
                ProvinceTerritoire = "Ontario",
                LatitudeLatitude = "44.329121",
                LongitudeLongitude = "-81.599956",
                WatershedNomduBassin = "East Lake Huron",
                PrimaryWork = "Water Intakes / Fish Screens",
                Ouvrageprincipal = "rises díeau/grillages ‡ poissons",
                Status = "Monitoring (Effects and/or Compliance)",
                Etat = "Surveillance  (Effets et/ou conformitÈ)",
                ProponentOrganization = "Bruce Power Inc.",
                PromoteurOrganisme = "Bruce Power Inc.",
                RegistryContactduRegistre = "Registry - Enregistrement,CNA (DO NOT UPDATE)",
                ContactURL = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-eng.html",
                URLdecontact = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-fra.html",
                AuthDateDatedeauth = "18-DEC-19",
                EffectiveDateDateenvigueur = "18-DEC-19",
                ExpiryDateDatedexpire = "31-DEC-28",
                AuthorizationType = "Authorized - Fisheries Act Authorization Issued",
                Typedeauthorization = "AutorisÈ - Autorisation - Loi sur les pÍches",
                ProjectDescDescduprojet = "The proponent currently operates the nuclear generating station located in the Bruce Nuclear site, on the east shore of Lake Huron.  There are two separate nuclear generating stations on the Bruce Nuclear site:  Bruce A and Brue B.  Both Bruce A and Bruce B facilities consist of four CANDU reactors, and have their own dedicated water intakes that continually draw water for the cooling water systems",
                LocationDescAutreinfogeo = "Water course Lake Huron Municipality of Kincardine",
                FederalStakeholders = "Canadian Nuclear Safety Commission",
                Lespartiesprenantesfed = "Commission canadienne de s˚retÈ nuclÈaire",
                ProvincialStakeholders = "Natural Resources and Forestry",
                Lespartiesprenantesprov = "Richesses naturelles et ForÍts",
                ProgramActivity = "Referrals - FPP",
                REGION = "Central & Arctic",
                RGION = "Centre et Arctique"
                },

                new RegistryRecord
                {
                Id = 3,
                PATHNoNoduSAPH = "14-HCAA-00569",
                TitleTitre = "Syncrude Mildred Lake Extension (MLX) Project",
                ProvinceTerritory = "Alberta",
                ProvinceTerritoire = "Alberta",
                LatitudeLatitude = "57.046115",
                LongitudeLongitude = "-111.614071",
                WatershedNomduBassin = "Lower Athabasca",
                PrimaryWork = "Watercourse Realignment",
                Ouvrageprincipal = "DÈrivation de cours díeau",
                Status = "Monitoring (Effects and/or Compliance)",
                Etat = "Surveillance  (Effets et/ou conformitÈ)",
                ProponentOrganization = "Syncrude Canada Ltd.",
                PromoteurOrganisme = "Syncrude Canada Ltd.",
                RegistryContactduRegistre = "Registry - Enregistrement,CNA (DO NOT UPDATE)",
                ContactURL = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-eng.html",
                URLdecontact = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-fra.html",
                AuthDateDatedeauth = "31-JAN-20",
                EffectiveDateDateenvigueur = "31-JAN-20",
                ExpiryDateDatedexpire = "31-DEC-36",
                AuthorizationType = "Authorized - Fisheries Act Authorization Issued",
                Typedeauthorization = "AutorisÈ - Autorisation - Loi sur les pÍches",
                ProjectDescDescduprojet = "The expansion of an existing oil sands mining operation, including clearing land of trees, muskeg, and aquatic resources to enable access to the oil sands resource, and construction of a bridge to access the area where the resource is located.",
                LocationDescAutreinfogeo = "Name of watercourse:  Unnamed tributaries to the MacKay River and Dover River, MacKay River",
                FederalStakeholders = "Fisheries and Oceans Canada",
                Lespartiesprenantesfed = "PÍches et OcÈans Canada",
                ProvincialStakeholders = "Energy|Environment and Parks|Department of Environment",
                Lespartiesprenantesprov = "…nergie|Environnement et parcs|Environnement",
                ProgramActivity = "Referrals - FPP",
                REGION = "Central & Arctic",
                RGION = "Centre et Arctique"
                }
            };
            return RegistryRecords;

        }




        public RegistryRecord GetRegistryRecordById(int id)
        {
            return new RegistryRecord
            {
                Id = 1,
                PATHNoNoduSAPH = "12-HCAA-CA7-00007",
                TitleTitre = "Sabina, Back River Project, Kitikmeot Region, Nunavut",
                ProvinceTerritory = "Nunavut",
                ProvinceTerritoire = "Nunavut",
                LatitudeLatitude = "65.557032",
                LongitudeLongitude = "106.452691",
                WatershedNomduBassin = "Coronation Gulf and Dease Strait",
                PrimaryWork = "Mineral Aggregate, Oil & Gas Exploration, Extraction, Production",
                Ouvrageprincipal = "Exploration, extraction et production de minÈrais, d'agrÈgats, de pÈtrole & gaz",
                Status = "Monitoring (Effects and/or Compliance)",
                Etat = "Surveillance  (Effets et/ou conformitÈ)",
                ProponentOrganization = "Sabina Gold and Silver Corporation",
                PromoteurOrganisme = "Sabina Gold and Silver Corporation",
                RegistryContactduRegistre = "Registry - Enregistrement,CNA (DO NOT UPDATE)",
                ContactURL = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-eng.html",
                URLdecontact = "http://www.dfo-mpo.gc.ca/pnw-ppe/contact-fra.html",
                AuthDateDatedeauth = "22-NOV-19",
                EffectiveDateDateenvigueur = "22-NOV-19",
                ExpiryDateDatedexpire = "31-DEC-31",
                AuthorizationType = "Authorized - Fisheries Act Authorization Issued",
                Typedeauthorization = "AutorisÈ - Autorisation - Loi sur les pÍches",
                ProjectDescDescduprojet = "The Back River Project is a proposed gold mining and milling operation located in the Kitikmeot region of Nunavut. The Project requires the construction, operation and closure of a mine site and a Marine Laydown Area. It is estimated that the project will yield approximately 350,000 ounces per year, over a 10-year span.The Project is comprised of two main areas connected by winter ice road access: the Goose Property and the Marine Laydown Area. The Marine Laydown Area will be use for annual resupply and seasonal transport of materials, and mining will occur in the Goose Property through open and underground mining methods. Four open-pit mines are proposed to be build. The decommissioning of Llama Lake will be required to allow the construction of the Llama Pit and Umwelt Lake for the saline pond. Other components of the Project include the construction of contact and non-contact water diversion berms and dams for water management into the mining area.",
                LocationDescAutreinfogeo = "Project located at: 65.544444, -106.425556, approx. 100 km north of the Hamlet of Kugluktuk, Nunavut",
                FederalStakeholders = "Environment and Climate Change Canada|Fisheries and Oceans Canada|Indigenous and Northern Affairs Canada|Natural Resources Canada|Transport Canada",
                Lespartiesprenantesfed = "Environnement et Changement climatique Canada|PÍches et OcÈans Canada|Affaires autochtones et du Nord Canada|Ressources naturelles Canada|Transports Canada",
                ProvincialStakeholders = "",
                Lespartiesprenantesprov = "",
                ProgramActivity = "Referrals and EA's - Habitat",
                REGION = "Central & Arctic",
                RGION = "Centre et Arctique"
            };


        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateRegistryRecord(RegistryRecord registryrecord)
        {
            throw new NotImplementedException();
        }
    }

}