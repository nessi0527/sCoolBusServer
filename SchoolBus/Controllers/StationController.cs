﻿using AutoMapper;
using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolBus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StationController : ControllerBase
    {

        IStationBL IStationBL;
        IMapper IMapper;
        public StationController(IStationBL _IStationBL, IMapper _IMapper)
        {
            IStationBL = _IStationBL;
            IMapper = _IMapper;
        }
        // GET api/<StationController>/5
        [HttpGet]
        public async Task<List<Station>> Get()
        {
            return await IStationBL.getAllStation();
        }
        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public async Task<Station> Get(int id)
        {
            return await IStationBL.getStationById(id);
        }
        // GET api/<StationController>/5
     

        [HttpGet("route/{routeId}")]
        public async Task<List<StationRouteDTO>> GetStationsByRouteId(int routeId)
        {
            List<StationOfRoute> res = await IStationBL.GetStationsByRouteId(routeId);
            return IMapper.Map<List<StationOfRoute>, List<StationRouteDTO>>(res);

        }
        
        [HttpGet("driver/{driverId}")]

        public async Task<List<StationRouteDTO>> GetStationsByDriverId(int driverId)
        {
            List<StationOfRoute> res = await IStationBL.GetStationsByDriverId(driverId);
            return IMapper.Map<List<StationOfRoute>, List<StationRouteDTO>>(res);

        }



        // POST api/<StationController>
        [HttpPost]
        public async Task<Station> Post([FromBody] Station newStation)
        {
            return await IStationBL.addNewStation(newStation);
        }
        


   
    }
}
