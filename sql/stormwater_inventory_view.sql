SELECT
    Asset.*,

    CONCAT(
        'https://prod.example.com/update/HFrame.htm?monk=',
        Asset.Owner,
        '.',
        Asset.ProductFamily,
        '.',
        Asset.BusinessObjectInfoViewerApplet,
        '&id=',
        Asset.UNITID,
        '&hasMenu=false&showHeader=false'
    ) AS Url

FROM
(
    SELECT
        UNITID,
        COMPKEY,
        CAST(N'Conduit' AS nvarchar(100)) AS FeatureClass,
        CAST(N'Hansen' AS nvarchar(100)) AS Owner,
        CAST(N'AssetManagement.Storm' AS nvarchar(100)) AS ProductFamily,
        CAST(N'StormLiftStation' AS nvarchar(100)) AS BusinessObject,
        CAST(N'ASSETMANAGEMENT_STORM' AS nvarchar(128)) AS DatabaseSchema,
        CAST(N'COMPSTLS' AS nvarchar(128)) AS DatabaseTable,
        CAST(N'StormLiftStationInfoViewerApplet' AS nvarchar(200)) AS BusinessObjectInfoViewerApplet,
        CAST(9204 AS int) AS TableKey
    FROM ASSETMANAGEMENT_STORM.COMPSTLS

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Culvert Cross Drain',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormServiceLine',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTSL',
        N'StormServiceLineInfoViewerApplet',
        9233
    FROM ASSETMANAGEMENT_STORM.COMPSTSL

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Debris Trap',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormValve',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTV',
        N'StormValveInfoViewerApplet',
        9284
    FROM ASSETMANAGEMENT_STORM.COMPSTV

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Ditch',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormBackflowPreventer',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTBF',
        N'StormBackflowInfoViewerApplet',
        9170
    FROM ASSETMANAGEMENT_STORM.COMPSTBF

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'End Point',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormNode',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTND',
        N'StormNodeInfoViewerApplet',
        9223
    FROM ASSETMANAGEMENT_STORM.COMPSTND

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Inlet',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormInlet',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTIN',
        N'StormInletInfoViewerApplet',
        9194
    FROM ASSETMANAGEMENT_STORM.COMPSTIN

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Junction Fixed',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormManhole',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTMH',
        N'StormManholeInfoViewerApplet',
        9209
    FROM ASSETMANAGEMENT_STORM.COMPSTMH

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Outfall',
        N'Hansen',
        N'AssetManagement.UsageArea',
        N'Complex',
        N'ASSETMANAGEMENT_USAGEAREA',
        N'COMPCPLX',
        N'ComplexAssetInfoViewerApplet',
        2198
    FROM ASSETMANAGEMENT_USAGEAREA.COMPCPLX
    WHERE UNITID LIKE 'OF%'

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Stormwater Pond Discharge',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormLevee',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTLV',
        N'StormLeveeInfoViewerApplet',
        9201
    FROM ASSETMANAGEMENT_STORM.COMPSTLV

    UNION ALL

    SELECT
        UNITID,
        COMPKEY,
        N'Stormwater Pond',
        N'Hansen',
        N'AssetManagement.Storm',
        N'StormMiscellaneous',
        N'ASSETMANAGEMENT_STORM',
        N'COMPSTMS',
        N'StormMiscellaneousInfoViewerApplet',
        9221
    FROM ASSETMANAGEMENT_STORM.COMPSTMS

) AS Asset