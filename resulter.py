import matplotlib.pyplot as plt
import numpy as np
import redo

handle = open("D:/Programming/Project/PoliticalCompass/result.txt", "r")

resultList = []
for line in handle:
    resultList.append(line)
handle.close()

Econ = int(resultList[0])
Auth = int(resultList[1])
"""
X = np.linspace(-Econ,Econ,10)
Y = Auth

plt.plot(X,Y, "o")

plt.show()
"""