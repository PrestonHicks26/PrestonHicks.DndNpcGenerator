using Newtonsoft.Json;
namespace PH.DndNpcGenerator.StatBlockGenerator.Utilities
{
    public class Util
    {
        public static List<T> LoadJsonData<T>(string path)
        {
            string Json;
            List<T> ElementList;
            using (StreamReader reader = new StreamReader(path))
            {
                Json = reader.ReadToEnd();
                ElementList = JsonConvert.DeserializeObject<List<T>>(Json);
            }
            return ElementList;
        }
    }
}
