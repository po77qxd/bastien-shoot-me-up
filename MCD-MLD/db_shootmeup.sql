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
   minutage INT,
   tir BOOLEAN,
   sprite ,
   PRIMARY KEY(ennemi_id)
);

CREATE TABLE t_obstacle(
   obstacle_id INT AUTO_INCREMENT,
   taille VARCHAR(50),
   position_x_y VARCHAR(50),
   sprite ,
   comportement VARCHAR(50),
   PRIMARY KEY(obstacle_id)
);

CREATE TABLE t_niveau(
   niveau_id INT AUTO_INCREMENT,
   t_joueur_joueur_id INT NOT NULL,
   PRIMARY KEY(niveau_id),
   FOREIGN KEY(t_joueur_joueur_id) REFERENCES t_joueur(joueur_id)
);

CREATE TABLE t_highscores(
   score_id INT AUTO_INCREMENT,
   score INT,
   nom_joueur VARCHAR(50),
   t_niveau_niveau_id INT NOT NULL,
   PRIMARY KEY(score_id),
   FOREIGN KEY(t_niveau_niveau_id) REFERENCES t_niveau(niveau_id)
);

CREATE TABLE avoir_ennemi(
   t_niveau_niveau_id INT,
   t_ennemi_ennemi_id INT,
   PRIMARY KEY(t_niveau_niveau_id, t_ennemi_ennemi_id),
   FOREIGN KEY(t_niveau_niveau_id) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(t_ennemi_ennemi_id) REFERENCES t_ennemi(ennemi_id)
);

CREATE TABLE avoir_obstacles(
   t_niveau_niveau_id INT,
   t_obstacle_obstacle_id INT,
   PRIMARY KEY(t_niveau_niveau_id, t_obstacle_obstacle_id),
   FOREIGN KEY(t_niveau_niveau_id) REFERENCES t_niveau(niveau_id),
   FOREIGN KEY(t_obstacle_obstacle_id) REFERENCES t_obstacle(obstacle_id)
);
