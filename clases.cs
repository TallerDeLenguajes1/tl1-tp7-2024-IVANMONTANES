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

        private int calcularEdad(){
            DateTime fechaActual = DateTime.Now;
            TimeSpan edad = fechaActual - FechaNacimiento;
            int edadAnios = (int)(edad.TotalDays / 365.25);
            return edadAnios;
        }

        public void edad(){
            int edad = calcularEdad();
            Console.WriteLine("edad "+edad);
        }

        public void jubilacion(){
            int jubiladoEn = 65 - calcularEdad();
            Console.WriteLine("le faltan "+jubiladoEn+" para jubilarse");
        }

        public void calcularSalario(){
            double salario,adicional = 0;
            int antiguedad = calcularDiferencia(fechaIngreso);
            //i//
            if(antiguedad <= 20){
                adicional += antiguedad * ((1 * sueldoBasico)/100);
            }
            else{
                adicional += (25 * sueldoBasico) / 100;
            }

            //ii//
            if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista){
                adicional *= 1.5;
            }

            //iii//
            if(estadoCivil == 'c'){
                adicional += 150000;
            }
            Console.WriteLine("adicional "+adicional);
        }

        
    }

