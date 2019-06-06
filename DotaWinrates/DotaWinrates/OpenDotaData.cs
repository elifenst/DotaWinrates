using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DotaWinrates
{
    public class OpenDotaData
    {
		[JsonProperty("match_id")]
		public int MatchID { get; set; }

		[JsonProperty("radiant_win")]
		public bool RadiantWin { get; set; }

		//[JsonProperty("player_slot")]
		//public string Player { get; set; }

		//[JsonProperty("hero_id")]
		//public int HeroID { get; set; }
    }
}