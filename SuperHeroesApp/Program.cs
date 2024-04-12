

using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;

var imprimirInfo = new ImprimirInfo();

var poderVolar = new SuperPoder();//variable de super poder
poderVolar.Nombre = "Volar";
poderVolar.Descripción = "Capaciodad opara volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneración = new SuperPoder();
regeneración.Nombre = "Regeneración";
regeneración.Nivel = NivelPoder.NivelTres;




var superman = new SuperHeroe();



/*var spiderman = new SuperHeroe();
var flash = new SuperHeroe();
var capAmerica = new SuperHeroe();
var thor = new SuperHeroe();

thor.Id = 1;
thor.Nombre = "Thor";
thor.IdentidadSecreta = "Thor";
thor.Ciudad = "Olimpo";
thor.PuedeVolar = true;


capAmerica.Id = 2;
capAmerica.Nombre = "Capitan America";
capAmerica.IdentidadSecreta = "Steve Rogers";
capAmerica.PuedeVolar = false;
capAmerica.Ciudad = "New York";


flash.Id = 3;
flash.Nombre = "Flash";
flash.IdentidadSecreta = "Jay Garrick";
flash.Ciudad = "Central City";

flash.PuedeVolar = false;

spiderman.Id = 5;
spiderman.Nombre = "Spider-Man";
spiderman.IdentidadSecreta = "Peter Parker";
spiderman.Ciudad = "New York";
spiderman.PuedeVolar = false;
 */

superman.Id = 1;
superman.Nombre = "    Superman    ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

imprimirInfo.ImprimirSuperHeroe(superman);


List<SuperPoder> poderesSuperman = new List<SuperPoder>(); //iniciamos la lista y añadimos las clases de super poder
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);   
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);


var venom = new AntiHeroe();

venom.Id = 5;
venom.Nombre = "Venom";
venom.IdentidadSecreta = "Eddie Brock";
venom.Ciudad = "New York";
venom.PuedeVolar = false;

imprimirInfo.ImprimirSuperHeroe(venom);
imprimirInfo.ImprimirSuperHeroe(venom);

List<SuperPoder> poderesVenom = new List<SuperPoder>(); //iniciamos la lista y añadimos las clases de super poder
poderesVenom.Add(regeneración);
poderesVenom.Add(superFuerza);
venom.SuperPoderes = poderesVenom;
string resultVenomPoderes = venom.UsarSuperPoderes();
Console.WriteLine(resultVenomPoderes);

string accionAntiHeroe = venom.RealizarAccionDeAntiHeroe("Ataque a la policia");
Console.WriteLine(accionAntiHeroe);



enum NivelPoder // otra clase dentro de la clase superpoder que se llama nivel de poder
{ 

NivelUno,
NivelDos,
NivelTres
}

public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);


