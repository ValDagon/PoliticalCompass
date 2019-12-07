import matplotlib.pyplot as plt
from matplotlib import pylab
import numpy as np

handle = open("db/result.txt", "r")

resultList = []
for line in handle:
    resultList.append(line)
handle.close()

Econ = int(resultList[0])
Auth = int(resultList[1])

X = np.linspace(Econ,Econ,1)
Y = Auth

plt.plot(X,Y, "o")

ax = plt.gca()
ax.spines['left'].set_position('center')
ax.spines['bottom'].set_position('center')
ax.spines['top'].set_visible(False)
ax.spines['right'].set_visible(False)
# !!! На графике будет показан только участок от -32 до 32 по оси X
pylab.xlim (-32, 32)

# !!! На графике будет показан участок от -32 до 32 по оси Y
pylab.ylim (-32, 32)
plt.show()