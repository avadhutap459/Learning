using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class AbstractFactoryPattern
    {
    }

    public interface ISmartPhoneDetails
    {
        string GetModelDetails();
    }
    public interface INormalPhoneDetails
    {
        string GetModelDetails();
    }

    public class Nokia3500 : INormalPhoneDetails
    {
        public string GetModelDetails()
        {
            return "Nokia normal phone";
        }
    }

    public class NokiaRange : ISmartPhoneDetails
    {
        public string GetModelDetails()
        {
            return "Nokia smart phone";
        }
    }

    public class SamsungGuru3500 : INormalPhoneDetails
    {
        public string GetModelDetails()
        {
            return "Samsung normal phone";
        }
    }

    public class SamsungGalaxy : ISmartPhoneDetails
    {
        public string GetModelDetails()
        {
            return "Samsung smart phone";
        }
    }

    public interface IMobileClient
    {
        ISmartPhoneDetails GetSmartPhoneDetails();
        INormalPhoneDetails GetNormalPhoneDetails();
    }

    class Nokia : IMobileClient
    {
        public INormalPhoneDetails GetNormalPhoneDetails()
        {
            return new Nokia3500();
        }

        public ISmartPhoneDetails GetSmartPhoneDetails()
        {
            return new NokiaRange();
        }
    }

    class Samsung : IMobileClient
    {
        public INormalPhoneDetails GetNormalPhoneDetails()
        {
            return new SamsungGuru3500();
        }

        public ISmartPhoneDetails GetSmartPhoneDetails()
        {
            return new SamsungGalaxy();
        }
    }

    public class MobileClient
    {
        ISmartPhoneDetails SmartDetails;
        INormalPhoneDetails NormalDetails;

        public MobileClient(IMobileClient mobileFactory)
        {
            SmartDetails = mobileFactory.GetSmartPhoneDetails();
            NormalDetails=mobileFactory.GetNormalPhoneDetails();
        }

        public string GetSmartMobileDetails()
        {
            return SmartDetails.GetModelDetails();
        }

        public string GetNormalMobileDetails()
        {
            return NormalDetails.GetModelDetails();
        }
    }
}
