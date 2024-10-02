USE db_shootmeup;

CREATE ROLE admin;
CREATE ROLE gameManager;

GRANT ALL PRIVILEGES ON * TO admin WITH GRANT OPTION;

GRANT SELECT ON * TO gameManager;
GRANT INSERT ON t_niveau TO gameManager;
GRANT INSERT ON t_highscores TO gameManager;


CREATE USER 'admin'@'localhost' IDENTIFIED BY 'admin';
CREATE USER 'gameManager'@'localhost' IDENTIFIED BY 'gameManager';


GRANT admin TO 'admin'@'localhost';
GRANT gameManager TO 'gameManager'@'localhost';