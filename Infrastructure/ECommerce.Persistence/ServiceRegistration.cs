﻿using System;
using ECommerce.Application.Abstractions;
using ECommerce.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddSingleton<IProductService, ProductService>();
		}
		
	}
}

