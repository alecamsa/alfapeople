using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsApp.Models;

namespace WindowsApp.Utils
{
    public class XmlUtility
    {
		public string DeserializeXml(string xml)
		{
			string jsonString = "";
			if (xml.Contains("</PedidoCompra>"))
			{
				jsonString = DeserializePedido<PedidoCompra>(xml);
			}
			else if (xml.Contains("</PedidoVenta>"))
			{
				jsonString = DeserializePedido<PedidoVenta>(xml);
			}
			else
			{
				throw new Exception("Estructura de archivo inválido");
			}
			
			JToken parsedJson = JToken.Parse(jsonString);
			return parsedJson.ToString(Formatting.Indented);
		}

		private string DeserializePedido<T> (string xml)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			using (StringReader reader = new StringReader(xml))
			{
				var pedido = (T)serializer.Deserialize(reader);
				return JsonConvert.SerializeObject(pedido);
			}
		}
	}
}
