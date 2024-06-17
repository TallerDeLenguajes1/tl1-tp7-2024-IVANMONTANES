using EspacioCalculadora;
Empleado[] empleados = new Empleado[3];
//empleado 1//
empleados[0] = new Empleado();
empleados[0].nombre = "bruno";
empleados[0].apellido = "galvan";
empleados[0].cargo = Cargos.Administrativo;
empleados[0].estadoCivil = 's';
empleados[0].fechaIngreso = new DateTime(2015,6,17);
empleados[0].FechaNacimiento = new DateTime(2004,10,21);
empleados[0].sueldoBasico = 1100000;
//empleado 2//
empleados[1] = new Empleado();
empleados[1].nombre = "santiago";
empleados[1].apellido = "gonzalez";
empleados[1].cargo = Cargos.Ingeniero;
empleados[1].estadoCivil = 's';
empleados[1].fechaIngreso = new DateTime(2010,3,5);
empleados[1].FechaNacimiento = new DateTime(1978,10,31);
empleados[1].sueldoBasico = 1450000;
//empleado 3//
empleados[2] = new Empleado();
empleados[2].nombre = "vicente";
empleados[2].apellido = "alzogaray";
empleados[2].cargo = Cargos.Auxiliar;
empleados[2].estadoCivil = 'c';
empleados[2].fechaIngreso = new DateTime(2021,8,17);
empleados[2].FechaNacimiento = new DateTime(2001,4,10);
empleados[2].sueldoBasico = 550000;

double montoTotal = 0;
for(int i = 0; i < 3; i++){
    montoTotal += empleados[i].sueldoBasico + empleados[i].calcularAdicional();
}
Console.WriteLine("monto total en salarios: $"+montoTotal);

//empleado mas proximo a jubilarse//
int jubilacionEmpleado1 = empleados[0].calcularJubilacion();
int jubilacionEmpleado2 = empleados[1].calcularJubilacion();
int jubilacionEmpleado3 = empleados[2].calcularJubilacion();
int proximo = 0;
int minimoAuxiliar = Math.Min(jubilacionEmpleado1,jubilacionEmpleado2);
empleados[0].mostrarDatos();
empleados[1].mostrarDatos();
empleados[2].mostrarDatos();
if(minimoAuxiliar == jubilacionEmpleado1){
    proximo = Math.Min(jubilacionEmpleado1,jubilacionEmpleado3);
}
else if(minimoAuxiliar == jubilacionEmpleado2){
    proximo = Math.Min(jubilacionEmpleado2,jubilacionEmpleado3);
}

if(proximo == jubilacionEmpleado1){
    empleados[0].mostrarDatos();
}
else if(proximo == jubilacionEmpleado2){
    empleados[1].mostrarDatos();
}
else{
    empleados[2].mostrarDatos();
}

