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

json Persons::toJson()
{
	json j;
	for (int i = 0; i < this->persons.size(); i++)
	{
		j[i] = json{ {"name",this->persons[i]->getName()},{"surnme",this->persons[i]->getSurname()},{"index",this->persons[i]->getIndex()} };
	}
	
	
	return j;
}


