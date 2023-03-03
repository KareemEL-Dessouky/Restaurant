using AutoMapper;

using Restaurant.Models;
using Restaurant.ViewModels.CategoryViewModel;

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

    }
}
