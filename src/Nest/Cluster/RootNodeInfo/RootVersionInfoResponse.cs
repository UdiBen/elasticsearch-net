﻿using Newtonsoft.Json;

namespace Nest
{
	public interface IRootNodeInfoResponse : IResponse
	{
		int Status { get; }
		string Name { get; }
		string Tagline { get;  }
		ElasticsearchVersionInfo Version { get;  }
	}

	[JsonObject]
	public class RootNodeInfoResponse : BaseResponse, IRootNodeInfoResponse
	{
		[JsonProperty(PropertyName = "status")]
		public int Status { get; internal set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; internal set; }

		[JsonProperty(PropertyName = "tagline")]
		public string Tagline { get; internal set; }
		
		[JsonProperty(PropertyName = "version")]
		public ElasticsearchVersionInfo Version { get; internal set; }

	}
}