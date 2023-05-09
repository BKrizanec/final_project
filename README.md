U ovoj mapi se nalazi rješenje zadataka seminarskog rada (samostalni projekt) - ASP.NET Developer/Developerka

# Završni rad - Web aplikacija instrukcija
Tema ovog završnog rada je mali CMS sustav koji služi za oglašavanje instrukcija iz raznih kategorija (npr. srednja škola, osnovna škola, itd...). Za izradu aplikacije korišten je C# programski jezik u .NET 6 frameworku, uz MVC obrazac softverske arhitekture. 

## Zadaci unutar završnog rada i postavljanje aplikacije za lokalno okruženje
### 1. Modelirana i dizajnirana baza podataka bazirana na MS SQL serveru. Unutar same programske solucije dodane su sve migracije potrebne za inicijalizaciju baze podataka. 
  
  1.1. Prije same inicijalizacije, ono što je potrebno je softvare u kojem se nesmetano mogu pregledavati i upravljati baze, poput [SQL Server Management Studia](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16). Sama baza za projekt kreirana je korištenjem Entity Framework Code First pristupa.
  
  1.2. Nakon što se baza podataka uredno može kreirati i pregledavati, potrebno je unutar programskog rješenja povezati bazu sa samim programom putem podešavanja Connection stringa. Connection string se podešava unutar appsetings.Development.json datoteke, a potrebno ga je podesiti na Vašu lokalnu bazu podataka.
  Primjer podešenja:
  ```
        {
        "Logging": {
          "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
          }
        },
        "ConnectionStrings": {
          "Default": "Server=localhost\\sqlexpress; Database=MyDatabase; Integrated Security=true; TrustServerCertificate=true; MultipleActiveResultSets=true;"
        }
      }
  ```
  1.3. I na samome kraju, potrebno je stvoriti bazu podataka, sa unaprijed pripremljenim migracijama, dodavanjem naredbe update-database unutar Package Manager konzole.

### 2. Sam program mora imati inicijaliziran GIT, te imati vidljiv proces verzioniranja. On je vidljiv u ovome repozitoriju.

### 3. Program mora imati sustav autorizacije i autentifikacije putem korisničkih računa, ili povezivanjem sa društvenim mrežama.
  
  3.1. U samim postavkama baze podataka i nakon prvog seedanja podataka u bazu, unaprijed je pripremljen jedan administratorski račun, a za sve ostale korisničke račune potrebno je izvršiti registraciju.
  
  3.2. Podaci za pristup administratorskom računu su: username: siguran@mailfirme.com i password: T4jn0v1t470z1nk4!, a oni se mogu pronaći unutar ApplicationDbContext klase.
  
### 4. Potreban je sustav za upravljanje korisnicima. 
  
  4.1. Nakon što ste ulogirani kao administrator, otvoriti će se padajući izbornik u navigacijskom panelu gdje je klikom na "Users" moguće pristupiti popisu korisnika te kreirati nove, upravljati sa već upisanim korisnicima, te detaljnije prikazati pojedinog korisnika, ili ga obrisati iz baze.

### 5. Jednako tako, potreban je i sustav za upravljanjem proizvoda.
  
  5.1. Do upravljanja proizvodima dolazi se na isti način kao i do korisnika, ali se u padajućem izborniku odabiru "Services". Jednako tako, u ovome popisu moguće je pristupiti svim proizvodima, i upravljati sa njima jednako kao i sa korisnicima.
  
  5.2. Na ovakav način može se pristupiti i dva druga modela baze, a to su Categories i Lecturers. To su jednako tako, dva modela, u koje je moguće dodati i slike.
  
### 6. Na početnoj stranici postoji sustav za navigaciju uslugama putem padajućeg izbornika u kojem se proizvodi mogu izlistati po kategorijama, ali postoji i obična tražilica u koju je jednako tako moguće upisati željeni pojam.
  
  6.1. Dokle god je padajući izbornik kategorije podešen na prikaz svih kategorija, na početnoj stranici prikazivati će se 10 nasumičnih proizvoda, odnosno usluga, iz baze podataka. Novih nasumičnih 10 proizvoda moguće je dobiti jednostavno ponovnim klikanjem na prikaz svih kategorija ili refreshanjem stranice.
  
  6.2. Ukoliko želite pogledati popis svih usluga, na naslovnoj stranici postoji gumb koji omogućuje i takav prikaz.
  
  6.3. Svaki proizvod/usluga ima mogućnost detaljnijeg prikaza klikom na gumb unutar kartice. Detaljniji pregled moguć je samo registriranim korisnicima. 
  
### 7. Projekt jednako tako ima mogućnost korištenja REST WebAPI endpointova kako bi pristupili svim uslugama ili pojedinačnim uslugama
  
  7.1. Kako bi pregledali ove endpointove, moguće je direktno u search bar unijeti https://vašlocalhost:xxxx/api/services za pregled svih, ili https://vašlocalhost:xxxx/api/services/{id} za pregled specifičnih usluga, gdje je {id} proizvoljni broj usluge: npr. https://vašlocalhost:xxxx/api/services/3
  
  7.2. Ovo je jednako tako moguće putem [Postman API platforme](https://www.postman.com/) za uredniji pregled
  
  7.3. Oba endpointa koriste GET protokol

### 8. Zadnji zadatak se odnosi na dokumentaciju vezanu za postavljanje ovoga projekta za lokalno okruženje, pa samim time, sretno postavljanje projekta i pregledavanje!
