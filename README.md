# Application de Gestion de Bibliothèque

Cette application simple a été développée pour se familiariser avec le framework .NET, en utilisant C#, CSS, HTML, MySQL et Bootstrap pour l'interface utilisateur. Elle permet de gérer les livres d'une bibliothèque, ainsi que les emprunts et retours de livres.

## Fonctionnalités principales :

- **Affichage des livres** : L'application affiche la liste des livres avec leur état actuel (Disponible / Emprunté).
- **Table Livres** : Les informations sur les livres sont stockées dans une base de données MySQL dans une table "Livres".
- **Gestion de l'état des livres** : Chaque livre a un statut indiquant s'il est disponible ou emprunté.
- **Liste des abonnés** : L'application affiche la liste des abonnés avec un bouton pour consulter les livres qu'ils ont empruntés et non encore restitués.
- **Table Abonnés** : Les informations sur les abonnés sont stockées dans une table "Abonnés" dans la base de données.
- **Emprunt de livres** : L'application permet d'emprunter un livre disponible et de le marquer comme emprunté.
- **Table Emprunts** : Les informations sur les emprunts (livres, dates, abonnés) sont stockées dans une table "Emprunts".
- **Limitation des emprunts** : Un abonné peut emprunter jusqu'à 2 livres à la fois, et la durée de l'emprunt est limitée à 2 semaines.
- **Restitution des livres** : Les livres empruntés peuvent être restitués, ce qui met à jour le statut du livre et l'entrée dans la table "Emprunts".
- **Limitation du nombre d'emprunts** : Un abonné ne peut pas emprunter plus de 2 livres en même temps.

## Technologies utilisées :

- **.NET (C#)** : Pour le développement de l'application.
- **HTML / CSS** : Pour la présentation et le style de l'interface utilisateur.
- **Bootstrap** : Utilisé pour créer une interface responsive et attrayante.
- **MySQL** : Pour la gestion des données dans la base de données.
