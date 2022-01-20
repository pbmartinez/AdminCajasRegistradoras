namespace AdminCajasRegistradoras.Enums
{
    public enum EnumQdriverPluMaintenanceCommand
    {
        CPX, // Clear Complete PLU  File (same as keyboard command 255)
        CPD, //Remove deleted PLU’s from file (same as keyboard command 102)
        CPM, //Merge BASE and UPDATE Plu File (same as keyboard command 101)
        CPB //Remove deleted PLU and MERGE BASE and UPDATE file (same as keyboard command 100)

    }
}
