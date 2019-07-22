using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Landmark_Remark.Models;
using Landmark_Remark.ViewModels;

namespace Landmark_Remark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationMarkersController : ControllerBase
    {
        private readonly Landmark_RemarkContext _context;

        public LocationMarkersController(Landmark_RemarkContext context)
        {
            _context = context;
        }

        // GET: api/LocationMarkers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationMarkerUser>>> GetLocationMarker()
        { 
            var result = (from lm in _context.LocationMarker
                          join u in _context.User
                          on lm.UserID equals u.UserID
                          select new LocationMarkerUser
                          {
                              Comment = lm.Comment,
                              Lat = lm.Lat,
                              UserID = lm.UserID,
                              Lng = lm.Lng,
                              LocationMarkerID = lm.LocationMarkerID,
                              Title = lm.Title,
                              UserName = u.UserName
                          });

            return await result.ToListAsync();
            //_context.LocationMarker.ToListAsync();
        }

        // GET: api/LocationMarkers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationMarker>> GetLocationMarker(int id)
        {
            var locationMarker = await _context.LocationMarker.FindAsync(id);

            if (locationMarker == null)
            {
                return NotFound();
            }

            return locationMarker;
        }

        // PUT: api/LocationMarkers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationMarker(int id, LocationMarker locationMarker)
        {
            if (id != locationMarker.LocationMarkerID)
            {
                return BadRequest();
            }

            _context.Entry(locationMarker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationMarkerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LocationMarkers
        [HttpPost]
        public async Task<ActionResult<LocationMarker>> PostLocationMarker(LocationMarker locationMarker)
        {
            _context.LocationMarker.Add(locationMarker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocationMarker", new { id = locationMarker.LocationMarkerID }, locationMarker);
        }

        // DELETE: api/LocationMarkers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationMarker>> DeleteLocationMarker(int id)
        {
            var locationMarker = await _context.LocationMarker.FindAsync(id);
            if (locationMarker == null)
            {
                return NotFound();
            }

            _context.LocationMarker.Remove(locationMarker);
            await _context.SaveChangesAsync();

            return locationMarker;
        }

        private bool LocationMarkerExists(int id)
        {
            return _context.LocationMarker.Any(e => e.LocationMarkerID == id);
        }
    }
}
