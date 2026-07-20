namespace ParcelManagementSystemWebAPI.Model
{
    public class Parcel
    {
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string Status { get; set; }
    }
}
