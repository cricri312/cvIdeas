#pragma once
#include <SFML/Graphics.hpp>
#include "WartosciStale.h"
#include <time.h>
#include "Plansza.h"
#include <iostream>
#include <Windows.h>

using namespace std;
using namespace sf;
class Tworzenie_Gry : Plansza
{
public:
	Tworzenie_Gry(string tytu,int szerokosc, int wysokosc);
	~Tworzenie_Gry();
private:
	RenderWindow* window;
	Event mojeWydarzenie;
	struct point { int x, y; };
	int zycie = 4;
	int flaga = 0;
	int x = 100, y = 100, h = 200;
	float dx = 0, dy = 0;
	int xx = 30, xy = 0, xd = 300, xdy = 0;
	int czas=0;
public:
	int kolizjaWiem();
	void tworzGre();
	
	
};

