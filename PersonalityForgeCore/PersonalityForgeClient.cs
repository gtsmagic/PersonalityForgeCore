using System;
using PersonalityForgeCore.Models;
using PersonalityForgeCore.Interfaces;
using System.Threading.Tasks;

namespace PersonalityForgeCore
{
	public class PersonalityForgeClient : IPersonalityForge
	{
		private ApiInfo _apiInfo;
		private IPersonalityForgeDataService _dataService;

		public PersonalityForgeClient(string secret, string key, int botId)
		{
			_apiInfo = new ApiInfo
			{
				Secret = secret,
				Key = key,
				BotId = botId
			};

			_dataService = new PersonalityForgeDataService(new JsonHelper(), new Utils());
		}

		//constructor for injecting dependencies
		internal PersonalityForgeClient(IPersonalityForgeDataService dataService)
		{
			_dataService = dataService;
		}

		public Response Send(string username, string message)
		{
			return _dataService.Send(_apiInfo, username, message);
		}

		public async Task<Response> SendAsync(string username, string message)
		{
			Response response = await _dataService.SendAsync(_apiInfo, username, message);
			return response;
		}
	}
}

