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
