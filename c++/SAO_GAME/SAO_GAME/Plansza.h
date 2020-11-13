#pragma once
#include <SFML/Graphics.hpp>
using namespace std;
using namespace sf;
class Plansza
{
public:
	Plansza();
	~Plansza();
private:
	Texture tlo;
	Texture gracz;
	Texture schodek;
	Texture duch;
	Texture duch2;
	Texture lawa;
protected:
	Sprite sTlo;
	Sprite sGracz;
	Sprite sSchodek;
	Sprite sDuch;
	Sprite sDuch2;
	Sprite sLawa;
public:
	void rysuj();
	int kolizja();
};

