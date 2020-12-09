#pragma once
#include <SFML/Network.hpp>
#include<iostream>
#include <fstream>
using namespace std;
using namespace sf;
class PeerReceiver
{
public:
	PeerReceiver(string IpAddres);
	void StartReceiver();
private:
	UdpSocket receiver;
	IpAddress ipaddress;
	unsigned int received;
	unsigned short port = 69420;
	const int datasize = 100;
	char data[100] = "";
	fstream plik;
};

