using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay10
{
    [Serializable]
    class Serialize_Deserialize
    {
        public int ID;
        
        public string Name;
        static void Main()
        {
            Serialize_Deserialize sobj = new Serialize_Deserialize();
            sobj.ID = 1;
            sobj.Name = "Zensar";

            IFormatter formater = new BinaryFormatter();
            //or BinaryFormatter bf = new BinaryFormatter();

            Stream stream = new FileStream(@"E:\Banu\Zensar\SFile.txt", FileMode.Create, FileAccess.Write);
            formater.Serialize(stream, sobj);
            stream.Close();

            stream= new FileStream(@"E:\Banu\Zensar\SFile.txt", FileMode.Open, FileAccess.Read);
            Serialize_Deserialize dobj =(Serialize_Deserialize) formater.Deserialize(stream);
            Console.WriteLine(dobj.ID);
            Console.WriteLine(dobj.Name);
            Console.Read();
        }
    }
}
