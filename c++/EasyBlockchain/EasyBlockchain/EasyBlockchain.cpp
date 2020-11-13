// EasyBlockchain.cpp : Questo file contiene la funzione 'main', in cui inizia e termina l'esecuzione del programma.
//
#define _CRT_SECURE_NO_WARNINGS 
#define _WINSOCK_DEPRECATED_NO_WARNINGS 1 
#include <iostream>
#include<ctime>
#include"Block.h"
#include"Blockchain.h"
#include<Windows.h>
using namespace std;
int main()
{

    Blockchain crisu = Blockchain();
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    Sleep(1000);
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    Sleep(1000);
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    Sleep(1000);
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    Sleep(1000);
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    Sleep(1000);
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    crisu.addBlock(Block(time_t(0), "", "x2d"));
    crisu.addBlock(Block(time_t(0), "", "x333d"));
    

}



