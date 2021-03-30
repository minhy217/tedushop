using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeduCoreApp.Data.Entities;
using TeduCoreApp.Data.IRepositories;

namespace TeduCoreApp.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        AppDbContext _appDbContext;
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
        public List<ProductCategory> GetByAlias(string alias)
        {
            return _appDbContext.ProductCategories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}
