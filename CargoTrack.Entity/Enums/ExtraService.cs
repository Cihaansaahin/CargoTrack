using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Enums
{
    [Flags]
    public enum ExtraService
    {
        None = 0,
        Insurance = 1,          // sigorta
        Fragile = 2,            // Kırılıcak eşya
        SmsNotification = 4,    // sms bilgilendirme
        SignatureRequired = 8   // imzalı teslim



    }
}
