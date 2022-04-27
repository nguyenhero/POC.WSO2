
using System.ServiceModel;
namespace SOAP.Models
{
    [ServiceContract]
    public interface ISeaportService
    {

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        /// <summary>
        /// Lấy về danh sách
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<SeaportModel> Get();
        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [OperationContract]
        bool Create(SeaportModel data);
        /// <summary>
        /// Lấy về 1 theo mã
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        SeaportModel GetById(int id);

        /// <summary>
        /// Cập nhật
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [OperationContract]
        bool Update(int id, SeaportModel data);
        /// <summary>
        /// Cập nhật từng phần
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        [OperationContract]
        bool Patch(int id, SeaportModel data);

        /// <summary>
        /// Xóa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        bool Delete(int id);

    }

}
