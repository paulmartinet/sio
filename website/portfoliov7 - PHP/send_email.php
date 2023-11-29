<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Récupérer les données du formulaire
    $nom = $_POST['nom'];
    $email = $_POST['email'];
    $message = $_POST['message'];

    // Adresse email de destination
    $destinataire = "paul.martinet34@gmail.com"; // Remplacez ceci par votre adresse email

    // Sujet de l'email
    $sujet = "Nouveau message de $nom";

    // Contenu de l'email
    $contenu = "Nom: $nom\n";
    $contenu .= "Email: $email\n\n";
    $contenu .= "Message:\n$message";

    // En-têtes de l'email
    $headers = "From: $email \r\n";
    $headers .= "Reply-To: $email \r\n";

    // Envoi de l'email
    if (mail($destinataire, $sujet, $contenu, $headers)) {
        echo "Votre message a été envoyé avec succès.";
    } else {
        echo "Une erreur s'est produite lors de l'envoi du message.";
    }
} else {
    echo "Une erreur s'est produite. Veuillez réessayer.";
}
?>
