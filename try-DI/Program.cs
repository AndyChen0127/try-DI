// See https://aka.ms/new-console-template for more information
using try_DI;

Console.WriteLine("DI 練習!!");

DriverA driverA = new DriverA();
DriverB driverB = new DriverB();

// 指派駕駛A
var dcompany = new DriverCompany(driverA);
dcompany.ShowDriver();

// 指派駕駛B
dcompany = new DriverCompany(driverB);
dcompany.ShowDriver();

