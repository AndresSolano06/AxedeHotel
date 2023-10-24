using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Axede.Models;

[ApiController]
[Route("api/hotels")]
public class HotelController : ControllerBase
{
    private readonly HotelService _hotelService;

    public HotelController(HotelService hotelService)
    {
        _hotelService = hotelService;
    }

    [HttpGet]
    public ActionResult<List<Hotel>> GetAllHotels()
    {
        var hotels = _hotelService.GetAllHotels();
        return Ok(hotels);
    }

    [HttpGet("{id}")]
    public ActionResult<Hotel> GetHotelById(int id)
    {
        var hotel = _hotelService.GetHotelById(id);
        if (hotel == null)
        {
            return NotFound();
        }
        return Ok(hotel);
    }

    [HttpPost]
    public ActionResult CreateHotel([FromBody] Hotel hotel)
    {
        _hotelService.CreateHotel(hotel);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult UpdateHotel(int id, [FromBody] Hotel hotel)
    {
        var existingHotel = _hotelService.GetHotelById(id);
        if (existingHotel == null)
        {
            return NotFound();
        }

        existingHotel.Nombre = hotel.Nombre;
        // Actualiza otros campos según tus necesidades.

        _hotelService.UpdateHotel(existingHotel);
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteHotel(int id)
    {
        var hotel = _hotelService.GetHotelById(id);
        if (hotel == null)
        {
            return NotFound();
        }

        _hotelService.DeleteHotel(id);
        return Ok();
    }
}
