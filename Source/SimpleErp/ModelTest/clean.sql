IF OBJECT_ID('dbo.__MigrationHistory', 'U') IS NOT NULL Drop TABLE dbo.__MigrationHistory;
IF OBJECT_ID('dbo.InventoryItem', 'U') IS NOT NULL Drop TABLE dbo.InventoryItem;
IF OBJECT_ID('dbo.InventoryCategory', 'U') IS NOT NULL Drop TABLE dbo.InventoryCategory;
IF OBJECT_ID('dbo.InventoryUOM', 'U') IS NOT NULL Drop TABLE dbo.InventoryUOM;
IF OBJECT_ID('dbo.VendorContact', 'U') IS NOT NULL Drop TABLE dbo.VendorContact;
IF OBJECT_ID('dbo.Vendor', 'U') IS NOT NULL Drop TABLE dbo.Vendor;
