using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{

    public class ClsProperty
    {
        public string _publicPro { get; set; } = "Public Property";
        public static string _StaticPro { get; set; } = "Static Property";
        private string _privatePro { get; set; } = "Private Property";

        public string _Public_Private_Pro
        {
            get { return _privatePro; }
        }

        protected string _ProtectedPro { get; set; } = "Protected Property";
        public string _ProptectedPro { get { return _ProtectedPro; } }
    }

    public class ClsCallProtectProperty : ClsProperty
    {
        
    }

    public class ClsVirtualProperty
    {
        public virtual string _VirtualProperty { get; set; } = "Virtual Property";

        public virtual string _VirtualProNoDeclare { get; set; } = string.Empty;

        public virtual string _DeclareVirtualProperty { get; set; } = "Declare virtual property";
    }
    public class ClsCallVirtualProperty : ClsVirtualProperty
    {
        public override string _VirtualProperty { get; set; } = "Override Property";

        public override string _VirtualProNoDeclare { get; set; } = "Override none declare virtual property";

        public override string _DeclareVirtualProperty { get; set; }
    }


    public class PropertyInitializerCls
    {
        

        private class _PrivatePropertyInitializer
        {
            public string PrivateProperty { get; set; } = "Private Property";
        }
    }
    internal class PropertyInitializer
    {
        
    }
}
