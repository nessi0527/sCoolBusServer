﻿using BL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolBus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RouteController : ControllerBase
    {
        IRouteBL IRouteBL;
        public RouteController(IRouteBL IRouteBL)
        {
            this.IRouteBL = IRouteBL;
        }
        // GET: api/<RouteController>
        [HttpGet]
        public async Task<List<Route>> Get()
        {
            return await IRouteBL.getAllRoutes();
        }

        // GET api/<RouteController>/5
        [HttpGet("driver/{driverId}")]
        public async Task<Route> GetByDriverId(int driverId)
        {
            return await IRouteBL.getAllRoutesByDriverId(driverId);
        }
        // GET api/<RouteController>/5
        [HttpGet("{id}")]
        public async Task<Route> Get(int id)
        {
            return await IRouteBL.getRouteById(id);
        }

        // POST api/<RouteController>
        [HttpPost]
        public async Task<Route> Post([FromBody] Route newRoute)
        {
            return await IRouteBL.addNewRoute(newRoute);
        }

        [HttpPost("{routeId}/{newStationId}")]
        public async Task Post(int routeId , int newStationId)
        {
             await IRouteBL.addNewStationToRoute(routeId, newStationId);
        }

        
       
    }
}
