Песнарка со акорди (Chordbook)
===========

Песнарка со акорди, Проектна задача - Визуелно програмирање 2012/13 ФИНКИ - Скопје

Изработена од Филип Николоски и Александра Пазаркоска

Песнарката со акорди работи со Mysql база на податоци.
Подесувањата за конекцијата се прават во фајлот App.Config од проектот.

Ова е структурата на табелите кои што треба да ги искреирате во вашата база:

CREATE TABLE IF NOT EXISTS `category` (
  `id_category` int(11) NOT NULL AUTO_INCREMENT,
  `name_category` varchar(250) NOT NULL,
  PRIMARY KEY (`id_category`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `song` (
  `id_song` int(11) NOT NULL AUTO_INCREMENT,
  `author` varchar(250) NOT NULL,
  `name` varchar(250) NOT NULL,
  `text` text NOT NULL,
  `id_category` int(11) NOT NULL,
  PRIMARY KEY (`id_song`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

CREATE TABLE IF NOT EXISTS `waitsong` (
  `id_waitsong` int(11) NOT NULL AUTO_INCREMENT,
  `name_waitsong` varchar(250) NOT NULL,
  `author_waitsong` varchar(250) NOT NULL,
  `id_category` int(11) NOT NULL,
  PRIMARY KEY (`id_waitsong`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;
