using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Enums
{
    public enum CargoStatus
    {
        Created = 1,
        AtOriginBranch = 2,
        AtTransferCenter = 3,
        AtDestinationBranch = 4,
        OutForDelivery = 5,
        Delivery = 6,
        DeliveryFailed = 7,
        ReturnInProcess = 8,
        ReturnedToSender = 9
    }
}
