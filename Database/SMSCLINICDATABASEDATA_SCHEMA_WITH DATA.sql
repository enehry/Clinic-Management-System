CREATE SCHEMA clinicsmsdb;

CREATE TABLE clinicsmsdb.tblcollege ( 
	college_code         int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	college_name         varchar(100)  NOT NULL    
 ) engine=InnoDB;

CREATE TABLE clinicsmsdb.tblcourse ( 
	course_code          int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	course_name          varchar(100)  NOT NULL    ,
	college_code         int UNSIGNED NOT NULL    
 ) engine=InnoDB;

CREATE INDEX fk_tblcourse_tblcollege ON clinicsmsdb.tblcourse ( college_code );

CREATE TABLE clinicsmsdb.tblmedicine ( 
	medicine_code        int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	medicine_name        varchar(100)  NOT NULL    ,
	generic_name         varchar(100)      ,
	description          varchar(255)      ,
	milligrams           int UNSIGNED NOT NULL    ,
	stock                int UNSIGNED NOT NULL    ,
	date_restock         datetime  NOT NULL DEFAULT CURRENT_TIMESTAMP   ,
	is_archive           boolean  NOT NULL DEFAULT false   
 ) engine=InnoDB;

CREATE TABLE clinicsmsdb.tblstudentprofile ( 
	student_number       varchar(10)  NOT NULL    PRIMARY KEY,
	fname                varchar(100)  NOT NULL    ,
	mname                varchar(100)      ,
	lname                varchar(100)  NOT NULL    ,
	course_code          int UNSIGNED NOT NULL    ,
	address              varchar(255)  NOT NULL    ,
	contact_no           varchar(45)      ,
	created_at           datetime  NOT NULL DEFAULT CURRENT_TIMESTAMP   ,
	sex                  enum('m', 'f')      ,
	is_archive           boolean  NOT NULL DEFAULT false   
 ) engine=InnoDB;

CREATE INDEX fk_tblstudentprofile_tblcourse ON clinicsmsdb.tblstudentprofile ( course_code );

CREATE TABLE clinicsmsdb.tbltransaction ( 
	id                   int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	student_number       varchar(10)  NOT NULL    ,
	medicine_code        int UNSIGNED NOT NULL    ,
	quantity_released    int UNSIGNED NOT NULL    ,
	is_archive           boolean  NOT NULL DEFAULT false   ,
	`date`               date  NOT NULL    
 ) engine=InnoDB;

CREATE INDEX fk_tbltransaction_tblmedicine ON clinicsmsdb.tbltransaction ( medicine_code );

CREATE INDEX fk_tbltransaction_tblstudentprofile ON clinicsmsdb.tbltransaction ( student_number );

CREATE TABLE clinicsmsdb.tbluser ( 
	id                   int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	username             varchar(100)  NOT NULL    ,
	password             varchar(100)  NOT NULL    ,
	usertype             enum('nurse', 'assistant')  NOT NULL    ,
	create_at            datetime  NOT NULL    ,
	updated_at           datetime  NOT NULL DEFAULT CURRENT_TIMESTAMP   ,
	is_archive           boolean  NOT NULL    ,
	login_name           varchar(100)  NOT NULL    ,
	CONSTRAINT unq_tbluser UNIQUE ( username ) 
 ) engine=InnoDB;

CREATE TABLE clinicsmsdb.tblactivitylog ( 
	id                   int UNSIGNED NOT NULL  AUTO_INCREMENT  PRIMARY KEY,
	username             varchar(100)  NOT NULL    ,
	activity             varchar(255)  NOT NULL    ,
	created_at           datetime  NOT NULL DEFAULT CURRENT_TIMESTAMP   
 ) engine=InnoDB;

CREATE INDEX fk_tblactivitylog_tbluser ON clinicsmsdb.tblactivitylog ( username );

ALTER TABLE clinicsmsdb.tblactivitylog ADD CONSTRAINT fk_tblactivitylog_tbluser FOREIGN KEY ( username ) REFERENCES clinicsmsdb.tbluser( username ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE clinicsmsdb.tblcourse ADD CONSTRAINT fk_tblcourse_tblcollege FOREIGN KEY ( college_code ) REFERENCES clinicsmsdb.tblcollege( college_code ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE clinicsmsdb.tblstudentprofile ADD CONSTRAINT fk_tblstudentprofile_tblcourse FOREIGN KEY ( course_code ) REFERENCES clinicsmsdb.tblcourse( course_code ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE clinicsmsdb.tbltransaction ADD CONSTRAINT fk_tbltransaction_tblstudentprofile FOREIGN KEY ( student_number ) REFERENCES clinicsmsdb.tblstudentprofile( student_number ) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE clinicsmsdb.tbltransaction ADD CONSTRAINT fk_tbltransaction_tblmedicine FOREIGN KEY ( medicine_code ) REFERENCES clinicsmsdb.tblmedicine( medicine_code ) ON DELETE NO ACTION ON UPDATE NO ACTION;

INSERT INTO clinicsmsdb.tblcollege( college_code, college_name ) VALUES ( 1, 'College of Computer Studies');
INSERT INTO clinicsmsdb.tblcollege( college_code, college_name ) VALUES ( 2, 'College of Engineering');
INSERT INTO clinicsmsdb.tblcollege( college_code, college_name ) VALUES ( 9, 'College of Education');
INSERT INTO clinicsmsdb.tblcourse( course_code, course_name, college_code ) VALUES ( 1, 'BSIT', 2);
INSERT INTO clinicsmsdb.tblcourse( course_code, course_name, college_code ) VALUES ( 4, 'BSE', 2);
INSERT INTO clinicsmsdb.tblcourse( course_code, course_name, college_code ) VALUES ( 6, 'BST', 1);
INSERT INTO clinicsmsdb.tblmedicine( medicine_code, medicine_name, generic_name, description, date_restock, is_archive, milligrams, stock ) VALUES ( 1, 'Advil', 'Iburofen', 'Pain reliever', '2021-04-28 07.40.06 pm', 0, 0, 0);
INSERT INTO clinicsmsdb.tblmedicine( medicine_code, medicine_name, generic_name, description, date_restock, is_archive, milligrams, stock ) VALUES ( 2, 'Alaxan', 'Paracetamol', 'Pain releiver', '2021-04-30 06.23.14 pm', 0, 500, 3);
INSERT INTO clinicsmsdb.tblmedicine( medicine_code, medicine_name, generic_name, description, date_restock, is_archive, milligrams, stock ) VALUES ( 3, 'Neozep', 'Parasatukmol', 'Some description', '2021-04-30 06.19.54 pm', 0, 500, 0);
INSERT INTO clinicsmsdb.tblstudentprofile( student_number, fname, mname, lname, course_code, address, contact_no, created_at, sex, is_archive ) VALUES ( '4423', 'John', 'C', 'Dedoro', 1, 'Angono, RIzal', '09123123', '2021-04-30 02.24.45 am', 'm', 0);
INSERT INTO clinicsmsdb.tblstudentprofile( student_number, fname, mname, lname, course_code, address, contact_no, created_at, sex, is_archive ) VALUES ( '44234', 'John Nehry', 'C', 'Dedoro', 1, 'Angono, RIzal', '09123123', '2021-04-30 02.24.56 am', 'f', 0);
INSERT INTO clinicsmsdb.tblstudentprofile( student_number, fname, mname, lname, course_code, address, contact_no, created_at, sex, is_archive ) VALUES ( '442346', 'John', 'C', 'Dedoro', 1, 'Angono, RIzal', '09123123', '2021-04-30 02.25.02 am', 'm', 1);
INSERT INTO clinicsmsdb.tblstudentprofile( student_number, fname, mname, lname, course_code, address, contact_no, created_at, sex, is_archive ) VALUES ( '4438', 'Nehry', 'updated', 'updated', 1, 'updated', '8700', '2021-04-28 07.48.02 pm', 'f', 1);
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 1, '4438', 1, 1, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 2, '44234', 3, 1, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 3, '44234', 2, 1, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 4, '4423', 2, 100, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 5, '442346', 3, 3, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbltransaction( id, student_number, medicine_code, quantity_released, is_archive, `date` ) VALUES ( 6, '44234', 2, 3, 0, '2021-04-30');
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 1, 'enehry', '12345', 'nehry', 'nurse', '2021-08-16 08.00.00 am', '2021-04-26 06.25.54 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 2, 'test', '12345', 'nehry(updated)', 'nurse', '2021-08-16 08.00.00 am', '2021-04-27 05.40.57 am', 1);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 3, 'test3', '123456', 'test', 'assistant', '2003-08-16 08.00.00 am', '2021-04-26 06.26.32 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 4, 'enehry1', '123456', 'Nehry Dedoro 1', 'nurse', '0001-01-01 08.00.00 am', '2021-04-28 05.17.42 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 5, 'johnyYes', '1234567', 'Johny Yes Papa (updated)', 'assistant', '2021-04-26 11.50.53 pm', '2021-04-27 12.08.02 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 6, 'enehry123', '123456', 'Yes Papa (updated)', 'assistant', '2021-04-26 11.53.10 pm', '2021-04-27 12.10.43 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 7, 'monpogi', '123456', 'Mon Alber Gamil', 'nurse', '2021-04-26 11.53.10 pm', '2021-04-26 11.53.10 pm', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 8, 'Gmail12', 'Mon Albert Gmail', '123456', 'nurse', '2021-04-27 05.35.30 am', '2021-04-27 05.35.30 am', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 9, 'DenisWalis', 'Denis Patis', '123456', 'nurse', '2021-04-27 05.37.55 am', '2021-04-30 06.26.15 am', 1);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 10, 'UsernameMoto', 'PasswordMoto', 'Logged In ', 'nurse', '2021-04-27 05.39.27 am', '2021-04-28 05.50.57 am', 1);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 11, 'NameTest123', 'NameTest123', 'NameTest', 'assistant', '2021-04-27 05.40.57 am', '2021-04-27 05.40.57 am', 1);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 12, 'thunder', '123456', 'thunder (updated)', 'assistant', '2021-04-28 05.03.35 am', '2021-04-28 07.48.02 pm', 0);
INSERT INTO clinicsmsdb.tbluser( id, username, password, login_name, usertype, create_at, updated_at, is_archive ) VALUES ( 13, 'assistant', 'assistant', 'John Nehry C Dedoro', 'assistant', '2021-04-30 08.54.56 am', '2021-04-30 08.54.56 am', 0);
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 1, 'enehry', 'Restored User : NameTest123', '2021-04-28 07.40.06 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 2, 'enehry', 'Restored User : thunder', '2021-04-28 07.40.08 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 3, 'enehry', 'Restored User : UsernameMoto', '2021-04-28 07.40.11 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 4, 'enehry', 'Restored User : UsernameMoto', '2021-04-28 07.40.14 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 5, 'enehry', 'Restored User : enehry1', '2021-04-28 07.40.17 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 6, 'enehry', 'Restored User : enehry1', '2021-04-28 07.40.18 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 7, 'enehry', 'Restored User : enehry1', '2021-04-28 07.40.20 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 8, 'enehry', 'Restored User : test3', '2021-04-28 07.40.24 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 9, 'enehry', 'Added To Trash : ', '2021-04-28 07.45.10 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 10, 'enehry', 'Added To Trash : thunder', '2021-04-28 07.47.43 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 11, 'enehry', 'Restored User : thunder', '2021-04-28 07.47.47 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 12, 'enehry', 'Updated User : thunder', '2021-04-28 07.48.02 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 13, 'enehry', 'Student Added : 4423', '2021-04-30 02.24.45 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 14, 'enehry', 'Student Added : 44234', '2021-04-30 02.24.56 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 15, 'enehry', 'Student Added : 442346', '2021-04-30 02.25.02 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 16, 'enehry', 'Student Added to : 442346', '2021-04-30 05.34.49 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 17, 'enehry', 'Student Updated : 44234', '2021-04-30 05.35.26 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 18, 'enehry', 'Student Added to : 44234', '2021-04-30 05.53.55 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 19, 'enehry', 'Student Added to : 4438', '2021-04-30 05.54.25 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 20, 'enehry', 'Student Restored : 44234', '2021-04-30 05.54.28 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 21, 'enehry', 'Student Restored : 44234', '2021-04-30 05.54.31 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 22, 'enehry', 'Student Added to : 4438', '2021-04-30 05.55.26 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 23, 'enehry', 'Student Added to : 4438', '2021-04-30 05.55.53 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 24, 'enehry', 'Student Restored : 4438', '2021-04-30 05.57.28 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 25, 'enehry', 'Student Added to : 4438', '2021-04-30 06.13.45 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 26, 'enehry', 'Student Added to : 442346', '2021-04-30 06.13.47 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 27, 'enehry', 'Student Added to : 44234', '2021-04-30 06.13.49 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 28, 'enehry', 'Student Added to : 4423', '2021-04-30 06.13.50 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 29, 'enehry', 'Student Restored : 4423', '2021-04-30 06.14.04 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 30, 'enehry', 'Student Restored : 4438', '2021-04-30 06.14.06 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 31, 'enehry', 'Student Restored : 44234', '2021-04-30 06.14.08 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 32, 'enehry', 'Student Restored : 442346', '2021-04-30 06.14.09 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 33, 'enehry', 'Student Added to : 4438', '2021-04-30 06.19.26 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 34, 'enehry', 'Student Added to : 442346', '2021-04-30 06.19.31 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 35, 'enehry', 'Student Added to : 44234', '2021-04-30 06.19.46 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 36, 'enehry', 'Student Restored : 4438', '2021-04-30 06.20.44 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 37, 'enehry', 'Student Restored : 44234', '2021-04-30 06.20.47 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 38, 'enehry', 'Student Restored : 442346', '2021-04-30 06.20.48 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 39, 'enehry', 'Student Added to : 4438', '2021-04-30 06.20.52 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 40, 'enehry', 'Student Added to : 442346', '2021-04-30 06.21.07 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 41, 'enehry', 'Student Restored : 4438', '2021-04-30 06.22.12 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 42, 'enehry', 'Student Restored : 442346', '2021-04-30 06.22.14 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 43, 'enehry', 'Student Added to : 4438', '2021-04-30 06.22.18 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 44, 'enehry', 'Student Added to : 44234', '2021-04-30 06.22.36 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 45, 'enehry', 'Student Restored : 44234', '2021-04-30 06.23.39 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 46, 'enehry', 'Student Added to : 442346', '2021-04-30 06.23.42 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 47, 'enehry', 'Student Restored : 4438', '2021-04-30 06.23.46 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 48, 'enehry', 'Student Restored : 442346', '2021-04-30 06.23.47 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 49, 'enehry', 'Student Added to : 4438', '2021-04-30 06.24.10 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 50, 'enehry', 'Student Added to : 442346', '2021-04-30 06.24.16 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 51, 'enehry', 'Student Added to : 44234', '2021-04-30 06.24.22 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 52, 'enehry', 'Student Added to : 4423', '2021-04-30 06.24.23 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 53, 'enehry', 'Added To Trash : thunder', '2021-04-30 06.25.51 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 54, 'enehry', 'Added To Trash : NameTest123', '2021-04-30 06.25.59 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 55, 'enehry', 'Updated User : DenisWalis', '2021-04-30 06.26.15 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 56, 'enehry', 'Student Restored : 4438', '2021-04-30 06.27.12 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 57, 'enehry', 'Student Restored : 442346', '2021-04-30 06.27.13 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 58, 'enehry', 'Student Restored : 44234', '2021-04-30 06.27.14 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 59, 'enehry', 'Student Restored : 4423', '2021-04-30 06.27.15 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 60, 'enehry', 'Student Added to : 4438', '2021-04-30 06.27.19 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 61, 'enehry', 'Student Restored : 4438', '2021-04-30 06.27.23 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 62, 'enehry', 'Restored From Trash : Neozep', '2021-04-30 08.26.38 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 63, 'enehry', 'Medicine Added to Trash : Alaxan', '2021-04-30 08.32.12 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 64, 'enehry', 'Medicine Added to Trash : Advil', '2021-04-30 08.32.14 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 65, 'enehry', 'Restored From Trash : Neozep', '2021-04-30 08.32.39 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 66, 'enehry', 'Restored From Trash : Alaxan', '2021-04-30 08.32.41 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 67, 'enehry', 'Restored From Trash : Advil', '2021-04-30 08.32.43 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 68, 'enehry', 'Added To Trash : DenisWalis', '2021-04-30 08.35.40 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 69, 'enehry', 'Added To Trash : UsernameMoto', '2021-04-30 08.35.47 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 70, 'enehry', 'Added To Trash : Gmail12', '2021-04-30 08.35.58 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 71, 'enehry', 'Restored User : thunder', '2021-04-30 08.36.14 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 72, 'enehry', 'Restored User : thunder', '2021-04-30 08.36.16 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 73, 'enehry', 'Added New User : assistant', '2021-04-30 08.54.57 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 74, 'enehry', 'Medicine Updated : Advil', '2021-04-30 08.58.05 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 75, 'enehry', 'Medicine Updated : Advil', '2021-04-30 08.58.15 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 76, 'enehry', 'Medicine Updated : Alaxan', '2021-04-30 08.58.25 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 77, 'enehry', 'Medicine Updated : Neozep (updated)', '2021-04-30 08.58.58 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 78, 'assistant', 'Student Updated : 4438', '2021-04-30 09.03.52 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 79, 'assistant', 'Student Added to : 4438', '2021-04-30 09.03.57 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 80, 'assistant', 'Student Added to : 442346', '2021-04-30 09.04.05 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 81, 'enehry', 'Student Restored : 4438', '2021-04-30 09.06.25 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 82, 'enehry', 'Student Restored : 442346', '2021-04-30 09.06.27 am');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 83, 'enehry', 'Medicine Added to Trash : Neozep', '2021-04-30 05.10.35 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 84, 'enehry', 'Restored From Trash : Neozep', '2021-04-30 05.10.38 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 85, 'enehry', ' Admit : John (updated 2) C Dedoro', '2021-04-30 05.11.11 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 86, 'enehry', ' Admit : John (updated 2) C Dedoro', '2021-04-30 05.14.42 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 87, 'enehry', 'Medicine Added to Trash : Neozep', '2021-04-30 06.06.56 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 88, 'enehry', 'Added Stock : Alaxan', '2021-04-30 06.07.10 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 89, 'enehry', 'Added Stock : Alaxan', '2021-04-30 06.07.23 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 90, 'enehry', 'Added Stock : Alaxan', '2021-04-30 06.08.06 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 91, 'enehry', 'Restored From Trash : Neozep', '2021-04-30 06.08.10 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 92, 'enehry', ' Admit : John C Dedoro', '2021-04-30 06.15.20 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 93, 'enehry', ' Admit : John C Dedoro', '2021-04-30 06.19.54 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 94, 'enehry', 'Restored User : Gmail12', '2021-04-30 06.21.06 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 95, 'assistant', 'Student Added to : 4438', '2021-04-30 06.21.49 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 96, 'assistant', 'Student Added to : 442346', '2021-04-30 06.21.52 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 97, 'assistant', 'Student Updated : 44234', '2021-04-30 06.23.00 pm');
INSERT INTO clinicsmsdb.tblactivitylog( id, username, activity, created_at ) VALUES ( 98, 'assistant', ' Admit : John Nehry C Dedoro', '2021-04-30 06.23.14 pm');