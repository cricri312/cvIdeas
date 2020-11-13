#include <iostream>
#include <SFML/Graphics.hpp>
#include "Tworzenie_Gry.h"
#include "WartosciStale.h"
int main()

{
	cout << "Gra polega na skakaniu, ma sie 4 zycia"<<endl;
	cout << "Porada: Uwazac na schody ktora sa widmami";
	getchar();
	Tworzenie_Gry nowaGra{ "SAO",SZEROKOSC_OKNA,WYSOKOSC_OKNA };
	
	nowaGra.tworzGre();
	
}