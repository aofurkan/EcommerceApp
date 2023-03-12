using System;
using Ecommerce.Domain.Entities;

namespace ECommerce.Application.Abstractions
{
	public interface IProductService
	{
		List<Product> GetProducts();

	}
}

