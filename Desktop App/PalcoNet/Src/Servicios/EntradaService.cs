using PalcoNet.Src.Modelo.Daos;
using PalcoNet.Src.Modelo.Entidades;
using PalcoNet.Src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Src.Servicios
{
    class EntradaService : DatabaseService
    {
        DaoEntrada daoEntrada = new DaoEntrada();

        public SortableBindingList<Entrada> GetEntradasVendidas(int publicacion)
        {

            try
            {
                SortableBindingList<Entrada> entradas = new SortableBindingList<Entrada>();

                List<List<object>> results = this.daoEntrada.GetEntradasVendidas(publicacion);

                foreach (List<object> row in results)
                {
                    Entrada entrada = new Entrada();
                    this.loadEntrada(entrada, row);
                    entradas.Add(entrada);
                }
                return entradas;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void loadEntrada(Entrada entrada, List<object> row)
        {
            entrada.Id = (int)row[0];
            entrada.Compra = (int)row[1];
            entrada.UbicacionId = (int)row[2];
            entrada.Fila = (int)row[3];
            entrada.Asiento = (int)row[4];
        }

        public SortableBindingList<Entrada> GetAllEntradasDisponibles(int publicacion)
        {
            UbicacionService ubicacionService = new UbicacionService();

            List<Ubicacion> ubicaciones = ubicacionService.getAllUbicacionesDisponibles(publicacion);
            SortableBindingList<Entrada> entradasDisponibles = new SortableBindingList<Entrada>();

            if (ubicaciones.Any(u => u.asientos * u.filas > u.ocupados))
            {
                SortableBindingList<Entrada> entradasVendidas = this.GetEntradasVendidas(publicacion);

                ubicaciones.ForEach( u => this.crearEntradas(u, entradasVendidas, entradasDisponibles));
            }
            else
                throw new Exception("No hay ubicaciones disponibles!");

            return entradasDisponibles;
        }

        private void crearEntradas(Ubicacion u, SortableBindingList<Entrada> entradasVendidas, SortableBindingList<Entrada> entradasDisponibles)
        {
            int fila = u.filas, asiento = u.asientos;

            if (fila * asiento == u.ocupados)
                return;

            while (fila > 0)
            {
                while (asiento > 0)
                {
                    Entrada entradaNueva = new Entrada(u.id, fila, asiento, u);

                    if( !entradasVendidas.Any(e => e.EsIgual(entradaNueva) ))
                        entradasDisponibles.Add(entradaNueva);

                    asiento -= 1;
                }
                asiento = u.asientos;
                fila -= 1;
            }

        }

    }
}
