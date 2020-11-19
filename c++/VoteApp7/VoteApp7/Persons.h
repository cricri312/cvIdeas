#pragma once
#include<iostream>
#include<vector>
#include<memory>
#include "Person.h"
using namespace std;
class Persons
{
private:
	vector < unique_ptr<Person>> persons;
public:
	int getSizeOfPersons(void);
	int addPersonToPersons(Person p);
};

