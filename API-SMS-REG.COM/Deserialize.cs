namespace API_SMS_REG.COM
{
    class MSG
    {
        public string response { get; set; }
        public string number { get; set; }
        public string service { get; set; }
        public string msg { get; set; }
    }
    class StateNumber
    {
        public string response { get; set; }
        public string number { get; set; }
        public string service { get; set; }
    }
    class GetNum
    {
        public string response { get; set; }
        public string tzid { get; set; }
    }
    class SMS_BALANCE
    {
        public string response { get; set; }
        public string balance { get; set; }
    }
}
