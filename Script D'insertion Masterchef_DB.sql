USE Master_ChefDB;
GO

-- Insertions pour la table "table_client"
INSERT INTO table_client (nbr_chaise, nbr_verre, nbr_assiette, nbr_pain, nbr_couverts, nbr_bouteille_eau, nbr_bouteille_vin, isOccupied)
VALUES
(4, 6, 4, 2, 4, 2, 1, 'non'), --1
(4, 4, 4, 4, 4, 4, 1, 'non'), --2
(2, 2, 2, 2, 2, 2, 1, 'non'), --3
(6, 6, 6, 6, 6, 6, 2, 'non'), --4
(8, 8, 8, 8, 8, 8, 3, 'non'), --5
(4, 4, 4, 4, 4, 4, 1, 'non'), --6
(2, 2, 2, 2, 2, 2, 1, 'oui'), --7
(6, 6, 6, 6, 6, 6, 2, 'oui'), --8
(2, 6, 6, 6, 6, 6, 2, 'non'), --9
(4, 4, 4, 4, 4, 4, 1, 'oui'); --10

-- -- Insertions pour la table "client"
-- INSERT INTO client (id_table, date, reservation) VALUES
-- (1, '2023-01-01', 'oui'),
-- (2, '2023-01-02', 'oui'),
-- (3, '2023-01-03', 'oui'),
-- (4, '2023-01-04', 'oui'),
-- (5, '2023-01-05', 'oui'),
-- (6, '2023-01-06', 'oui'),
-- (6, '2023-01-07', 'oui'),
-- (7, '2023-01-08', 'non'),
-- (7, '2023-01-09', 'non'),
-- (8, '2023-01-10', 'non');

-- -- insertion avec appel a la procedure stockée
-- EXEC dbo.InsertClient @id_table = 1, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 2, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 3, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 4, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 5, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 6, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 6, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 7, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 7, @date = '2023-12-19', @reservation = 'oui';
-- EXEC dbo.InsertClient @id_table = 8, @date = '2023-12-19', @reservation = 'non';
-- EXEC dbo.InsertClient @id_table = 9, @date = '2023-12-19', @reservation = 'non';
-- EXEC dbo.InsertClient @id_table = 9, @date = '2023-12-19', @reservation = 'non';
-- EXEC dbo.InsertClient @id_table = 10, @date = '2023-12-19', @reservation = 'non';

-- -- Insertions pour la table "reservation"
-- INSERT INTO reservation (id_client, id_table) VALUES
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , );

-- Insertions pour la table "reserve_salle"
INSERT INTO reserve_salle (max_verre, max_assiette, max_pain, max_couverts, max_bouteille_eau, max_bouteille_vin) VALUES
(150, 150, 150, 150, 150, 150);

-- Insertions pour la table "identity_reserve"
-- INSERT INTO identity_reserve (verre, assiette, couverts) VALUES
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , );
 
-- Insertions pour la table "materiel_cuisine"
INSERT INTO materiel_cuisine (nom_materiel, max_materiel, nbr_sale) VALUES
('Materiel1', 50, 0),
('Materiel2', 50, 0),
('Materiel3', 50, 0),
('Materiel4', 50, 0),
('Materiel5', 50, 0),
('Materiel6', 50, 0),
('Materiel7', 50, 0),
('Materiel8', 50, 0),
('Materiel9', 50, 0),
('Materiel10', 50, 0);

-- Insertions pour la table "aliment"
INSERT INTO aliment (nom_aliment) VALUES
('Aliment1'),
('Aliment2'),
('Aliment3'),
('Aliment4'),
('Aliment5'),
('Aliment6'),
('Aliment7'),
('Aliment8'),
('Aliment9'),
('Aliment10');


-- -- Insertions pour la table "repas"
-- INSERT INTO repas (id_aliment, id_materiel, nom, typ_repas, nbr_materiel) VALUES
-- (1, 1, '', '', 2),
-- (2, 2, '', '', 1),
-- (3, 3, '', '', 3),
-- (4, 4, '', '', 2),
-- (5, 5, '', '', 1),
-- (6, 6, '', '', 2),
-- (7, 7, '', '', 1),
-- (8, 8, '', '', 3),
-- (9, 9, '', '', 2),
-- (10, 10, '', '', 1);

-- -- Insertions pour la table "commande"
-- INSERT INTO commande (id_repas, id_table, id_client) VALUES
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , ),
-- ( , , );

-- -- Insertions pour la table "plonge"
-- INSERT INTO plonge (id_materiel, id_reserve) VALUES
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , ),
-- ( , );

-- Insertions pour la table "stockage_produit"
INSERT INTO stockage_produit (id_aliment, nom_aliment, typ_stockage, max_aliment) VALUES
(1, 'Aliment1', 'Denrée Sec', 200),
(2, 'Aliment2', 'Chambre froid', 200),
(3, 'Aliment3', 'Congelateur', 200),
(4, 'Aliment4', 'Denrée Sec', 200),
(5, 'Aliment5', 'Chambre froid', 200),
(6, 'Aliment6', 'Denrée Sec', 200),
(7, 'Aliment7', 'Chambre froid', 200),
(8, 'Aliment8', 'Congelateur', 200),
(9, 'Aliment9', 'Denrée Sec', 200),
(10, 'Aliment10', 'Chambre froid', 200);