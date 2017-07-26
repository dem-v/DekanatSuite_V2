CREATE TABLE Students (
	StudID INT IDENTITY(1,1) NOT NULL,
	FamilyName TEXT NOT NULL,
	FirstName TEXT NOT NULL,
	FathersName TEXT,
	GradeID INT NOT NULL,
	GroupID INT NOT NULL,
	PhoneNumber TEXT NOT NULL,
	TypeOfEducation TEXT NOT NULL,
	OrderOfAcceptance TEXT NOT NULL,
	PRIMARY KEY (StudID)
);

CREATE TABLE "GuestsOfAdministration" (
	"PersonID" INT IDENTITY(1,1) NOT NULL,
	"FamilyName" TEXT NOT NULL,
	"FirstName" TEXT NOT NULL,
	"FathersName" TEXT,
	"DateOfBirth" DATETIME NOT NULL,
	"EMail" TEXT NOT NULL,
	"PhoneNumber" TEXT NOT NULL,
	"Reason" TEXT NOT NULL,
	"RelativeTo" TEXT NOT NULL,
	PRIMARY KEY ("PersonID")
);

CREATE TABLE "RequestForPermission" (
	"RecordID" INT IDENTITY(1,1) NOT NULL,
	"StudID" INT NOT NULL,
	"DateOfRequest" DATETIME NOT NULL,
	"NumberOfMissedClasses" INT NOT NULL,
	"ListOfDatesMissed" TEXT NOT NULL,
	"MissedDepartment" TEXT NOT NULL,
	"PermissionType" INT NOT NULL,
	"Explanation" TEXT NOT NULL,
	"ValidTill" DATETIME NOT NULL,
	"HasArrived" bit NOT NULL DEFAULT 0,
	"IsAllowed" bit NOT NULL DEFAULT 0,
	"HasReceived" bit NOT NULL DEFAULT 0,
	PRIMARY KEY ("RecordID")
);

CREATE TABLE "RequestForCertificates" (
	"RequestID" INT NOT NULL IDENTITY(1,1),
	"StudID" INT NOT NULL,
	"DateOfRequest" DATETIME NOT NULL,
	"RequestingOrganization" TEXT NOT NULL,
	"HasArrived" bit NOT NULL DEFAULT 0,
	"IsAllowed" bit NOT NULL DEFAULT 0,
	"HasReceived" bit NOT NULL DEFAULT 0,
	PRIMARY KEY ("RequestID")
);

CREATE TABLE "DeansRecord" (
	"RecordID" INT NOT NULL IDENTITY(1,1),
	"IsStudent" bit NOT NULL DEFAULT 0,
	"StudID" INT NOT NULL,
	"PersonID" INT NOT NULL,
	"DateOfRequest" DATETIME NOT NULL,
	"DateOfReceipt" DATETIME NOT NULL,
	"Reason" TEXT NOT NULL,
	"HasArrived" bit NOT NULL DEFAULT 0,
	"IsAccepted" bit NOT NULL DEFAULT 0,
	PRIMARY KEY ("RecordID")
);

CREATE TABLE "DeansTimeTableView" (
	"RecViewID" INT NOT NULL,
	"RecordID" INT NOT NULL,
	"TableName" TEXT NOT NULL,
	"DateAndTimeOfRecord" DATETIME NOT NULL
);

CREATE TABLE "OfficeTimeTableView" (
	"RecViewID" INT NOT NULL,
	"RecordID" INT NOT NULL,
	"TableName" TEXT NOT NULL,
	"DateAndTimeOfRecord" DATETIME NOT NULL
);

ALTER TABLE "RequestForPermission" ADD CONSTRAINT "RequestForPermission_fk0" FOREIGN KEY ("StudID") REFERENCES "Students"("StudID");

ALTER TABLE "RequestForCertificates" ADD CONSTRAINT "RequestForCertificates_fk0" FOREIGN KEY ("StudID") REFERENCES "Students"("StudID");

ALTER TABLE "DeansRecord" ADD CONSTRAINT "DeansRecord_fk0" FOREIGN KEY ("StudID") REFERENCES "Students"("StudID");

ALTER TABLE "DeansRecord" ADD CONSTRAINT "DeansRecord_fk1" FOREIGN KEY ("PersonID") REFERENCES "GuestsOfAdministration"("PersonID");

