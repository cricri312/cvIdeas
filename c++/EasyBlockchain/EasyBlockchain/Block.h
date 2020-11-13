#pragma once
#include <ctime>
#include<string>
using namespace std;
class Block
{
public:
    Block(time_t timeStamp, string previousHash, string data);
    string compute_hash(string s);
private:
    time_t TimeStamp;
    string Dtstr;
  
public:
    int Index;
    string Hash;
    string PreviousHash;
    string calculateHash();
    string Data;
};

