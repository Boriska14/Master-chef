1

USE Master_ChefDB;
GO

CREATE TRIGGER trg_table_client_insert
ON table_client
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_table VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_table = 'TA' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE table_client
    SET id_table = @id_table
    FROM inserted
    WHERE table_client.id_table IS NULL -- Uniquement pour les insertions manuelles

END;
**********************
2

USE Master_ChefDB;
GO

CREATE TRIGGER trg_client_insert
ON client
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_client VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_client = 'CL' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE client
    SET id_client = @id_client
    FROM inserted
    WHERE client.id_client IS NULL -- Uniquement pour les insertions manuelles

END;
**********************
3

USE Master_ChefDB;
GO

CREATE TRIGGER trg_reservation_insert
ON reservation
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_reservation VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_reservation = 'RS' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE reservation
    SET id_reservation = @id_reservation
    FROM inserted
    WHERE reservation.id_reservation IS NULL -- Uniquement pour les insertions manuelles

END;
************************
4

USE Master_ChefDB;
GO

CREATE TRIGGER trg_reserve_insert
ON identity_reserve
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_reserve VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_reserve = 'IR' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE identity_reserve
    SET id_reserve = @id_reserve
    FROM inserted
    WHERE identity_reserve.id_reserve IS NULL -- Uniquement pour les insertions manuelles

END;
************************
5

USE Master_ChefDB;
GO

CREATE TRIGGER trg_materiel_insert
ON materiel_cuisine
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_materiel VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_materiel = 'MA' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE materiel_cuisine
    SET id_materiel = @id_materiel
    FROM inserted
    WHERE materiel_cuisine.id_materiel IS NULL -- Uniquement pour les insertions manuelles

END;
**********************
6

USE Master_ChefDB;
GO

CREATE TRIGGER trg_aliment_insert
ON aliment
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_aliment VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_aliment = 'AL' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE aliment
    SET id_aliment = @id_aliment
    FROM inserted
    WHERE aliment.id_aliment IS NULL -- Uniquement pour les insertions manuelles

END;
*********************
7

USE Master_ChefDB;
GO

CREATE TRIGGER trg_repas_insert
ON repas
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_repas VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_repas = 'RE' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE repas
    SET id_repas = @id_repas
    FROM inserted
    WHERE repas.id_repas IS NULL -- Uniquement pour les insertions manuelles

END;
******************
8

USE Master_ChefDB;
GO

CREATE TRIGGER trg_stockage_produit_insert
ON stockage_produit
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_stocks VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_stocks = 'SP' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE stockage_produit
    SET id_stocks = @id_stocks
    FROM inserted
    WHERE stockage_produit.id_stocks IS NULL -- Uniquement pour les insertions manuelles

END;
*****************
9

USE Master_ChefDB;
GO

CREATE TRIGGER trg_commande_insert
ON commande
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_commande VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_commande = 'CD' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE commande
    SET id_commande = @id_commande
    FROM inserted
    WHERE commande.id_commande IS NULL -- Uniquement pour les insertions manuelles

END;
********************
10

USE Master_ChefDB;
GO

CREATE TRIGGER trg_plonge_insert
ON plonge
FOR INSERT
AS
BEGIN
    DECLARE @nextId INT;
    DECLARE @id_plonge VARCHAR(10);

    -- Récupérer le prochain identifiant à partir de la séquence
    SET @nextId = NEXT VALUE FOR Myid_tables_SequenceA;

    -- Générer la valeur de l'attribut id_table dans le format "TAxxx"
    SET @id_plonge = 'PL' + RIGHT('000' + CAST(@nextId AS VARCHAR(3)), 3);

    -- Mettre à jour l'attribut id_table pour les lignes insérées
    UPDATE plonge
    SET id_plonge = @id_plonge
    FROM inserted
    WHERE plonge.id_plonge IS NULL -- Uniquement pour les insertions manuelles

END;