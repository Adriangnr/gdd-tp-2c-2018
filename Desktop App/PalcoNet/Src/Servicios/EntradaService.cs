﻿using PalcoNet.Src.Modelo.Daos;
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
        // fila y asiento 0 es para sin numerar
        private void loadEntrada(Entrada entrada, List<object> row)
        {
            entrada.Id = (int)row[0];
            entrada.Compra = (int)row[1];
            entrada.UbicacionId = (int)row[2];
            entrada.Fila = (row[3].GetType() != typeof(DBNull)) ? (int)row[3] : 0;
            entrada.Asiento = (row[4].GetType() != typeof(DBNull)) ? (int)row[4] : 0;
            entrada.FechaEventoId = (int)row[5];
            entrada.FechaEvento = (DateTime)row[6];
        }

        public List<Entrada> GetAllEntradasDisponibles(int publicacion)
        {
            UbicacionService ubicacionService = new UbicacionService();

            List<Ubicacion> ubicaciones = ubicacionService.getAllUbicacionesDisponibles(publicacion);
            //SortableBindingList<Entrada> entradasDisponibles = new SortableBindingList<Entrada>();
            List<Entrada> entradasDisponibles = new List<Entrada>();

            if (ubicaciones.Any(u => u.asientos * u.filas > u.ocupados))
            {
                SortableBindingList<Entrada> entradasVendidas = this.GetEntradasVendidas(publicacion);

                ubicaciones.ForEach( u => this.crearEntradas(u, entradasVendidas, entradasDisponibles));
            }
            else
                throw new Exception("No hay ubicaciones disponibles!");

            return entradasDisponibles;
        }

        private void crearEntradas(Ubicacion u, SortableBindingList<Entrada> entradasVendidas, List<Entrada> entradasDisponibles)
        {
            int fila = u.filas, asiento = u.asientos;

            if (!u.sinNumerar) // Si es numerada
            {
                if (fila * asiento == u.ocupados)
                    return;

                while (fila > 0)
                {
                    while (asiento > 0)
                    {
                        Entrada entradaNueva = new Entrada(u.id, fila, asiento, u);

                        if (!entradasVendidas.Any(e => e.EsIgual(entradaNueva)))
                            entradasDisponibles.Add(entradaNueva);

                        asiento -= 1;
                    }
                    asiento = u.asientos;
                    fila -= 1;
                }
            }
            else
            {
                if (asiento == u.ocupados)
                return;

                if (asiento > 0)
                {
                    Entrada entradaNueva = new Entrada(u.id, fila, asiento, u);

                    if (!entradasVendidas.Any(e => e.EsIgual(entradaNueva)))
                        entradasDisponibles.Add(entradaNueva);
                }
            }

        }

        public List<Entrada> getEntradasByCompra(int id)
        {
            List<Entrada> entradas = new List<Entrada>();
            List<List<object>> entradasData = this.daoEntrada.getEntradasByCompra(id);
            foreach(List<object> row in entradasData)
            {
                Entrada entrada = new Entrada();
                entrada.Id = (int)row[0];
                entrada.Compra = (int)row[1];
                entrada.UbicacionId = (int)row[2];
                entrada.Fila = (row[3].GetType() != typeof(DBNull)) ? (int)row[3] : 0;
                entrada.Asiento = (row[4].GetType() != typeof(DBNull)) ? (int)row[4] : 0;
                entrada.Precio = decimal.ToDouble((decimal)row[6]);

                entradas.Add(entrada);
            }
            return entradas;
        }

        public void update(Entrada entrada)
        {
            try
            {
                this.daoEntrada.update(entrada);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
