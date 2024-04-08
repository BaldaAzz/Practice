using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N_1.Models;

namespace N_1.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Flower flower);
        void Delete(string flowerName);
        Flower FindBy(string flowerName);
        List<Flower> GetAll();
    }
}
