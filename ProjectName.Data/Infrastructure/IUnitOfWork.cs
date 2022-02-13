using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectName.Data.Repository.Interface;

namespace ProjectName.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        IProductRepository product { get; }
        Task CompleteAsync();
    }
}
