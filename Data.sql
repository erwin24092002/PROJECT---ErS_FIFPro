USE master ;  
GO  

DROP DATABASE FIFPro;  
GO

CREATE DATABASE FIFPro
GO

USE FIFPro
GO 

CREATE TABLE ACCOUNT
(
	AC_ID INT IDENTITY PRIMARY KEY, 
	AC_NAME VARCHAR(100) NOT NULL DEFAULT 'no name', 
	AC_PASSWORD VARCHAR(100) NOT NULL, 
	AC_COIN INT NOT NULL DEFAULT 1000, 
	AC_ROLE INT NOT NULL DEFAULT 0, 
	AC_IDTEAM INT DEFAULT 0, 
)
GO

CREATE TABLE TEAM 
(
	T_ID INT IDENTITY PRIMARY KEY, 
	T_NAME VARCHAR(100) NOT NULL DEFAULT 'no name', 
	T_WIN INT DEFAULT 0, 
	T_LOSE INT DEFAULT 0, 
	T_DRAW INT DEFAULT 0, 
)
GO

CREATE TABLE FOOTBALLER
(
	FB_ID INT IDENTITY PRIMARY KEY, 
	FB_NAME VARCHAR(100) DEFAULT 'no name',
	FB_BIRTHDAY DATE, 
	FB_INDEX INT,
	FB_ROLE VARCHAR(100), 
	FB_SCORE INT DEFAULT 0, 
	FB_IDTEAM INT, 

)
GO

CREATE TABLE TMATCH 
(
	M_ID INT IDENTITY PRIMARY KEY, 
	M_IDTEAM INT DEFAULT 0
)

CREATE TABLE FMATCH 
(
	M_ID INT IDENTITY PRIMARY KEY, 
	M_IDTEAM1 INT DEFAULT 0, 
	M_IDTEAM2 INT DEFAULT 0, 
	M_SCORE1 INT DEFAULT 0, 
	M_SCORE2 INT DEFAULT 0, 
	M_HDP1 FLOAT DEFAULT 0.0,
	M_HDP2 FLOAT DEFAULT 0.0, 
	M_STATUS INT DEFAULT 0, 
	M_DATE DATETIME DEFAULT '1995-9-24 22:00:00',
	M_LINK VARCHAR(1000) DEFAULT ''
)

CREATE TABLE BET 
(
	B_ID INT IDENTITY PRIMARY KEY, 
	B_IDMATCH INT, 
	B_IDTEAM INT,
	B_IDACCOUNT INT,
	B_COIN INT, 
	B_DATE DATETIME, 
	B_STATUS INT
)

ALTER TABLE ACCOUNT NOCHECK CONSTRAINT ALL
ALTER TABLE TEAM NOCHECK CONSTRAINT ALL
ALTER TABLE FOOTBALLER NOCHECK CONSTRAINT ALL
ALTER TABLE TMATCH NOCHECK CONSTRAINT ALL
ALTER TABLE FMATCH NOCHECK CONSTRAINT ALL
GO

INSERT INTO ACCOUNT (AC_NAME, AC_PASSWORD, AC_COIN, AC_ROLE, AC_IDTEAM) VALUES 
	('Argentina', 'Argentina', 1000, 1, 1), 
	('France', 'France', 1000, 1, 2), 
	('Brazil', 'Brazil', 1000, 1, 3), 
	('Qatar', 'Qatar', 1000, 1, 4), 
	('Japan', 'Japan', 1000, 1, 5), 
	('South Korea', 'South Korea', 1000, 1, 6), 
	('Germany', 'Germany', 1000, 1, 7), 
	('Croatia', 'Croatia', 1000, 1, 8),
	('Erwin', 'Erwin', 1000, 2, 0),
	('Suong', 'Suong', 1000, 2, 0)
GO

INSERT INTO TEAM (T_NAME, T_WIN, T_LOSE, T_DRAW) VALUES 
	('Argentina', 1, 0, 0), 
	('France', 0, 1, 0), 
	('Brazil', 1, 0, 0), 
	('Qatar', 0, 1, 0), 
	('Japan', 0, 0, 0), 
	('South Korea', 0, 0, 0), 
	('Germany', 0, 0, 0), 
	('Croatia', 0, 0, 0)
GO

INSERT INTO TMATCH (M_IDTEAM) VALUES 
	(1),
	(2),
	(3),
	(4),
	(5),
	(6),
	(7),
	(8),
	(1),
	(3),
	(0),
	(0),
	(0),
	(0),
	(0)
GO

INSERT INTO FMATCH (M_IDTEAM1, M_IDTEAM2, M_SCORE1, M_SCORE2, M_DATE, M_LINK, M_STATUS) VALUES 
	(1, 2, 2, 1, '2023-1-11 22:00:00', 'https://www.youtube.com/watch?v=TElOdnfP1SE', 1),
	(3, 4, 3, 0, '2023-1-13 22:00:00', 'https://www.youtube.com/watch?v=TElOdnfP1SE', 1),
	(5, 6, 0, 0, '2023-1-15 22:00:00', '', 0),
	(7, 8, 0, 0, '2023-1-17 22:00:00', '', 0),
	(1, 3, 0, 0, '2023-1-19 22:00:00', '', 0),
	(0, 0, 0, 0, '2023-1-21 22:00:00', '', 0),
	(0, 0, 0, 0, '2023-1-23 22:00:00', '', 0)
GO

INSERT INTO BET (B_IDACCOUNT, B_IDMATCH, B_IDTEAM, B_COIN, B_DATE, B_STATUS) VALUES 
	(9, 1, 1, 100, '2023-1-11 22:00:00', 1), 
	(9, 2, 3, 200, '2023-1-11 22:00:00', 0)
GO 

INSERT INTO FOOTBALLER (FB_NAME, FB_BIRTHDAY, FB_INDEX, FB_ROLE, FB_SCORE, FB_IDTEAM) VALUES 
	('Franco Armani', '1995-9-24', 1, 'Defender', 0, 1), 
	('Juan Foyth', '1995-9-24', 2, 'Defender', 0, 1), 
	('Nicolás Tagliafico', '1995-9-24', 3, 'Defender', 0, 1), 
	('Gonzalo Montiel', '1995-9-24', 4, 'Defender', 0, 1), 
	('Leandro Paredes', '1995-9-24', 5, 'Midfielder', 0, 1), 
	('Germán Pezzella', '1995-9-24', 6, 'Defender', 0, 1), 
	('Rodrigo De Paul', '1995-9-24', 7, 'Midfielder', 0, 1),
	('Marcos Acuña', '1995-9-24', 8, 'Midfielder', 0, 1), 
	('Julián Álvarez', '1995-9-24', 9, 'Forward', 0, 1), 
	('Lionel Messi', '1995-9-24', 10, 'Forward', 0, 1), 
	('Ángel Di María', '1995-9-24', 11, 'Forward', 0, 1), 
	('Gerónimo Rulli', '1995-9-24', 12, 'Goalkeeper', 0, 1), 
	('Cristian Romero', '1995-9-24', 13, 'Defender', 0, 1), 
	('Exequiel Palacios', '1995-9-24', 14, 'Midfielder', 0, 1), 
	('Ángel Correa', '1995-9-24', 15, 'Midfielder', 0, 1), 
	('Thiago Almada', '1995-9-24', 16, 'Forward', 0, 1), 
	('Papu Gómez', '1995-9-24', 17, 'Midfielder', 0, 1), 
	('Guido Rodríguez', '1995-9-24', 18, 'Midfielder', 0, 1), 
	('Nicolás Otamendi', '1995-9-24', 19, 'Defender', 0, 1), 
	('Alexis Mac Allister', '1995-9-24', 20, 'Midfielder', 0, 1), 
	('Paulo Dybala', '1995-9-24', 21, 'Forward', 0, 1), 
	('Lautaro Martínez', '1995-9-24', 22, 'Forward', 0, 1), 
	('Emiliano Martínez', '1995-9-24', 23, 'Goalkeeper', 0, 1), 
	('Enzo Fernández', '1995-9-24', 24, 'Midfielder', 0, 1), 
	('Lisandro Martínez', '1995-9-24', 25, 'Goalkeeper', 0, 1), 
	('Nahuel Molina', '1995-9-24', 26, 'Defender', 0, 1), 
	
	('Hugo Lloris', '1995-9-24', 1, 'Goalkeeper', 0, 2), 
	('Benjamin Pavard', '1995-9-24', 2, 'Defender', 0, 2), 
	('Axel Disasi', '1995-9-24', 3, 'Defender', 0, 2), 
	('Raphaël Varane', '1995-9-24', 4, 'Defender', 0, 2), 
	('Jules Koundé', '1995-9-24', 5, 'Defender', 0, 2), 
	('Matteo Guendouzi', '1995-9-24', 6, 'Midfielder', 0, 2), 
	('Antoine Griezmann', '1995-9-24', 7, 'Forward', 0, 2), 
	('Aurélien Tchouaméni', '1995-9-24', 8, 'Midfielder', 0, 2), 
	('Olivier Giroud', '1995-9-24', 9, 'Forward', 0, 2), 
	('Kylian Mbappé', '1995-9-24', 10, 'Forward', 0, 2), 
	('Ousmane Dembélé', '1995-9-24', 11, 'Forward', 0, 2), 
	('Randal Kolo Muani', '1995-9-24', 12, 'Forward', 0, 2), 
	('Youssouf Fofana', '1995-9-24', 13, 'Midfielder', 0, 2), 
	('Adrien Rabiot', '1995-9-24', 14, 'Midfielder', 0, 2), 
	('Jordan Veretout', '1995-9-24', 15, 'Midfielder', 0, 2), 
	('Steve Mandanda', '1995-9-24', 16, 'Goalkeeper', 0, 2), 
	('William Saliba', '1995-9-24', 17, 'Defender', 0, 2), 
	('Dayot Upamecano', '1995-9-24', 18, 'Defender', 0, 2), 
	('Karim Benzema', '1995-9-24', 19, 'Forward', 0, 2), 
	('Kingsley Coman', '1995-9-24', 20, 'Forward', 0, 2), 
	('Lucas Hernandez', '1995-9-24', 21, 'Defender', 0, 2), 
	('Théo Hernandez', '1995-9-24', 22, 'Defender', 0, 2), 
	('Alphonse Areola', '1995-9-24', 23, 'Goalkeeper', 0, 2), 
	('Ibrahima Konaté', '1995-9-24', 24, 'Defender', 0, 2), 
	('Eduardo Camavinga', '1995-9-24', 25, 'Midfielder', 0, 2), 
	('Marcus Thuram', '1995-9-24', 26, 'Forward', 0, 2), 
		 
	('Alisson', '1995-9-24', 1, 'Goalkeeper', 0, 3), 
	('Danilo', '1995-9-24', 2, 'Defender', 0, 3), 
	('Thiago Silva', '1995-9-24', 3, 'Defender', 0, 3), 
	('Marquinhos', '1995-9-24', 4, 'Defender', 0, 3), 
	('Casemiro', '1995-9-24', 5, 'Midfielder', 0, 3), 
	('Alex Sandro', '1995-9-24', 6, 'Defender', 0, 3), 
	('Lucas Paquetá', '1995-9-24', 7, 'Midfielder', 0, 3), 
	('Fred', '1995-9-24', 8, 'Midfielder', 0, 3), 
	('Richarlison', '1995-9-24', 9, 'Forward', 0, 3), 
	('Neymar', '1995-9-24', 10, 'Forward', 0, 3), 
	('Raphinha', '1995-9-24', 11, 'Forward', 0, 3), 
	('Weverton', '1995-9-24', 12, 'Goalkeeper', 0, 3), 
	('Dani Alves', '1995-9-24', 13, 'Defender', 0, 3), 
	('Éder Militão', '1995-9-24', 14, 'Defender', 0, 3), 
	('Fabinho', '1995-9-24', 15, 'Midfielder', 0, 3), 
	('Alex Telles', '1995-9-24', 16, 'Defender', 0, 3), 
	('Bruno Guimarães', '1995-9-24', 17, 'Midfielder', 0, 3), 
	('Gabriel Jesus', '1995-9-24', 18, 'Forward', 0, 3), 
	('Antony', '1995-9-24', 19, 'Forward', 0, 3), 
	('Vinícius Júnior', '1995-9-24', 20, 'Forward', 0, 3), 
	('Rodrygo', '1995-9-24', 21, 'Forward', 0, 3), 
	('Éverton Ribeiro', '1995-9-24', 22, 'Midfielder', 0, 3), 
	('Ederson', '1995-9-24', 23, 'Goalkeeper', 0, 3), 
	('Bremer', '1995-9-24', 24, 'Defender', 0, 3), 
	('Pedro', '1995-9-24', 25, 'Forward', 0, 3), 
	('Gabriel Martinelli', '1995-9-24', 26, 'Forward', 0, 3), 
		  
	('Saad Al Sheeb', '1995-9-24', 1, 'Goalkeeper', 0, 4), 
	('Ró Ró', '1995-9-24', 2, 'Defender', 0, 4), 
	('Abdelkarim Hassan', '1995-9-24', 3, 'Midfielder', 0, 4), 
	('Mohammed Waad', '1995-9-24', 4, 'Defender', 0, 4), 
	('Tarek Salman', '1995-9-24', 5, 'Defender', 0, 4), 
	('Abdulaziz Hatem', '1995-9-24', 6, 'Midfielder', 0, 4), 
	('Ahmed Alaaeldin', '1995-9-24', 7, 'Forward', 0, 4), 
	('Ali Assadalla', '1995-9-24', 8, 'Midfielder', 0, 4), 
	('Mohammed Muntari', '1995-9-24', 9, 'Forward', 0, 4), 
	('Hassan Al Haydos', '1995-9-24', 10, 'Midfielder', 0, 4), 
	('Akram Afif', '1995-9-24', 11, 'Forward', 0, 4), 
	('Karim Boudiaf', '1995-9-24', 12, 'Midfielder', 0, 4), 
	('Musab Kheder', '1995-9-24', 13, 'Defender', 0, 4), 
	('Homam Ahmed', '1995-9-24', 14, 'Defender', 0, 4), 
	('Bassam Al Rawi', '1995-9-24', 15, 'Defender', 0, 4), 
	('Boualem Khoukhi', '1995-9-24', 16, 'Defender', 0, 4), 
	('Ismaeel Mohammad', '1995-9-24', 17, 'Defender', 0, 4), 
	('Khalid Muneer', '1995-9-24', 18, 'Forward', 0, 4), 
	('Almoez Ali', '1995-9-24', 19, 'Forward', 0, 4), 
	('Salem Al Hajri', '1995-9-24', 20, 'Midfielder', 0, 4), 
	('Yousef Hassan', '1995-9-24', 21, 'Goalkeeper', 0, 4), 
	('Meshaal Barsham', '1995-9-24', 22, 'Goalkeeper', 0, 4), 
	('Assim Madibo', '1995-9-24', 23, 'Midfielder', 0, 4), 
	('Naif Al Hadhrami', '1995-9-24', 24, 'Midfielder', 0, 4), 
	('Jassem Gaber', '1995-9-24', 25, 'Midfielder', 0, 4), 
	('Mostafa Meshaal', '1995-9-24', 26, 'Midfielder', 0, 4), 
		  
	('Eiji Kawashima', '1995-9-24', 1, 'Goalkeeper', 0, 5), 
	('Miki Yamane', '1995-9-24', 2, 'Defender', 0, 5), 
	('Shogo Taniguchi', '1995-9-24', 3, 'Defender', 0, 5), 
	('Ko Itakura', '1995-9-24', 4, 'Defender', 0, 5), 
	('Yuto Nagatomo', '1995-9-24', 5, 'Defender', 0, 5), 
	('Wataru Endo', '1995-9-24', 6, 'Midfielder', 0, 5), 
	('Gaku Shibasaki', '1995-9-24', 7, 'Midfielder', 0, 5), 
	('Ritsu Doan', '1995-9-24', 8, 'Midfielder', 0, 5), 
	('Kaoru Mitoma', '1995-9-24', 9, 'Midfielder', 0, 5), 
	('Takumi Minamino', '1995-9-24', 10, 'Midfielder', 0, 5), 
	('Takefusa Kubo', '1995-9-24', 11, 'Midfielder', 0, 5), 
	('Shuichi Gonda', '1995-9-24', 12, 'Goalkeeper', 0, 5), 
	('Hidemasa Morita', '1995-9-24', 13, 'Midfielder', 0, 5), 
	('Junya Ito', '1995-9-24', 14, 'Midfielder', 0, 5), 
	('Daichi Kamada', '1995-9-24', 15, 'Midfielder', 0, 5), 
	('Takehiro Tomiyasu', '1995-9-24', 16, 'Defender', 0, 5), 
	('Ao Tanaka', '1995-9-24', 17, 'Midfielder', 0, 5), 
	('Takuma Asano', '1995-9-24', 18, 'Forward', 0, 5), 
	('Hiroki Sakai', '1995-9-24', 19, 'Defender', 0, 5), 
	('Shuto Machino', '1995-9-24', 20, 'Forward', 0, 5), 
	('Ayase Ueda', '1995-9-24', 21, 'Forward', 0, 5), 
	('Maya Yoshida', '1995-9-24', 22, 'Defender', 0, 5), 
	('Daniel Schmidt', '1995-9-24', 23, 'Goalkeeper', 0, 5), 
	('Yuki Soma', '1995-9-24', 24, 'Midfielder', 0, 5), 
	('Daizen Maeda', '1995-9-24', 25, 'Forward', 0, 5), 
	('Hiroki Ito', '1995-9-24', 26, 'Defender', 0, 5), 
		 
	('Kim Seung gyu', '1995-9-24', 1, 'Goalkeeper', 0, 6), 
	('Yoon Jong gyu', '1995-9-24', 2, 'Defender', 0, 6), 
	('Kim Jin su', '1995-9-24', 3, 'Defender', 0, 6), 
	('Kim Min jae', '1995-9-24', 4, 'Defender', 0, 6), 
	('Jung Woo young', '1995-9-24', 5, 'Midfielder', 0, 6), 
	('Hwang In beom', '1995-9-24', 6, 'Midfielder', 0, 6), 
	('Son Heung min', '1995-9-24', 7, 'Midfielder', 0, 6), 
	('Paik Seung ho', '1995-9-24', 8, 'Midfielder', 0, 6), 
	('Cho Gue sung', '1995-9-24', 9, 'Forward', 0, 6), 
	('Lee Jae sung', '1995-9-24', 10, 'Midfielder', 0, 6), 
	('Hwang Hee chan', '1995-9-24', 11, 'Midfielder', 0, 6), 
	('Song Bum keun', '1995-9-24', 12, 'Goalkeeper', 0, 6), 
	('Son Jun ho', '1995-9-24', 13, 'Midfielder', 0, 6), 
	('Hong Chul', '1995-9-24', 14, 'Defender', 0, 6), 
	('Kim Moon hwan', '1995-9-24', 15, 'Defender', 0, 6), 
	('Hwang Ui jo', '1995-9-24', 16, 'Forward', 0, 6), 
	('Na Sang ho', '1995-9-24', 17, 'Midfielder', 0, 6), 
	('Lee Kang in', '1995-9-24', 18, 'Midfielder', 0, 6), 
	('Kim Young gwon', '1995-9-24', 19, 'Defender', 0, 6), 
	('Kwon Kyung won', '1995-9-24', 20, 'Defender', 0, 6), 
	('Jo Hyeon woo', '1995-9-24', 21, 'Goalkeeper', 0, 6), 
	('Kwon Chang hoon', '1995-9-24', 22, 'Midfielder', 0, 6), 
	('Kim Tae hwan', '1995-9-24', 23, 'Defender', 0, 6), 
	('Cho Yu min', '1995-9-24', 24, 'Defender', 0, 6), 
	('Jeong Woo yeong', '1995-9-24', 25, 'Midfielder', 0, 6), 
	('Song Min kyu', '1995-9-24', 26, 'Midfielder', 0, 6), 
		   
	('Manuel Neuer', '1995-9-24', 1, 'Goalkeeper', 0, 7), 
	('Antonio Rüdiger', '1995-9-24', 2, 'Defender', 0, 7), 
	('David Raum', '1995-9-24', 3, 'Defender', 0, 7), 
	('Matthias Ginter', '1995-9-24', 4, 'Defender', 0, 7), 
	('Thilo Kehrer', '1995-9-24', 5, 'Defender', 0, 7), 
	('Joshua Kimmich', '1995-9-24', 6, 'Midfielder', 0, 7), 
	('Kai Havertz', '1995-9-24', 7, 'Forward', 0, 7), 
	('Leon Goretzka', '1995-9-24', 8, 'Midfielder', 0, 7), 
	('Niclas Füllkrug', '1995-9-24', 9, 'Forward', 0, 7), 
	('Serge Gnabry', '1995-9-24', 10, 'Forward', 0, 7), 
	('Mario Götze', '1995-9-24', 11, 'Midfielder', 0, 7), 
	('Kevin Trapp', '1995-9-24', 12, 'Goalkeeper', 0, 7), 
	('Thomas Müller', '1995-9-24', 13, 'Midfielder', 0, 7), 
	('Jamal Musiala', '1995-9-24', 14, 'Midfielder', 0, 7), 
	('Niklas Süle', '1995-9-24', 15, 'Defender', 0, 7), 
	('Lukas Klostermann', '1995-9-24', 16, 'Defender', 0, 7), 
	('Julian Brandt', '1995-9-24', 17, 'Midfielder', 0, 7), 
	('Jonas Hofmann', '1995-9-24', 18, 'Midfielder', 0, 7), 
	('Leroy Sané', '1995-9-24', 19, 'Midfielder', 0, 7), 
	('Christian Günter', '1995-9-24', 20, 'Defender', 0, 7), 
	('Ilkay Gundogan', '1995-9-24', 21, 'Midfielder', 0, 7), 
	('Marc André ter Stegen', '1995-9-24', 22, 'Goalkeeper', 0, 7), 
	('Nico Schlotterbeck', '1995-9-24', 23, 'Defender', 0, 7), 
	('Karim Adeyemi', '1995-9-24', 24, 'Forward', 0, 7), 
	('Armel Bella Kotchap', '1995-9-24', 25, 'Defender', 0, 7), 
	('Youssoufa Moukoko', '1995-9-24', 26, 'Forward', 0, 7), 
		  
	('Dominik Livakovic', '1995-9-24', 1, 'Goalkeeper', 0, 8), 
	('Josip Stanisic', '1995-9-24', 2, 'Defender', 0, 8), 
	('Borna Barisic', '1995-9-24', 3, 'Defender', 0, 8), 
	('Ivan Perisic', '1995-9-24', 4, 'Forward', 0, 8), 
	('Martin Erlic', '1995-9-24', 5, 'Defender', 0, 8), 
	('Dejan Lovren', '1995-9-24', 6, 'Defender', 0, 8), 
	('Lovro Majer', '1995-9-24', 7, 'Midfielder', 0, 8), 
	('Mateo Kovacic', '1995-9-24', 8, 'Midfielder', 0, 8), 
	('Andrej Kramaric', '1995-9-24', 9, 'Forward', 0, 8), 
	('Luka Modric', '1995-9-24', 10, 'Midfielder', 0, 8), 
	('Marcelo Brozovic', '1995-9-24', 11, 'Midfielder', 0, 8), 
	('Ivo Grbic', '1995-9-24', 12, 'Goalkeeper', 0, 8), 
	('Nikola Vlasic', '1995-9-24', 13, 'Midfielder', 0, 8), 
	('Marko Livaja', '1995-9-24', 14, 'Forward', 0, 8), 
	('Mario Pasalic', '1995-9-24', 15, 'Midfielder', 0, 8), 
	('Bruno Petkovic', '1995-9-24', 16, 'Forward', 0, 8), 
	('Ante Budimir', '1995-9-24', 17, 'Forward', 0, 8), 
	('Mislav Orsic', '1995-9-24', 18, 'Forward', 0, 8), 
	('Borna Sosa', '1995-9-24', 19, 'Defender', 0, 8), 
	('Joško Gvardiol', '1995-9-24', 20, 'Defender', 0, 8), 
	('Domagoj Vida', '1995-9-24', 21, 'Defender', 0, 8), 
	('Josip Juranovic', '1995-9-24', 22, 'Defender', 0, 8), 
	('Ivica Ivusic', '1995-9-24', 23, 'Goalkeeper', 0, 8), 
	('Josip Šutalo', '1995-9-24', 24, 'Defender', 0, 8), 
	('Luka Sucic', '1995-9-24', 25, 'Midfielder', 0, 8), 
	('Kristijan Jakic', '1995-9-24', 26, 'Midfielder', 0, 8),

	('Lionel Scaloni', '1995-9-24', 27, 'Trainer', 0, 1),
	('Didier Deschamps', '1995-9-24', 27, 'Trainer', 0, 2),
	('Tite', '1995-9-24', 27, 'Trainer', 0, 3), 
	('Felix Sanchez', '1995-9-24', 27, 'Trainer', 0, 4), 
	('Hajime Moriyasu', '1995-9-24', 27, 'Trainer', 0, 5), 
	('Paulo Bento', '1995-9-24', 27, 'Trainer', 0, 6), 
	('Hansi Flick', '1995-9-24', 27, 'Trainer', 0, 7), 
	('Zlatko Dalic', '1995-9-24', 27, 'Trainer', 0, 8)
GO

SELECT * FROM ACCOUNT 
SELECT * FROM TEAM
SELECT * FROM FOOTBALLER 
SELECT * FROM TMATCH
SELECT * FROM BET
SELECT * FROM ACCOUNT WHERE AC_NAME='Erwin' AND AC_PASSWORD='Erwin'
SELECT * FROM FMATCH WHERE M_IDTEAM1=1 OR M_IDTEAM2=1
SELECT * FROM ACCOUNT 
GO

CREATE PROC RESET_ALL
AS 
BEGIN 
	DELETE FROM BET
	UPDATE TEAM SET T_WIN=0, T_LOSE=0, T_DRAW=0
	UPDATE TMATCH SET M_IDTEAM=0 WHERE M_ID>8 
	UPDATE FMATCH SET M_SCORE1=0, M_SCORE2=0, M_DATE='', M_LINK='', M_STATUS=0 
	UPDATE FMATCH SET M_IDTEAM1=0, M_IDTEAM2=0 WHERE M_ID>4
END
GO

--EXEC RESET_ALL

--GO 
 /*
INSERT INTO ACCOUNT (AC_NAME, AC_PASSWORD) VALUES ('Thang', 'Thang') 
GO 
UPDATE ACCOUNT 
SET AC_COIN = 10000
WHERE AC_ID = 9
GO

*/



