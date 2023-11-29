# Créé par paul.martinet, le 13/10/2023 en Python 3.7
from random import*
dé=randint(1,6)
dé2=randint(1,6)
dé3=dé+dé2
print(dé3)
if 7<dé3<10:
    print("tu as gagné")

else :
    print("Tu as perdu")
