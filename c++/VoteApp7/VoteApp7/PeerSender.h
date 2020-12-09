#pragma once
#include <SFML/Network.hpp>
#include<iostream>
#include<Windows.h>
using namespace std;
using namespace sf;
class PeerSender
{
public:
	PeerSender(string IpAddres, int Datasize, string Data);
	void sendInformation();
private:
	UdpSocket sender;
	IpAddress ipaddress;
	unsigned int port = 69420;
	int datasize;
	string data;

};

