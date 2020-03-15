DROP DATABASE IF EXISTS pausenmodell;
CREATE DATABASE pausenmodell;
USE pausenmodell;



create table Tbl_Lehrer
(
	L_Kuerzel		 	varchar(5),     		PRIMARY KEY (L_Kuerzel),
	L_Name			 	varchar(20),	  
	L_Passwort	     	varchar(20)
)	ENGINE = INNODB;


create table Tbl_Klassen
(
	K_ID			 	int(10)					NOT NULL AUTO_INCREMENT ,      PRIMARY KEY (K_ID),
	K_Name			 	varchar(20),	  
	L_Kuerzel	     	varchar(5),     		FOREIGN KEY (L_Kuerzel) REFERENCES Tbl_Lehrer (L_Kuerzel)
)	ENGINE=InnoDB;


create table Tbl_Schueler
(	
	S_Matrikelnummer 	varchar(20),			PRIMARY KEY (S_Matrikelnummer),
	S_Passwort			varchar(20),
	S_Nachname		 	varchar(20),
	S_Name			 	varchar(20),	  
	K_ID	     	    int(10),				FOREIGN KEY (K_ID) REFERENCES Tbl_Klassen (K_ID)
)	ENGINE=InnoDB;


create table Tbl_Anwesenheit
(
	R_ID				varchar(10),		    PRIMARY KEY (R_ID),
	S_Matrikelnummer	varchar(20), 			FOREIGN KEY (S_Matrikelnummer) REFERENCES Tbl_Schueler (S_Matrikelnummer),
	S_Passwort			varchar(20),
	A_Ankunft			datetime,
	A_Feierabend		datetime
)	ENGINE=InnoDB;


create table Tbl_Pausen
(
	P_ID			 	int(10) 				NOT NULL AUTO_INCREMENT,			 PRIMARY KEY (P_ID),		
	S_Matrikelnummer	varchar(20),	 		FOREIGN KEY (S_Matrikelnummer) REFERENCES Tbl_Schueler (S_Matrikelnummer),
	P_Datum	     		date,
	P_Max_Pausenlaenge  varchar(20),
	P_Aufenthaltsort	varchar(20)
)	ENGINE=InnoDB;



SELECT * FROM Tbl_Lehrer;
INSERT INTO `Tbl_Lehrer`(`L_Kuerzel`, `L_Name`, `L_Passwort`) VALUES ("MA","Maier","maier123");
INSERT INTO `Tbl_Lehrer`(`L_Kuerzel`, `L_Name`, `L_Passwort`) VALUES ("SCH","Schmitz","schmitzi246");
INSERT INTO `Tbl_Lehrer`(`L_Kuerzel`, `L_Name`, `L_Passwort`) VALUES ("KL","Klüttermann","klütterschen123");
INSERT INTO `Tbl_Lehrer`(`L_Kuerzel`, `L_Name`, `L_Passwort`) VALUES ("EN","Engelhardt","engel123");


SELECT * FROM Tbl_Klassen;
INSERT INTO `Tbl_Klassen`(`K_Name`, `L_Kuerzel`) VALUES ("AIT21V","MA");
INSERT INTO `Tbl_Klassen`(`K_Name`, `L_Kuerzel`) VALUES ("AIT22V","SCH");
INSERT INTO `Tbl_Klassen`(`K_Name`, `L_Kuerzel`) VALUES ("AIT21V","KL");


SELECT * FROM Tbl_Schueler;
INSERT INTO `Tbl_Schueler`(`S_Matrikelnummer`, `S_Passwort`, `S_Nachname`, `S_Name`, `K_ID`) VALUES ("8218101964","schueler123","Müller","Peter","1");
INSERT INTO `Tbl_Schueler`(`S_Matrikelnummer`, `S_Passwort`, `S_Nachname`, `S_Name`, `K_ID`) VALUES ("5218101964","schueler456","Cunha","Matheus","2");
INSERT INTO `Tbl_Schueler`(`S_Matrikelnummer`, `S_Passwort`, `S_Nachname`, `S_Name`, `K_ID`) VALUES ("3218101964","schueler789","Tousart","Lucas","3");


SELECT * FROM Tbl_Anwesenheit;
INSERT INTO `Tbl_Anwesenheit`(`R_ID`, `S_Matrikelnummer`, `S_Passwort`, `A_Ankunft`, `A_Feierabend`) VALUES ("C205","8218101964","schueler123","2020-03.10 07:45:00","2020-03-10 15:05:00");
INSERT INTO `Tbl_Anwesenheit`(`R_ID`, `S_Matrikelnummer`, `S_Passwort`, `A_Ankunft`, `A_Feierabend`) VALUES ("C206","5218101964","schueler456","2020-03-10 08:00:00","2020-03-10 14:50:00");
INSERT INTO `Tbl_Anwesenheit`(`R_ID`, `S_Matrikelnummer`, `S_Passwort`, `A_Ankunft`, `A_Feierabend`) VALUES ("C207","3218101964","schueler789","2020-03-10 08:15:00","2020-03-10 14:45:00");


SELECT * FROM Tbl_Pausen;
INSERT INTO `Tbl_Pausen`(`P_ID`, `S_Matrikelnummer`, `P_Datum`, `P_Max_Pausenlaenge`,`P_Aufenthaltsort`) VALUES ("1","8218101964","2020-03-10","60min","Cafeteria");
INSERT INTO `Tbl_Pausen`(`P_ID`, `S_Matrikelnummer`, `P_Datum`, `P_Max_Pausenlaenge`,`P_Aufenthaltsort`) VALUES ("2","5218101964","2020-03-11","60min","Rewe");
INSERT INTO `Tbl_Pausen`(`P_ID`, `S_Matrikelnummer`, `P_Datum`, `P_Max_Pausenlaenge`,`P_Aufenthaltsort`) VALUES ("3","3218101964","2020-03-12","60min","Mediamarkt");







