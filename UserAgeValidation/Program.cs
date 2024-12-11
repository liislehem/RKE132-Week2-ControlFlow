// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Hello, Liis!");
//rakendus küsib kasutajalt valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
// "Welcome, MR. [kasutaja perekonnanimi] /"Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse (Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis.
//chari tahame seetõttu, et vaid m ja F väärtuseid salvestada, pole vaja suuri sõnu ja vahemälu.

Console.WriteLine("Please, enter your last name:");
string userLastName= Console.ReadLine();

//miks peab küsima kasutaja nime enne if koodi? Kuna neid andmeid ei ole veel antud, kood jookseb ülevalt alla ja if ei leiaks neid muidu.

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, MS.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName} !");
}

// kontrollin kas kasutaja sugu = m
// 1 = toimuks uue väärtuse salvestamine. If lausetes tohib vaid topelt == kasutada
//{ sulgude abil pannakse tööle see plokk ja kui on käivitatud, siis vahemälust kustutakse. 
// " on sõnadele ja ' on char infole mõeldud- sedasi teeb süsteem vahet
//else on kõik muud juhud mis ei ole m või f
// else if ja if vahe - sest kui juba korra on if kontroll käinud,
// //siis ei tohiks koormata arvutit ja tuleks edasi else ifiga minna

Console.WriteLine($"Welcome, {userGender}");