//Iimplementacion de un cliente en el banco
using bancoPoo.Models;

Banco cliente = new Banco("123", "12023", "Carlos Moreno", "Pte de Cabi", 250000);
Console.WriteLine("saldo Inicial del cliente : "+cliente.saldo);
//realizare un deposito
cliente.Depositar(75000);

Console.WriteLine("saldo una vez depositado : "+cliente.saldo);

//realizare un retiro
cliente.retirar(35000);

Console.WriteLine("saldo una vez retirado : "+cliente.saldo);


//cosultare la cuenta
Console.WriteLine("saldo final una vez depositado y retirado : "+cliente.consultaSaldo());