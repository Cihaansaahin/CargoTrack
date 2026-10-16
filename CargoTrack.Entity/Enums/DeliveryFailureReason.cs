using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Enums
{
    public enum  DeliveryFailureReason
    {
        WrongAdress = 1,           //Adres hatalı
        RecipientNotFound = 2,     //Alıcı adreste yok
        Damaged = 3,               //Kargo hatalı
        Refused = 4,               // Alıcı reddetti
        Other = 99 
    }
}
