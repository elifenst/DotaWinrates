using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DotaWinrates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoadingPage : ContentPage
	{
		OpenDotaService _openDotaService;
		public LoadingPage ()
		{
			InitializeComponent ();
			//Now we need to load the winrates
			_openDotaService = new OpenDotaService();
			string sql = "SELECT public_matches.match_id, radiant_win, player_slot, hero_id FROM public_matches JOIN public_player_matches ON public_matches.match_id = public_player_matches.match_id WHERE 4500 < avg_mmr AND avg_mmr< 6000 AND start_time > 1559106329 AND start_time< 1559186329 AND lobby_type = 7 AND game_mode = 22 LIMIT 20";
			//string sql = "SELECT match_id, radiant_win FROM public_matches LIMIT 200";
			_openDotaService.GetOpenDotaDataAsync( sql);
		}

	}
}