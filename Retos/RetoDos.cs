using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaPushUp.Retos;
public class RetoDos
{
    public void Reto2(){
        int multc = 0;
        int multp = 0;
        int menor = 0;
        int mayor = 0;
        bool entrando = true;
        List<int> listI = new List<int>();

        Console.WriteLine("Ingrese el primer numero");
        Console.Write("--> ");
        multc = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        Console.Write("--> ");
        multp = int.Parse(Console.ReadLine());

        if(multc < multp){
            menor = multc;
            mayor = multp;
        }else{
            menor = multp;
        }
        while(entrando){
            menor = menor / 2;
            mayor = mayor * 2;
            if(menor == 1){
                listI.Add(mayor);
                entrando = false;
            }else if(menor % 2 != 0){
                listI.Add(mayor);
            }
        }
        Console.WriteLine("Suma de numero es: {0}", listI.Sum());
        Console.ReadLine();
    }
}
