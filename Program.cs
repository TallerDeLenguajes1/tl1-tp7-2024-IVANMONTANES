using EspacioCalculadora;
Empleado NuevoEmpleado = new Empleado();
NuevoEmpleado.nombre = "ivan";
NuevoEmpleado.apellido = "montañes";
NuevoEmpleado.FechaNacimiento = new DateTime(2005,6,20);
NuevoEmpleado.estadoCivil = 's';
NuevoEmpleado.fechaIngreso = new DateTime(2019,6,15);
NuevoEmpleado.sueldoBasico = 5200000;
NuevoEmpleado.cargo = Cargos.Ingeniero;
NuevoEmpleado.antiguedad();
NuevoEmpleado.edad();