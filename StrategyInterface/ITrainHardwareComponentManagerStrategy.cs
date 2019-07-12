namespace StrategyInterface
{
    public interface ITrainHardwareComponentManagerStrategy
    {
        // Just think of this as a generic interface that defines the ways we can connect to a 
        // complex hardware and manage it...
        void Connect(string ip);
        
        // we could define a lot of additional functions like:
        // Disconnect();
        // GetTypeOfHardware (to get if it is an LED, TFT, RCOM, etc...)
        // GetVersion
        // GetManufacturer
        // Check
        // ExecuteHealthTest
        // UpdateCredentials  - GetCredentials
        // And so on...

        // But, for easiness... we just implement a single method 
    }
}
