using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext contex) : base(contex)
        {
        }

        public void CreateOneProduct(Product product) => Create(product);

        public void DeleteOneProduct(Product product) => Remove(product);

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        //Interface
        public Product? GetOneProduct(int id,bool trackChanges){
            return FindByCondition(p=>p.ProductId.Equals(id),trackChanges);
        }

        public void UpdateOneProduct(Product entity) => Update(entity);
    }
}