using EspacioCalculadora;
Calculadora nuevaCalculadora = new Calculadora();
int seguir = 1;
do{
    Console.WriteLine("valor actual: "+nuevaCalculadora.Resultado);
    Console.WriteLine("1: sumar un numero");
    Console.WriteLine("2: restar un numero");
    Console.WriteLine("3: multiplicar un numero");
    Console.WriteLine("4: dividir un numero");
    Console.WriteLine("5: limpiar");
    Console.WriteLine("6: salir");
    Console.WriteLine("ingrese una opcion:");
    string opcionC = Console.ReadLine();
    int opcion = 0;
    if(int.TryParse(opcionC,out opcion)){
        if(opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4){
            Console.WriteLine("ingrese un numero");
            string numeroC = Console.ReadLine();
            int numero = 0;
            if(int.TryParse(numeroC,out numero)){
                switch(opcion){
                    case 1: nuevaCalculadora.sumar(numero); break;
                    case 2: nuevaCalculadora.restar(numero); break;
                    case 3: nuevaCalculadora.multiplicar(numero); break;
                    case 4: nuevaCalculadora.dividir(numero); break;
                }
            }
            else{
                Console.WriteLine("no se ingreso un numero valido");
            }
        }
        else if(opcion == 5){
            nuevaCalculadora.limpiar();
        }
        else if(opcion == 6){
            seguir = 0;
        }
        else{
        Console.WriteLine("no se ingreso un numero");
        }
}}while(seguir == 1);
Console.WriteLine("resultado final: "+nuevaCalculadora.Resultado);