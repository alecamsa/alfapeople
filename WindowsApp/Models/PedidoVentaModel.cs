using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsApp.Models
{
	[XmlRoot(ElementName = "PedidoVenta")]
	public class PedidoVenta
	{

		[XmlElement(ElementName = "CodigoVenta")]
		public string CodigoVenta { get; set; }

		[XmlElement(ElementName = "NombreCliente")]
		public string NombreCliente { get; set; }

		[XmlElement(ElementName = "FechaVenta")]
		public DateTime FechaVenta { get; set; }

		[XmlElement(ElementName = "Lineas")]
		public LineasCompra Lineas { get; set; }
	}
}
