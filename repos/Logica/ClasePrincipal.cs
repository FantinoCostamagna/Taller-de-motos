using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClasePrincipal
    {
        List<Cliente> Listacliente = new List<Cliente>(); //Lista cliente

        List<Mecanicos> Listamecanico = new List<Mecanicos>(); //Lista mecanico

        List<Proveedores> Listaproveedores = new List<Proveedores>(); //Lista proveedores

        List<Secretarias> Listasecretarias = new List<Secretarias>(); //Lista secreatarias

        List<Vendedores> Listavendedores = new List<Vendedores>(); //Lista vendedores

        List<Articulos> Listaarticulos = new List<Articulos>(); //Lista articulos

        List<cobrosReparaciones> ListacobrosReparaciones = new List<cobrosReparaciones>(); // Lista cobrosReparaciones

        List<Facturas> Listafacturas = new List<Facturas>(); //Lista facturas

        List<informeReparaciones> ListainformeReparaciones = new List<informeReparaciones>(); // Lista informeReparaciones

        List<Motos> Listamotos = new List<Motos>(); // Lista motos

        List<Precio> Listaprecios = new List<Precio>(); // Lista precio

        List<Reservas> Listareservas = new List<Reservas>(); // Lista reservas

        List<Stock> Listastock = new List<Stock>(); //Lista stock

        List<Ventas> Listaventas = new List<Ventas>(); // Lista ventas


        Persistenciadedatos InstanciaPersistenciadedatos = new Persistenciadedatos();


        public void RellenarListas()
        {
            Listacliente = InstanciaPersistenciadedatos.LeerArchivoCliente();
            Listamecanico = InstanciaPersistenciadedatos.LeerArchivoMecanico();
            Listaproveedores = InstanciaPersistenciadedatos.LeerArchivoProveedores();
            Listasecretarias = InstanciaPersistenciadedatos.LeerArchivoSecretarias();
            Listavendedores = InstanciaPersistenciadedatos.LeerArchivoVendedores();
            Listaarticulos = InstanciaPersistenciadedatos.LeerArchivoArticulos();
            ListacobrosReparaciones = InstanciaPersistenciadedatos.LeerArchivocobrosReparaciones();
            Listafacturas = InstanciaPersistenciadedatos.LeerArchivoFacturas();
            ListainformeReparaciones = InstanciaPersistenciadedatos.LeerArchivoinformeReparaciones();
            Listamotos = InstanciaPersistenciadedatos.LeerArchivoMotos();
            Listaprecios = InstanciaPersistenciadedatos.LeerArchivoPrecio();
            Listareservas = InstanciaPersistenciadedatos.LeerArchivoReservas();
            Listastock = InstanciaPersistenciadedatos.LeerArchivoStock();
            Listaventas = InstanciaPersistenciadedatos.LeerArchivoVentas();


        }






        //Alta Cliente
        public void AltaCliente(Cliente personaNueva)
        {
            Listacliente =  ValidarCliente();
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Telefono = personaNueva.Telefono;
            nuevoCliente.Correo = personaNueva.Correo;
            nuevoCliente.DNI = personaNueva.DNI;
            nuevoCliente.Nombre = personaNueva.Nombre;
            nuevoCliente.Direccion = personaNueva.Direccion;
            nuevoCliente.fechaNacimiento = personaNueva.fechaNacimiento;
            nuevoCliente.ID_Cliente = personaNueva.ID_Cliente;

            Listacliente.Add(nuevoCliente);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);
        }


        //Modificacion cliente
        public void ModificarCliente(Cliente personaNueva, int idcliente)
        {
            Listacliente = ValidarCliente();
            var clienteModificado = Listacliente.Find(x => idcliente == x.ID_Cliente);

            clienteModificado.Telefono = personaNueva.Telefono;
            clienteModificado.Correo = personaNueva.Correo;
            clienteModificado.DNI = personaNueva.DNI;
            clienteModificado.Nombre = personaNueva.Nombre;
            clienteModificado.Direccion = personaNueva.Direccion;
            clienteModificado.fechaNacimiento = personaNueva.fechaNacimiento;
            clienteModificado.ID_Cliente = idcliente;

            var clienteEliminado = Listacliente.Find(x => idcliente == x.ID_Cliente);
            Listacliente.Remove(clienteEliminado);
            Listacliente.Add(clienteModificado);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);


        }

        //Baja cliente
        public void BajaCliente(int idcliente)
        {
            Listacliente = ValidarCliente();
            var clienteEliminado = Listacliente.Find(x => idcliente == x.ID_Cliente);
            Listacliente.Remove(clienteEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);

        }






        //Alta mecanico
        public void AltaMecanicos(Mecanicos personaNueva)
        {
            Listamecanico = ValidarMecanico();
            Mecanicos nuevoMecanico = new Mecanicos();
            nuevoMecanico.Telefono = personaNueva.Telefono;
            nuevoMecanico.Correo = personaNueva.Correo;
            nuevoMecanico.DNI = personaNueva.DNI;
            nuevoMecanico.Nombre = personaNueva.Nombre;
            nuevoMecanico.Direccion = personaNueva.Direccion;
            nuevoMecanico.fechaNacimiento = personaNueva.fechaNacimiento;
            Listamecanico.Add(nuevoMecanico);
            InstanciaPersistenciadedatos.GuardarArchivoMecanico(Listamecanico);

        }

        //Modificacion mecanico
        public void ModificacionMecanico(Mecanicos personaNueva, int idmecanico, string dni)
        {
            Listamecanico = ValidarMecanico();

            var mecanicoModificado = Listamecanico.Find(x => idmecanico == x.ID_Mecanico);

            mecanicoModificado.Telefono = personaNueva.Telefono;
            mecanicoModificado.Correo = personaNueva.Correo;
            mecanicoModificado.Nombre = personaNueva.Nombre;
            mecanicoModificado.Direccion = personaNueva.Direccion;
            mecanicoModificado.fechaNacimiento = personaNueva.fechaNacimiento;
            mecanicoModificado.DNI = dni;
            mecanicoModificado.ID_Mecanico = idmecanico;

            var mecanicoEliminado = Listamecanico.Find(x => idmecanico == x.ID_Mecanico);
            Listamecanico.Remove(mecanicoEliminado);
            Listamecanico.Add(mecanicoModificado);
            InstanciaPersistenciadedatos.GuardarArchivoMecanico(Listamecanico);


        }

        //Baja mecanico
        public void BajaMecanico(int idmecanico)
        {
            Listamecanico = ValidarMecanico();

            var mecanicoEliminado = Listamecanico.Find(x => idmecanico == x.ID_Mecanico);
            Listamecanico.Remove(mecanicoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoMecanico(Listamecanico);

        }





        //Alta proveedor
        public void AltaProveedores(Proveedores personaNueva)
        {
            Listaproveedores = ValidarProveedores();
            Proveedores nuevoProveedores = new Proveedores();
            nuevoProveedores.Telefono = personaNueva.Telefono;
            nuevoProveedores.Correo = personaNueva.Correo;
            nuevoProveedores.DNI = personaNueva.DNI;
            nuevoProveedores.Nombre = personaNueva.Nombre;
            nuevoProveedores.Direccion = personaNueva.Direccion;
            nuevoProveedores.fechaNacimiento = personaNueva.fechaNacimiento;
            Listaproveedores.Add(nuevoProveedores);
            InstanciaPersistenciadedatos.GuardarArchivoProveedores(Listaproveedores);


        }

        //Modificacion proveedor
        public void ModificacionProveedores(Proveedores personaNueva, int idproveedor, int cuit, string dni)
        {
            Listaproveedores = ValidarProveedores();

            var proveedorModificado = Listaproveedores.Find(x => idproveedor == x.ID_Proveedor);

            proveedorModificado.Telefono = personaNueva.Telefono;
            proveedorModificado.Correo = personaNueva.Correo;
            proveedorModificado.Nombre = personaNueva.Nombre;
            proveedorModificado.Direccion = personaNueva.Direccion;
            proveedorModificado.fechaNacimiento = personaNueva.fechaNacimiento;
            proveedorModificado.DNI = dni;
            proveedorModificado.ID_Proveedor = idproveedor;
            proveedorModificado.Cuit = cuit;

            var proveedorEliminado = Listaproveedores.Find(x => idproveedor == x.ID_Proveedor);
            Listaproveedores.Remove(proveedorEliminado);
            Listaproveedores.Add(proveedorModificado);
            InstanciaPersistenciadedatos.GuardarArchivoProveedores(Listaproveedores);


        }

        //Baja proveedor
        public void Bajaproveedor(int idproveedor)
        {
            Listaproveedores = ValidarProveedores();

            var proveedorEliminado = Listaproveedores.Find(x => idproveedor == x.ID_Proveedor);
            Listaproveedores.Remove(proveedorEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoProveedores(Listaproveedores);

        }





        //Alta secretarias
        public void AltaSecretarias(Secretarias personaNueva)
        {
            Listasecretarias = Validarsecretarias();
            Secretarias nuevoSecretarias = new Secretarias();
            nuevoSecretarias.Telefono = personaNueva.Telefono;
            nuevoSecretarias.Correo = personaNueva.Correo;
            nuevoSecretarias.DNI = personaNueva.DNI;
            nuevoSecretarias.Nombre = personaNueva.Nombre;
            nuevoSecretarias.Direccion = personaNueva.Direccion;
            nuevoSecretarias.fechaNacimiento = personaNueva.fechaNacimiento;
            Listasecretarias.Add(nuevoSecretarias);
            InstanciaPersistenciadedatos.GuardarArchivoSecretarias(Listasecretarias);


        }

        //Modificacion Secretaria
        public void ModificacionSecretarias(Secretarias personaNueva, int idsecretaria, string dni)
        {
            Listasecretarias = Validarsecretarias();

            var secretariaModificada = Listasecretarias.Find(x => idsecretaria == x.ID_Secretaria);

            secretariaModificada.Telefono = personaNueva.Telefono;
            secretariaModificada.Correo = personaNueva.Correo;
            secretariaModificada.Nombre = personaNueva.Nombre;
            secretariaModificada.Direccion = personaNueva.Direccion;
            secretariaModificada.fechaNacimiento = personaNueva.fechaNacimiento;
            secretariaModificada.DNI = dni;
            secretariaModificada.ID_Secretaria = idsecretaria;

            var secretariaEliminada = Listasecretarias.Find(x => idsecretaria == x.ID_Secretaria);
            Listasecretarias.Remove(secretariaEliminada);
            Listasecretarias.Add(secretariaModificada);
            InstanciaPersistenciadedatos.GuardarArchivoSecretarias(Listasecretarias);


        }

        //Baja secretaria
        public void Bajasecretaria(int idsecretaria)
        {
            Listasecretarias = Validarsecretarias();

            var secretariaEliminada = Listasecretarias.Find(x => idsecretaria == x.ID_Secretaria);
            Listasecretarias.Remove(secretariaEliminada);
            InstanciaPersistenciadedatos.GuardarArchivoSecretarias(Listasecretarias);

        }




        //Alta vendedores
        public void Altavendedores(Vendedores personaNueva)
        {
            Listavendedores = Validarvendedores();
            Vendedores nuevoVendedores = new Vendedores();
            nuevoVendedores.Telefono = personaNueva.Telefono;
            nuevoVendedores.Correo = personaNueva.Correo;
            nuevoVendedores.DNI = personaNueva.DNI;
            nuevoVendedores.Nombre = personaNueva.Nombre;
            nuevoVendedores.Direccion = personaNueva.Direccion;
            nuevoVendedores.fechaNacimiento = personaNueva.fechaNacimiento;
            Listavendedores.Add(nuevoVendedores);
            InstanciaPersistenciadedatos.GuardarArchivoVendedores(Listavendedores);


        }

        //Modificacion vendedor
        public void ModificacionVendedores(Vendedores personaNueva, int idvendedor, string dni)
        {
            Listavendedores = Validarvendedores();

            var vendedorModificado = Listavendedores.Find(x => idvendedor == x.ID_Vendedor);

            vendedorModificado.Telefono = personaNueva.Telefono;
            vendedorModificado.Correo = personaNueva.Correo;
            vendedorModificado.Nombre = personaNueva.Nombre;
            vendedorModificado.Direccion = personaNueva.Direccion;
            vendedorModificado.fechaNacimiento = personaNueva.fechaNacimiento;
            vendedorModificado.DNI = dni;
            vendedorModificado.ID_Vendedor = idvendedor;

            var vendedorEliminado = Listavendedores.Find(x => idvendedor == x.ID_Vendedor);
            Listavendedores.Remove(vendedorEliminado);
            Listavendedores.Add(vendedorModificado);
            InstanciaPersistenciadedatos.GuardarArchivoVendedores(Listavendedores);


        }

        //Baja vendedor
        public void Bajavendedor(int idvendedor)
        {
            Listavendedores = Validarvendedores();

            var vendedorEliminado = Listavendedores.Find(x => idvendedor == x.ID_Vendedor);
            Listavendedores.Remove(vendedorEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoVendedores(Listavendedores);

        }




        //Alta articulo
        public void AltaArticulo(Articulos articuloNuevo)
        {
            Listaarticulos = ValidarArticulos();
            Articulos nuevoArtiuculo = new Articulos();
            nuevoArtiuculo.ID_Articulo = articuloNuevo.ID_Articulo;
            nuevoArtiuculo.Cantidad = articuloNuevo.Cantidad;
            nuevoArtiuculo.Tipo = articuloNuevo.Tipo;
            nuevoArtiuculo.descripcionArticulo = articuloNuevo.descripcionArticulo;
            Listaarticulos.Add(nuevoArtiuculo);
            InstanciaPersistenciadedatos.GuardarArchivoArticulos(Listaarticulos);


        }

        //Modificacion articulo
        public void ModificacionArticulo(Articulos articuloNuevo, int idarticulo)
        {
            Listaarticulos = ValidarArticulos();

            var articuloModificado = Listaarticulos.Find(x => idarticulo == x.ID_Articulo);

            articuloModificado.descripcionArticulo = articuloNuevo.descripcionArticulo;
            articuloModificado.Tipo = articuloNuevo.Tipo;
            articuloModificado.Cantidad = articuloNuevo.Cantidad;
            articuloModificado.ID_Articulo = idarticulo;

            var articuloEliminado = Listaarticulos.Find(x => idarticulo == x.ID_Articulo);
            Listaarticulos.Remove(articuloEliminado);
            Listaarticulos.Add(articuloModificado);
            InstanciaPersistenciadedatos.GuardarArchivoArticulos(Listaarticulos);


        }

        //Baja articulo
        public void Bajaarticulo(int idarticulo)
        {
            Listaarticulos = ValidarArticulos();

            var articuloEliminado = Listaarticulos.Find(x => idarticulo == x.ID_Articulo);
            Listaarticulos.Remove(articuloEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoArticulos(Listaarticulos);

        }




        //Alta informeReparaciones
        public void AltainformeReparaciones(informeReparaciones informeReparacionesNuevo)
        {
            ListainformeReparaciones = ValidarinformeReparaciones();
            informeReparaciones nuevoinformeReparaciones = new informeReparaciones();
            nuevoinformeReparaciones.importeReparacion = informeReparacionesNuevo.importeReparacion;
            nuevoinformeReparaciones.ID_Cliente = informeReparacionesNuevo.ID_Cliente;
            nuevoinformeReparaciones.detalleReparacion = informeReparacionesNuevo.detalleReparacion;
            nuevoinformeReparaciones.ID_informeReparacion = informeReparacionesNuevo.ID_informeReparacion;
            nuevoinformeReparaciones.ID_Cliente = informeReparacionesNuevo.ID_Cliente;
            nuevoinformeReparaciones.ID_Moto = informeReparacionesNuevo.ID_Moto;
            nuevoinformeReparaciones.ID_Mecanico = informeReparacionesNuevo.ID_Mecanico;
            ListainformeReparaciones.Add(nuevoinformeReparaciones);
            InstanciaPersistenciadedatos.GuardarArchivoinformeReparaciones(ListainformeReparaciones);



        }


        //Modificacion informeReparaciones
        public void ModificacioninformeReparaciones(informeReparaciones informeReparacionesNuevo, int id_informeReparacion)
        {
            ListainformeReparaciones = ValidarinformeReparaciones();

            var informeReparacionesModificado = ListainformeReparaciones.Find(x => id_informeReparacion == x.ID_informeReparacion);

            informeReparacionesModificado.importeReparacion = informeReparacionesNuevo.importeReparacion;
            informeReparacionesModificado.ID_Cliente = informeReparacionesNuevo.ID_Cliente;
            informeReparacionesModificado.ID_Cliente = informeReparacionesNuevo.ID_Cliente;
            informeReparacionesModificado.ID_Moto = informeReparacionesNuevo.ID_Moto;
            informeReparacionesModificado.ID_Mecanico = informeReparacionesNuevo.ID_Mecanico;
            informeReparacionesModificado.detalleReparacion = informeReparacionesNuevo.detalleReparacion;
            informeReparacionesModificado.ID_informeReparacion = id_informeReparacion;

            var informeReparacionesEliminado = ListainformeReparaciones.Find(x => id_informeReparacion == x.ID_informeReparacion);
            ListainformeReparaciones.Remove(informeReparacionesEliminado);
            ListainformeReparaciones.Add(informeReparacionesModificado);
            InstanciaPersistenciadedatos.GuardarArchivoinformeReparaciones(ListainformeReparaciones);


        }

        //Baja informeReparaciones
        public void BajainformeReparaciones(int id_informeReparacion)
        {
            ListainformeReparaciones = ValidarinformeReparaciones();

            var informeReparacionesEliminado = ListainformeReparaciones.Find(x => id_informeReparacion == x.ID_informeReparacion);
            ListainformeReparaciones.Remove(informeReparacionesEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoinformeReparaciones(ListainformeReparaciones);

        }





        //Alta cobrosReparaciones
        public void AltacobrosReparaciones(cobrosReparaciones cobrosReparacionesNuevo)
        {
            ListacobrosReparaciones = ValidarcobrosReparaciones();
            cobrosReparaciones nuevocobrosReparaciones = new cobrosReparaciones();
            nuevocobrosReparaciones.importeReparacion = cobrosReparacionesNuevo.importeReparacion;
            nuevocobrosReparaciones.ID_Cliente = cobrosReparacionesNuevo.ID_Cliente;
            nuevocobrosReparaciones.ID_Moto = cobrosReparacionesNuevo.ID_Moto;
            nuevocobrosReparaciones.ID_Mecanico = cobrosReparacionesNuevo.ID_Mecanico;
            ListacobrosReparaciones.Add(nuevocobrosReparaciones);
            InstanciaPersistenciadedatos.GuardarArchivocobrosReparaciones(ListacobrosReparaciones);


        }


        //Modificacion cobrosReparaciones
        public void ModificacioncobrosReparaciones(cobrosReparaciones cobrosReparacionesNuevo, int id_cobrosReparaciones)
        {
            ListacobrosReparaciones = ValidarcobrosReparaciones();

            var cobrosReparacionesModificado = ListacobrosReparaciones.Find(x => id_cobrosReparaciones == x.ID_cobrosReparaciones);

            cobrosReparacionesModificado.importeReparacion = cobrosReparacionesNuevo.importeReparacion;
            cobrosReparacionesModificado.ID_Cliente = cobrosReparacionesNuevo.ID_Cliente;
            cobrosReparacionesModificado.ID_Moto = cobrosReparacionesNuevo.ID_Moto;
            cobrosReparacionesModificado.ID_Mecanico = cobrosReparacionesNuevo.ID_Mecanico;
            cobrosReparacionesModificado.ID_cobrosReparaciones = id_cobrosReparaciones;

            var cobrosReparacionesEliminado = ListacobrosReparaciones.Find(x => id_cobrosReparaciones == x.ID_informeReparacion);
            ListacobrosReparaciones.Remove(cobrosReparacionesEliminado);
            ListacobrosReparaciones.Add(cobrosReparacionesModificado);
            InstanciaPersistenciadedatos.GuardarArchivocobrosReparaciones(ListacobrosReparaciones);


        }

        //Baja cobrosReparaciones
        public void BajacobrosReparaciones(int id_cobrosReparaciones)
        {
            ListacobrosReparaciones = ValidarcobrosReparaciones();

            var cobrosReparacionesEliminado = ListacobrosReparaciones.Find(x => id_cobrosReparaciones == x.ID_informeReparacion);
            ListacobrosReparaciones.Remove(cobrosReparacionesEliminado);
            InstanciaPersistenciadedatos.GuardarArchivocobrosReparaciones(ListacobrosReparaciones);

        }





        //Alta facturas
        public void Altafacturas(Facturas facturasNuevo)
        {
            Listafacturas = ValidarFacturas();
            Facturas nuevoFacturas = new Facturas();
            nuevoFacturas.importeTotal = facturasNuevo.importeTotal;
            nuevoFacturas.descripcionFactura = facturasNuevo.descripcionFactura;
            nuevoFacturas.ID_Cliente = facturasNuevo.ID_Cliente;
            nuevoFacturas.ID_cobrosReparaciones = facturasNuevo.ID_cobrosReparaciones;
            nuevoFacturas.ID_Venta = facturasNuevo.ID_Venta;
            Listafacturas.Add(nuevoFacturas);
            InstanciaPersistenciadedatos.GuardarArchivoFacturas(Listafacturas);



        }


        //Modificacion facturas
        public void Modificacionfacturas(Facturas facturasNuevo, int id_Factura)
        {
            Listafacturas = ValidarFacturas();

            var facturasModificado = Listafacturas.Find(x => id_Factura == x.ID_Factura);

            facturasModificado.importeTotal = facturasNuevo.importeTotal;
            facturasModificado.descripcionFactura = facturasNuevo.descripcionFactura;
            facturasModificado.ID_Cliente = facturasNuevo.ID_Cliente;
            facturasModificado.ID_cobrosReparaciones = facturasNuevo.ID_cobrosReparaciones;
            facturasModificado.ID_Venta = facturasNuevo.ID_Venta;
            facturasModificado.ID_Factura = id_Factura;

            var facturasEliminado = Listafacturas.Find(x => id_Factura == x.ID_Factura);
            Listafacturas.Remove(facturasEliminado);
            Listafacturas.Add(facturasModificado);
            InstanciaPersistenciadedatos.GuardarArchivoFacturas(Listafacturas);

        }

        //Baja Facturas
        public void Bajafacturas(int id_Factura)
        {
            Listafacturas = ValidarFacturas();

            var facturasEliminado = Listafacturas.Find(x => id_Factura == x.ID_Factura);
            Listafacturas.Remove(facturasEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoFacturas(Listafacturas);

        }




        //Alta motos
        public void Altamotos(Motos motosNuevo)
        {
            Listamotos = ValidarMotos();
            Motos nuevoMotos = new Motos();
            nuevoMotos.descripcionMoto = motosNuevo.descripcionMoto;
            Listamotos.Add(nuevoMotos);
            InstanciaPersistenciadedatos.GuardarArchivoMotos(Listamotos);


        }


        //Modificacion motos
        public void Modificacionmotos(Motos motosNuevo, int id_Moto)
        {
            Listamotos = ValidarMotos();

            var motosModificado = Listamotos.Find(x => id_Moto == x.ID_Moto);

            motosModificado.descripcionMoto = motosNuevo.descripcionMoto;
            motosModificado.ID_Moto = id_Moto;

            var motosEliminado = Listamotos.Find(x => id_Moto == x.ID_Moto);
            Listamotos.Remove(motosEliminado);
            Listamotos.Add(motosModificado);
            InstanciaPersistenciadedatos.GuardarArchivoMotos(Listamotos);


        }

        //Baja motos
        public void Bajamotos(int id_Moto)
        {
            Listamotos = ValidarMotos();

            var motosEliminado = Listamotos.Find(x => id_Moto == x.ID_Moto);
            Listamotos.Remove(motosEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoMotos(Listamotos);

        }





        //Alta precios
        public void Altaprecios(Precio precioNuevo)
        {
            Listaprecios = ValidarPrecio();
            Precio nuevoPrecio = new Precio();
            nuevoPrecio.ID_Articulo = precioNuevo.ID_Articulo;
            nuevoPrecio.Cantidad = precioNuevo.Cantidad;
            nuevoPrecio.Tipo = precioNuevo.Tipo;
            nuevoPrecio.descripcionArticulo = precioNuevo.descripcionArticulo;
            nuevoPrecio.Importe = precioNuevo.Importe;
            nuevoPrecio.fechaImporte = precioNuevo.fechaImporte;
            Listaprecios.Add(nuevoPrecio);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecios);



        }


        //Modificacion precios
        public void Modificacionprecios(Precio precioNuevo, int id_Articulo)
        {
            Listaprecios = ValidarPrecio();

            var preciosModificado = Listaprecios.Find(x => id_Articulo == x.ID_Articulo);

            preciosModificado.ID_Articulo = precioNuevo.ID_Articulo;
            preciosModificado.Cantidad = precioNuevo.Cantidad;
            preciosModificado.Tipo = precioNuevo.Tipo;
            preciosModificado.descripcionArticulo = precioNuevo.descripcionArticulo;
            preciosModificado.Importe = precioNuevo.Importe;
            preciosModificado.fechaImporte = precioNuevo.fechaImporte;
            preciosModificado.ID_Articulo = id_Articulo;


            var preciosEliminado = Listaprecios.Find(x => id_Articulo == x.ID_Articulo);
            Listaprecios.Remove(preciosEliminado);
            Listaprecios.Add(preciosModificado);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecios);


        }

        //Baja precios
        public void Bajaprecios(int id_Articulo)
        {
            Listaprecios = ValidarPrecio();

            var preciosEliminado = Listaprecios.Find(x => id_Articulo == x.ID_Articulo);
            Listaprecios.Remove(preciosEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecios);

        }





        //Alta reservas
        public void Altareservas(Reservas reservasNuevo)
        {
            Listareservas = ValidarReservas();
            Reservas nuevoReservas = new Reservas();
            nuevoReservas.fechaReserva = reservasNuevo.fechaReserva;
            nuevoReservas.ID_Articulo = reservasNuevo.ID_Articulo;
            nuevoReservas.ID_Vendedor = reservasNuevo.ID_Vendedor;
            Listareservas.Add(nuevoReservas);
            InstanciaPersistenciadedatos.GuardarArchivoReservas(Listareservas);


        }


        //Modificacion reservas
        public void Modificacionreservas(Reservas reservasNuevo, int id_Reserva)
        {
            Listareservas = ValidarReservas();

            var reservasModificado = Listareservas.Find(x => id_Reserva == x.ID_Reserva);

            reservasModificado.fechaReserva = reservasNuevo.fechaReserva;
            reservasModificado.ID_Articulo = reservasNuevo.ID_Articulo;
            reservasModificado.ID_Vendedor = reservasNuevo.ID_Vendedor;
            reservasModificado.ID_Reserva = id_Reserva;



            var reservasEliminado = Listareservas.Find(x => id_Reserva == x.ID_Reserva);
            Listareservas.Remove(reservasEliminado);
            Listareservas.Add(reservasModificado);
            InstanciaPersistenciadedatos.GuardarArchivoReservas(Listareservas);

        }

        //Baja reservas
        public void Bajareservas(int id_Reserva)
        {
            Listareservas = ValidarReservas();

            var reservasEliminado = Listareservas.Find(x => id_Reserva == x.ID_Reserva);
            Listareservas.Remove(reservasEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoReservas(Listareservas);

        }



        //Alta stock
        public void Altastock(Stock stockNuevo)
        {
            Listastock = ValidarStock();
            Stock nuevoStock = new Stock();
            nuevoStock.ID_Articulo = stockNuevo.ID_Articulo;
            nuevoStock.Cantidad = stockNuevo.Cantidad;
            nuevoStock.Tipo = stockNuevo.Tipo;
            nuevoStock.descripcionArticulo = stockNuevo.descripcionArticulo;
            Listastock.Add(nuevoStock);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);


        }


        //Modificacion stock
        public void Modificacionstock(Stock stockNuevo, int id_Stock)
        {
            Listastock = ValidarStock();

            var stockModificado = Listastock.Find(x => id_Stock == x.ID_Stock);

            stockModificado.ID_Articulo = stockNuevo.ID_Articulo;
            stockModificado.Cantidad = stockNuevo.Cantidad;
            stockModificado.Tipo = stockNuevo.Tipo;
            stockModificado.ID_Stock = id_Stock;



            var stockEliminado = Listastock.Find(x => id_Stock == x.ID_Stock);
            Listastock.Remove(stockEliminado);
            Listastock.Add(stockModificado);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);

        }

        //Baja stock
        public void Bajastock(int id_Stock)
        {
            Listastock = ValidarStock();

            var stockEliminado = Listastock.Find(x => id_Stock == x.ID_Stock);
            Listastock.Remove(stockEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);

        }





        //Alta ventas
        public void Altaventas(Ventas ventasNuevo)
        {
            Listaventas = ValidarVentas();
            Ventas nuevoVentas = new Ventas();
            nuevoVentas.idComprador = ventasNuevo.idComprador;
            nuevoVentas.descripcionVenta = ventasNuevo.descripcionVenta;
            nuevoVentas.fechaVenta = ventasNuevo.fechaVenta;
            nuevoVentas.importeVenta = ventasNuevo.importeVenta;
            nuevoVentas.ID_Venta = ventasNuevo.ID_Venta;
            Listaventas.Add(nuevoVentas);
            InstanciaPersistenciadedatos.GuardarArchivoVentas(Listaventas);


        }


        //Modificacion ventas
        public void Modificacionventas(Ventas ventasNuevo, int id_Venta)
        {
            Listaventas = ValidarVentas();

            var ventasModificado = Listaventas.Find(x => id_Venta == x.ID_Venta);

            ventasModificado.descripcionVenta = ventasNuevo.descripcionVenta;
            ventasModificado.fechaVenta = ventasNuevo.fechaVenta;
            ventasModificado.importeVenta = ventasNuevo.importeVenta;
            ventasModificado.ID_Reserva = ventasNuevo.ID_Reserva;
            ventasModificado.idComprador = ventasNuevo.idComprador;
            ventasModificado.ID_Venta = id_Venta;



            var ventasEliminado = Listaventas.Find(x => id_Venta == x.ID_Venta);
            Listaventas.Remove(ventasEliminado);
            Listaventas.Add(ventasModificado);
            InstanciaPersistenciadedatos.GuardarArchivoVentas(Listaventas);


        }

        //Baja ventas
        public void Bajaventas(int id_Venta)
        {
            Listaventas = ValidarVentas();

            var ventasEliminado = Listaventas.Find(x => id_Venta == x.ID_Venta);
            Listaventas.Remove(ventasEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoVentas(Listaventas);

        }



        //Validacion Listas
        public List<Cliente> ValidarCliente()
        {
            Listacliente = InstanciaPersistenciadedatos.LeerArchivoCliente();
            if (Listacliente == null)
            {
                List<Cliente> NuevaListacliente = new List<Cliente>();
                return NuevaListacliente;
            }
                   
             return Listacliente;
            
        }

        public List<Cliente> BuscarClienteporID(int idcliente)//Clase 03/10
        {
            List<Cliente> NuevaListacliente = new List<Cliente>();
            if (Listacliente == null)
            {
                return NuevaListacliente;
            }
            else
            {
                var clienteObtenido = Listacliente.Find(x => idcliente == x.ID_Cliente);
                NuevaListacliente.Add(clienteObtenido);
                return NuevaListacliente;
            }
        }

        public List<Mecanicos> ValidarMecanico()
        {
            Listamecanico = InstanciaPersistenciadedatos.LeerArchivoMecanico();
            if (Listamecanico == null)
            {
                List<Mecanicos> NuevaListamecanico = new List<Mecanicos>();
                return NuevaListamecanico;
            }
            else
            {
                return Listamecanico;
            }
        }

        public List<Proveedores> ValidarProveedores()
        {
            Listaproveedores = InstanciaPersistenciadedatos.LeerArchivoProveedores();
            if (Listaproveedores == null)
            {
                List<Proveedores> NuevaListaproveedores = new List<Proveedores>();
                return NuevaListaproveedores;
            }
            else
            {
                return Listaproveedores;
            }
        }

        public List<Secretarias> Validarsecretarias()
        {
            Listasecretarias = InstanciaPersistenciadedatos.LeerArchivoSecretarias();
            if (Listasecretarias == null)
            {
                List<Secretarias> NuevaListasecretarias = new List<Secretarias>();
                return NuevaListasecretarias;
            }
            else
            {
                return Listasecretarias;
            }
        }

        public List<Vendedores> Validarvendedores()
        {
            Listavendedores = InstanciaPersistenciadedatos.LeerArchivoVendedores();
            if (Listavendedores == null)
            {
                List<Vendedores> NuevaListavendedores = new List<Vendedores>();
                return NuevaListavendedores;
            }
            else
            {
                return Listavendedores;
            }
        }

        public List<Articulos> ValidarArticulos()
        {
            Listaarticulos = InstanciaPersistenciadedatos.LeerArchivoArticulos();
            if (Listaarticulos == null)
            {
                List<Articulos> NuevaListaarticulos = new List<Articulos>();
                return NuevaListaarticulos;
            }
            
                return Listaarticulos;
            
        }

        public List<cobrosReparaciones> ValidarcobrosReparaciones()
        {
            ListacobrosReparaciones = InstanciaPersistenciadedatos.LeerArchivocobrosReparaciones();
            if (ListacobrosReparaciones == null)
            {
                List<cobrosReparaciones> NuevaListacobrosReparaciones = new List<cobrosReparaciones>();
                return NuevaListacobrosReparaciones;
            }
            else
            {
                return ListacobrosReparaciones;
            }
        }

        public List<Facturas> ValidarFacturas()
        {
            Listafacturas = InstanciaPersistenciadedatos.LeerArchivoFacturas();
            if (Listafacturas == null)
            {
                List<Facturas> NuevaListafacturas = new List<Facturas>();
                return NuevaListafacturas;
            }
            else
            {
                return Listafacturas;
            }
        }

        public List<informeReparaciones> ValidarinformeReparaciones()
        {
            ListainformeReparaciones = InstanciaPersistenciadedatos.LeerArchivoinformeReparaciones();
            if (ListainformeReparaciones == null)
            {
                List<informeReparaciones> NuevaListainformeReparaciones = new List<informeReparaciones>();
                return NuevaListainformeReparaciones;
            }
           
            
                return ListainformeReparaciones;
            
        }

        public List<Motos> ValidarMotos()
        {
            Listamotos = InstanciaPersistenciadedatos.LeerArchivoMotos();
            if (Listamotos == null)
            {
                List<Motos> NuevaListamotos = new List<Motos>();
                return NuevaListamotos;
            }
            else
            {
                return Listamotos;
            }
        }

        public List<Precio> ValidarPrecio()
        {
            Listaprecios = InstanciaPersistenciadedatos.LeerArchivoPrecio();
            if (Listaprecios == null)
            {
                List<Precio> NuevaListaprecios = new List<Precio>();
                return NuevaListaprecios;
            }
            else
            {
                return Listaprecios;
            }
        }

        public List<Reservas> ValidarReservas()
        {
            Listareservas = InstanciaPersistenciadedatos.LeerArchivoReservas();
            if (Listareservas == null)
            {
                List<Reservas> NuevaListareservas = new List<Reservas>();
                return NuevaListareservas;
            }
            else
            {
                return Listareservas;
            }
        }

        public List<Stock> ValidarStock()
        {
            Listastock = InstanciaPersistenciadedatos.LeerArchivoStock();
            if (Listastock == null)
            {
                List<Stock> NuevaListastock = new List<Stock>();
                return NuevaListastock;
            }
            else
            {
                return Listastock;
            }
        }

        public List<Ventas> ValidarVentas()
        {
            Listaventas = InstanciaPersistenciadedatos.LeerArchivoVentas();
            if (Listaventas == null)
            {
                List<Ventas> NuevaListaventas = new List<Ventas>();
                return NuevaListaventas;
            }
            
            
            return Listaventas;
            
        }

        
    }
}