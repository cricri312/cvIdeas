#include <iostream>
#include<GL/glew.h>
#include <GLFW/glfw3.h>
#include<math.h>
#include<glm.hpp>

using namespace std;
using namespace glm;


bool r = false;
bool f = false;
bool v = false;
bool q = false;
bool w = false;
bool a = false;
bool s = false;
bool z = false;
bool x = false;
bool e = false;
bool d = false;
bool c = false;
bool t = false;

bool ra = false;
bool fa = false;
bool va = false;
bool qa = false;
bool wa = false;
bool aa = false;
bool sa = false;
bool za = false;
bool xa = false;
bool ea = false;
bool da = false;
bool ca = false;
bool ta = false;

#define WYSOKOSC 1000
#define SZYROKOSC 1000
#define PI  3.1415926535897;
	//#define LISTWA 2.5*abs(cos(180 * 2*3.1415926535897 / 360))*abs(cos(180 * 2*3.1415926535897 / 360));
	//FUNKCJE DO RYSOWANIE OBIEKTOW
	void keyActions();
	void drawCube(float x, float y, float z, float size);
	void drawCube2(float x, float y, float z, float size);
	void drawWalec(float x, float y, float z, float height, float radius, bool czerwony);
	void drawWalec2(float x, float y, float z, float height, float radius, bool czerwony);
	void drawWalec3(float x, float y, float z, float height, float radius, bool czerwony);
	void drawFork(float x, float y, float z, float height, float radius, float rot, bool czerwony);
	void drawGrid();

	float baseRot = 0;
	float forkRot = 0;
	float xRot1 = 0;
	float xRot2 = 0;
	float xRot3 = 0;
	float zRot1 = 0;
	float zRot2 = 0;
	float zRot3 = 0;

	float baseRota = 0;
	float forkRota = 0;
	float xRot1a = 0;
	float xRot2a = 0;
	float xRot3a = 0;
	float zRot1a = 0;
	float zRot2a = 0;
	float zRot3a = 0;

	////////////////////////////////////////////////////

	//FUNKCJE DO OBSLUGI 
	void key_callback(GLFWwindow* window, int key, int scancode, int action, int mods);
	static void cursor_position_callback(GLFWwindow* window, double xpos, double ypos);
	//////////////////////////////////

	//KAMERA FPS JAK W CS ;)
	class myCamera
	{
	public:
		myCamera();
		~myCamera();
		void cam();
	public:
		float xpos = 0, ypos = 0, zpos = 0, xRot1 = 0, yrot = 0, angle = 0.0;
		void setPosition(float x, float y, float z, float xRot1, float yrot);
		float lastx, lasty;

	};

	myCamera::myCamera()
	{

	}

	myCamera::~myCamera()
	{
	}
	void myCamera::cam()
	{
		glRotatef(xRot1, 1.0, 0.0, 0.0);
		glRotatef(yrot, 0.0, 1.0, 0.0);
		glTranslated(-xpos, -ypos, -zpos);
	}
	void myCamera::setPosition(float x, float y, float z, float xRot1, float yrot)
	{
		this->xpos = x; this->ypos = y; this->zpos = z; this->xRot1 = xRot1; this->yrot = yrot;
		this->lastx = x;
		this->lasty = y;
	}


	GLFWwindow *window;
	myCamera camera;
	//INITIALIZE_EVERYTHING
	void init()
	{
		glClearColor(0.3, 0.3, 0.8, 1.0);
		glMatrixMode(GL_PROJECTION);
		glLoadIdentity();
		gluPerspective(35, 1, 0.1, 1000.0);
		glMatrixMode(GL_MODELVIEW);
		glEnable(GL_DEPTH_TEST);



	}
	//TUTAJ DAJEMY WSZYSTKIE NASZE FUNKCJE RYSUNKU
	void display()
	{
		glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
		glLoadIdentity();


		keyActions();

		camera.cam();
		
		drawCube2(0, 400, 0, 800);
		glPushMatrix();
		drawCube(60, 4, /*rand() % (20 - (-20 + 1)) + (-20)*/0 , 8);
		glPopMatrix();
		/////////////////START////////////////////
		glPushMatrix();
		glRotatef(baseRot, 0, 1, 0);
		drawWalec(0, 0, 0, 17.5, 2.5, true);

		glTranslatef(0, 20, 0);
		glRotatef(xRot1, 1, 0, 0);
		glRotatef(zRot1, 0, 0, 1);
		glRotatef(90, 0, 1, 0);
		drawWalec2(0, 0, 0, 25, 2.5, true);

		glTranslatef(0, 30, 0);
		glRotatef(-zRot2, 1, 0, 0);
		glRotatef(xRot2, 0, 0, 1);
		glRotatef(-90, 0, 1, 0);
		drawWalec2(0, 0, 0, 25, 2.5, true);

		glTranslatef(0, 30, 0);
		glRotatef(xRot3, 1, 0, 0);
		glRotatef(zRot3, 0, 0, 1);
		//glRotatef(90, 0, 1, 0);
		drawWalec3(0, 0, 0, 17.5, 2.5, true);

		glTranslatef(0, 20, 0);
		drawFork(0, 0, 0, 3, 0.5, forkRot, true);
		glPopMatrix();

		///////////////////////
		glPushMatrix();
		glTranslatef(120, 0, 0);
		glRotatef(baseRota, 0, 1, 0);
		drawWalec(0, 0, 0, 17.5, 2.5, false);

		glTranslatef(0, 20, 0);
		glRotatef(xRot1a, 1, 0, 0);
		glRotatef(zRot1a, 0, 0, 1);
		glRotatef(90, 0, 1, 0);
		drawWalec2(0, 0, 0, 25, 2.5, false);

		glTranslatef(0, 30, 0);
		glRotatef(-zRot2a, 1, 0, 0);
		glRotatef(xRot2a, 0, 0, 1);
		glRotatef(-90, 0, 1, 0);
		drawWalec2(0, 0, 0, 25, 2.5, false);

		glTranslatef(0, 30, 0);
		glRotatef(xRot3a, 1, 0, 0);
		glRotatef(zRot3a, 0, 0, 1);
		//glRotatef(90, 0, 1, 0);
		drawWalec3(0, 0, 0, 17.5, 2.5, false);

		glTranslatef(0, 20, 0);
		drawFork(0, 0, 0, 3, 0.5, forkRota, false);
		glPopMatrix();

	
	}

	int main()
	{

		if (!glfwInit())
		{
			return -1;
		}
		window = glfwCreateWindow(SZYROKOSC, WYSOKOSC, "OpenGl", NULL, NULL); //TWORZENIE OKNA W GLFW
		if (!window)
		{
			glfwTerminate();
			return -1;
		}
		//camera.setPosition(5, 5, 3, 4, 1048);
		camera.setPosition(60, 200, 280, 30, 0);
		//WYWOLANIA FUNKCJE OBSLUGI
		glfwSetKeyCallback(window, key_callback);
		glfwSetCursorPosCallback(window, cursor_position_callback);
		glfwMakeContextCurrent(window);
		init();
		while (!glfwWindowShouldClose(window))
		{
			display();
			glfwSwapBuffers(window);
			glfwPollEvents();

		}

		glfwTerminate();
	}

	void drawWalec(float x, float y, float z, float height, float radius, bool czerwony)
	{
		float twicePi = 2.0f * 3.1415926535897;
		float coverH = 2.5*abs(cos(180 * twicePi / 360))*abs(cos(180 * twicePi / 360));
		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));

		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);

		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.6, 0, 0); }
			else { glColor3f(0, 0, 0.6); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + 2.5*abs(cos(i * twicePi / 360))*abs(cos(i * twicePi / 360)), z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_LINES);
		glColor3f(0, 0, 0);
		glVertex3f(x + (radius * cos(0 * twicePi / 360)), y + height + 2.5, z + (radius * sin(0 * twicePi / 360)));
		glVertex3f(x + (radius * cos(180 * twicePi / 360)), y + height + 2.5, z + (radius * sin(180 * twicePi / 360)));
		glEnd();
		//glColor3f(1.0, 0.0, 0.0);
		/*for (int i = 0; i < 120; i+=30)
		{
		glColor3f(sin(i), cos(i), sin(i)/cos(i));
		glVertex3f(x, y, z);
		glVertex3f(x+sin(i), y, z +cos(i));
		glVertex3f(x + sin(i+30), y, z + cos(i+30));
		}*/
		/*glVertex3f(x,y,z);
		glVertex3f(x,y,z+2);
		glVertex3f(x+2,y,z);*/
	}

	void drawWalec2(float x, float y, float z, float height, float radius, bool czerwony)
	{
		float twicePi = 2.0f * 3.1415926535897;
		float coverH = 2.5*abs(cos(180 * twicePi / 360))*abs(cos(180 * twicePi / 360));
		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.6, 0, 0); }
			else { glColor3f(0, 0, 0.6); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH - 2.5*abs(cos(i * twicePi / 360))*abs(cos(i * twicePi / 360)), z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + coverH, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height + coverH, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));

		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);

		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.6, 0, 0); }
			else { glColor3f(0, 0, 0.6); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH + 2.5*abs(cos(i * twicePi / 360))*abs(cos(i * twicePi / 360)), z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_LINES);
		glColor3f(0, 0, 0);
		glVertex3f(x + (radius * cos(0 * twicePi / 360)), y, z + (radius * sin(0 * twicePi / 360)));
		glVertex3f(x + (radius * cos(180 * twicePi / 360)), y, z + (radius * sin(180 * twicePi / 360)));
		glVertex3f(x + (radius * cos(0 * twicePi / 360)), y + height + 5, z + (radius * sin(0 * twicePi / 360)));
		glVertex3f(x + (radius * cos(180 * twicePi / 360)), y + height + 5, z + (radius * sin(180 * twicePi / 360)));
		glEnd();
	}

	void drawWalec3(float x, float y, float z, float height, float radius, bool czerwony)
	{
		float twicePi = 2.0f * 3.1415926535897;
		float coverH = 2.5*abs(cos(180 * twicePi / 360))*abs(cos(180 * twicePi / 360));

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + coverH, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height + coverH, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));

		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);

		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.6, 0, 0); }
			else { glColor3f(0, 0, 0.6); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + 2.5*abs(cos(i * twicePi / 360))*abs(cos(i * twicePi / 360)), z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_LINES);
		glColor3f(0, 0, 0);
		glVertex3f(x + (radius * cos(90 * twicePi / 360)), y, z + (radius * sin(90 * twicePi / 360)));
		glVertex3f(x + (radius * cos(270 * twicePi / 360)), y, z + (radius * sin(270 * twicePi / 360)));
		glEnd();

	}

	void drawFork(float x, float y, float z, float height, float radius, float rot, bool czerwony)
	{
		float twicePi = 2.0f * 3.1415926535897;

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));

		}
		glEnd();

		////////////
		glTranslatef(height / 2, height, 0);
		glRotatef(90, 0, 0, 1);

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
			glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));

		}
		glEnd();

		glRotatef(90, 1, 0, 0);
		glTranslatef(0, -height / 2, 0);
		glRotatef(90, 0, 1, 0);
		//zamykanie
		glRotatef(rot, 0, 1, 0);
		//////////// lapka
		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
			}
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y + height, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
			}
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y, z + (radius * 6 * sin(i * twicePi / 360)));
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y + height, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
			}


		}
		glEnd();

		glRotatef(-rot, 0, 1, 0);
		glTranslatef(height, 0, 0);
		glRotatef(-rot, 0, 1, 0);
		//////////// lapka
		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
			}
		}
		glEnd();

		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(x, y + height, z); // center of circle
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(1, 0, 0); }
			else { glColor3f(0, 0, 1); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y + height, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
			}
		}
		glEnd();

		glBegin(GL_TRIANGLE_STRIP);
		for (int i = 0; i <= 360; i += 30) {
			if (czerwony) { glColor3f(0.8, 0, 0); }
			else { glColor3f(0, 0, 0.8); }
			//glColor3f(sin(i), cos(i), sin(i) / cos(i));
			if (i == 90)
			{
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y, z + (radius * 6 * sin(i * twicePi / 360)));
				glVertex3f(x + (radius * 6 * cos(i *  twicePi / 360)), y + height, z + (radius * 6 * sin(i * twicePi / 360)));
			}
			else
			{
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
				glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
			}


		}
		glEnd();

	}

	void drawCube2(float x, float y, float z, float size)
	{
		glBegin(GL_QUADS);
		// front face
		glColor3f(0.5, 0.5, 0.5);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		// left face
		glColor3f(0.5, 0.5, 0.5);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		// back face
		glColor3f(0.5, 0.5, 0.5);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		// right face
		glColor3f(0.5, 0.5, 0.5);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		// top face
		glColor3f(0.0, 0.6, 1);
		//glColor3f(1,1,1);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		// bottom face
		//glColor3f(0.2, 0.7, 0.2);
		glColor3f(0.8, 0.8, 0.8);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		glEnd();
	}
	void drawCube(float x, float y, float z, float size)
	{
		glBegin(GL_QUADS);
		// front face
		glColor3f(1, 0.65, 0);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		// left face
		glColor3f(1, 0.65, 0);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		// back face
		glColor3f(1, 0.65, 0);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		// right face
		glColor3f(1, 0.65, 0);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		// top face
		glColor3f(1, 0.65, 0);
		//glColor3f(1,1,1);
		glVertex3f(x + size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z + size / 2);
		glVertex3f(x - size / 2, y + size / 2, z - size / 2);
		glVertex3f(x + size / 2, y + size / 2, z - size / 2);
		// bottom face
		glColor3f(1, 0.65, 0);
		glVertex3f(x + size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z + size / 2);
		glVertex3f(x - size / 2, y - size / 2, z - size / 2);
		glVertex3f(x + size / 2, y - size / 2, z - size / 2);
		glEnd();

	}
	void drawGrid()
	{
		int i;
		for (i = 0; i < 40; i++)
		{
			glPushMatrix();
			if (i < 20) glTranslatef(0, 0, i);
			if (i >= 20)
			{
				glTranslatef(i - 20, 0, 0);
				glRotatef(-90, 0, 1, 0);
			}
			glBegin(GL_LINES);
			glColor3f(1, 1, 1); glLineWidth(1);
			glVertex3f(0, -0.1, 0);
			glVertex3f(19, -0.1, 0);
			glEnd();
			glPopMatrix();
		}
	}
	void key_callback(GLFWwindow* window, int key, int scancode, int action, int mods)
	{

		/*if (key == GLFW_KEY_Q)
		{
		camera.xRot1 += 1;
		if (camera.xRot1 > 360) camera.xRot1 -= 360;
		}*/

		/*if (key == GLFW_KEY_Z)
		{
			camera.xRot1 -= 1;
			if (camera.xRot1 < -360) camera.xRot1 += 360;
		}*/

		if (key == GLFW_KEY_UP)
		{
			float xRot1rad, yrotrad;
			yrotrad = (camera.yrot / 180 * 3.141592654f);
			xRot1rad = (camera.xRot1 / 180 * 3.141592654f);
			camera.xpos += float(sin(yrotrad));
			camera.zpos -= float(cos(yrotrad));
			camera.ypos -= float(sin(xRot1rad));
		}

		if (key == GLFW_KEY_DOWN)
		{
			float xRot1rad, yrotrad;
			yrotrad = (camera.yrot / 180 * 3.141592654f);
			xRot1rad = (camera.xRot1 / 180 * 3.141592654f);
			camera.xpos -= float(sin(yrotrad));
			camera.zpos += float(cos(yrotrad));
			camera.ypos += float(sin(xRot1rad));
		}

		if (key == GLFW_KEY_RIGHT)
		{
			float yrotrad;
			yrotrad = (camera.yrot / 180 * 3.141592654f);
			camera.xpos += float(cos(yrotrad)) * 0.2;
			camera.zpos += float(sin(yrotrad)) * 0.2;

		}

		if (key == GLFW_KEY_LEFT)
		{
			float yrotrad;
			yrotrad = (camera.yrot / 180 * 3.141592654f);
			camera.xpos -= float(cos(yrotrad)) * 0.2;
			camera.zpos -= float(sin(yrotrad)) * 0.2;
		}

		/*if (key == GLFW_KEY_Q)
		{
			forkRot += 5;
			if (forkRot > 30)forkRot = 30;
		}

		if (key == GLFW_KEY_W)
		{
			forkRot -= 5;
			if (forkRot < -90)forkRot = -90;
		}*/
		if (key == GLFW_KEY_Q)
		{
			q = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_W)
		{
			w = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_A)
		{
			a = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_S)
		{
			s = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_Z)
		{
			z = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_X)
		{
			x = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_E)
		{
			e = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_D)
		{
			d = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_C)
		{
			c = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_R)
		{
			r = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_F)
		{
			f = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_V)
		{
			v = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_RIGHT_BRACKET)
		{
			ra = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_LEFT_BRACKET)
		{
			ea = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_O)
		{
			qa = action == GLFW_PRESS;
		}
		if (key == GLFW_KEY_P)
		{
			wa = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_K)
		{
			aa = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_L)
		{
			sa = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_M)
		{
			za = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_SEMICOLON)
		{
			da = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_APOSTROPHE)
		{
			fa = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_COMMA)
		{
			xa = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_PERIOD)
		{
			ca = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_SLASH)
		{
			va = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_T)
		{
			t = action == GLFW_PRESS;
		}

		if (key == GLFW_KEY_I)
		{
			ta = action == GLFW_PRESS;
		}
	}

	static void cursor_position_callback(GLFWwindow* window, double xPos, double yPos)
	{

		int diffx = xPos - camera.lastx;
		int diffy = yPos - camera.lasty;
		camera.lastx = xPos;
		camera.lasty = yPos;
		camera.xRot1 += (float)diffy;
		camera.yrot += (float)diffx;

	}

	void keyActions()
	{
		/*if (o)
		{
			baseRot -= 6;
		}

		if (p) 
		{ 
			baseRot += 6; 
		}*/

		if (q) 
		{
			xRot1 += 5;
			if (xRot1 >= 60)
			{
				xRot1 = 60;
			}
		}

		if (w)
		{
			xRot1 -= 5;
			if (xRot1 <= -60)
			{
				xRot1 = -60;
			}
		}

		if (a)
		{
			xRot2 += 5;
			if (xRot2 >= 60)
			{
				xRot2 = 60;
			}
		}

		if (s)
		{

			xRot2 -= 5;
			if (xRot2 <= -60)
			{
				xRot2 = -60;
			}
		}

		if (z)
		{
			xRot3 += 5;
			if (xRot3 >= 60)
			{
				xRot3 = 60;
			}
		}

		if (x)
		{
			xRot3 -= 5;
			if (xRot3 <= -60)
			{
				xRot3 = -60;
			}
		}

		if (e)
		{
			zRot1 += 5;
			if (zRot1 >= 60)
			{
				zRot1 = 60;
			}
		}

		if (r)
		{
			zRot1 -= 5;
			if (zRot1 <= -60)
			{
				zRot1 = -60;
			}
		}

		if (d)
		{
			zRot2 += 5;
			if (zRot2 >= 60)
			{
				zRot2 = 60;
			}
		}

		if (f)
		{
			zRot2 -= 5;
			if (zRot2 <= -60)
			{
				zRot2 = -60;
			}
		}

		if (c)
		{
			zRot3 += 5;
			if (zRot3 >= 60)
			{
				zRot3 = 60;
			}
		}

		if (v)
		{
			zRot3 -= 5;
			if (zRot3 <= -60)
			{
				zRot3 = -60;
			}
		}

		if (t)
		{
			baseRot += 5;
			if (baseRot ==360)
			{
				baseRot = 0;
			}
		}
		///////////////////////////////////////
		if (qa)
		{
			xRot1a += 5;
			if (xRot1a >= 60)
			{
				xRot1a = 60;
			}
		}

		if (wa)
		{
			xRot1a -= 5;
			if (xRot1a <= -60)
			{
				xRot1a = -60;
			}
		}

		if (aa)
		{
			xRot2a += 5;
			if (xRot2a >= 60)
			{
				xRot2a = 60;
			}
		}

		if (sa)
		{

			xRot2a -= 5;
			if (xRot2a <= -60)
			{
				xRot2a = -60;
			}
		}

		if (za)
		{
			xRot3a += 5;
			if (xRot3a >= 60)
			{
				xRot3a = 60;
			}
		}

		if (xa)
		{
			xRot3a -= 5;
			if (xRot3a <= -60)
			{
				xRot3a = -60;
			}
		}

		if (ea)
		{
			zRot1a += 5;
			if (zRot1a >= 60)
			{
				zRot1a = 60;
			}
		}

		if (ra)
		{
			zRot1a -= 5;
			if (zRot1a <= -60)
			{
				zRot1a = -60;
			}
		}

		if (da)
		{
			zRot2a += 5;
			if (zRot2a >= 60)
			{
				zRot2a = 60;
			}
		}

		if (fa)
		{
			zRot2a -= 5;
			if (zRot2a <= -60)
			{
				zRot2a = -60;
			}
		}

		if (ca)
		{
			zRot3a += 5;
			if (zRot3a >= 60)
			{
				zRot3a = 60;
			}
		}

		if (va)
		{
			zRot3a -= 5;
			if (zRot3a <= -60)
			{
				zRot3a = -60;
			}
		}

		if (ta)
		{
			baseRota += 5;
			if (baseRota == 360)
			{
				baseRota = 0;
			}
		}
	}