using EspacioCalculadora;
Empleado NuevoEmpleado = new Empleado();
NuevoEmpleado.nombre = "ivan";
NuevoEmpleado.apellido = "montañes";
NuevoEmpleado.FechaNacimiento = new DateTime(2005,1,27);
NuevoEmpleado.estadoCivil = 'c';
NuevoEmpleado.fechaIngreso = new DateTime(2019,6,15);
NuevoEmpleado.sueldoBasico = 100000;
NuevoEmpleado.cargo = Cargos.Ingeniero;
NuevoEmpleado.antiguedad();
NuevoEmpleado.edad();
NuevoEmpleado.jubilacion();
NuevoEmpleado.calcularSalario();