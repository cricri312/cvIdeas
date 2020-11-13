#include "Plansza.h"



Plansza::Plansza()
{
}


Plansza::~Plansza()
{
}

void Plansza::rysuj()
{
	tlo.loadFromFile("obrazy\\tlo.jpg");
	sTlo.setTexture(tlo);
	gracz.loadFromFile("obrazy\\gracz.png");
	sGracz.setTexture(gracz);
	schodek.loadFromFile("obrazy\\schodek.png");
	sSchodek.setTexture(schodek);
	duch.loadFromFile("obrazy\\duch.png");
	sDuch.setTexture(duch);
	duch2.loadFromFile("obrazy\\duch2.png");
	sDuch2.setTexture(duch2);
	lawa.loadFromFile("obrazy\\lawa.png");
	sLawa.setTexture(lawa);
}

int Plansza::kolizja()
{
	if (sGracz.getGlobalBounds().intersects(sSchodek.getGlobalBounds()))
	{
		return 1;
	}
	return NULL;
}
