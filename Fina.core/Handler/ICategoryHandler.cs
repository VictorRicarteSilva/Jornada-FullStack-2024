using Fina.Core.Models;
using Fina.Core.Response;
using Fina.Core.Request.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Handler
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request); 
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request);

    }
}
