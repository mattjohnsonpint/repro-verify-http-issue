using System.Runtime.CompilerServices;

namespace BaseLibrary;

public static class ModuleInit
{
    [ModuleInitializer]
    public static void Init()
    {
        VerifyHttp.Enable();
    }
}