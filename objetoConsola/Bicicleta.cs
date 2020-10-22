namespace Carrera.Modelo
{
    
    class Bicicleta
    {
        public string color;
        int velocidad;
        public int cambio;
        int cantidadCambios;
        bool estaRota;

        public Bicicleta(string color, int cantidadCambios)
        {
            this.color = color;
            this.cantidadCambios = cantidadCambios;
        }
        public void SubirCambio()
        {
            if(this.cambio < this.cantidadCambios)
            {
                this.cambio++;
            }
        } 

        public string Mostrar()
        {
            return $"Color: {this.color} Cambio actual: {this.cambio}. Velocidad: {this.velocidad}";
        }

    }
}
