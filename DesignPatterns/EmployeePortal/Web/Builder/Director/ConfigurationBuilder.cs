using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using Web.Builder.IBuilder;

namespace Web.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systembuilder,NameValueCollection collection)
        {
            systembuilder.AddDrive(collection["Drive"])
            .AddMemory(collection["RAM"])
            .AddKeyBoard(collection["KeyBoard"])
            .AddMouse(collection["Mouse"])
            .AddTouchScreen(collection["TouchScreen"]);
        }
    }
}