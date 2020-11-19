#pragma once
#include<string>
#include<iostream>
using namespace std;
class Person
{
public:
	Person(int Index, string Name, string Surname);
	void toString(void);
	int getIndex(void);
	string getName(void);
	string getSurname(void);
private:
	int index;
	string name;
	string surname;
};

