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
    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado{
        public string nombre;
        public string apellido;
        public DateTime FechaNacimiento;
        //S: SOLTERO -- C: COMPROMETIDO//
        public char estadoCivil;
        public DateTime fechaIngreso;
        public double sueldoBasico;
        public Cargos cargo;

        //metodos//
        public void antiguedad(){
            DateTime fechaActual = DateTime.Now;
            int antiguedad = fechaActual.Year - fechaIngreso.Year;
            if(fechaActual.Month > fechaIngreso.Month){
                antiguedad--;
            }
            else if(fechaActual.Month == fechaIngreso.Month){
                if(fechaActual.Day > fechaIngreso.Day){
                    antiguedad--;
                }
            }
            Console.WriteLine("antiguedad: "+antiguedad);
        }
    }

