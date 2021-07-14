/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());
            
            float reajuste,salario;
            int funcionario;

            if (salario>=0.0&&salario<=400.0) { aumento=0.15;SalarioFinal=salario+(aumento*salario); }
            if (salario>=400.01&&salario<=700.0) { aumento=0.12;SalarioFinal=salario+(aumento*salario); }

            if (salario>=700.01&&salario<=1000.0) { aumento=0.10;SalarioFinal=salario+(aumento*salario); }

            if (salario>=1000.01&&salario<=1800.0) { aumento=0.07;SalarioFinal=salario+(aumento*salario); }

            if (salario>=1800.01&&salario<=2500.0) { aumento=0.04;SalarioFinal=salario+(aumento*salario);}
            if(salario >= 0.00 && salario <= 000.00)
            salario*=aumento;
            {
                reajuste = salario * 0.00; 
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 000) /salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            
                
            }
            else if (salario > 000.00 && salario <= 000.00)
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 000) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 000.00 && salario <= 000.00)
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 000) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 000.00 && salario <= 000.00)
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ((novoSalario - salario) * 000) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else 
            {
                Console.WriteLine(string.Format("Resultado: {0}", Resultado)); //complete o codigo
            }
        }   
    }




