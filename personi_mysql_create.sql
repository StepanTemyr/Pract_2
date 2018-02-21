CREATE TABLE `TypeRace` (
	`idRace` int(200) NOT NULL AUTO_INCREMENT,
	`Race` varchar(200) NOT NULL,
	PRIMARY KEY (`idRace`)
);

CREATE TABLE `TypeGrade` (
	`idGrade` int(200) NOT NULL AUTO_INCREMENT,
	`Grade` varchar(200) NOT NULL,
	PRIMARY KEY (`idGrade`)
);

CREATE TABLE `TypePerson` (
	`idPerson` int(200) NOT NULL AUTO_INCREMENT,
	`Name` varchar(200) NOT NULL,
	`Sex` bool NOT NULL,
	`idRace` int(200) NOT NULL,
	`idGrade` int(200) NOT NULL,
	PRIMARY KEY (`idPerson`)
);

ALTER TABLE `TypePerson` ADD CONSTRAINT `TypePerson_fk0` FOREIGN KEY (`idRace`) REFERENCES `TypeRace`(`idRace`);

ALTER TABLE `TypePerson` ADD CONSTRAINT `TypePerson_fk1` FOREIGN KEY (`idGrade`) REFERENCES `TypeGrade`(`idGrade`);

