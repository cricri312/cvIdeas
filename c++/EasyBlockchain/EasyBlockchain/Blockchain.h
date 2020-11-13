#pragma once
#include<list>
#include<string>
#include"Block.h"
#include<iostream>
using namespace std;
class Blockchain
{
public:
	Blockchain();
private :
	list<Block> Chain;
public:
	void initialize();
	Block createBlock();
	void addGenBlock();
	Block getLatest();
	void addBlock(Block block);
};

