#include <iostream>
#include<GL/glew.h>
#include <GLFW/glfw3.h>
#include<math.h>
#include<glm.hpp>

using namespace std;
using namespace glm;

#define WYSOKOSC 600
#define SZYROKOSC 600
#define PI  3.1415926535897;
//#define LISTWA 2.5*abs(cos(180 * 2*3.1415926535897 / 360))*abs(cos(180 * 2*3.1415926535897 / 360));
//FUNKCJE DO RYSOWANIE OBIEKTOW
void drawCube(float size);
void drawCube2(float x, float y, float z, float size);
void drawWalec(float x, float y, float z, float height, float radius);
void drawWalec2(float x, float y, float z, float height, float radius);
void drawGrid();

int kolizja();
float XafterY(float x, float y, float z, float stopien);
float YafterY(float x, float y, float z, float stopien);
float ZafterY(float x, float y, float z, float stopien);


float basex = 0; float basey = 0; float basez = 0;
float seg1x = 0; float seg1y = 10.5; float seg1z = 0;
float seg2x = 0; float seg2y = 13; float seg2z = 0;
float seg3x = 0; float seg3y = 13; float seg3z = 0;
float seg4x = 0; float seg4y = 10.5; float seg4z = 0;

float baseRot = 0;
float xRot1 = 0;
float xRot2 = 0;
float xRot3 = 0;
float zRot1 = 0;
float zRot2 = 0;
float zRot3 = 0;
int xCube = 10;
int yCube = 1;
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

	camera.cam();

	glPushMatrix();
	glRotatef(-baseRot, 0, 1, 0);
		drawCube2(10, 1, 0, 3);
	glPopMatrix();
	drawWalec(basex, basey, basey, 8, 2.5);
	
	glTranslatef(0, 10.5, 0);
	glRotatef(xRot1, 1, 0, 0);
	glRotatef(zRot1, 0, 0, 1);
	glRotatef(90,0, 1, 0);
	drawWalec2(0,0, 0, 8, 2.5);
	
	glTranslatef(0, 13, 0);
	glRotatef(zRot2, 1, 0, 0);
	glRotatef(xRot2, 0, 0, 1);
	glRotatef(-90, 0, 1, 0);
	drawWalec2(0, 0, 0, 8, 2.5);

	glTranslatef(0, 13, 0);
	glRotatef(xRot3, 1, 0, 0);
	glRotatef(zRot3, 0, 0, 1);
	glRotatef(90, 0, 1, 0);
	drawWalec(0, 0, 0, 8, 2.5);

	
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
	camera.setPosition(0, 10, 50, 0, 0);
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

int kolizja()
{
	int x;
	x = 1;
	return x;
}
void drawWalec(float x, float y, float z, float height, float radius)
{
	float twicePi = 2.0f * 3.1415926535897;
	float coverH = 2.5*abs(cos(180 * twicePi / 360))*abs(cos(180 * twicePi / 360));
	glBegin(GL_TRIANGLE_FAN);
	glVertex3f(x, y, z); // center of circle
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(1, 0, 0);
		//glColor3f(sin(i), cos(i), sin(i) / cos(i));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
	}
	glEnd();

	glBegin(GL_TRIANGLE_FAN);
	glVertex3f(x, y + height, z); // center of circle
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(1, 0, 0);
		//glColor3f(sin(i), cos(i), sin(i) / cos(i));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));
	}
	glEnd();

	glBegin(GL_TRIANGLE_STRIP);
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(0.8f, 0, 0);
		//glColor3f(sin(i), cos(i), sin(i) / cos(i));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y, z + (radius * sin(i * twicePi / 360)));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height, z + (radius * sin(i * twicePi / 360)));

	}
	glEnd();

	glBegin(GL_TRIANGLE_STRIP);

	for (int i = 0; i <= 360; i += 30) {
		glColor3f(0.6f, 0, 0);
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
}

void drawWalec2(float x, float y, float z, float height, float radius)
{
	float twicePi = 2.0f * 3.1415926535897;
	float coverH = 2.5*abs(cos(180 * twicePi / 360))*abs(cos(180 * twicePi / 360));
	glBegin(GL_TRIANGLE_STRIP);
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(0.6f, 0, 0);
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH - 2.5*abs(cos(i * twicePi / 360))*abs(cos(i * twicePi / 360)), z + (radius * sin(i * twicePi / 360)));
	}
	glEnd();

	glBegin(GL_TRIANGLE_FAN);
	glVertex3f(x, y + coverH, z); // center of circle
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(1, 0, 0);
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
	}
	glEnd();

	glBegin(GL_TRIANGLE_FAN);
	glVertex3f(x, y + height + coverH, z); // center of circle
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(1, 0, 0);
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));
	}
	glEnd();

	glBegin(GL_TRIANGLE_STRIP);
	for (int i = 0; i <= 360; i += 30) {
		glColor3f(0.8f, 0, 0);
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + coverH, z + (radius * sin(i * twicePi / 360)));
		glVertex3f(x + (radius * cos(i *  twicePi / 360)), y + height + coverH, z + (radius * sin(i * twicePi / 360)));

	}
	glEnd();

	glBegin(GL_TRIANGLE_STRIP);

	for (int i = 0; i <= 360; i += 30) {
		glColor3f(0.6f, 0, 0);
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

void drawCube2(float x, float y, float z, float size)
{
	glPushMatrix();
	glTranslatef(xCube, 0, 0);
	glBegin(GL_QUADS);
	// front face
	glColor3f(1.0, 0.0, 0.0);
	glVertex3f(x + size / 2, y + size / 2, z + size / 2);
	glVertex3f(x - size / 2, y + size / 2, z + size / 2);
	glVertex3f(x - size / 2, y - size / 2, z + size / 2);
	glVertex3f(x + size / 2, y - size / 2, z + size / 2);
	// left face
	glColor3f(0.0, 1.0, 0.0);
	glVertex3f(x - size / 2, y + size / 2, z + size / 2);
	glVertex3f(x - size / 2, y - size / 2, z + size / 2);
	glVertex3f(x - size / 2, y - size / 2, z - size / 2);
	glVertex3f(x - size / 2, y + size / 2, z - size / 2);
	// back face
	glColor3f(0.0, 0.0, 1.0);
	glVertex3f(x + size / 2, y + size / 2, z - size / 2);
	glVertex3f(x - size / 2, y + size / 2, z - size / 2);
	glVertex3f(x - size / 2, y - size / 2, z - size / 2);
	glVertex3f(x + size / 2, y - size / 2, z - size / 2);
	// right face
	glColor3f(1.0, 1.0, 0.0);
	glVertex3f(x + size / 2, y + size / 2, z + size / 2);
	glVertex3f(x + size / 2, y - size / 2, z + size / 2);
	glVertex3f(x + size / 2, y - size / 2, z - size / 2);
	glVertex3f(x + size / 2, y + size / 2, z - size / 2);
	// top face
	glColor3f(1.0, 0.0, 1.0);
	glVertex3f(x + size / 2, y + size / 2, z + size / 2);
	glVertex3f(x - size / 2, y + size / 2, z + size / 2);
	glVertex3f(x - size / 2, y + size / 2, z - size / 2);
	glVertex3f(x + size / 2, y + size / 2, z - size / 2);
	// bottom face
	glColor3f(0.0, 1.0, 1.0);
	glVertex3f(x + size / 2, y - size / 2, z + size / 2);
	glVertex3f(x - size / 2, y - size / 2, z + size / 2);
	glVertex3f(x - size / 2, y - size / 2, z - size / 2);
	glVertex3f(x + size / 2, y - size / 2, z - size / 2);
	glEnd();
	glPopMatrix();
}
void drawCube(float size)
{
	glBegin(GL_QUADS);
	// front face
	glColor3f(1.0, 0.0, 0.0);
	glVertex3f(size / 2, size / 2, size / 2);
	glVertex3f(-size / 2, size / 2, size / 2);
	glVertex3f(-size / 2, -size / 2, size / 2);
	glVertex3f(size / 2, -size / 2, size / 2);
	// left face
	glColor3f(0.0, 1.0, 0.0);
	glVertex3f(-size / 2, size / 2, size / 2);
	glVertex3f(-size / 2, -size / 2, size / 2);
	glVertex3f(-size / 2, -size / 2, -size / 2);
	glVertex3f(-size / 2, size / 2, -size / 2);
	// back face
	glColor3f(0.0, 0.0, 1.0);
	glVertex3f(size / 2, size / 2, -size / 2);
	glVertex3f(-size / 2, size / 2, -size / 2);
	glVertex3f(-size / 2, -size / 2, -size / 2);
	glVertex3f(size / 2, -size / 2, -size / 2);
	// right face
	glColor3f(1.0, 1.0, 0.0);
	glVertex3f(size / 2, size / 2, size / 2);
	glVertex3f(size / 2, -size / 2, size / 2);
	glVertex3f(size / 2, -size / 2, -size / 2);
	glVertex3f(size / 2, size / 2, -size / 2);
	// top face
	glColor3f(1.0, 0.0, 1.0);
	glVertex3f(size / 2, size / 2, size / 2);
	glVertex3f(-size / 2, size / 2, size / 2);
	glVertex3f(-size / 2, size / 2, -size / 2);
	glVertex3f(size / 2, size / 2, -size / 2);
	// bottom face
	glColor3f(0.0, 1.0, 1.0);
	glVertex3f(size / 2, -size / 2, size / 2);
	glVertex3f(-size / 2, -size / 2, size / 2);
	glVertex3f(-size / 2, -size / 2, -size / 2);
	glVertex3f(size / 2, -size / 2, -size / 2);
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

	if (key == GLFW_KEY_Q)
	{
		camera.xRot1 += 1;
		if (camera.xRot1 > 360) camera.xRot1 -= 360;
	}

	if (key == GLFW_KEY_Z)
	{
		camera.xRot1 -= 1;
		if (camera.xRot1 < -360) camera.xRot1 += 360;
	}

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

	if (key == GLFW_KEY_O)
	{
		float _x, _y, _z;
		baseRot -= 6;
		camera.yrot = baseRot;
		_x = XafterY(camera.xpos, camera.ypos, camera.zpos, 6);
		_y = YafterY(camera.xpos, camera.ypos, camera.zpos, 6);
		_z = ZafterY(camera.xpos, camera.ypos, camera.zpos, 6);
		camera.xpos = _x;
		camera.ypos = _y;
		camera.zpos = _z;
	}
	if (key == GLFW_KEY_P)
	{
		float _x, _y, _z;
		baseRot += 6;
		camera.yrot = baseRot;
		_x = XafterY(camera.xpos, camera.ypos, camera.zpos, -6);
		_y = YafterY(camera.xpos, camera.ypos, camera.zpos, -6);
		_z = ZafterY(camera.xpos, camera.ypos, camera.zpos, -6);
		camera.xpos = _x;
		camera.ypos = _y;
		camera.zpos = _z;
		
	}

	if (key == GLFW_KEY_R)
	{
		float _x, _y, _z;
		xRot1 += 5;
		//xRot2 +=< 6;
		//xRot3 += 6;
		if (xRot1 >=60)
		{
			xRot1 = 60;
		}
	

	}
	if (key == GLFW_KEY_T)
	{
		float _x, _y, _z;
		xRot1 -= 5;

		if (xRot1 <= -60)
		{
			xRot1 = -60;
		}
		
	}

	if (key == GLFW_KEY_F)
	{
		float _x, _y, _z;
		xRot2 += 5;
		//xRot3 += 6;
		if (xRot2 >= 60)
		{
			xRot2 = 60;
		}
		
	}

	if (key == GLFW_KEY_G)
	{
		float _x, _y, _z;
		xRot2 -= 5;
		//xRot3 -= 6;
		if (xRot2 <= -60)
		{
			xRot2 = -60;
		}
		
	}

	if (key == GLFW_KEY_V)
	{
		float _x, _y, _z;
		xRot3 += 5;
		if (xRot3 >= 60)
		{
			xRot3 = 60;
		}
		
	}
	if (key == GLFW_KEY_B)
	{
		float _x, _y, _z;
		xRot3 -= 5;
		if (xRot3 <= -60)
		{
			xRot3 = -60;
		}
		
	}

	if (key == GLFW_KEY_Y)
	{
		float _x, _y, _z;
		zRot1 += 5;
		if (zRot1 >= 60)
		{
			zRot1 = 60;
		}
		
	}
	if (key == GLFW_KEY_U)
	{
		float _x, _y, _z;
		zRot1 -= 5;
		if (zRot1 <= -60)
		{
			zRot1 = -60;
		}
		
	}

	if (key == GLFW_KEY_H)
	{
		float _x, _y, _z;
		zRot2 += 5;
		if (zRot2 >= 60)
		{
			zRot2 = 60;
		}
		
	}
	if (key == GLFW_KEY_J)
	{
		float _x, _y, _z;
		zRot2 -= 5;
		if (zRot2 <= -60)
		{
			zRot2 = -60;
		}
		
	}

	if (key == GLFW_KEY_N)
	{
		float _x, _y, _z;
		zRot3 += 5;
		if (zRot3 >= 60)
		{
			zRot3 = 60;
		}

	}
	if (key == GLFW_KEY_M)
	{
		float _x, _y, _z;
		zRot3 -= 5;
		if (zRot3 <= -60)
		{
			zRot3 = -60;
		}

	}
	if (key==GLFW_KEY_1)
	{
		xCube++;
	}
	if (key == GLFW_KEY_2)
	{
		xCube--;
	}
}
static void cursor_position_callback(GLFWwindow* window, double xPos, double yPos)
{

	int diffy = yPos - camera.lasty;
	int diffx = xPos - camera.lastx;
	camera.lastx =xPos;
	camera.lasty = yPos;
	camera.xRot1 += (float)diffy;
	camera.yrot += (float)diffx;

}

//////////////////////////////////////////////////
float XafterY(float x, float y, float z, float stopien)
{
	float twicePi = 2.0f * 3.1415926535897;
	float result;
	result = cos(stopien* twicePi / 360)*x + sin(stopien* twicePi / 360)*z;
	return result;
}

float YafterY(float x, float y, float z, float stopien)
{
	float result;
	result = y;
	return result;
}

float ZafterY(float x, float y, float z, float stopien)
{
	float twicePi = 2.0f * 3.1415926535897;
	float result;
	result = -sin(stopien* twicePi / 360)*x + cos(stopien* twicePi / 360)*z;
	return result;
}

//////////////////////////////////////////////////
