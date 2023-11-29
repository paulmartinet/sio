
--
-- Base de données :   GestNotes 
--
CREATE DATABASE SIO1_GestNotes2;
USE SIO1_GestNotes2;


-- --------------------------------------------------------

--
-- Structure de la table  appreciation 
--

CREATE TABLE Appreciation (
	libelle  varchar(50) NOT NULL DEFAULT '',
	noteMini  int NOT NULL DEFAULT '0',
	noteMaxi  int NOT NULL DEFAULT '0',
	CONSTRAINT PK_appreciation PRIMARY KEY ( libelle )
) ;

--
-- Contenu de la table  appreciation 
--

INSERT INTO  appreciation VALUES
	('bon travail', 13, 15),
	('insuffisant', 8, 9),
	('moyen', 10, 12),
	('très bien', 15, 20),
	('très insuffisant', 0, 7);

-- --------------------------------------------------------

--
-- Structure de la table  classe 
--

CREATE TABLE classe  (
	id  int NOT NULL DEFAULT '0',
	nom  varchar(15) DEFAULT '',
	postBac  varchar(1) DEFAULT '',
	txReussiteAnnee_1  decimal(10,2) DEFAULT '0.00',
	txReussiteAnnee_2  decimal(10,2) DEFAULT '0.00',
	CONSTRAINT PK_classe PRIMARY KEY (id)
) ;

--
-- Contenu de la table  classe 
--

INSERT INTO  classe  VALUES
	(1, 'SIO1', 'o', '0.70', '0.80'),
	(2, 'SIOSLAM', 'o', '0.70', '1'),
	(3, 'SIOSISR', 'o', '0.70', '0.80'),
	(4, 'SIG', 'n', '0.80', '0.90'),
	(5, 'TS', 'n', '0.50', '0.60');

-- --------------------------------------------------------

--
-- Structure de la table  eleve 
--

CREATE TABLE eleve (
   id  int NOT NULL DEFAULT '0',
   nom  varchar(50) DEFAULT '',
   dateNaiss date DEFAULT NULL,
   ville  varchar(50) DEFAULT '',
   idClasse  int NOT NULL DEFAULT '0',
  CONSTRAINT PK_eleve PRIMARY KEY ( id ),
  CONSTRAINT  FK_eleve_classe  FOREIGN KEY (idClasse) REFERENCES  classe(id)
) ;

--
-- Contenu de la table  eleve 
--

INSERT INTO  eleve VALUES
	(1,  'moulin', '2000-10-04', 'Béziers', 1),
	(2,  'mermoz', '2003-12-03', 'Montpellier', 1),
	(3,  'lurcat', '2004-01-09', 'Béziers', 1),
	(4,  'linux',  '2000-03-03', 'Paris', 2),
	(5,  'unix',   '2002-01-31',  NULL, 2),
	(6,  'daspet', '2003-12-04', 'Béziers', 2),
	(7,  'webig',  '2004-02-02', 'Montpellier', 3),
	(8,  'azerty', '2005-06-08', 'Béziers', 4),
	(9,  'dupond', '2005-08-06', 'Béziers', 4),
	(10, 'dupert', '2006-06-08', 'Béziers', 4),
	(11, 'dupire',  NULL,		 'Béziers', 4),
	(12, 'dupol',   NULL,		 'Béziers', 3);

-- --------------------------------------------------------

--
-- Structure de la table  matiere 
--

CREATE TABLE matiere  (
   id  int NOT NULL DEFAULT '0',
   nom  varchar(50) DEFAULT '',
  PRIMARY KEY ( id )
) ;

--
-- Contenu de la table  matiere 
--

INSERT INTO  matiere VALUES
	(1, 'Base De Données'),
	(2, 'Programmation'),
	(3, 'Cybersécurité'),
	(4, 'Système d''exploitation'),
	(5, 'Administration Réseau'),
	(6, 'SIG'),
	(7, 'NSI');

-- --------------------------------------------------------

--
-- Structure de la table  notation 
--

CREATE TABLE   notation  (
   idEleve  int NOT NULL DEFAULT '0',
   idMatiere  int NOT NULL DEFAULT '0',
   dateControle  date NOT NULL,
   note  int NOT NULL DEFAULT '0',
  PRIMARY KEY ( idEleve , idMatiere , dateControle ),
  CONSTRAINT FK_note_eleve   FOREIGN KEY  (idEleve) REFERENCES eleve(id),
  CONSTRAINT FK_note_matiere FOREIGN KEY  (idMatiere) REFERENCES matiere(id)
) ;

--
-- Contenu de la table  notation 
--

INSERT INTO  notation  VALUES
	(2, 1, '2021-05-30', 18),
	(2, 1, '2021-12-30', 7),
	(2, 2, '2021-03-30', 12),
	(2, 2, '2021-06-12', 19),
	(2, 3, '2021-04-30', 11),
	(2, 3, '2021-06-30', 10),
	(2, 4, '2021-07-30', 13),
	(3, 1, '2021-01-30', 11),
	(3, 1, '2021-01-31', 13),
	(3, 1, '2021-02-28', 11),
	(3, 2, '2021-01-21', 5),
	(3, 2, '2021-01-30', 8),
	(4, 1, '2021-01-30', 19),
	(4, 2, '2021-01-30', 2),
	(4, 2, '2021-11-30', 16),
	(4, 4, '2021-11-30', 18),
	(4, 4, '2021-12-30', 13),
	(5, 1, '2021-01-30', 10),
	(5, 1, '2021-06-30', 1),
	(8, 6, '2021-10-02', 12),
	(9, 6, '2021-10-02',14),
	(8, 6, '2022-09-10', 12),
	(9, 6, '2022-09-10',14);

-- MISE A JOUR DES DATES
-- NbJours : nombre de jours ajoutés par rapport à 2023

/*
update eleve
set dateNaiss=adddate(dateNaiss, INTERVAL NbJours YEAR);

update notation
set dateControle=adddate(dateControle, INTERVAL NbJours YEAR);

*/