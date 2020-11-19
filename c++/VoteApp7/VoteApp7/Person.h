#pragma once
#include<string>
#include<iostream>
using namespace std;
class Person
{
public:
	Person(int Index, string Name, string Surname);
	void toString(void);
private:
	int index;
	string name;
	string surname;
};

