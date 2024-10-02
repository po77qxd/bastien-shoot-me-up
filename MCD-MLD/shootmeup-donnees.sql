USE db_shootmeup;

INSERT INTO t_joueur (nbrVies, sprite) 
VALUES 
(3, 'vaisseau_joueur_1.png'),

INSERT INTO t_ennemi (nbrVies, tir, sprite) 
VALUES 
(1, FALSE, 'ennemi1.png'),
(2, TRUE, 'ennemi2.png'),
(3, TRUE, 'ennemi3.png'),


INSERT INTO t_obstacle (hauteur, largeur, position_x, position_y, sprite) 
VALUES 
(20, 100, 200, 700, 'obstacle1.png'),
(20, 100, 600, 700, 'obstacle1.png'),
(20, 100, 1000, 700, 'obstacle1.png');


INSERT INTO t_niveau (joueur_id) 
VALUES 
(1),
(2),
(3);


INSERT INTO t_highscores (score, nom_joueur, niveau_id) 
VALUES 
(2500, 'Joueur1', 1),
(3200, 'Joueur1', 2),
(2800, 'Joueur2', 3);


INSERT INTO avoir_ennemi (niveau_id, ennemi_id) 
VALUES 
(1, 1),
(1, 2),
(2, 3),
(3, 3);


INSERT INTO avoir_obstacles (niveau_id, obstacle_id) 
VALUES 
(1, 1),
(1, 3),
(2, 2),
(3, 2);
