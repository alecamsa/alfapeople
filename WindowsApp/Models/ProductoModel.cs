using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsApp.Models
{
    public class ProductoModel
    {
		[XmlElement(ElementName = "CodigoProducto")]
		public int CodigoProducto { get; set; }

		[XmlElement(ElementName = "Nombre")]
		public string Nombre { get; set; }

		[XmlElement(ElementName = "Almacen")]
		public string Almacen { get; set; }

		[XmlElement(ElementName = "Estilo")]
		public string Estilo { get; set; }

		[XmlElement(ElementName = "Color")]
		public string Color { get; set; }

		[XmlElement(ElementName = "Talla")]
		public string Talla { get; set; }

	}
}
