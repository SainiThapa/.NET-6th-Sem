CREATE TABLE [dbo].[Student] (
    [CollegeId]      INT          NOT NULL,
    [CollegeName]    VARCHAR (30) NOT NULL,
    [Address]        VARCHAR (50) NULL,
    [UniversityName] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([CollegeId] ASC)
);

