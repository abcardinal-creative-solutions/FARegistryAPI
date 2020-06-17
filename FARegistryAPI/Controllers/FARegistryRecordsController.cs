using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FARegistryAPI.Data;
using FARegistryAPI.DTO;
using FARegistryAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FARegistryAPI.Controllers
{


    [Route("api/registryrecords")]
    [ApiController]
    public class FARegistryRecordsController : ControllerBase
    {
        private readonly IFARegistryRepo _repository;
        private readonly IMapper _mapper;

        public FARegistryRecordsController(IFARegistryRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        //GET api/registryrecords
        [HttpGet]
        public ActionResult<IEnumerable<RegistryReadDTO>> GetAllRegistryRecords()
        {
            var FARegistryRecords = _repository.GetAllRegistryRecords();

            return Ok(_mapper.Map<IEnumerable<RegistryReadDTO>>(FARegistryRecords));
        }
        //GET api/registryrecords/{id}
        [HttpGet("{id}", Name = "GetRegistryRecordById")]
        public ActionResult<RegistryReadDTO> GetRegistryRecordById(int id)

        {
            var RegistryRecord = _repository.GetRegistryRecordById(id);
            if (RegistryRecord != null)
                return Ok(_mapper.Map<RegistryReadDTO>(RegistryRecord));
            else
                return NotFound();
        }
        //POST api/registryrecords
        [HttpPost]
        public ActionResult<RegistryReadDTO> PutRegistryRecord(RegistryWriteDTO registryWriteDTO)
        {
            var registrymodel = _mapper.Map<RegistryRecord>(registryWriteDTO);
            _repository.CreateRegistryRecord(registrymodel);
            _repository.SaveChanges();

            var registryReadDTO = _mapper.Map<RegistryReadDTO>(registrymodel);



            return CreatedAtRoute(nameof(GetRegistryRecordById), new { Id = registryReadDTO.Id }, registryReadDTO);


        }
        //PUT api/registryrecords/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateRegistryRecord(int id, RegistryUpdateDTO registryUpdateDTO)
        {
            var registryModelfromRepo = _repository.GetRegistryRecordById(id);
            if (registryModelfromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(registryUpdateDTO, registryModelfromRepo);
            _repository.UpdateRegistryRecord(registryModelfromRepo);
            _repository.SaveChanges();
            return NoContent();
        }

        //PATCH api/registryrecords/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialRegistryRecordUpdate(int id, JsonPatchDocument<RegistryUpdateDTO> patchDocument)
        {
            var registryModelfromRepo = _repository.GetRegistryRecordById(id);
            if (registryModelfromRepo == null)
            {
                return NotFound();
            }

            var registryRecordToPatch = _mapper.Map<RegistryUpdateDTO>(registryModelfromRepo);
            patchDocument.ApplyTo(registryRecordToPatch, ModelState);
            if(!TryValidateModel(registryRecordToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(registryRecordToPatch, registryModelfromRepo);
            _repository.UpdateRegistryRecord(registryModelfromRepo);
            _repository.SaveChanges();
            return NoContent();
        }
        //DELETE api/registryrecords/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRegistryRecord(int id)
        {
            var registryModelfromRepo = _repository.GetRegistryRecordById(id);
            if (registryModelfromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteRegistryRecord(registryModelfromRepo);
            _repository.SaveChanges();
            return NoContent();

        }


    }



}


