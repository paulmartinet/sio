#Boucle For
for numéro in range(1, 5):
    print("Vous etes le numéro", numéro)

#Boucle For each
emails = ["paul.swifer@gmail.com", "paul.martinet34@gmail.com", "paul.alan.martinet@gmail.com"] #Listes des emails

blacklist = ["swifer@gmail.com", "paul.swifer@gmail.com", "lechat@lechat.sio"] #Listes des emails qui sont blacklist

for email in emails:

    if email in blacklist:
        print("Email {} Interdit ! l'envoie est impossible car cette email est blacklist".format(email))
        break #pour casser la boucle ou "continue" pour que les emails qui ne sont pas blacklist soit afficher 
    
    print("Email envoyé à : ", email)

#Boucle While
salaire = 1500

while salaire <=4000:

    salaire += 150

    print("Votre salaire est de", salaire, "euros")

print("Le salaire final est de 2100 après augmentation")