using System.Collections.Generic;
using SolarCoffee.Data.Models;

namespace SolarCoffee.Services.Order
{
	public interface IOrderService
	{
		List<SalesOrder> GetOrder();
		ServiceResponse<bool> GenerateOpenOrder(SalesOrder order);
		ServiceResponse<bool> MarkFulfilled(int id);
	}
}
