using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace hw_serialization_Product
{

    [Serializable]
    public class Product
    {
        public int Pid { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

    }
}
