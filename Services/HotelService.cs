using System;
using System.Collections.Generic;
using System.Linq;
using Axede.Models;

public class HotelService
{
    private readonly HotelDbContext _context;

    public HotelService(HotelDbContext context)
    {
        _context = context;
    }

    public List<Hotel> GetAllHotels()
    {
        return _context.Hoteles.ToList();
    }

    public Hotel GetHotelById(int id)
    {
        return _context.Hoteles.FirstOrDefault(h => h.Id == id);
    }

    public void CreateHotel(Hotel hotel)
    {
        _context.Hoteles.Add(hotel);
        _context.SaveChanges();
    }

    public void UpdateHotel(Hotel hotel)
    {
        _context.Hoteles.Update(hotel);
        _context.SaveChanges();
    }

    public void DeleteHotel(int id)
    {
        var hotel = _context.Hoteles.FirstOrDefault(h => h.Id == id);
        if (hotel != null)
        {
            _context.Hoteles.Remove(hotel);
            _context.SaveChanges();
        }
    }
}
