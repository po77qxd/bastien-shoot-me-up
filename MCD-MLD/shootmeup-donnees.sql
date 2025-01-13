USE db_shootmeup;

INSERT INTO t_joueur (nbrVies, sprite) 
VALUES 
(3, 'vaisseau_joueur_1.png'),
(5, 'vaisseau_joueur_2.png'),
(4, 'vaisseau_joueur_3.png');

INSERT INTO t_ennemi (nbrVies, tir, sprite) 
VALUES 
(1, TRUE, 'alien_vert.png'),
(2, TRUE, 'alien_bleu.png'),
(1, FALSE, 'alien_rouge.png'),
(3, TRUE, 'boss.png');

INSERT INTO t_obstacle (hauteur, largeur, position_x, position_y, sprite) 
VALUES 
(20, 100, 50, 400, 'barriere_1.png'),
(25, 120, 200, 380, 'barriere_2.png'),
(15, 90, 350, 390, 'barriere_3.png');

INSERT INTO t_niveau (joueur_id) 
VALUES 
(1),
(2),
(3);

INSERT INTO t_highscores (score, niveau_id, joueur_humain_id) 
VALUES 
(2500, 1, 1),
(3200, 2, 2),
(2800, 3, 3);

INSERT INTO t_avoir_ennemi (niveau_id, ennemi_id) 
VALUES 
(1, 1),
(1, 2),
(2, 3),
(3, 4);

INSERT INTO t_avoir_obstacles (niveau_id, obstacle_id) 
VALUES 
(1, 1),
(1, 2),
(2, 3),
(3, 1);

INSERT INTO t_joueur_humain (nom_joueur)
VALUES
('Alex Martin'),
('Emma Dupont'),
('Lucas Moreau'),