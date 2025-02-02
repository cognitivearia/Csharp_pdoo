﻿namespace FabricadorArepas
{
    public class ArepaProcesada : Arepa, IAsable, ICongelable
    {
        private int temperaturaCoccion;
        private int diasMaximosCongelado;

        public ArepaProcesada() : base()
        {
            this.diasMaximosCongelado = 0;
            this.temperaturaCoccion = 0;
        }

        public ArepaProcesada(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroMolino,
                              int temperaturaCoccion,
                              int diasMaximosCongelado,
                              string tipoArepa) : base(
                                  tipoDeMasa, diasCaducidad, numeroMolino, tipoArepa)
        {
            this.temperaturaCoccion = temperaturaCoccion;
            this.diasMaximosCongelado = diasMaximosCongelado;
        }

        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }

        public string InfoCongelacion()
        {
            string info = $"Dias maximos de congelacion: {diasMaximosCongelado}";
            return info; ;
        }

        public string InfoCoccion()
        {
            string info = $"Temperatura para cocción: {temperaturaCoccion}";
            return info; ;
        }

        public override string ObtieneInformacion()
        {
            string info = $"Esta arepa fue {tipoArepa}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del molino {numeroMolino} \n" +
                $"Dias caducidad: {diasCaducidad} \n" +
                InfoCoccion() + " \n" +
                InfoCongelacion();
            return info;
        }
    }
}
