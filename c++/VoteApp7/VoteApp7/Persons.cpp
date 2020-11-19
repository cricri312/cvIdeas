#include "Persons.h"

int Persons::getSizeOfPersons(void)
{
	return persons.size();
}

int Persons::addPersonToPersons(Person p)
{
	this->persons.push_back(make_unique<Person>(p));
	return 1;
}
