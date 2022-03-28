using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer
{
    public class Settings : ISettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }
}
