USE [CS6232-g3]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[getMostPopularFurnitureDuringDates]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
GO

CREATE PROCEDURE getMostPopularFurnitureDuringDates
    @startDate DATE,
    @endDate DATE
AS
BEGIN
    -- Calculate the total number of rental transactions within the date range
    DECLARE @TotalRentalTransactions INT;
    SELECT @TotalRentalTransactions = COUNT(*) FROM RentalTransaction 
    WHERE RentalDate BETWEEN @startDate AND @endDate;

    SELECT 
        f.FurnitureID,
        f.CategoryName,
        f.Name,
        COUNT(DISTINCT rt.RentalTransactionID) AS RentalTransactionsCount,
        @TotalRentalTransactions AS TotalRentalTransactions,
        COUNT(DISTINCT rt.RentalTransactionID) * 100.0 / @TotalRentalTransactions AS PercentageOfRentals,
        SUM(CASE WHEN DATEDIFF(year, m.DateOfBirth, rt.RentalDate) BETWEEN 18 AND 29 THEN 1 ELSE 0 END) * 100.0 
            / COUNT(*) AS Percentage18To29,
        SUM(CASE WHEN DATEDIFF(year, m.DateOfBirth, rt.RentalDate) NOT BETWEEN 18 AND 29 THEN 1 ELSE 0 END) * 100.0 
            / COUNT(*) AS PercentageOutside18To29
    FROM 
        Furniture f
    INNER JOIN 
        RentalItem ri ON f.FurnitureID = ri.FurnitureID
    INNER JOIN 
        RentalTransaction rt ON ri.RentalTransactionID = rt.RentalTransactionID
    INNER JOIN 
        Member m ON rt.MemberID = m.MemberID
    WHERE 
        rt.RentalDate BETWEEN @startDate AND @endDate
    GROUP BY 
        f.FurnitureID, f.CategoryName, f.Name
    HAVING 
        COUNT(DISTINCT rt.RentalTransactionID) >= 2
    ORDER BY 
        RentalTransactionsCount DESC, f.FurnitureID DESC
END
GO

--EXEC getMostPopularFurnitureDuringDates '2024-04-05', '2024-04-25';