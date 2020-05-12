CREATE TABLE [dbo].[tblReview] (
    [ReviewId]            INT  NOT NULL,
    [CustomerId]          INT  NOT NULL,
    [ReviewText]          TEXT NOT NULL,
    [ReviewTitle]         TEXT NULL,
    [DatePublished]       DATE NULL,
    [IsComplaintRecorded] BIT  NOT NULL,
    PRIMARY KEY CLUSTERED ([ReviewId] ASC)
);

