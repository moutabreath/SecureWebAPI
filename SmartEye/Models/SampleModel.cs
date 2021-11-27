using System.Text.Json.Serialization;

namespace SmartEye.Models
{
    public class SampleModel
    {
        [JsonConstructor]
        public SampleModel(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
