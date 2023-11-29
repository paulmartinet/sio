<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contact</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="img/icon.png" />
</head>
<body>

      <div class="topnav">
        <a class="active" href="index.php">Accueil</a>
        <a href="CV.php">CV</a>
        <a href="lettre-de-motivation.php">Lettre de motivation</a>
        <a href="contact.php">Contact</a>
      </div> 

      <p>============================</p>

      <div class="content">
        <h1>Contactez-moi</h1>
        <p>Pour toute question ou demande de renseignements, veuillez utiliser le formulaire de contact ci-dessous.</p>
    
        <form action="send_email.php" method="post">
            <label for="nom">Nom :</label>
            <input type="text" id="nom" name="nom" required>
    
            <label for="email">Email :</label>
            <input type="email" id="email" name="email" required>
    
            <label for="message">Message :</label>
            <textarea id="message" name="message" rows="4" required></textarea>
    
            <input type="submit" value="Envoyer">
        </form>
    </div>
    

      <!-- ======= Début de la section Footer ======= -->
      <footer>
        <small>Copyright © 2023 <a href="paul.php">Paul Martinet</a>. Tous droits réservés.</small>
      </footer><!-- Fin de la catégorie  -->
    
</body>
</html>