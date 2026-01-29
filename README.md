# Wiki

## User
Représente les utilisateurs du Wiki.

| Champ    | Type    | Description                |
|----------|---------|----------------------------|
| id       | INT     | Identifiant unique         |
| nom      | STRING  | Nom de l'utilisateur       |
| password | STRING  | Mot de passe               |
| role     | STRING  | Rôle de l'utilisateur (ex : admin, éditeur, lecteur) |

## Article
Représente un article du Wiki.

| Champ     | Type   | Description                        |
|-----------|--------|------------------------------------|
| id        | INT    | Identifiant unique                 |
| nom       | STRING | Nom de l'article                   |
| contenu   | STRING | Contenu de l'article               |
| auteur    | INT    | Référence à l'ID de l'utilisateur (User) |
| categorie | INT    | Référence à l'ID de la catégorie (Categorie) |

## Categorie
Représente les catégories d'articles.

| Champ | Type   | Description            |
|-------|--------|------------------------|
| id    | INT    | Identifiant unique     |
| nom   | STRING | Nom de la catégorie    |
