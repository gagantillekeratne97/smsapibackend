namespace ServvistaWebAppAPI.Models
{
    public class ServiceVisitDailyInfoModel
    {
        public string cusName { get; set; }
        public string serialNo { get; set; }
        public string machineRefNo { get; set; }
        public string expectedVisitNo { get; set; }
        public DateTime expectedVisitDate { get; set; }
    }

    public class ServiceVisitMonthlyInfo
    {
        public string machineRefNo { get; set; }
        public string expectedVisitNo { get; set; }
        public DateTime expectedVisitDate { get; set; }
        public int expectedVisitCount { get; set; }
        public string VisitStatus { get; set; }
    }
}
