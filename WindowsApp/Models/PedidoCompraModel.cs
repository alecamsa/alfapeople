using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsApp.Models
{
	[XmlRoot(ElementName = "PedidoCompra")]
	public class PedidoCompra
	{
		[XmlElement(ElementName = "CodigoCompra")]
		public string CodigoCompra { get; set; }

		[XmlElement(ElementName = "NombreProveedor")]
		public string NombreProveedor { get; set; }

		[XmlElement(ElementName = "FechaCompra")]
		public DateTime FechaCompra { get; set; }

		[XmlElement(ElementName = "Lineas")]
		public LineasPedido Lineas { get; set; }
	}
}
