# Créé par paul.martinet, le 17/11/2023 en Python 3.7

n = int(input("Veuillez saisir la valeur d'une variable n : "))

print(f"Table de multiplication de {n} :")
for i in range(1, 11):
    result = n * i
    print(f"{n} x {i} = {result}")
