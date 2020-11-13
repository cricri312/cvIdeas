#include "Tworzenie_Gry.h"



Tworzenie_Gry::Tworzenie_Gry(string tytu, int szerokosc, int wysokosc)
{
	window = new RenderWindow(VideoMode(szerokosc, wysokosc), tytu, sf::Style::Titlebar | sf::Style::Close);
	window->setFramerateLimit(60);
}


Tworzenie_Gry::~Tworzenie_Gry()
{
}

int Tworzenie_Gry::kolizjaWiem()
{
	if (flaga == 1) return 1;
}

void Tworzenie_Gry::tworzGre()
{
	//sDuch.setPosition(100, 400);
	rysuj();
	point scho[20];

	for (int i = 0; i < 10; i++)
	{
		scho[i].x = rand() % 400;
		scho[i].y = rand() % 533;
	}


	while (window->isOpen())
	{
		czas += 1;
		
		while (window->pollEvent(mojeWydarzenie))
		{
			if (mojeWydarzenie.type == Event::Closed)
				window->close();
		}

		if (Keyboard::isKeyPressed(Keyboard::Right)) x += 3;
		if (Keyboard::isKeyPressed(Keyboard::Left)) x -= 3;
		

		dy += 0.2;
		y += dy;
		if (y > 500)  dy = -10;
		
		if (y < h)
			for (int i = 0; i < 10; i++)
			{
				y = h;
				scho[i].y = scho[i].y - dy;
				if (scho[i].y > 533) { scho[i].y = 0; scho[i].x = rand() % 400; }
			}

		for (int i = 0; i < 10; i++)
			if ((x + 50 > scho[i].x) && (x + 20 < scho[i].x + 68)
				&& (y + 70 > scho[i].y) && (y + 70 < scho[i].y + 14) && (dy > 0))  dy = -10;
		
		xy += 4;
		if (xy > 500) { xy = -40; xx += 20; }
		if (xx > 350) { xx = 30; }
		
		sDuch.setPosition(xx, xy);
		sGracz.setPosition(x, y);
		if (Keyboard::isKeyPressed(Keyboard::Space)) sGracz.move(0, -100);
		sLawa.setPosition(0, 527);

		if (czas > 700) {
			xdy += 4;
			if (xdy > 500) { xdy = -40; xd -= 20; }
			if (xd < 100) { xd = 300; }
			sDuch2.setPosition(xd, xdy);
		}
		
		if (sGracz.getGlobalBounds().intersects(sDuch.getGlobalBounds()) || sGracz.getGlobalBounds().intersects(sDuch2.getGlobalBounds()))
		{  

			sDuch.setPosition(0, 0);
			sDuch2.setPosition(0, 0);
			xx = 0; xy = 0;
			xd = 0; xdy = 0;
		
			zycie -= 1;
			cout << "Zycia:" << zycie<<endl;
			if (zycie <= 0) {
				sDuch.scale(0, 0);
				sGracz.setScale(0, 0);
				sDuch2.scale(0, 0);
				
				window->setVisible(false);
				int o = czas;
				cout << "Twoj rekord:" << o;
				flaga = 1;
				
			}
		}
		if (sGracz.getGlobalBounds().intersects(sLawa.getGlobalBounds()))
		{
			zycie -= 1;
			sGracz.setColor(Color::Red);

		}
		
		
         window->draw(sTlo);
		 window->draw(sLawa);
		window->draw(sGracz);
		window->draw(sDuch);
		window->draw(sDuch2);
		for (int i = 0; i < 10; i++)
		{
			sSchodek.setPosition(scho[i].x, scho[i].y);
			window->draw(sSchodek);
		}
		kolizjaWiem();
		window->display();
	}

}




