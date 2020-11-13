#include "Blockchain.h"

Blockchain::Blockchain()
{
	initialize();
}

void Blockchain::initialize()
{
	list<Block> Chain;
}

Block Blockchain::createBlock()
{
	return Block(time_t(0),"","");
}

void Blockchain::addGenBlock()
{
	Chain.push_back(createBlock());
}

Block Blockchain::getLatest()
{
	
	return *Chain.end();
}

void Blockchain::addBlock(Block block)
{
	block.Index = block.Index + 1;
	block.PreviousHash = block.Hash;
	block.Hash = block.calculateHash();
	Chain.push_back(block);
	cout << block.Index;
	cout << block.Hash;

	
}

