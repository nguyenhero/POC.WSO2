
using System.Xml.Linq;

namespace SOAP.Models
{
    public class SeaportService : ISeaportService
    {

        private readonly List<SeaportModel> _data = new()
            {
                new SeaportModel() { GlobalName = "Seaport I",Name = "Seaport I", Id = 1 },
                new SeaportModel() { GlobalName = "Seaport II",Name = "Seaport II", Id = 2 },
                new SeaportModel() { GlobalName = "Seaport III",Name = "Seaport III", Id = 3 },
                new SeaportModel() { GlobalName = "Seaport IV",Name = "Seaport IV", Id = 4 },
            };


        public List<SeaportModel> Get()
        {
            return _data;
        }
        public bool Create(SeaportModel data)
        {
            _data.Add(data);
            return true;
        }
        public SeaportModel GetById(int id)
        {
            SeaportModel? current = _data.FirstOrDefault(x => x.Id == id);
            return current ?? throw new Exception("Not Found");
        }
        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Update(int id, SeaportModel data)
        {
            SeaportModel? current = _data.FirstOrDefault(x => x.Id == id);
            if (current != null)
            {
                current.Name = data.Name;
                current.GlobalName = data.GlobalName;
            }
            else
            {
                throw new Exception("Not Found");
            }
            return true;
        }
        /// <summary>
        /// Cập nhật từng phần
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Patch(int id, SeaportModel data)
        {
            SeaportModel? current = _data.FirstOrDefault(x => x.Id == id);
            if (current != null)
            {

                if (!string.IsNullOrEmpty(data.Name))
                {
                    current.Name = data.Name;
                }

                if (!string.IsNullOrEmpty(data.GlobalName))
                {
                    current.GlobalName = data.GlobalName;
                }
            }
            else
            {
                throw new Exception("Not Found");
            }
            return true; ;
        }
        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            SeaportModel? current = _data.FirstOrDefault(x => x.Id == id);
            _ = current != null ? _data.Remove(current) : throw new Exception("Not Found");
            return true;
        }

        public void XmlMethod(XElement xml)
        {
            throw new NotImplementedException();
        }

    }

}