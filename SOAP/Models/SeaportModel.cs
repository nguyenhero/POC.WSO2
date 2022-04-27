using System.Runtime.Serialization;
namespace SOAP.Models
{
    [DataContract]
    public class SeaportModel
    {
        [DataMember]
        /// <summary>
        /// Mã
        /// </summary>
        public int Id { get; set; }
        [DataMember]
        /// <summary>
        /// Tên tiếng việt
        /// </summary>
        public string? Name { get; set; }
        [DataMember]
        /// <summary>
        /// Tên quốc tế
        /// </summary>
        public string? GlobalName { get; set; }
    }
}
