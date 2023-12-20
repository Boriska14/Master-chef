USE [Master_ChefDB]
GO


CREATE PROCEDURE dbo.InsertCommande
    @id_repas INT,
    @id_client INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @id_table INT;

    -- Récupération de l'id_table associé à l'id_client depuis la table "client"
    SELECT @id_table = id_table
    FROM client
    WHERE id_client = @id_client;

    IF @id_table IS NOT NULL
    BEGIN
        -- Insertion de la commande dans la table "commande"
        INSERT INTO commande (id_repas, id_table, id_client)
        VALUES (@id_repas, @id_table, @id_client);

        PRINT 'La commande a été insérée avec succès.';
    END
    ELSE
    BEGIN
        PRINT 'L''id_client fourni n''est pas valide.';
    END
END;

-- Appeler la procédure stockée InsertCommande avec les paramètres spécifiés
--EXEC dbo.InsertCommande @id_repas = 11, @id_client = 2;

-- Appeler la procédure stockée InsertCommande avec les paramètres spécifiés
--EXEC dbo.InsertCommande @id_repas = 11, @id_client = 10;

