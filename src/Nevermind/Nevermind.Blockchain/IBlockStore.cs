using Nevermind.Core;
using Nevermind.Core.Crypto;

namespace Nevermind.Blockchain
{
    public interface IBlockStore
    {
        void AddBlock(Block block, bool isMainChain);
        Block FindBlock(Keccak blockHash, bool mainChainOnly);
        bool IsMainChain(Keccak blockHash);
        void MoveToMain(Keccak blockHash);
        void MoveToBranch(Keccak blockHash);
        bool WasProcessed(Keccak blockHash);
    }
}