using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace CRUD.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DriverController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            var recibido = new List<Driver>();
            var conexion = new SqlConnection("data source=104.217.253.86;initial catalog=tracking;user id=alumno;password=12345678");
            conexion.Open();

            var pedidosql = "SELECT id,firstname,lastname,idnumber,driverlicense,driverlicenseexpirationdate,phone,email,area,imageurl,addressid,enterpriseid,active FROM driver";
            var comando = new SqlCommand(pedidosql, conexion);
            var lector = comando.ExecuteReader();

            while(lector.Read())
            {
                recibido.Add(
                    new Driver
                    {
                        id = lector.GetInt32(0),
                        FirstName = lector.GetString(1),
                        LastName = lector.GetString(2),
                        idnumber = lector.GetString(3),
                        driverlicense = lector.GetString(4),
                        driverlicenseexpirationdate = lector.GetDateTime(5),
                        Phone = lector.GetString(6),
                        Email = lector.GetString(7),
                        area = lector.GetString(8),
                        imageurl = lector.GetString(9),
                        adressid = lector.GetInt32(10),
                        enterpriseid = lector.GetInt32(11),
                        active = lector.GetString(12)
                    });
            }
            lector.Close();
            conexion.Close();
            return recibido;
        }

    }
}
