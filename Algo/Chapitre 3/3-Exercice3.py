# Créé par paul.martinet, le 10/11/2023 en Python 3.7
n = int(input("Veuillez saisir une valeur numérique positive : "))

if n >= 0:
    for i in range(n, -1, -1):
        print(i)
