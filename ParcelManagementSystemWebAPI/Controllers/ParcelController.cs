using Microsoft.AspNetCore.Mvc;
using ParcelManagementSystemWebAPI.Model;

namespace ParcelManagementSystemWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParcelController : ControllerBase
    {
        private static readonly List<Parcel> Parcels = new List<Parcel>
        {
            new Parcel
            {
                Id = 1,
                TrackingNumber = "TRK1001",
                SenderName = "Swathi",
                ReceiverName = "Rahul",
                Status = "Booked"
            },
            new Parcel
            {
                Id = 2,
                TrackingNumber = "TRK1002",
                SenderName = "John",
                ReceiverName = "David",
                Status = "In Transit"
            }
        };

        [HttpGet] //"This method should execute only when a GET request is received."
        public IActionResult GetParcels() //"This method will return an HTTP response."
        {
           
            return Ok(Parcels); //Ok() is a helper method provided by ControllerBase.
        }

        [HttpGet("{id}")] //"This method should execute only when a GET request is received with an id parameter."
        public IActionResult GetParcelById(int id)
        {
            
            var parcel = Parcels.FirstOrDefault(p => p.Id == id);
            if (parcel == null)
            {
                return NotFound(); //NotFound() is a helper method provided by ControllerBase.
            }

            return Ok(parcel);
        }
    }
}
