using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLayer
{
   public  interface ISettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
