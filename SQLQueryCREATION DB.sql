--
-- Utilisation de la base de données
USE Master_ChefDB;
GO

-- Création de la table "table_client"
CREATE TABLE table_client (
                              id_table INT IDENTITY(1,1) PRIMARY KEY,
                              nbr_chaise INT NOT NULL CHECK (nbr_chaise <= 10),
                              nbr_verre INT NOT NULL ,
                              nbr_assiette INT NOT NULL,
                              nbr_pain INT NOT NULL,
                              nbr_couverts INT NOT NULL,
                              nbr_bouteille_eau INT NOT NULL,
                              nbr_bouteille_vin INT NOT NULL,
                              isOccupied  VARCHAR(10) NOT NULL CHECK (isOccupied IN ('oui', 'non'))
);
GO

-- Création de la table "client"
CREATE TABLE client (
                        id_client INT IDENTITY(1,1) PRIMARY KEY,
                        id_table INT NOT NULL,
                        date DATE NOT NULL,
                        reservation VARCHAR(10) NOT NULL CHECK (reservation IN ('oui','non')),
                        FOREIGN KEY (id_table) REFERENCES table_client(id_table)
);
GO

-- Création de la table "reservation"
CREATE TABLE reservation (
                             id_reservation INT IDENTITY(1,1) PRIMARY KEY,
                             id_client INT NOT NULL,
                             id_table INT NOT NULL,
                             FOREIGN KEY (id_client) REFERENCES client (id_client),
                             FOREIGN KEY (id_table) REFERENCES table_client(id_table)
);
GO

-- Création de la table "reserve_salle"
CREATE TABLE reserve_salle (
                               max_verre INT NOT NULL DEFAULT 150 CHECK (max_verre <= 150),
                               max_assiette INT NOT NULL DEFAULT 150 CHECK (max_assiette <= 150),
                               max_pain INT NOT NULL DEFAULT 150 CHECK (max_pain <= 150),
                               max_couverts INT NOT NULL DEFAULT 150 CHECK (max_couverts <= 150),
                               max_bouteille_eau INT NOT NULL DEFAULT 150 CHECK (max_bouteille_eau <= 150),
                               max_bouteille_vin INT NOT NULL DEFAULT 150 CHECK (max_bouteille_vin <= 150)
);
GO

-- Création de la table "identity_reserve"
CREATE TABLE identity_reserve (
                                  id_reserve INT IDENTITY(1,1) PRIMARY KEY,
                                  verre INT NOT NULL DEFAULT 1 ,
                                  assiette INT NOT NULL DEFAULT 1,
                                  couverts INT NOT NULL DEFAULT 1 
);
GO

-- Création de la table "materiel_cuisine"
CREATE TABLE materiel_cuisine (
                                  id_materiel INT IDENTITY(1,1) PRIMARY KEY,
                                  nom_materiel VARCHAR(50) NOT NULL,
                                  max_materiel INT NULL  DEFAULT 50 CHECK (max_materiel <= 50),
                                  nbr_sale INT NULL CHECK (nbr_sale <= 50),
                                  CONSTRAINT CHK_max_materiel CHECK (max_materiel + nbr_sale = '50')
);
GO

-- Création de la table "aliment"
CREATE TABLE aliment (
                         id_aliment INT IDENTITY(1,1) PRIMARY KEY,
                         nom_aliment VARCHAR(50) NOT NULL
);
GO

-- Création de la table "repas"
CREATE TABLE repas (
                       id_repas INT IDENTITY(1,1) PRIMARY KEY,
                       id_aliment INT NOT NULL,
                       id_materiel INT NOT NULL,
                       nom VARCHAR(50) NOT NULL,
                       typ_repas VARCHAR(10) NOT NULL CHECK (typ_repas IN('entrée-plat', 'dessert')),
                       nbr_materiel INT NOT NULL CHECK (nbr_materiel <= 3),
                       FOREIGN KEY (id_aliment) REFERENCES aliment(id_aliment),
                       FOREIGN KEY (id_materiel) REFERENCES  materiel_cuisine(id_materiel)
);
GO

-- Création de la table "commande"
CREATE TABLE commande (
                          id_commande INT IDENTITY(1,1) PRIMARY KEY,
                          id_repas INT NOT NULL,
                          id_table INT NOT NULL,
                          id_client INT NOT NULL,
                          FOREIGN KEY (id_repas) REFERENCES repas(id_repas),
                          FOREIGN KEY (id_table) REFERENCES table_client(id_table),
                          FOREIGN KEY (id_client) REFERENCES client(id_client)
);
GO

-- Création de la table "plonge"
CREATE TABLE plonge (
                        id_plonge INT IDENTITY(1,1) PRIMARY KEY,
                        id_materiel INT NOT NULL,
                        id_reserve  INT NOT NULL,
                        FOREIGN KEY (id_materiel) REFERENCES materiel_cuisine(id_materiel),
                        FOREIGN KEY (id_reserve) REFERENCES identity_reserve(id_reserve)
);
GO

-- Création de la table "stockage_produit"
CREATE TABLE stockage_produit (
                                  id_stocks INT IDENTITY(1,1) PRIMARY KEY,
                                  id_aliment INT NOT NULL,
                                  nom_aliment VARCHAR(50) NOT NULL,
                                  typ_stockage VARCHAR(40) NOT NULL CHECK (typ_stockage IN('Denrée Sec', 'Chambre froid', 'Congelateur')),
                                  max_aliment INT NOT NULL  DEFAULT 200 CHECK (max_aliment = 200),
                                  FOREIGN KEY (id_aliment) REFERENCES aliment(id_aliment) 
);
GO