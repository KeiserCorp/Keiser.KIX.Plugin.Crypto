namespace Keiser.KIX.Plugin.Crypto.Droid
{
    using Cirrious.CrossCore;
    using Cirrious.CrossCore.Plugins;

    public class Plugin
        : IMvxPlugin
    {
        public void Load()
        {
            Mvx.RegisterType<ICrypto, DroidCrypto>();
        }
    }
}
