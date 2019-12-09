import matplotlib.pyplot as plt
from matplotlib import pylab, patches
import numpy as np
import os

handle = open(r"D:\Programming\Project\PoliticalCompass\PoliticalCompass\bin\Release\db\result.txt", "r")

resultList = []
for line in handle:
    resultList.append(line)
handle.close()

Econ = int(resultList[0])
Auth = int(resultList[1])

X = np.linspace(Econ,Econ,1)
Y = Auth

plt.plot(X,Y, "ko")

#Какая-то штука для управления осями
ax = plt.gca()

#Смещаем оси в центр и убираем рамки
ax.xaxis.get_major_ticks()
ax.spines['left'].set_visible(False)
ax.spines['bottom'].set_visible(False)
ax.spines['top'].set_position('center')
ax.spines['right'].set_position('center')

#Убираем значения и деления на осяхх
for tick in ax.yaxis.get_major_ticks():
    tick.label1On = False
    tick.label2On = False
    tick.tick1line.set_color('white')
    
for tick in ax.xaxis.get_major_ticks():
    tick.label1On = False
    tick.label2On = False
    tick.tick1line.set_color('white')

ax.yaxis.set_label_position('left')
ax.set_ylabel(u'Экономическая ось')

ax.xaxis.set_label_position('bottom')
ax.set_xlabel(u'Авторитарная ось')

#Красим квадрант комунистов
quadr_comm = patches.Rectangle((0, 0), -30, 30, color='#FF0000')
ax.add_patch(quadr_comm)

#Красим квадрант фашистов
quadr_fash = patches.Rectangle((0, 0), 30, 30, color='#009966')
ax.add_patch(quadr_fash)

#Красим квадрант либеральных леваков
quadr_llib = patches.Rectangle((0, 0), -30, -30, color='#0099CC')
ax.add_patch(quadr_llib)

#Красим квадрант правых либералов
quadr_rlib = patches.Rectangle((0, 0), 30, -30, color='#FFCC00')
ax.add_patch(quadr_rlib)

#На графике будет показан только участок от -32 до 32 по оси X
pylab.xlim (-30, 30)

#На графике будет показан участок от -32 до 32 по оси Y
pylab.ylim (-30, 30)
plt.show()