
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
	Person cris1(1, "d3222224", "22222334");
	Persons block;
	block.addPersonToPersons(cris);
	block.addPersonToPersons(cris1);
	cout << block.toJson() << endl;

  return 0;
}
