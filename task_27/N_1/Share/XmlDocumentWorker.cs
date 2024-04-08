using System;
using System.Xml;
using System.Collections.Generic;
using N_1.Interfaces;
using N_1.Models;

namespace N_1.Share
{
    class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private string _xmlFilePath;

        public XmlDocumentWorker()
        {
            _document = new XmlDocument();
        }

        public void Add(Flower flower)
        {
            var xRoot = _document.DocumentElement;

            XmlElement flowerElem = _document.CreateElement("flower");

            XmlAttribute nameAttribute = _document.CreateAttribute("floverName");
            XmlText flowerNameText = _document.CreateTextNode(flower.FlowerName);
            nameAttribute.AppendChild(flowerNameText);

            XmlAttribute priceElem = _document.CreateAttribute("price");
            XmlText priceInnerText = _document.CreateTextNode(flower.Price.ToString());
            priceElem.AppendChild(priceInnerText);

            flowerElem.AppendChild(priceElem);

            xRoot.AppendChild(flowerElem);
            _document.Save(_xmlFilePath);
        }

        public void Delete(string flowerName)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem("flowerName");
                    try
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(flowerName))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {

                        continue;
                    }
                }
            }
        }

        public Flower FindBy(string flowerName)
        {
            Flower flower = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xmlNode in xRoot)
            {
                flower = GetFlower(xmlNode);
                if (flower.FlowerName.Equals(flowerName))
                {
                    return flower;
                }
            }
            return flower;
        }

        public List<Flower> GetAll()
        {
            List<Flower> flowers = new List<Flower>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var flower = GetFlower(node);
                flowers.Add(flower);
            }
            return flowers;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);

        }

        private Flower GetFlower(XmlNode node)
        {
            var flower = new Flower();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("flowerName");
                flower.FlowerName = attributeName?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("flowerName"))
                    {
                        flower.FlowerName = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("price"))
                    {
                        flower.Price = int.Parse(childNode.InnerText);
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    continue;
                }
            }
            return flower;
        }
    }
}
