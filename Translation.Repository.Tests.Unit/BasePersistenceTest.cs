using Microsoft.EntityFrameworkCore;
using System;
using System.Transactions;

namespace Translation.Repository.Tests.Unit
{
    public class BasePersistenceTest<T> : IDisposable where T : DbContext, new()
    {
        private TransactionScope _scope;
        public T DbContext { get; private set; }
        public BasePersistenceTest()
        {
            _scope = new TransactionScope();
            DbContext = new T();
        }
        public void Dispose()
        {
            DbContext.Dispose();
            _scope.Dispose();
        }
    }
}