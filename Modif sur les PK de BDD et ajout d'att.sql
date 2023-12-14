-- Modification de la table "table_client"
ALTER TABLE table_client
ADD CONSTRAINT CHK_table_client_id_table
CHECK (id_table LIKE 'TA[0-9][0-9][0-9]');

-- Modification de la table "table_client"
ALTER TABLE table_client
ADD isOccupied  VARCHAR(10) CHECK (isOccupied IN ('oui', 'non'));

-- Modification de la table "client"
ALTER TABLE client
ADD CONSTRAINT CHK_client_id_client
CHECK (id_client LIKE 'CL[0-9][0-9][0-9]');

-- Modification de la table "reservation"
ALTER TABLE reservation
ADD CONSTRAINT CHK_reservation_id_reservation
CHECK (id_reservation LIKE 'RS[0-9][0-9][0-9]');

-- Modification de la table "identity_reserve"
ALTER TABLE identity_reserve
ADD CONSTRAINT CHK_identity_reserve_id_reserve
CHECK (id_reserve LIKE 'IR[0-9][0-9][0-9]');

-- Modification de la table "materiel_cuisine"
ALTER TABLE materiel_cuisine
ADD CONSTRAINT CHK_materiel_cuisine_id_materiel
CHECK (id_materiel LIKE 'MA[0-9][0-9][0-9]');

-- Modification de la table "aliment"
ALTER TABLE aliment
ADD CONSTRAINT CHK_aliment_id_aliment
CHECK (id_aliment LIKE 'AL[0-9][0-9][0-9]');

-- Modification de la table "repas"
ALTER TABLE repas
ADD CONSTRAINT CHK_repas_id_repas
CHECK (id_repas LIKE 'RE[0-9][0-9][0-9]');

-- Modification de la table "stockage_produit"
ALTER TABLE stockage_produit
ADD CONSTRAINT CHK_stockage_produit_id_stocks
CHECK (id_stocks LIKE 'SP[0-9][0-9][0-9]');

-- Modification de la table "commande"
ALTER TABLE commande
ADD id_commande VARCHAR(10) PRIMARY KEY;

-- Ajout de la contrainte de vérification pour "id_commande"
ALTER TABLE commande
ADD CONSTRAINT CHK_commande_id_commande
CHECK (id_commande LIKE 'CD[0-9][0-9][0-9]');

-- Modification de la table "plonge"
ALTER TABLE plonge
ADD id_plonge VARCHAR(10) PRIMARY KEY;


-- Ajout de la contrainte de vérification pour "id_plonge"
ALTER TABLE plonge
ADD CONSTRAINT CHK_plonge_id_plonge
CHECK (id_plonge LIKE 'PL[0-9][0-9][0-9]');