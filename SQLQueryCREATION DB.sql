-- Cr�ation de la table "client"
CREATE TABLE client (
    id_client CHAR(5) PRIMARY KEY,
    date DATE,
    reservation VARCHAR(3)
);

-- Cr�ation de la table "table_client"
CREATE TABLE table_client (
    id_table CHAR(5) PRIMARY KEY,
    id_client CHAR(5) FOREIGN KEY REFERENCES client(id_client),
    nbr_chaise INT CHECK (nbr_chaise <= 10),
    nbr_verre INT,
    nbr_assiette INT,
    nbr_pain INT,
    nbr_couverts INT,
    nbr_bouteille_eau INT,
    nbr_bouteille_vin INT
);

-- Cr�ation de la table "reserve_salle"
CREATE TABLE reserve_salle (
    max_verre INT CHECK (max_verre <= 150),
    max_assiette INT CHECK (max_assiette <= 150),
    max_pain INT CHECK (max_pain <= 150),
    max_couverts INT CHECK (max_couverts <= 150),
    max_bouteille_eau INT CHECK (max_bouteille_eau <= 150),
    max_bouteille_vin INT CHECK (max_bouteille_vin <= 150)
);

-- Cr�ation de la table "identity_reserve"
CREATE TABLE identity_reserve (
    id_reserve CHAR(5) PRIMARY KEY,
    max_verre INT CHECK (max_verre = 1),
    max_assiette INT CHECK (max_assiette = 1),
    max_couverts INT CHECK (max_couverts = 1)
);

-- Cr�ation de la table "materiel_cuisine"
CREATE TABLE materiel_cuisine (
    id_materiel CHAR(5) PRIMARY KEY,
    nom_materiel VARCHAR(255),
    max_materiel INT CHECK (max_materiel <= 50),
    nbr_propre INT,
    nbr_sale INT,
    CONSTRAINT CHK_nbr_propre CHECK (nbr_propre + nbr_sale = max_materiel)
);

-- Cr�ation de la table "aliment"
CREATE TABLE aliment (
    id_aliment CHAR(5) PRIMARY KEY,
    nom_aliment VARCHAR(255)
);

-- Cr�ation de la table "repas"
CREATE TABLE repas (
    id_repas CHAR(5) PRIMARY KEY,
    id_aliment CHAR(5) FOREIGN KEY REFERENCES aliment(id_aliment),
    id_materiel CHAR(5) FOREIGN KEY REFERENCES materiel_cuisine(id_materiel),
    nom VARCHAR(255),
    typ_repas VARCHAR(20),
    nbr_materiel INT CHECK (nbr_materiel <= 3)
);

-- Cr�ation de la table "commande"
CREATE TABLE commande (
    id_repas CHAR(5) FOREIGN KEY REFERENCES repas(id_repas),
    id_table CHAR(5) FOREIGN KEY REFERENCES table_client(id_table),
    id_client CHAR(5) FOREIGN KEY REFERENCES client(id_client)
);

-- Cr�ation de la table "plonge"
CREATE TABLE plonge (
    id_materiel CHAR(5) FOREIGN KEY REFERENCES materiel_cuisine(id_materiel),
    id_reserve CHAR(5) FOREIGN KEY REFERENCES identity_reserve(id_reserve)
);

-- Cr�ation de la table "stockage_produit"
CREATE TABLE stockage_produit (
    id_stocks CHAR(5) PRIMARY KEY,
    id_aliment CHAR(5) FOREIGN KEY REFERENCES aliment(id_aliment),
    nom_aliment VARCHAR(255),
    typ_stockage VARCHAR(20),
    max_aliment INT CHECK (max_aliment <= 150)
);