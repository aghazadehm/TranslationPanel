using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;

namespace InfraStructure.Repository
{
    //public class CurrencyRepositroy : ICurrencyRepositroy, IDisposable
    //{
    //    private readonly AuctionDbContext _context;
    //    public CurrencyRepositroy(AuctionDbContext context)
    //    {
    //        _context = context;
    //    }
    //    public void DeleteCurrency(int id)
    //    {
    //        var c = _context.Currencies.Find(id);
    //        _context.Currencies.Remove(c);
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }
    //    private bool _disposed = false;
    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!_disposed)
    //            if (disposing)
    //                _context.Dispose();
    //    }

    //    public Currency GetByID(int id)
    //    {
    //        return _context.Currencies.Find(id);
    //    }

    //    public IEnumerable<Currency> GetCurrencies()
    //    {
    //        return _context.Currencies.ToList();
    //    }

    //    public void InsertCurrency(Currency currency)
    //    {
    //        _context.Currencies.Add(currency);
    //    }

    //    public void Save()
    //    {
    //        _context.SaveChanges();
    //    }

    //    public void UpdateCurrency(Currency currency)
    //    {
    //        _context.Entry(currency).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
    //    }
    //}
}