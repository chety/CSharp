using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Tutor.Properties;

namespace Tutor.DesignPatterns.Creational.AbstractFactoryDP
{
    public class UiGenerator
    {
        public static IGUICreatorFactory GenerateUIGenerator()
        {
            //will read project resources.resx os value to create appropriate ui elements
            string osName = Resources.OS.ToLowerInvariant();
            if (osName == "windows")
            {
                return new WindowsUIFactory();
            }

            if (osName == "macos")
            {
                return new AppleUIFactory();
            }

            throw new  ArgumentNullException($"Unknown os name. Got: {osName}");
        }
    }
}
