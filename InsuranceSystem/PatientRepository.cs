using System;
using System.Collections.Generic;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class PatientRepository
    {
        // Using a dictionary to store patients with policy numbers as keys
        Dictionary<string, InsuranceInterface> patients = new Dictionary<string, InsuranceInterface>();

        public PatientRepository()
        {
            // Adding InNetwork patients
            patients.Add("A111B222", new InNetworkPatient("Tom Gibbons", "A111B222", PolicyLevels.Gold));
            patients.Add("A222C444", new InNetworkPatient("Jen Rosato", "A222C444", PolicyLevels.Platinum));
            patients.Add("D333B111", new InNetworkPatient("Dave Vosen", "D333B111", PolicyLevels.Silver));

            // Adding an OutNetwork patient using OutNetworkAdapter
            patients.Add("112233", new OutNetworkAdapter()); // Assuming "112233" is the policy number
        }

        // Method to get all patients
        public IEnumerable<InsuranceInterface> getAllPatients()
        {
            return patients.Values;
        }

        // Method to get a patient by their policy number
        public InsuranceInterface getPatientByPolicy(string policyNumber)
        {
            if (patients.TryGetValue(policyNumber, out InsuranceInterface patient))
            {
                return patient;
            }
            throw new KeyNotFoundException($"Patient with policy number {policyNumber} not found.");
        }
    }
}
