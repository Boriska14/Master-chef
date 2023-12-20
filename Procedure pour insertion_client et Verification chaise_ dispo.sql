-- Utilisation de la base de données
USE Master_ChefDB;
GO

CREATE PROCEDURE dbo.InsertClient
    @id_table INT,
    @date DATE,
    @reservation VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @isOccupied VARCHAR(10);
    DECLARE @availableChairs INT;
    DECLARE @currentlyUsed INT;

    -- Vérification si la table est occupée
    SELECT @isOccupied = isOccupied, @availableChairs = nbr_chaise
    FROM table_client
    WHERE id_table = @id_table;

    -- Vérification du nombre d'insertions déjà effectuées
    SELECT @currentlyUsed = COUNT(*)
    FROM client
    WHERE id_table = @id_table;

     IF  @isOccupied = 'non'
		 BEGIN
				IF @currentlyUsed < @availableChairs  --comparaisons du nombre de fois client est inséré avec nbr_chaise
					BEGIN
						-- Mise à jour de l'attribut isOccupied à 'oui'
						UPDATE table_client
						SET isOccupied = 'oui'
						WHERE id_table = @id_table;

						-- Insertion du nouveau client dans la table client
						INSERT INTO client (id_table, date, reservation)
						VALUES (@id_table, @date, @reservation);

						PRINT 'Le client a été inséré avec succès et l''état de la table a été mis à jour.';
					END
					ELSE
					BEGIN
						-- Le nombre d'insertions dépasse le nombre de chaises disponibles
						PRINT 'Désolé, la table est déjà pleine.';
					END
         END
    ELSE
		IF  @isOccupied = 'oui'
			BEGIN
				IF @currentlyUsed < @availableChairs  --comparaisons du nombre de fois client est inséré avec nbr_chaise
					BEGIN
						-- Insertion du nouveau client dans la table client
						INSERT INTO client (id_table, date, reservation)
						VALUES (@id_table, @date, @reservation);
						-- La table est déjà utilisée, affichage du message d'erreur
						PRINT 'La table est déjà utilisée.';
					END
					ELSE
					BEGIN
						-- Le nombre d'insertions dépasse le nombre de chaises disponibles
						PRINT 'Désolé, la table est déjà pleine.';
					END
		END

END;
--EXEC dbo.InsertClient @id_table = 1, @date = '2023-12-19', @reservation = 'oui';