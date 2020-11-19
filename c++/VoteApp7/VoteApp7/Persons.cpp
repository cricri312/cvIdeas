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

json Persons::toJson(Person p)
{
	json j;
	j["index"] = p.getIndex();
	j["name"] = p.getName();
	j["surname"] = p.getSurname();
	return j;
}
