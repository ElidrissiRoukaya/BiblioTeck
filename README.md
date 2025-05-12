<<<<<<< HEAD
# 📚 Application de Gestion de Bibliothèque

Cette simple application web a été développée dans le but de se familiariser avec le framework .NET et de maîtriser les opérations CRUD (Créer, Lire, Mettre à jour, Supprimer). Elle permet de gérer efficacement les livres d'une bibliothèque, les abonnés, ainsi que les emprunts .

Chaque abonné dispose d’un espace personnel sécurisé, accessible après authentification, lui permettant d’emprunter des livres en ligne. Un espace administrateur est également prévu pour la gestion centralisée de la bibliothèque.

## 🛠️ Technologies Utilisées

- **ASP.NET MVC (C#)** : Pour le développement côté serveur.
- **HTML / CSS / Bootstrap** : Pour la conception d'une interface utilisateur responsive et attrayante.
- **MySQL** : Pour la gestion des données et le stockage des informations.

## 🎯 Fonctionnalités Principales

### 📖 Gestion des Livres

- **Affichage des Livres** : Liste complète des livres avec leur statut actuel (Disponible / Emprunté).
- **Ajout / Modification / Suppression** : Possibilité d'ajouter de nouveaux livres, de modifier les informations existantes ou de supprimer des livres de la base de données.
- **Statut des Livres** : Mise à jour automatique du statut en fonction des emprunts et des retours.

### 👥 Gestion des Abonnés

- **Liste des Abonnés** : Affichage de tous les abonnés enregistrés avec leurs informations personnelles.
- **Détails des Emprunts** : Consultation des livres empruntés par chaque abonné.
- **Limitation des Emprunts** : Chaque abonné peut emprunter jusqu'à 2 livres simultanément pour une durée maximale de 2 semaines.

## 🗄️ Structure de la Base de Données

- **Table `Livres`** : Contient les informations sur les livres (titre, auteur, statut, etc.).
- **Table `Abonnés`** : Stocke les données des abonnés (nom, prénom, identifiants de connexion, etc.).
- **Table `Emprunts`** : Enregistre les détails des emprunts (livre, abonné, date d'emprunt, date de retour..).
=======
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
>>>>>>> 92c770d0feb2ddd9c80b368bff42843f30b8fc04
