namespace Sitecore.Foundation.LocalDatasource
{
    public static class Settings
    {
        private const string LocalDatasourceFolderNameSetting = "Foundation.LocalDatasource.LocalDatasourceFolderName";

        private const string LocalDatasourceFolderNameDefault = "_Local";

        private const string LocalDatasourceFolderTemplateSetting = "Foundation.LocalDatasource.LocalDatasourceFolderTemplate";

        public static string LocalDatasourceFolderName => Configuration.Settings.GetSetting(LocalDatasourceFolderNameSetting, LocalDatasourceFolderNameDefault);

        public static string LocalDatasourceFolderTemplate => Configuration.Settings.GetSetting(LocalDatasourceFolderTemplateSetting);
    }
}
