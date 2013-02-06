CREATE TABLE "Country"
(
  "CountryId" integer NOT NULL,
  "Code" character varying(2) NOT NULL,
  "Name" text NOT NULL,
  "NativeName" text,
  "System" smallint
  ,
  CONSTRAINT "Country_PK" PRIMARY KEY ("CountryId")
)
WITH (
  OIDS=FALSE
);
ALTER TABLE "Country"
  OWNER TO postgres;
