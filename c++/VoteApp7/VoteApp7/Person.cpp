#include "Person.h"

Person::Person(int Index, string Name, string Surname)
{
	this->index = Index;
	this->name = Name;
	this->surname = Surname;
	
}

void Person::toString(void)
{
	cout << this->index;
	cout << this->name.c_str();
	cout << this->surname.c_str();
	
}

int Person::getIndex(void)
{
	return this->index;
}

string Person::getName(void)
{
	return this->name;
}

string Person::getSurname(void)
{
	return this->surname;
}
