﻿namespace SistemaGestionBiblioteca.Models
{
    public class EstadoReserva
    {
        public int EstadoReservaId { get; set; }
        public string Descripcion { get; set; }

        public virtual Reserva Reserva { get; set; }
    }
}