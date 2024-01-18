wallet = 500
computer_price = 1000

if computer_price <= wallet:
    print("Achat du PC effectué")
    wallet -= computer_price
    print("Il vous reste " + str(wallet) + (" euros sur votre wallet"))
else:
    print("Nous n'avons pas assez d'argent pour acheter ce PC vous avez que " + str(wallet) + (" euros sur votre wallet !"))