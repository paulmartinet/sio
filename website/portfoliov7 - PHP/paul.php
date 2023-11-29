<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>About</title>
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link rel="icon" href="img/icon.png" />
    <style>

        body {
            font-family: 'cursive', sans-serif;
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            background-color: gray;
            display: flex;
            align-items: center;
            justify-content: center;
            height: 70vh;
        }

        .container {
            width: 35%;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 626px;
            margin: 90px;
        }

        p {
            text-align: center;
            color: black;
            font-weight: bold;
            font-family: cursive;
        }

        .social-links {
            text-align: center;
            margin-top: 20px;
        }

        .social-links a {
            display: inline-block;
            margin: 5px;
            text-decoration: none;
            color: #333;
            font-family: cursive;
        }

        @media screen and (max-width: 768px) {
            body {
                height: auto;
            }
            
            .container {
                width: 80%;
            }
        }

        @media screen and (max-width: 480px) {
            .container {
                width: 90%;
            }
        }


    </style>
</head>
<body>

    <div class="topnav">
        <a class="active" href="index.php">Accueil</a>
        <a href="CV.php">CV</a>
        <a href="lettre-de-motivation.php">Lettre de motivation</a>
        <a href="contact.php">Contact</a>
      </div> 

    <br>

    <br>

    <div class="container">
        <p>Paul Martinet | 18 ans | Développeur Rust, C#, HTML/CSS, JavaScript et PHP</p>

        <p>Mes réseaux sociaux :</p>

        <div class="social-links">
            <a href="https://www.github.com/paulmartinet">👉 Suivez-moi sur Github</a><br />
            <a href="https://www.instagram.com/paulmartinet34">👉 Suivez-moi sur Instagram</a><br />
            <a href="https://fr.linkedin.com/in/paul-martinet-a6b72925a">👉 Suivez-moi sur LinkedIn</a><br />
            <a href="mailto:paul.martinet34@gmail.com">Cliquer ici pour m'envoyer un mail</a>
        </div>
    </div>

    <!-- ======= Début de la section Footer ======= -->
    <footer>
        <small>Copyright © 2023 <a href="paul.php">Paul Martinet</a>. Tous droits réservés.</small>
      </footer><!-- Fin de la catégorie  -->

</body>
</html>
