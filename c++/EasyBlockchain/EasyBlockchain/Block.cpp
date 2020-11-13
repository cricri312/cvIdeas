#define _CRT_SECURE_NO_WARNINGS 
#include "Block.h"
Block::Block(time_t timeStamp, string previousHash, string data)
{
	Index = 0;
	TimeStamp = timeStamp;
	TimeStamp = time(0);
	char* dt = ctime(&TimeStamp);
	char* dtstr = dt;
	Dtstr = dtstr;
	PreviousHash = previousHash;
	Data = data;
	Hash = calculateHash();
}
//SHA256 ALGORITHM TO IMPLEMENT
string Block::compute_hash(string s)
{
	return s;
}

string Block::calculateHash()
{
	return  compute_hash(Dtstr);
}
/////////////////////////////
