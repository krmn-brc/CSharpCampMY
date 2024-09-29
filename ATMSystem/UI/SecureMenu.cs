using System.ComponentModel;

namespace ATMSystem.UI
{
    public enum SecureMenu
    {
        [Description("Bakiye Sorgulama")]
        CheckBalance =1,

        [Description("Para Yatırma")]
        PlaceDeposit,

        [Description("Para Çekme")]
        WithDrawal,

        [Description("Para Transferi")]
        PartyTransfer,

        [Description("Hesap Hareketleri")]
        Transaction,

        [Description("Çıkış Yap")]
        Logout
    }
}