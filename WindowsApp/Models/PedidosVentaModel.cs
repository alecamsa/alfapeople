using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsApp.Models
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(PedidoVenta));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (PedidoVenta)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "LineasPedidoVenta")]
	public class LineasPedidoVenta : ProductoModel
	{
		[XmlElement(ElementName = "CantidadVenta")]
		public int CantidadVenta { get; set; }

		[XmlElement(ElementName = "UnidadVenta")]
		public string UnidadVenta { get; set; }
	}

	[XmlRoot(ElementName = "Lineas")]
	public class LineasCompra
	{
		[XmlElement(ElementName = "LineasPedidoVenta")]
		public List<LineasPedidoVenta> LineasPedidoVenta { get; set; }
	}
}
