CREATE DATABASE IF NOT EXISTS db_shootmeup;
USE db_shootmeup;


CREATE TABLE t_joueur(
   joueur_id INT AUTO_INCREMENT,
   nbrVies INT,
   sprite BLOB,
   PRIMARY KEY(joueur_id)
);

CREATE TABLE t_ennemi(
   ennemi_id INT AUTO_INCREMENT,
   nbrVies INT,
   tir BOOLEAN,
   sprite BLOB,
   PRIMARY KEY(ennemi_id)
);

CREATE TABLE t_obstacle(
   obstacle_id INT AUTO_INCREMENT,
   hauteur INT,
   largeur INT,
   position_x INT,
   position_y INT,
   sprite BLOB,
   PRIMARY KEY(obstacle_id)
);

CREATE TABLE t_joueur_humain(
   joueur_humain_id INT AUTO_INCREMENT,
   nom_joueur VARCHAR(50),
   PRIMARY KEY(joueur_humain_id)
);

CREATE TABLE t_niveau(
   niveau_id INT AUTO_INCREMENT,
   joueur_id_fk INT NOT NULL,
   PRIMARY KEY(niveau_id),
   FOREIGN KEY(joueur_id_fk) REFERENCES t_joueur(joueur_id)
);

CREATE TABLE t_highscores(
   score_id INT AUTO_INCREMENT,
   score INT,
   joueur_humain_id_fk INT NOT NULL,
   niveau_id_fk INT NOT NULL,
   PRIMARY KEY(score_id),
   FOREIGN KEY(joueur_humain_id_fk) REFERENCES t_joueur_humain(joueur_humain_id),
   FOREIGN KEY(niveau_id_fk) REFERENCES t_niveau(niveau_id)
);

CREATE TABLE t_avoir_ennemi(
   niveau_id_fk INT,
   ennemi_id_fk INT,
   PRIMARY KEY(niveau_id_fk, ennemi_id_fk),
   FOREIGN KEY(niveau_id_fk) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(ennemi_id_fk) REFERENCES t_ennemi(ennemi_id)
);

CREATE TABLE t_avoir_obstacles(
   niveau_id_fk INT,
   obstacle_id_fk INT,
   PRIMARY KEY(niveau_id_fk, obstacle_id_fk),
   FOREIGN KEY(niveau_id_fk) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(obstacle_id_fk) REFERENCES t_obstacle(obstacle_id)
);

