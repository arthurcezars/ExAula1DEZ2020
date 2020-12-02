using System;

class MainClass {
  public static void Main (string[] args) {
    int test = 1;
    string name;
    string lastName;
    double salary;

    // Cria duas instancis da classe
    Empregado Kamila = new Empregado("Kamila", "Fagundes", 1045);
    Empregado Izabella = new Empregado("Izabella", "Freire", 4000);

    // Passa um novo valor de salario para o objeto Kamila
    Kamila.monthlySalary = 2000;
    // Acessa o metodo estatico dentro da classe
    Kamila.monthlySalary = Empregado.increasesSalary(Kamila.monthlySalary);
    Console.WriteLine(Kamila.monthlySalary);

    // Mostra o salario anual de cada instancia
    Console.WriteLine("Salario anual Kamila: {0}", Kamila.monthlySalary * 12);
    Console.WriteLine("Salario anual Izabella: {0}", Izabella.monthlySalary * 12);
  }
}