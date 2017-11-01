create database pok;
use pok;
CREATE TABLE Pokemon (DexNO real , Name varchar(20), EvolvesFrom varchar(20), TypeOne varchar(20), TypeTwo varchar(20), AbilityOne varchar(20), AbilityTwo varchar(20), HiddenAbility varchar(20), Region varchar(20), Status varchar(20), constraint po_pe primary key(name,DexNO));
select * from Pokemon

ALTER TABLE Pokemon DROP constraint default  
 
 INSERT INTO Pokemon VALUES(1, 'Bulbasaur', NULL, 'Grass', 'Poison', 'Overgrow', NULL, 'Chlorophyll', 'Kanto', 'Starter'); INSERT INTO Pokemon VALUES(2, 'Ivysaur', 'Bulbasaur', 'Grass', 'Poison', 'Overgrow', NULL, 'Chlorophyll', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(3, 'Venusaur', 'Ivysaur', 'Grass', 'Poison', 'Overgrow', NULL, 'Chlorophyll', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(3.1, 'Mega Venusaur', 'Venusaur', 'Grass', 'Poison', 'Thick Fat', NULL, NULL, 'Kanto', 'Mega Starter');INSERT INTO Pokemon VALUES(4, 'Charmander', NULL, 'Fire', NULL, 'Blaze', NULL, 'Solar Power', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(5, 'Charmeleon', 'Charmander', 'Fire', NULL, 'Blaze', NULL, 'Solar Power', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(6, 'Charizard', 'Charmeleon', 'Fire', 'Flying', 'Blaze', NULL, 'Solar Power', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(6.1, 'Mega Charizard X', 'Charizard', 'Fire', 'Dragon', 'Tough Claws', NULL, NULL, 'Kanto', 'Mega Starter');INSERT INTO Pokemon VALUES(6.2, 'Mega Charizard  Y', 'Charizard', 'Fire', 'Flying', 'Drought' ,NULL, NULL, 'Kanto', 'Mega Starter');INSERT INTO Pokemon VALUES(7, 'Squirtle', NULL, 'Water', NULL, 'Torrent' ,NULL, 'Rain Dish', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(8, 'Wartortle', 'Squirtle', 'Water', NULL, 'Torrent' ,NULL, 'Rain Dish', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(9, 'Blastoise', 'Wartortle', 'Water', NULL, 'Torrent' ,NULL, 'Rain Dish', 'Kanto', 'Starter');INSERT INTO Pokemon VALUES(9.1, 'Mega Blastoise', 'Blastoise', 'Water', NULL, 'Mega Launcher' ,NULL, NULL, 'Kanto', 'Mega Starter');INSERT INTO Pokemon VALUES(10, 'Caterpie', NULL, 'Bug', NULL, 'Shield Dust' ,NULL, 'Run Away', 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(11, 'Metapod', 'Caterpie', 'Bug', NULL, 'Shed Skin' ,NULL, NULL, 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(12, 'Butterfree', 'Metapod', 'Bug', 'Flying', 'Compound Eyes' ,NULL, 'Tinted Lens', 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(13, 'Weedle', NULL, 'Bug', 'Poison', 'Shield Dust' ,NULL, 'Run Away', 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(14, 'Kakuna', 'Weedle', 'Bug', 'Poison', 'Shed Skin' ,NULL, NULL, 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(15, 'Beedrill', 'Kakuna', 'Bug', 'Poison', 'Swarm' ,NULL, 'Sniper', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(16, 'Pidgey', NULL, 'Normal', 'Flying', 'Keen Eye' ,'Tangled Feet', 'Big Pecks', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(17, 'Pidgeotto', 'Pidgey', 'Normal', 'Flying', 'Keen Eye' ,'Tangled Feet', 'Big Pecks', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(18, 'Pidgeot', 'Pidgeotto', 'Normal', 'Flying', 'Keen Eye' ,'Tangled Feet', 'Big Pecks', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(18.1, 'Mega Pidgeot', 'Pidgeot', 'Normal', 'Flying', 'No Guard' ,NULL, NULL, 'Kanto', 'Mega'); INSERT INTO Pokemon VALUES(19, 'Rattata', NULL, 'Normal', NULL, 'Run Away' ,'Guts', 'Hustle', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(19.1, 'Alolan Rattata', NULL, 'Dark', 'Normal', 'Gluttony' ,'Hustle', NULL, 'Kanto', 'Alolan Form'); INSERT INTO Pokemon VALUES(20, 'Raticate', NULL, 'Normal', NULL, 'Run Away' ,'Guts', 'Hustle', 'Kanto', 'Normal'); INSERT INTO Pokemon VALUES(20.1, 'Alolan Raticate', NULL, 'Dark', 'Normal', 'Gluttony' ,'Hustle', NULL, 'Kanto', 'Alolan Form');
 
 INSERT INTO Pokemon VALUES(25, 'Pikachu', 'Pichu', 'Electric', NULL, 'Static' ,NULL, 'Lightning Rod', 'Kanto', 'Mascot');
 
 INSERT INTO Pokemon VALUES(147, 'Dratini', NULL, 'Dragon', NULL, 'Shed Skin' ,NULL, 'Multiscale', 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(148, 'Dragonair', 'Dratini', 'Dragon', NULL, 'Inner Focus' ,NULL, 'Marvel Scale', 'Kanto', 'Normal');INSERT INTO Pokemon VALUES(149, 'Dragonite', 'Dragonair', 'Dragon', 'Flying', 'Inner Focus' ,NULL, 'Multiscale', 'Kanto', 'Pseudo-Legendary');INSERT INTO Pokemon VALUES(150, 'Mewtwo', NULL, 'Psychic', NULL, 'Pressure' ,NULL, 'Unnerve', 'Kanto', 'False'); INSERT INTO Pokemon VALUES(150.1, 'Mega Mewtwo X', 'Mewtwo', 'Psychic', 'Fighting', 'Steadfast' ,NULL, NULL, 'Kanto', 'Legendary Mega'); INSERT INTO Pokemon VALUES(150.2, 'Mega Mewtwo Y', 'Mewtwo', 'Psychic', NULL, 'Insomnia' ,NULL, NULL, 'Kanto', 'Legendary');INSERT INTO Pokemon VALUES(151, 'Mew', NULL, 'Psychic', NULL, 'Synchronize' ,NULL, NULL, 'Kanto', 'Mythical');  INSERT INTO Pokemon VALUES(152, 'Chikorita', NULL, 'Grass', NULL, 'Overgrow' ,NULL, 'Leaf Guard', 'Jotho', 'Starter');INSERT INTO Pokemon VALUES(153, 'Bayleef', 'Chikorita', 'Grass', NULL, 'Overgrow' ,NULL, 'Leaf Guard', 'Jotho', 'Starter');INSERT INTO Pokemon VALUES(154, 'Meganium', 'Bayleef', 'Grass', NULL, 'Overgrow' ,NULL, 'Leaf Guard', 'Jotho', 'Starter');INSERT INTO Pokemon VALUES(155, 'Cyndaquil', NULL, 'Fire', NULL, 'Blaze' ,NULL, 'Flash Fire', 'Jotho', 'Starter');INSERT INTO Pokemon VALUES(156, 'Quilava', 'Cyndaquil', 'Fire', NULL, 'Blaze' ,NULL, 'Flash Fire', 'Jotho', 'Starter');INSERT INTO Pokemon VALUES(157, 'Typhlosion', 'Quilava', 'Fire', NULL, 'Blaze' ,NULL, 'Flash Fire', 'Jotho', 'Starter');
 
INSERT INTO Pokemon VALUES(249, 'Lugia', NULL, 'Psychic', 'Flying', 'Pressure' ,NULL, 'Multiscale', 'Jotho', 'Legendary'); INSERT INTO Pokemon VALUES(250, 'Ho-oh', NULL, 'Fire', 'Flying', 'Pressure' ,NULL, 'Regenerator', 'Jotho', 'Legendary');INSERT INTO Pokemon VALUES(251, 'Celebi', NULL, 'Psychic', 'Grass', 'Natural Cure', NULL, NULL, 'Jotho', 'Mythical');INSERT INTO Pokemon VALUES(252, 'Treecko', NULL, 'Grass', NULL, 'Overgrow' ,NULL, 'Unburden', 'Hoenn', 'Starter');INSERT INTO Pokemon VALUES(253, 'Grovyle', 'Treecko', 'Grass', NULL, 'Overgrow' ,NULL, 'Unburden', 'Hoenn', 'Starter');INSERT INTO Pokemon VALUES(254, 'Sceptile', 'Grovyle', 'Grass', NULL, 'Overgrow' ,NULL, 'Unburden', 'Hoenn', 'Starter');INSERT INTO Pokemon VALUES(254.1, 'Mega Sceptile', 'Sceptile', 'Grass', 'Dragon', 'Lightning Rod' ,NULL, NULL, 'Hoenn', 'Mega Starter');
 
  INSERT INTO Pokemon VALUES(448, 'Lucario', 'Riolu', 'Fighting', 'Steel', 'Steadfast' ,'Inner Focus', 'Justified', 'Sinnoh', 'Normal');

 INSERT INTO Pokemon VALUES(468, 'Togekiss', 'Togetic', 'Fairy', 'Flying', 'Hustle' ,'Serene Grace', 'Super Luck', 'Sinnoh', 'Normal');
 
 
INSERT INTO Pokemon VALUES(647, 'Keldeo', NULL, 'Water', 'Fighting', 'Justified' ,NULL, NULL, 'Unova', 'Mythical');INSERT INTO Pokemon VALUES(647.1, 'Keldeo Resolute', NULL, 'Water', 'Fighting', 'Justified' ,NULL, NULL, 'Unova', 'Mythical');INSERT INTO Pokemon VALUES(648, 'Meloetta', NULL, 'Normal', 'Psychic', 'Serene Grace' ,NULL, NULL, 'Unova', 'Mythical');INSERT INTO Pokemon VALUES(648.1, 'Meloetta Pirouette', NULL, 'Normal', 'Fighting', 'Serene Grace' ,NULL, NULL, 'Unova', 'Mythical');INSERT INTO Pokemon VALUES(649, 'Genesect', NULL, 'Bug', 'Steel', 'Download' ,NULL, NULL, 'Unova', 'Mythical');INSERT INTO Pokemon VALUES(650, 'Chespin', NULL, 'Grass', NULL, 'Overgrow' ,NULL, 'Bulletproof', 'Kalos', 'Starter');INSERT INTO Pokemon VALUES(651, 'Quilladin', 'Chespin', 'Grass', NULL, 'Overgrow' ,NULL, 'Bulletproof', 'Kalos', 'Starter');INSERT INTO Pokemon VALUES(652, 'Chesnaught', 'Quilladin', 'Grass', 'Fighting', 'Overgrow' ,NULL, 'Bulletproof', 'Kalos', 'Starter');INSERT INTO Pokemon VALUES(653, 'Fennekin', NULL, 'Fire', NULL, 'Blaze' ,NULL, 'Magician', 'Kalos', 'Starter');INSERT INTO Pokemon VALUES(654, 'Braixen', 'Fennekin', 'Fire', NULL, 'Blaze' ,NULL, 'Magician', 'Kalos', 'Starter');INSERT INTO Pokemon VALUES(655, 'Delphox', 'Braixen', 'Fire', 'Psychic', 'Blaze' ,NULL, 'Magician', 'Kalos', 'Starter');
 
INSERT INTO Pokemon VALUES(714, 'Noibat', NULL, 'Flying', 'Dragon', 'Frisk' ,'Infiltrator', 'Telepathy', 'Kalos', 'Normal');INSERT INTO Pokemon VALUES(715, 'Noivern', 'Noibat', 'Flying', 'Dragon', 'Frisk' ,'Infiltrator', 'Telepathy', 'Kalos', 'Normal');INSERT INTO Pokemon VALUES(716, 'Xerneas', NULL, 'Fairy', NULL, 'Fairy Aura' ,NULL, NULL, 'Kalos', 'Legendary');INSERT INTO Pokemon VALUES(717, 'Yveltal', NULL, 'Dark', 'Flying', 'Dark Aura' ,NULL, NULL, 'Kalos', 'Legendary');INSERT INTO Pokemon VALUES(718, 'Zygarde', NULL, 'Dragon', 'Ground', 'Aura Break' ,NULL, NULL, 'Kalos', 'Legendary');INSERT INTO Pokemon VALUES(719, 'Diancie', NULL, 'Rock', 'Fairy', 'Clear Body' ,NULL, NULL, 'Kalos', 'Mythical');INSERT INTO Pokemon VALUES(719.1, 'Mega Diancie', 'Diancie', 'Rock', 'Fairy', ' Magic Bounce' ,NULL, NULL, 'Kalos', 'Mythical');INSERT INTO Pokemon VALUES(720, 'Hoopa', NULL, 'Psychic', 'Ghost', ' Magician' ,NULL, NULL, 'Kalos', 'Mythical');INSERT INTO Pokemon VALUES(720.1, 'Hoopa Unbound', 'Hoopa', 'Pyschic', 'Dark', 'Magician' ,NULL, NULL, 'Kalos', 'Mythical');INSERT INTO Pokemon VALUES(721, 'Volcanion', NULL, 'Fire', 'Water', 'Water Absorb' ,NULL, NULL, 'Kalos', 'Mythical');  

alter Table Pokemon add CP int default 0 Not null;
alter Table Pokemon add HP int default 0 Not null;
alter Table Pokemon add constraint pe_fo foreign key(name) references Pokemon(name);

update Pokemon set HP=100
update Pokemon set CP=10

///////////////////////////////////////////////////////////////////////////

create table trainer (
	tid int,
	name varchar(30),
	lvl int,
	place varchar(30),
	skill varchar(30),
	coins int,
	constraint tk primary key(tid)	
);


insert into trainer values(21,'Ash',15,'NYC','expert',12000);
insert into trainer values(22,'Mystical',14,'California','professional',10500);
insert into trainer values(23,'Brock',15,'LA','master',16000);

select * from trainer;

/////////////////////////////////////////////////////////////////////

create table pokecenter (
	pcid int,
	name varchar(20),
	location varchar(20),
	doc varchar(20),
	constraint pck primary key(pcid) 
);

insert into pokecenter values(101,'Walsh Center','NYC','Mr. Sam');
insert into pokecenter values(132,'W.D.C Center','Washington','Mrs. Felicity');
insert into pokecenter values(189,'LA Center','LA','Mr. Shock');
insert into pokecenter values(245,'California Center','California','Mr. Edward');

select * from pokecenter

////////////////////////////////////////////////////////////////////

create table gym (
	gid int,
	name varchar(20),
	badge varchar(20),
	battle int,
	lvl int,
	tournament int,
	loc varchar(20),
	constraint gck primary key(gid)
	
);

insert into gym values(12,'Dimo Gym','Purple Ruby',5,8,2,'NYC');
insert into gym values(15,'Gold Gym','Yellow Stud',9,6,4,'Washington');
insert into gym values(18,'Sun Gym','Red Gem',5,4,1,'LA');

select * from gym

////////////////////////////////////////////////////////////////////

create table pokestop(

	psid int,
	rberry int,
	stones int,
	potions int,
	pballs int,
	xp int,
	loc varchar(20),
	constraint psck primary key(psid)

);

insert into pokestop values(03,156,356,189,366,15,'NYC');
insert into pokestop values(04,356,166,274,400,10,'LA');
insert into pokestop values(05,107,106,321,125,12,'Washington');
insert into pokestop values(06,266,156,222,327,16,'California');
insert into pokestop values(07,76,376,451,259,11,'Miami');

select * from pokestop

////////////////////////////////////////////////////////////////////