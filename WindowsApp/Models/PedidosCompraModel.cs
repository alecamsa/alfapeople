using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsApp.Models
{
	[XmlRoot(ElementName = "LineaPedidoCompra")]
	public class LineaPedidoCompra : ProductoModel
	{
		[XmlElement(ElementName = "CantidadCompra")]
		public int CantidadCompra { get; set; }

		[XmlElement(ElementName = "UnidadCompra")]
		public string UnidadCompra { get; set; }
	}

	[XmlRoot(ElementName = "Lineas")]
	public class LineasPedido
	{
		[XmlElement(ElementName = "LineaPedidoCompra")]
		public List<LineaPedidoCompra> LineaPedidoCompra { get; set; }
	}
}


