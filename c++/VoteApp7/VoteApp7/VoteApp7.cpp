
#include <iostream>
#include <fstream>
#include "Person.h"
#include "Persons.h"
using namespace std;
int main()
{
	Person cris(1, "d", "3");
	Persons block;
	block.addPersonToPersons(cris);
	block.addPersonToPersons(cris);
	int size=block.getSizeOfPersons();
	cout << size;
  return 0;
}
