from mpl_toolkits.mplot3d import Axes3D
import matplotlib.pyplot as plt
from mpl_toolkits import mplot3d
import numpy as np
filename='314x1.txt'
with open(filename,'r') as f:
    charachrer=f.read()
xfile=open('x.txt',"w")
yfile=open('y.txt',"w")
zfile=open('z.txt',"w")
length = len(charachrer)
for i in range (0, length, 3):
    xfile.write(charachrer[i])
xfile.close()
for i in range (1, length, 3):
    yfile.write(charachrer[i])
yfile.close()
for i in range (2, length, 3):
    zfile.write(charachrer[i])
zfile.close()

fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')
with open('x.txt',"r") as f1:
    fx=f1.read()
with open('y.txt',"r") as f2:
    fy=f2.read()
with open('z.txt',"r") as f3:
    fz=f3.read()
f1.close()
f2.close()
f3.close()
xx=[]
yy=[]
zz=[]
for nx in fx:
    xx.append(nx)
for item in xx[:]:
    if item == '\n':
        xx.remove(item)
xd = list(map(int, xx))
for ny in fy:
    yy.append(ny)
for item in yy[:]:
    if item == '\n':
        yy.remove(item)
yd = list(map(int, yy))
for nz in fz:
    zz.append(nz)
for item in zz[:]:
    if item == '\n':
        zz.remove(item)
zd = list(map(int, zz))
print(len(xd))
print(len(yd))
print(len(zd))
x =[1,2,3,4,5,6,7,8,9,10]
y =[5,6,2,3,13,4,1,2,4,8]
z =np.array([[2,3,3,3,5,7,9,11,9,10],[2,3,3,3,5,7,9,11,9,10]])
zdd=np.array([zd,zd])
ydd=np.array([yd,yd])
xdd=np.array([xd,xd])
ax.scatter(xd,yd,zd,color="red",s=69)
ax.plot_wireframe(xd, yd, zdd)
#ax.plot_surface(xdd, ydd, zdd)
#ax.plot_wireframe(xd,yd,zdd, rstride=1, cstride=1)
#ax.plot(xd ,yd, zd)
ax.set_xlabel('X Label')
ax.set_ylabel('Y Label')
ax.set_zlabel('Z Label')
plt.show()