
#include <iostream>
#include <fstream>
#include "Person.h"
#include "Persons.h"
using namespace std;
int main()
{
	fstream plik;
	plik.open("filename.txt");
	Person cris(1, "d34", "334");
	Persons block;
	block.addPersonToPersons(cris);
	plik << block.toJson(cris);
	
	plik.close();
	int size=block.getSizeOfPersons();

	cout << block.toJson(cris);
  return 0;
}
