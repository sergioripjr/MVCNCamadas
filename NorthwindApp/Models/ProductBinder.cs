using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindApp.Domain.Repositories;

namespace NorthwindApp.Models
{
    public class ProductBinder : DefaultModelBinder
    {
        private const string _categoryIdKey = "Category.Identificador";

        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
            if (bindingContext.ValueProvider["id"] == null || string.IsNullOrEmpty(bindingContext.ValueProvider["id"].AttemptedValue))
                return base.CreateModel(controllerContext, bindingContext, modelType);

            var _productRepository = DependencyResolution.Registry.Resolve<IProductRepository>();
            var id = Convert.ToInt32(bindingContext.ValueProvider["id"].AttemptedValue);
            var entity = _productRepository.GetById(id);
            return entity;
        }

        protected override void OnModelUpdated(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var _categoryRepository = DependencyResolution.Registry.Resolve<ICategoryRepository>();
            
            var entity = (Domain.Product)bindingContext.Model;
            try
            {
                var categoryId = Convert.ToInt32(bindingContext.ValueProvider[_categoryIdKey].AttemptedValue);
                var category = _categoryRepository.GetById(categoryId);
                entity.Category = category;
            }
            catch (Exception ex)
            {
                bindingContext.ModelState.AddModelError(_categoryIdKey, "Invalid category id.");
            }

        }
    }
}
