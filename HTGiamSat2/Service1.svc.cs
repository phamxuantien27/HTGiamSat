using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace HTGiamSat2
{
    static class Connection
    {
        static string ConnectionString = @"Data Source=DESKTOP-TD6J3OH\SQLEXPRESS;Initial Catalog=HTGiamSat;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(ConnectionString);
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public DataTable Camera(string ID)
        {
            DataTable result = new DataTable();
            string strCommand = @"select NhanDien.BienSo from Camera,NhanDien where Camera.ID=NhanDien.Camera_ID and Camera.ID='" + ID + "'";
            SqlCommand command = new SqlCommand(strCommand, Connection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(result);
            adapter.Dispose();
            return result;
        }
        public DataTable ViTri(string bienso)
        {
            DataTable result = new DataTable();
            string strCommand = @"select ThoiGianQua,ViTri.ViTri,Camera.ViTri from Car,NhanDien,Camera,ViTri where Car.BienSo = NhanDien.BienSo and NhanDien.Camera_ID = Camera.ID and ViTri.ID=Camera.ViTri and Car.BienSo='"+bienso+"'";
            SqlCommand command = new SqlCommand(strCommand, Connection.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(result);
            adapter.Dispose();
            return result;
        }
    }
}
