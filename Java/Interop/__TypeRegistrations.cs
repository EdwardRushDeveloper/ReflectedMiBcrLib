namespace Java.Interop
{
    using System;

    internal class __TypeRegistrations
    {
        private static string[] package_com_mitac_cell_device_bcr_mappings;

        private static Type Lookup(string[] mappings, string javaType)
        {
            string typeMapping = TypeManager.LookupTypeMapping(mappings, javaType);
            if (typeMapping == null)
            {
                return null;
            }
            return Type.GetType(typeMapping);
        }

        private static Type lookup_com_mitac_cell_device_bcr_package(string klass)
        {
            if (package_com_mitac_cell_device_bcr_mappings == null)
            {
                package_com_mitac_cell_device_bcr_mappings = new string[] { "com/mitac/cell/device/bcr/IRemoteBcrListener$Stub:Com.Mitac.Cell.Device.Bcr.RemoteBcrListenerStub", "com/mitac/cell/device/bcr/IRemoteBcrListener$Stub$Proxy:Com.Mitac.Cell.Device.Bcr.RemoteBcrListenerStub/Proxy", "com/mitac/cell/device/bcr/IRemoteBcrService$Stub:Com.Mitac.Cell.Device.Bcr.RemoteBcrServiceStub", "com/mitac/cell/device/bcr/IRemoteBcrService$Stub$Proxy:Com.Mitac.Cell.Device.Bcr.RemoteBcrServiceStub/Proxy" };
            }
            return Lookup(package_com_mitac_cell_device_bcr_mappings, klass);
        }

        public static void RegisterPackages()
        {
            string[] textArray1 = new string[] { "com/mitac/cell/device/bcr" };
            Converter<string, Type>[] converterArray1 = new Converter<string, Type>[] { new Converter<string, Type>(__TypeRegistrations.lookup_com_mitac_cell_device_bcr_package) };
            TypeManager.RegisterPackages(textArray1, converterArray1);
        }
    }
}

