
#include <iostream>
#include <fstream>
#include<thread>
#include "Person.h"
#include "Persons.h"
#include"nlohmann/json.hpp"
#include"PeerSender.h"
#include"PeerReceiver.h"
#include <set>
using namespace std;
void StartPeer(string IpAddress) {
	unique_ptr<PeerReceiver> rec(new PeerReceiver(IpAddress));
	rec->StartReceiver();
}
void StartSender(string IpAddress, int Datasize, string Data) {
	unique_ptr<PeerSender> rec(new PeerSender(IpAddress,Datasize,Data));
	rec->sendInformation();
}


int main()
{

  
	
	/*fstream plik;
	plik.open("filename.txt");
	Person cris(1, "d34", "334");
	Person cris1(1, "d3222224", "22222334");
	Persons block;
	block.addPersonToPersons(cris);
	block.addPersonToPersons(cris1);
	plik<<block.toJson();
	thread PeerRecivier(StartPeer, "25.47.185.51");
	thread PeerSeder(StartSender, "25.47.185.51",100,"hello");
	PeerRecivier.join();
	PeerSeder.join();
  return 0;*/

}
