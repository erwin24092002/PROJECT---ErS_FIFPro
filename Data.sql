CREATE DATABASE FIFPro
GO

USE FIFPro
GO 

CREATE TABLE ACCOUNT
(
	AC_ID INT IDENTITY PRIMARY KEY, 
	AC_NAME VARCHAR(100) NOT NULL DEFAULT 'no name', 
	AC_PASSWORD VARCHAR(100) NOT NULL, 
	AC_COIN INT NOT NULL, 
	AC_ROLE INT NOT NULL DEFAULT 0, 
	AC_IDTEAM INT, 
)
GO

CREATE TABLE TEAM 
(
	T_ID INT IDENTITY PRIMARY KEY, 
	T_NAME VARCHAR(100) NOT NULL DEFAULT 'no name', 
	T_WIN INT DEFAULT 0, 
	T_LOSE INT DEFAULT 0, 
	T_DRAW INT DEFAULT 0, 
	T_SCORE INT DEFAULT 0, 
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

CREATE TABLE FMATCH 
(
	M_ID INT IDENTITY PRIMARY KEY, 
	M_IDTEAM1 INT, 
	M_IDTEAM2 INT, 
	M_TEAM1SCORE INT, 
	M_TEAM2SCORE INT, 
	M_DATETIME DATETIME
)

ALTER TABLE ACCOUNT ADD
CONSTRAINT FK_AC_T FOREIGN KEY (AC_IDTEAM) REFERENCES TEAM(T_ID)
GO 

ALTER TABLE FOOTBALLER ADD
CONSTRAINT FK_FB_T FOREIGN KEY (FB_IDTEAM) REFERENCES TEAM(T_ID)
GO 

ALTER TABLE FMATCH ADD
CONSTRAINT FK_M_T1 FOREIGN KEY (M_IDTEAM1) REFERENCES TEAM(T_ID),
CONSTRAINT FK_M_T2 FOREIGN KEY (M_IDTEAM2) REFERENCES TEAM(T_ID)
GO 

ALTER TABLE ACCOUNT NOCHECK CONSTRAINT ALL
ALTER TABLE TEAM NOCHECK CONSTRAINT ALL
ALTER TABLE FOOTBALLER NOCHECK CONSTRAINT ALL
ALTER TABLE FMATCH NOCHECK CONSTRAINT ALL
GO

INSERT INTO ACCOUNT (AC_NAME, AC_PASSWORD, AC_COIN, AC_ROLE, AC_IDTEAM) VALUES 
	('Argentina', 'Argentina', 1000, 2, 1), 
	('France', 'France', 1000, 2, 2), 
	('Brazil', 'Brazil', 1000, 2, 3), 
	('Quatar', 'Quatar', 1000, 2, 4), 
	('Japan', 'Japan', 1000, 2, 5), 
	('South Korea', 'South Korea', 1000, 2, 6), 
	('Germany', 'Germany', 1000, 2, 7), 
	('Croatia', 'Croatia', 1000, 2, 8),
	('Erwin', 'Erwin', 1000, 2, 9),
	('Suong', 'Suong', 1000, 2, 10)
GO

INSERT INTO TEAM (T_NAME) VALUES 
	('Argentina'), 
	('France'), 
	('Brazil'), 
	('Quatar'), 
	('Japan'), 
	('South Korea'), 
	('Germany'), 
	('Croatia')
GO

INSERT INTO FOOTBALLER (FB_NAME, FB_BIRTHDAY, FB_INDEX, FB_ROLE, FB_SCORE, FB_IDTEAM) VALUES 
	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 1), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 1), 
	
	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 2), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 2), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 3), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 3), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 4), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 4), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 5), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 5), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 6), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 6), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 7), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 7), 

	('Forward', 'Midfielder', 'Defender', 'Goalkeeper')
	('', '24-9-1995', 1, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 2, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 3, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 4, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 5, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 6, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 7, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 8, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 9, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 10, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 11, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 12, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 13, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 14, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 15, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 16, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 17, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 18, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 19, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 20, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 21, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 22, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 23, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 24, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 25, 'Goalkeeper', 0, 8), 
	('', '24-9-1995', 26, 'Goalkeeper', 0, 8)

GO

SELECT * FROM ACCOUNT 
SELECT * FROM TEAM
SELECT * FROM FOOTBALLER 
SELECT * FROM FMATCH

