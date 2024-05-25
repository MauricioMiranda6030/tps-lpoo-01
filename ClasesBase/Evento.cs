using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Evento
    {

        private static int idCont = 1;

        public Evento()
        {
            this.eve_ID = idCont;
            idCont++;
        }
        private int eve_ID;

        public int Eve_ID
        {
            get { return eve_ID; }
            set { eve_ID = value; }
        }
        private Competencia com_ID;

        public Competencia Com_ID
        {
            get { return com_ID; }
            set { com_ID = value; }
        }
        private Atleta atl_ID;

        public Atleta Atl_ID
        {
            get { return atl_ID; }
            set { atl_ID = value; }
        }
        private string eve_Estado;

        public string Eve_Estado
        {
            get { return eve_Estado; }
            set { eve_Estado = value; }
        }
        private DateTime eve_HoraInicio;

        public DateTime Eve_HoraInicio
        {
            get { return eve_HoraInicio; }
            set { eve_HoraInicio = value; }
        }
        private DateTime eve_HoraFin;

        public DateTime Eve_HoraFin
        {
            get { return eve_HoraFin; }
            set { eve_HoraFin = value; }
        }

        public override string ToString()
        {
            string eventoString = "ID: " + Eve_ID + "\n" +
                                  "Estado: " + Eve_Estado + "\n" +
                                  "Hora Inicio: " + Eve_HoraInicio + "\n" +
                                  "Hora Fin: " + Eve_HoraFin + "\n";
            return eventoString;
        }
    }
}
