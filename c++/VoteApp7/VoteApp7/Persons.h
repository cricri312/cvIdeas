#pragma once
#include<iostream>
#include<vector>
#include<memory>
#include "Person.h"
#include"nlohmann/json.hpp"
using namespace std;
using json = nlohmann::json;
class Persons
{
private:
	vector < unique_ptr<Person>> persons;
public:
	int getSizeOfPersons(void);
	int addPersonToPersons(Person p);
	json toJson(Person p);
	
};

