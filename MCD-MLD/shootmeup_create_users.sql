USE db_shootmeup;

CREATE ROLE admin;
CREATE ROLE gameManager;


GRANT INSERT, SELECT, UPDATE, DELETE ON * TO admin;
GRANT GRANT OPTION ON * TO admin;

GRANT SELECT ON * TO gameManager;
GRANT INSERT ON t_niveau TO gameManager;
GRANT INSERT ON t_highscores TO gameManager;


CREATE USER 'admin'@'localhost' IDENTIFIED BY 'admin';
CREATE USER 'gameManager'@'localhost' IDENTIFIED BY 'gameManager';


GRANT admin TO 'admin'@'localhost';
GRANT gameManager TO 'gameManager'@'localhost';