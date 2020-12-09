#include "PeerSender.h"

PeerSender::PeerSender(string IpAddres, int Datasize, string Data)
{
	this->ipaddress = IpAddres;
	this->datasize = Datasize;
	this->data = Data;
}

void PeerSender::sendInformation()
{
	for (size_t i = 0; i < 5; i++)
	{
		cout << ipaddress<<endl;
		Sleep(5000);
	}
	
}
