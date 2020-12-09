#include "PeerReceiver.h"
PeerReceiver::PeerReceiver(string IpAddres)
{
	this->ipaddress = IpAddres;
}

void PeerReceiver::StartReceiver()
{
	receiver.bind(port);
	while (true)
	{
		receiver.receive(data, datasize, received, ipaddress, port);
		plik.open("filename1.txt", std::ios::in | std::ios::out);
		cout << data;
	}
}
