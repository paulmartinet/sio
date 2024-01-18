password = input("Entrer votre mot de passe ")
password_length = len (password)

if password_length < 8:
    print("Mot de passe hackable")

elif 8 < password_length <=12:
    print("Mot de passe un peu sécurisé car il contient que " + str(password_length))

else:
    print("Mot de passe très sécurisé car il contient " + str(password_length) + " caractères. Bon travail !")