﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades {
    public class Vuelo {
        private static List<string> destinosInternacionales;

        private int idVuelo;
        private string? ciudadPartida;
        private string? ciudadDestino;
        private DateTime fechaDeVuelo;
        private Aeronave? avion;
        private EEstadoVuelo estadoDelVuelo;
        private int asientosPremiumOcupados;
        private int asientosTuristaOcupados;
        private int duracionVuelo;
        private List<Pasaje> listaPasajes;
        private ETipoVuelo tipoVuelo;
        private float pesoBodegaOcupada;

        static Vuelo() {
            destinosInternacionales = new List<string>() {
                    "Recife (Brasil)",
                    "Roma (Italia)",
                    "Acapulco (México)",
                    "Miami (EE.UU.)"
            };
        }

        public Vuelo() {
            this.idVuelo = ObtenerIdVueloUnico();
            this.listaPasajes = new List<Pasaje>();
            this.estadoDelVuelo = EEstadoVuelo.EnTierra;
            this.asientosPremiumOcupados = 0;
            this.asientosTuristaOcupados = 0;
            this.pesoBodegaOcupada = 0;
        }

        public Vuelo(string ciudadPartida, string ciudadDestino, DateTime fechaDeVuelo, Aeronave avion) : this() {
            Validador.ValidarCiudades(ciudadPartida, ciudadDestino);
            this.ciudadPartida = ciudadPartida;
            this.ciudadDestino = ciudadDestino;
            this.fechaDeVuelo = fechaDeVuelo;
            this.avion = avion;
            this.tipoVuelo = ObtenerTipoDeVuelo(ciudadPartida, ciudadDestino);
            Validador.ValidarInternacional(ciudadPartida, ciudadDestino, this.tipoVuelo);
            this.duracionVuelo = CalcularDuracionDeVuelo(this.tipoVuelo);
        }

        public int IdVuelo { get { return this.idVuelo; } }
        public string CiudadPartida { get { return this.ciudadPartida!; } set { this.ciudadPartida = value; } }
        public string CiudadDestino { get { return this.ciudadDestino!; } set { this.ciudadDestino = value; } }
        public DateTime FechaDeVuelo { get { return this.fechaDeVuelo!; } set { this.fechaDeVuelo = value; } }
        public Aeronave Avion { get { return this.avion!; } set { this.avion = value; } }
        public EEstadoVuelo EstadoDelVuelo { get { return this.estadoDelVuelo; } set { this.estadoDelVuelo = value; } }
        public int DuracionVuelo { get { return this.duracionVuelo; } set { this.duracionVuelo = value; } }
        public ETipoVuelo TipoVuelo { get { return this.tipoVuelo; } set { this.tipoVuelo = value; } }
        public List<Pasaje> ListaPasajes { get { return this.listaPasajes; } set { this.listaPasajes = value; } }
        public int AsientosPremiumOcupados { get { return this.asientosPremiumOcupados; } set { this.asientosPremiumOcupados = value; } }
        public int AsientosTuristaOcupados { get { return this.asientosTuristaOcupados; } set { this.asientosTuristaOcupados = value; } }
        public float PesoBodegaOcupada { get { return this.pesoBodegaOcupada; } set { this.pesoBodegaOcupada = value; } }

        private int ObtenerIdVueloUnico() {
            int idGenerado;

            do {
                idGenerado = Sistema.GenerarIdNumerico();                    
            } while (Validador.ValidarIdVueloUnico(idGenerado));
            
            return idGenerado;
        }


        private ETipoVuelo ObtenerTipoDeVuelo(string partida, string destino) {
            ETipoVuelo tipoVuelo = ETipoVuelo.Nacional;

            foreach(string destinoAux in destinosInternacionales) {
                if(partida == destinoAux || destino == destinoAux) {
                    tipoVuelo = ETipoVuelo.Internacional;
                    break;
                }
            }

            return tipoVuelo;
        }

        private int CalcularDuracionDeVuelo(ETipoVuelo tipoVuelo) {
            Random rand = new Random();
            int duracionDelVuelo;

            //si tipoVuelo == ETipoVuelo.Internacional
            duracionDelVuelo = rand.Next(8, 13);

            if (tipoVuelo == ETipoVuelo.Nacional) {
                duracionDelVuelo = rand.Next(2, 5);
            }

            return duracionDelVuelo;
        }

        public void ContarAsientosOcupados() {
            this.asientosTuristaOcupados = 0;
            this.asientosPremiumOcupados = 0;

            foreach (Pasaje pasaje in ListaPasajes) {
                if(pasaje.ClasePasajero == ETipoClase.Turista) {
                    this.asientosTuristaOcupados++;
                }
                else {
                    this.asientosPremiumOcupados++;
                }
            }
        }


        public static bool operator ==(Vuelo v1, Vuelo v2) {
            bool iguales = false;

            if (v1 is not null && v2 is not null) {
                iguales = v1.idVuelo == v2.idVuelo;
            }

            return iguales;
        }

        public static bool operator !=(Vuelo v1, Vuelo v2) {
            return !(v1 == v2);
        }

        public override bool Equals(object? obj) {
            Vuelo? vuelo = obj as Vuelo;
            return vuelo is not null && this == vuelo;
        }

        public override int GetHashCode() {
            return this.idVuelo;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {this.idVuelo}");
            sb.AppendLine($"Ciudad de partida: {this.ciudadPartida}");
            sb.AppendLine($"Ciudad de destino: {this.ciudadDestino}");
            sb.AppendLine($"Fecha del vuelo: {this.fechaDeVuelo.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Asientos premium ocupados: {this.asientosPremiumOcupados}");
            sb.AppendLine($"Asientos turista ocupados: {this.asientosTuristaOcupados}");
            sb.AppendLine($"Duracion del vuelo: {this.duracionVuelo}hs"); 

            return sb.ToString();
        }
    }
}
