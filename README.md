# Gästbok – C#/.NET

En konsolapplikation utvecklad i C# som en del av en laboration i objektorienterad programmering vid Mittuniversitetet.

Applikationen fungerar som en enkel gästbok där användaren kan skapa, visa och ta bort inlägg. Inläggen sparas lokalt i en JSON-fil så att informationen finns kvar även efter att programmet avslutats.

## Funktioner

- Skapa nya inlägg med namn och meddelande.
- Visa samtliga inlägg med tillhörande index.
- Ta bort inlägg genom att ange deras index.
- Validera användarens inmatning för att förhindra tomma inlägg och ogiltiga index.
- Spara och läsa in inlägg automatiskt med JSON-serialisering och deserialisering.
- Navigera genom ett enkelt konsolbaserat menysystem.

## Tekniker

- C#
- .NET
- Objektorienterad programmering (OOP)
- JSON (`System.Text.Json`)
- Git och GitHub

## Projektstruktur

Projektet är uppdelat i tre huvudsakliga kodfiler:

- **Program.cs** – Hanterar menysystemet och användarens inmatning.
- **Guestbook.cs** – Hanterar gästbokens inlägg samt lagring och inläsning från JSON.
- **Post.cs** – Representerar ett enskilt inlägg med egenskaperna `Owner` och `Message`.

## Köra programmet

1. Klona repositoryt eller ladda ner projektet.
2. Öppna projektet i Visual Studio eller en terminal med .NET SDK installerat.
3. Navigera till mappen som innehåller projektets `.csproj`-fil.
4. Starta applikationen med kommandot:

   `dotnet run`

## Datalagring

Inläggen sparas automatiskt i filen `guestbook.json` när ett inlägg läggs till eller tas bort.

När applikationen startas läses tidigare sparade inlägg in från filen, om den finns. JSON-filen ingår inte i repositoryt eftersom den genereras vid användning.

## Syfte

Syftet med laborationen är att tillämpa grundläggande objektorienterad programmering i C#, med fokus på klasser, objekt, metoder, egenskaper, listor, felhantering och filhantering genom serialisering och deserialisering.
