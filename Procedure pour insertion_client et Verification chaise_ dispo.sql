-- Utilisation de la base de donn�es
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

    -- V�rification si la table est occup�e
    SELECT @isOccupied = isOccupied, @availableChairs = nbr_chaise
    FROM table_client
    WHERE id_table = @id_table;

    -- V�rification du nombre d'insertions d�j� effectu�es
    SELECT @currentlyUsed = COUNT(*)
    FROM client
    WHERE id_table = @id_table;

     IF  @isOccupied = 'non'
		 BEGIN
				IF @currentlyUsed < @availableChairs  --comparaisons du nombre de fois client est ins�r� avec nbr_chaise
					BEGIN
						-- Mise � jour de l'attribut isOccupied � 'oui'
						UPDATE table_client
						SET isOccupied = 'oui'
						WHERE id_table = @id_table;

						-- Insertion du nouveau client dans la table client
						INSERT INTO client (id_table, date, reservation)
						VALUES (@id_table, @date, @reservation);

						PRINT 'Le client a �t� ins�r� avec succ�s et l''�tat de la table a �t� mis � jour.';
					END
					ELSE
					BEGIN
						-- Le nombre d'insertions d�passe le nombre de chaises disponibles
						PRINT 'D�sol�, la table est d�j� pleine.';
					END
         END
    ELSE
		IF  @isOccupied = 'oui'
			BEGIN
				IF @currentlyUsed < @availableChairs  --comparaisons du nombre de fois client est ins�r� avec nbr_chaise
					BEGIN
						-- Insertion du nouveau client dans la table client
						INSERT INTO client (id_table, date, reservation)
						VALUES (@id_table, @date, @reservation);
						-- La table est d�j� utilis�e, affichage du message d'erreur
						PRINT 'La table est d�j� utilis�e.';
					END
					ELSE
					BEGIN
						-- Le nombre d'insertions d�passe le nombre de chaises disponibles
						PRINT 'D�sol�, la table est d�j� pleine.';
					END
		END

END;
--EXEC dbo.InsertClient @id_table = 1, @date = '2023-12-19', @reservation = 'oui';