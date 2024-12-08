using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;
namespace Tyuiu.DemchenkoAD.Sprint5.Task3.V8.Lib
{
    public class DataService : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            string file = Path.GetTempFileName();

                     
           double y = (Math.Pow(x, 2) + 1) / (3 * x + 4);

            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return file;
        }
    }
}
