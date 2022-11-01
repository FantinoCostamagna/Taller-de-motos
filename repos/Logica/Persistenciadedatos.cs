using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica
{
    public class Persistenciadedatos
    {



        readonly string RutaListacliente = @"C:\Users\Fanti\source\repos\Taller de motos\Listacliente.txt";
        readonly string RutaListamecanico = @"C:\Users\Fanti\source\repos\Taller de motos\Listamecanico.txt";
        readonly string RutaListaproveedores = @"C:\Users\Fanti\source\repos\Taller de motos\Listaproveedores.txt";
        readonly string RutaListasecretarias = @"C:\Users\Fanti\source\repos\Taller de motos\Listasecretarias.txt";
        readonly string RutaListavendedores = @"C:\Users\Fanti\source\repos\Taller de motos\Listavendedores.txt";
        readonly string RutaListaarticulos = @"C:\Users\Fanti\source\repos\Taller de motos\Listaarticulos.txt";
        readonly string RutaListacobrosReparaciones = @"C:\Users\Fanti\source\repos\Taller de motos\ListacobrosReparaciones.txt";
        readonly string RutaListafacturas = @"C:\Users\Fanti\source\repos\Taller de motos\Listafacturas.txt";
        readonly string RutaListainformeReparaciones = @"C:\Users\Fanti\source\repos\Taller de motos\ListainformeReparaciones.txt";
        readonly string RutaListamotos = @"C:\Users\Fanti\source\repos\Taller de motos\Listamotos.txt";
        readonly string RutaListaprecios = @"C:\Users\Fanti\source\repos\Taller de motos\Listaprecios.txt";
        readonly string RutaListareservas = @"C:\Users\Fanti\source\repos\Taller de motos\Listareservas.txt";
        readonly string RutaListastock = @"C:\Users\Fanti\source\repos\Taller de motos\Listastock.txt";
        readonly string RutaListaventas = @"C:\Users\Fanti\source\repos\Taller de motos\Listaventas.txt";
    

    public void InicializarArchivos()
    {
        if (!File.Exists(RutaListacliente))
        {
            File.Create(RutaListacliente).Close();
        }

        if (!File.Exists(RutaListamecanico))
        {
            File.Create(RutaListamecanico).Close();
        }

        if (!File.Exists(RutaListaproveedores))
        {
            File.Create(RutaListaproveedores).Close();
        }

        if (!File.Exists(RutaListasecretarias))
        {
            File.Create(RutaListasecretarias).Close();
        }

        if (!File.Exists(RutaListavendedores))
        {
            File.Create(RutaListavendedores).Close();
        }

        if (!File.Exists(RutaListaarticulos))
        {
            File.Create(RutaListaarticulos).Close();
        }

        if (!File.Exists(RutaListacobrosReparaciones))
        {
            File.Create(RutaListacobrosReparaciones).Close();
        }

        if (!File.Exists(RutaListafacturas))
        {
            File.Create(RutaListafacturas).Close();
        }

        if (!File.Exists(RutaListainformeReparaciones))
        {
            File.Create(RutaListainformeReparaciones).Close();
        }

        if (!File.Exists(RutaListamotos))
        {
            File.Create(RutaListamotos).Close();
        }

        if (!File.Exists(RutaListaprecios))
        {
            File.Create(RutaListaprecios).Close();
        }

        if (!File.Exists(RutaListareservas))
        {
            File.Create(RutaListareservas).Close();
        }

        if (!File.Exists(RutaListastock))
        {
            File.Create(RutaListastock).Close();
        }

        if (!File.Exists(RutaListaventas))
        {
            File.Create(RutaListaventas).Close();
        }
    }

      
 

        public List<Cliente> LeerArchivoCliente()
    {

        string locationFile = RutaListacliente;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Cliente> Listacliente = JsonConvert.DeserializeObject<List<Cliente>>(content);
            return Listacliente;
        }

    }

        public List<Mecanicos> LeerArchivoMecanico()
    {
        string locationFile = RutaListamecanico;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Mecanicos> Listamecanico = JsonConvert.DeserializeObject<List<Mecanicos>>(content);
            return Listamecanico;
        }

    }

    public List<Proveedores> LeerArchivoProveedores()
    {
        string locationFile = RutaListaproveedores;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Proveedores> Listaproveedores = JsonConvert.DeserializeObject<List<Proveedores>>(content);
            return Listaproveedores;
        }

    }

    public List<Secretarias> LeerArchivoSecretarias()
    {
        string locationFile = RutaListasecretarias;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Secretarias> Listasecretarias = JsonConvert.DeserializeObject<List<Secretarias>>(content);
            return Listasecretarias;
        }

    }

    public List<Vendedores> LeerArchivoVendedores()
    {
        string locationFile = RutaListavendedores;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Vendedores> Listavendedores = JsonConvert.DeserializeObject<List<Vendedores>>(content);
            return Listavendedores;
        }

    }

    public List<Articulos> LeerArchivoArticulos()
    {
        string locationFile = RutaListaarticulos;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Articulos> Listaarticulos = JsonConvert.DeserializeObject<List<Articulos>>(content);
            return Listaarticulos;
        }

    }

    public List<cobrosReparaciones> LeerArchivocobrosReparaciones()
    {
        string locationFile = RutaListacobrosReparaciones;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<cobrosReparaciones> ListacobrosReparaciones = JsonConvert.DeserializeObject<List<cobrosReparaciones>>(content);
            return ListacobrosReparaciones;
        }

    }

    public List<Facturas> LeerArchivoFacturas()
    {
        string locationFile = RutaListafacturas;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Facturas> Listafacturas = JsonConvert.DeserializeObject<List<Facturas>>(content);
            return Listafacturas;
        }

    }

    public List<informeReparaciones> LeerArchivoinformeReparaciones()
    {
        string locationFile = RutaListainformeReparaciones;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<informeReparaciones> ListainformeReparaciones = JsonConvert.DeserializeObject<List<informeReparaciones>>(content);
            return ListainformeReparaciones;
        }

    }

    public List<Motos> LeerArchivoMotos()
    {
        string locationFile = RutaListamotos;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Motos> Listamotos = JsonConvert.DeserializeObject<List<Motos>>(content);
            return Listamotos;
        }

    }

    public List<Precio> LeerArchivoPrecio()
    {
        string locationFile = RutaListaprecios;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Precio> Listaprecios = JsonConvert.DeserializeObject<List<Precio>>(content);
            return Listaprecios;
        }

    }

    public List<Reservas> LeerArchivoReservas()
    {
        string locationFile = RutaListareservas;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Reservas> Listareservas = JsonConvert.DeserializeObject<List<Reservas>>(content);
            return Listareservas;
        }

    }

    public List<Stock> LeerArchivoStock()
    {
        string locationFile = RutaListastock;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Stock> Listastock = JsonConvert.DeserializeObject<List<Stock>>(content);
            return Listastock;
        }

    }

    public List<Ventas> LeerArchivoVentas()
    {
        string locationFile = RutaListaventas;
        using (StreamReader reader = new StreamReader(locationFile))
        {
            string content = reader.ReadToEnd();
            List<Ventas> Listaventas = JsonConvert.DeserializeObject<List<Ventas>>(content);
            return Listaventas;
        }

    }

    public void GuardarArchivoCliente(List<Cliente> Listacliente)
    {
        string locationFile = RutaListacliente;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listacliente);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoMecanico(List<Mecanicos> Listamecanico)
    {
        string locationFile = RutaListamecanico;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listamecanico);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoProveedores(List<Proveedores> Listaproveedores)
    {
        string locationFile = RutaListaproveedores;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listaproveedores);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoSecretarias(List<Secretarias> Listasecretarias)
    {
        string locationFile = RutaListasecretarias;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listasecretarias);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoVendedores(List<Vendedores> Listavendedores)
    {
        string locationFile = RutaListavendedores;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listavendedores);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoArticulos(List<Articulos> Listaarticulos)
    {
        string locationFile = RutaListaarticulos;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listaarticulos);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivocobrosReparaciones(List<cobrosReparaciones> ListacobrosReparaciones)
    {
        string locationFile = RutaListacobrosReparaciones;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(ListacobrosReparaciones);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoFacturas(List<Facturas> Listafacturas)
    {
        string locationFile = RutaListafacturas;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listafacturas);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoinformeReparaciones(List<informeReparaciones> ListainformeReparaciones)
    {
        string locationFile = RutaListainformeReparaciones;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(ListainformeReparaciones);
            writer.Write(jsonContent);
        }
    }

    public void GuardarArchivoMotos(List<Motos> Listamotos)
    {
        string locationFile = RutaListamotos;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listamotos);
            writer.Write(jsonContent);
        }

    }

    public void GuardarArchivoPrecio(List<Precio> Listaprecios)
    {
        string locationFile = RutaListaprecios;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listaprecios);
            writer.Write(jsonContent);
        }

    }

    public void GuardarArchivoReservas(List<Reservas> Listareservas)
    {
        string locationFile = RutaListareservas;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listareservas);
            writer.Write(jsonContent);
        }

    }

    public void GuardarArchivoStock(List<Stock> Listastock)
    {
        string locationFile = RutaListastock;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listastock);
            writer.Write(jsonContent);
        }

    }

    public void GuardarArchivoVentas(List<Ventas> Listaventas)
    {
        string locationFile = RutaListaventas;
        using (StreamWriter writer = new StreamWriter(locationFile, false))
        {
            string jsonContent = JsonConvert.SerializeObject(Listaventas);
            writer.Write(jsonContent);
        }

    }
    }
}

