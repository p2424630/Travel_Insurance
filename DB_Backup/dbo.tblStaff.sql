CREATE TABLE [dbo].[tblStaff] (
    [Staff_ID]       INT          NOT NULL,
    [staff_Fullname] TEXT         NULL,
    [start_Date]     DATE         NULL,
    [staff_Address]  TEXT         NULL,
    [clockedin]      NCHAR (10)   NULL,
    [staff_Salary]   DECIMAL (18) NULL,
    [staff_num]      INT          NULL,
    PRIMARY KEY CLUSTERED ([Staff_ID] ASC)
);

