using NBitcoin;
using System;

namespace NBXplorer
{
    public partial class NBXplorerNetworkProvider
    {
		private void InitShibacoin(ChainName networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Shibacoin.Instance, networkType)
			{
				MinRPCVersion = 100300,
				ChainLoadingTimeout = TimeSpan.FromHours(1),
				ChainCacheLoadingTimeout = TimeSpan.FromMinutes(2),
				CoinType = NetworkType == ChainName.Mainnet ? new KeyPath("3'") : new KeyPath("1'")
			});
		}

		public NBXplorerNetwork GetSHIC()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Shibacoin.Instance.CryptoCode);
		}
	}
}
