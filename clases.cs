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
        private int calcularDiferencia(DateTime fecha){
            DateTime fechaActual = DateTime.Now;
            int antiguedad = fechaActual.Year - fecha.Year;
            if(fechaActual.Month > fecha.Month){
                antiguedad--;
            }
            else if(fechaActual.Month == fecha.Month){
                if(fechaActual.Day > fechaIngreso.Day){
                    antiguedad--;
                }
            }
            return antiguedad;
        }

        public void antiguedad(){
            int antiguedad = calcularDiferencia(fechaIngreso);
            Console.WriteLine("antiguedad "+antiguedad);
        }

        public void edad(){
            DateTime fechaActual = DateTime.Now;
            TimeSpan edad = fechaActual - FechaNacimiento;
            int edadAnios = (int)(edad.TotalDays / 365.25);
            Console.WriteLine("edad "+edadAnios);
        }
    }

