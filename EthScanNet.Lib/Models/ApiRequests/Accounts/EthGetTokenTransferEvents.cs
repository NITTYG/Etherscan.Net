using EthScanNet.Lib.Enums;
using EthScanNet.Lib.Models.ApiResponses.Accounts;
using EthScanNet.Lib.Models.EthModels;

namespace EthScanNet.Lib.Models.ApiRequests.Accounts
{
    internal class EthGetTokenTransferEvents : EthAccountRequest
    {

        public EthGetTokenTransferEvents(EthAddress address) 
            : base(address,EthModules.Account, EthActions.TokenNftTx, typeof(EthApiTokenTransferEvents))
        {
        }
    }
}