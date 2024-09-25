--création de la base de données
CREATE IF NOT EXISTS db_shootmeup;
USE db_shootmeup;


CREATE TABLE t_joueur(
   joueur_id INT AUTO_INCREMENT,
   nbrVies INT,
   sprite ,
   PRIMARY KEY(joueur_id)
);

CREATE TABLE t_ennemi(
   ennemi_id INT AUTO_INCREMENT,
   nbrVies INT,
   tir BOOLEAN,
   sprite ,
   PRIMARY KEY(ennemi_id)
);

CREATE TABLE t_obstacle(
   obstacle_id INT AUTO_INCREMENT,
   hauteur INT,
   largeur INT,
   position_x INT,
   position_y INT,
   sprite ,
   PRIMARY KEY(obstacle_id)
);

CREATE TABLE t_niveau(
   niveau_id INT AUTO_INCREMENT,
   joueur_id INT NOT NULL,
   PRIMARY KEY(niveau_id),
   FOREIGN KEY(joueur_id) REFERENCES t_joueur(joueur_id)
);

CREATE TABLE t_highscores(
   score_id INT AUTO_INCREMENT,
   score INT,
   nom_joueur VARCHAR(50),
   niveau_id INT NOT NULL,
   PRIMARY KEY(score_id),
   FOREIGN KEY(niveau_id) REFERENCES t_niveau(niveau_id)
);

CREATE TABLE t_avoir_ennemi(
   niveau_id INT,
   ennemi_id INT,
   PRIMARY KEY(niveau_id, ennemi_id),
   FOREIGN KEY(niveau_id) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(ennemi_id) REFERENCES t_ennemi(ennemi_id)
);

CREATE TABLE t_avoir_obstacles(
   niveau_id INT,
   obstacle_id INT,
   PRIMARY KEY(niveau_id, obstacle_id),
   FOREIGN KEY(niveau_id) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(obstacle_id) REFERENCES t_obstacle(obstacle_id)
);

