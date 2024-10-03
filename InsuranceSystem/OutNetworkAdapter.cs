namespace InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        private OutNetworkPatient outNetworkPatient;

        // Constructor that instantiates OutNetworkPatient
        public OutNetworkAdapter()
        {
            outNetworkPatient = new OutNetworkPatient();
        }

        // Implementing getPatientName by calling OutNetworkPatient's method
        public string getPatientName()
        {
            return outNetworkPatient.getPatientName();
        }

        // Implementing getPolicyNumber by calling OutNetworkPatient's method and converting to string
        public string getPolicyNumber()
        {
            return outNetworkPatient.getPolicyNumber().ToString();
        }

        // Implementing CoverageAmount by calling CoveragePercent and multiplying it by procedureCost
        public double CoverageAmount(double procedureCost)
        {
            return outNetworkPatient.CoveragePercent() * procedureCost;
        }

        // Implementing IsCovered by converting policy number to int and calling OutNetworkPatient's IsCovered
        public bool IsCovered(string policyNumber)
        {
            int policyNum = Int32.Parse(policyNumber);
            return outNetworkPatient.IsCovered(policyNum);
        }
    }
}
