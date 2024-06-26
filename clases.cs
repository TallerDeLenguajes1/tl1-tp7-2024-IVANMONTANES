namespace EspacioCalculadora
{
    public class Calculadora{
        private double dato;

        //funcion para sumar//
        public void sumar(double termino){
            dato += termino;
        }

        //funcion para restar//
        public void restar(double termino){
            dato -= termino;
        }

        //funcion para multiplicar//
        public void multiplicar(double termino){
            dato *= termino;
        }

        //funcion para dividir//
        public void dividir(double termino){
            if(termino != 0){
                dato /= termino;
            }
            else{
                Console.WriteLine("no se puede dividir en 0");
            }
        }

        //funcion para limpiar//
        public void limpiar(){
            dato = 0;
        }

        public double Resultado{
            get => dato;
        }
    }
}

