using System.Collections.Generic;

namespace IdentityServer.UI.ViewModels.Client
{
	public class ClientsDto
	{
		public ClientsDto()
		{
			Clients = new List<ClientDto>();
		}

		public List<ClientDto> Clients { get; set; }

		public int TotalCount { get; set; }		

		public int PageSize { get; set; }
	}
}
