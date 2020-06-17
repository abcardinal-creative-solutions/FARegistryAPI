using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FARegistryAPI.DTO
{
    public class RegistryWriteDTO
    {
      
        public string PATHNoNoduSAPH { get; set; }

        public string TitleTitre { get; set; }
        public string ProvinceTerritory { get; set; }
        public string ProvinceTerritoire { get; set; }

        public string LatitudeLatitude { get; set; }

        public string LongitudeLongitude { get; set; }
        public string WatershedNomduBassin { get; set; }

        public string PrimaryWork { get; set; }

        public string Ouvrageprincipal { get; set; }

        public string Status { get; set; }

        public string Etat { get; set; }

        public string ProponentOrganization { get; set; }

        public string PromoteurOrganisme { get; set; }

        public string RegistryContactduRegistre { get; set; }

        public string ContactURL { get; set; }

        public string URLdecontact { get; set; }

        public string AuthDateDatedeauth { get; set; }

        public string EffectiveDateDateenvigueur { get; set; }

        public string ExpiryDateDatedexpire { get; set; }

        public string AuthorizationType { get; set; }

        public string Typedeauthorization { get; set; }

        public string ProjectDescDescduprojet { get; set; }

        public string LocationDescAutreinfogeo { get; set; }
        public string FederalStakeholders { get; set; }
        public string Lespartiesprenantesfed { get; set; }
        public string ProvincialStakeholders { get; set; }
        public string Lespartiesprenantesprov { get; set; }

        public string ProgramActivity { get; set; }

        public string REGION { get; set; }

        public string RGION { get; set; }

    }
}
