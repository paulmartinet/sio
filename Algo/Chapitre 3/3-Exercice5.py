# Créé par paul.martinet, le 17/11/2023 en Python 3.7

s = int(input("Déposer sur votre livret d'épargne : "))
n = int(input("Année sur logmentation : "))
for i in range(1,n+1):
    s = s * 1.04
print (s)
