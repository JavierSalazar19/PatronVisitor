

using PatronVisitor.Component;
using PatronVisitor.Components;
using PatronVisitor.Concreto;
using PatronVisitor.Interface;

IVisitor visitante1 = new VisitanteConcreto();

Componente _Dr1 = new DiscoRigido("Disa231231312");
Componente _Pb1 = new PlacaBase("Placaa123131");
Componente _P1 = new Procesador("Procesador123123");

_Dr1.Aceptar(visitante1);
_Pb1.Aceptar(visitante1);
_P1.Aceptar(visitante1);

IVisitor visitante2 = new VisitanteConcreto2();

Componente dr2 = new DiscoRigido("1231DSFFSD3-DR");
Componente pb2 = new PlacaBase("dkk3nndj12313-PB");
Componente p2 = new Procesador("9393SKKK4K3-P");


dr2.Aceptar(visitante2);
pb2.Aceptar(visitante2);
p2.Aceptar(visitante2);
Console.ReadKey();
