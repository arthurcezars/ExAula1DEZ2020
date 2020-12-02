using System;

class Empregado{
  string name;
  string lastName;
  double salary;

  public string Name{
    get{return name;}
    set{name = value;}
  }

  public string LastName{
    get{return lastName;}
    set{lastName = value;}
  }

  public double getSalary(){
    return salary;
  }
  public double monthlySalary{
    get{return salary;}
    set{if(value > 0){salary = value;}else{throw new Exception("Valor tem que ser postivo!");}}
  }

  public Empregado(string n, string ln, double s){
    name = n;
    lastName = ln;
    salary = s;
  }

  public static double increasesSalary(double s){
    return s*1.1;
  }
}