using AutoMapper;

using Restaurant.Models;
using Restaurant.ViewModels.CategoryViewModel;
using Restaurant.ViewModels.ProductViewModel;

namespace Restaurant.Helper;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<Category, CategoryViewModel>();
        CreateMap<Category, CategoryNameEditViewModel>();
        CreateMap<Category, CategoryNameDetailViewModel>();
        CreateMap<Category, CategoryNameDeleteViewModel>();
        CreateMap<CategoryNameCreateViewModel, Category>();
        CreateMap<ProductCreateNewViewModel, Product>();
        CreateMap<Product, ProductCreateNewViewModel>();

    }
}
