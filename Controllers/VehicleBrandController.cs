using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using System.Data.SqlClient;

namespace CRUD.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class VehicleBrandController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Vehiclebrand> Get()
        {
            var recibido2 = new List<Vehiclebrand>();
            var conexion = new SqlConnection("data source=104.217.253.86;initial catalog=tracking;user id=alumno;password=12345678");
            conexion.Open();

            var pedidosqlb = @"SELECT id,name,enterpriseid,active
                                FROM vehiclebrand";
            var comando = new SqlCommand(pedidosqlb, conexion);
            var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                recibido2.Add(
                    new Vehiclebrand
                    {
                        Id = lector.GetInt32(0),
                        Name = lector.GetString(1),
                        //Entrepriseid = lector.GetInt32(2), DEJARON CAMPOS EN NULL CUANDO AGREGARON BRANDS EN EL EJERCICIO ANTERIOR 
                        //Active = lector.GetString(3)
                    });
            }

            lector.Close();
            conexion.Close();
            return recibido2;
        }


    }
}
