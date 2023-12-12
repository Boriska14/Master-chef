-- Utilisation de la base de données
USE Master_ChefDB;
GO

-- Création de la table "table_client"
CREATE TABLE table_client (
                              id_table VARCHAR(10) PRIMARY KEY,
                              nbr_chaise INT CHECK (nbr_chaise <= 10),
                              nbr_verre INT,
                              nbr_assiette INT,
                              nbr_pain INT,
                              nbr_couverts INT,
                              nbr_bouteille_eau INT,
                              nbr_bouteille_vin INT
);
GO

-- Création de la table "client"
CREATE TABLE client (
                        id_client VARCHAR(10) PRIMARY KEY,
                        id_table VARCHAR(10) FOREIGN KEY REFERENCES table_client(id_table),
                        date DATE,
                        reservation VARCHAR(10) CHECK (reservation IN ('oui','non'))
);
GO

-- Création de la table "reservation"
CREATE TABLE reservation (
                             id_reservation VARCHAR(10) PRIMARY KEY,
                             id_client VARCHAR(10) FOREIGN KEY REFERENCES client (id_client),
                             id_table VARCHAR(10) FOREIGN KEY REFERENCES table_client(id_table)
);
GO

-- Création de la table "reserve_salle"
CREATE TABLE reserve_salle (
                               max_verre INT DEFAULT 150 CHECK (max_verre <= 150),
                               max_assiette INT DEFAULT 150 CHECK (max_assiette <= 150),
                               max_pain INT DEFAULT 150 CHECK (max_pain <= 150),
                               max_couverts INT DEFAULT 150 CHECK (max_couverts <= 150),
                               max_bouteille_eau INT DEFAULT 150 CHECK (max_bouteille_eau <= 150),
                               max_bouteille_vin INT DEFAULT 150 CHECK (max_bouteille_vin <= 150)
);
GO

-- Création de la table "identity_reserve"
CREATE TABLE identity_reserve (
                                  id_reserve VARCHAR(10) PRIMARY KEY,
                                  verre INT DEFAULT 1 ,
                                  assiette INT DEFAULT 1,
                                  couverts INT DEFAULT 1
);
GO

-- Création de la table "materiel_cuisine"
CREATE TABLE materiel_cuisine (
                                  id_materiel VARCHAR(10) PRIMARY KEY,
                                  nom_materiel VARCHAR(50),
                                  max_materiel INT DEFAULT 50 CHECK (max_materiel <= 50),
                                  nbr_sale INT CHECK (nbr_sale <= 50),
                                  CONSTRAINT CHK_max_materiel CHECK (max_materiel + nbr_sale = '50')
);
GO

-- Création de la table "aliment"
CREATE TABLE aliment (
                         id_aliment VARCHAR(10) PRIMARY KEY,
                         nom_aliment VARCHAR(50)
);
GO

-- Création de la table "repas"
CREATE TABLE repas (
                       id_repas VARCHAR(10) PRIMARY KEY,
                       id_aliment VARCHAR(10) FOREIGN KEY REFERENCES aliment(id_aliment),
                       id_materiel VARCHAR(10) FOREIGN KEY REFERENCES materiel_cuisine(id_materiel),
                       nom VARCHAR(50),
                       typ_repas VARCHAR(10) CHECK (typ_repas IN('entrée-plat', 'dessert')),
                       nbr_materiel INT CHECK (nbr_materiel <= 3)
);
GO

-- Création de la table "commande"
CREATE TABLE commande (
                          id_repas VARCHAR(10) FOREIGN KEY REFERENCES repas(id_repas),
                          id_table VARCHAR(10) FOREIGN KEY REFERENCES table_client(id_table),
                          id_client VARCHAR(10) FOREIGN KEY REFERENCES client(id_client)
);
GO

-- Création de la table "plonge"
CREATE TABLE plonge (
                        id_materiel VARCHAR(10) FOREIGN KEY REFERENCES materiel_cuisine(id_materiel),
                        id_reserve VARCHAR(10) FOREIGN KEY REFERENCES identity_reserve(id_reserve)
);
GO

-- Création de la table "stockage_produit"
CREATE TABLE stockage_produit (
                                  id_stocks VARCHAR(10) PRIMARY KEY,
                                  id_aliment VARCHAR(10) FOREIGN KEY REFERENCES aliment(id_aliment),
                                  nom_aliment VARCHAR(50),
                                  typ_stockage VARCHAR(10) CHECK (typ_stockage IN('Denrée Sec', 'Chambre froid', 'Congelateur')),
                                  max_aliment INT DEFAULT 200 CHECK (max_aliment = 200)
);
GO