![alt tag](https://github.com/ooad-2016-2017/Tim12-MrviceLJubavi/blob/master/Slike/glasaj.ba.jpg)
![Gifovi](Gifovi/ssquad.gif)

##### Naziv Tima: Tim12-MrviceLJubavi:chicken:

##### Èlanovi Tima: :hatching_chick::hatched_chick:

1. Kupusoviæ Elma :baby_chick::bread::corn:
2. Krupalija Ehlimana :dog:
3. Muftiæ Belma :octocat:

*****
### Naziv teme: Glasanje na bosanskohercegovaèkim izborima - Glasaj.ba

### Opis teme

Potrebno je kreirati aplikaciju za (online) glasanje na izborima 
u Sarajevu.
Svrha sistema jeste omoguæiti lakši naèin glasanja graðanima BiH,
 taènije omoguæiti elektronsko glasanje ili pronalazak biraèkog mjesta 
(ukoliko se glasaè odluèi za glasanje na listiæu).
Sam dolazak na biraèko mjesto za neke glasaèe je nemoguæ ili skoro
 pa nemoguæ te bi u tom sluèaju online glasanje bilo najjednostavniji
 naèin.
Ukoliko se glasaè odluèi za glasanje putem Interneta, tada se neæe 
kreirati njegov glasaèki listiæ te æe se time smanjiti ukupna potrošnja budžetskog
novca i proizvodnja papira (što je pozitivno za našu okolinu).
Ukoliko glasaè želi glasati na biraèkom mjestu, aplikacija æe mu
pomoæi da naðe lokaciju svog biraèkog mjesta te tako uštedjeti njegovo vrijeme i novac.
*****
### Procesi

##### Glasanje
Graðanin unosi svoje podatke (ime, prezime, JMBG, broj liène karte, ulicu 
stanovanja, državu iz koje glasa) te bira stranku i kandidate. Ukoliko
su podaci validni, podaci se unose u sistem i kadidat se obavješava o 
uspješnom glasanju, u suprotnom sistem obavještava kadidata o greški i
zahtijeva ponovni unos podataka i odabir kandidata i stranke. Ukoliko 
glasaè želi glasati na biraèkom mjestu (i bira opciju za glasanje na biraèkom mjestu),
 tada se samo provjeravaju njegovi 
podaci (sistem obavještava glasaèa o ispravnosti podataka) i ukoliko su validni,
u sistem se unosi odluka glasaèa, ukoliko nisu, zahtijeva se ponovni unos podataka.

##### Pregled kandidata
Graðanin ima moguænost da pogleda osnovne informacije o svakom kandidatu uz 
pomoæno filtriranje. Filtrirati kandidate može po godinama,
struènoj spremi, stranci, poziciji, društvenim priznanjima, popularnosti.

##### Opcija za slijepe i slabovidne osobe
Pri pokretanju aplikacije korisnik može klikom na dugme odabrati nastavak 
komunikacije sa sistemom uz pomoæ zvuènih signala.

##### Pronazak biraèkog mjesta
Graðanin unosi ulicu u kojoj živi i sistem mu na osnovu nje javlja detaljnije
informacije o tome gdje se nalazi njegovo biraèko mjesto (adresu i prikaz 
lokacije na google maps-u). Ukoliko ulica ne postoji, sistem javlja grešku i 
zahtijeva ponovni upis naziva ulice.
 
##### Registracija administratora
Administrator ima poseban account kojim (kada se prijavi) može održavati 
sistem u realnom vremenu i održavati bazu kandidata (zabranjeno je mijenjanje 
baze sa glasovima). Administrator može promijeniti informacije o kandidatu,
dodati novog kandidata i obrisati kandidata iz baze, no samo do odreðenog roka
(izmjene nisu dozvoljene za vrijeme i nakon izbora te sedam dana prije izbora). Prijavljuje
 se tako što na glavnoj stranici aplikacije ima rubriku u koju unosi svoj 
username i password. Ukoliko podaci nisu taèni, sistem korisnika obavještava o
 greški i zahtijeva ponovni unos podataka (ukoliko se korisnik želi prijaviti).
*****
### Funkcionalnosti
- moguænost odabira naèina glasanja
- moguænost informisanja o naèinu glasanja i vrstama izbora
- moguænost prijave u sistem sa razlièitim privilegijama
- moguænost pronalaska biraèkog mjesta
- moguænost pregleda historije politike u BiH
- moguænost online glasanja
- moguænost održavanja baze kandidata (dodavanje, mijenjanje i brisanje)
- moguænost igranja igre
- moguænost informisanja o strankama i kandidatima
- moguænost pregleda novosti o tekuæim izborima
- moguænost pregleda najnovijih „tweetova“ sa Twitter accounta stranice
- moguænost pregleda svih trenutnih kandidata uz odreðena filtriranja (po godinama,
struènoj spremi, stranci, poziciji, društvenim priznanjima, popularnosti) 
- moguænost komunikacije slijepih i slabovidnih osoba sa sistemom
*****
### Akteri
1. Glasaè - Glasaè je osoba koja ima moguænost glasanja, odabira naèina glasanja,
 pronalaska biraèkog mjesta (elektronskim ili pismenim putem), igranja igrice,
 pregleda informacionog dijela.
2. Administrator - Administrator je osoba koja je zadužena za održavanje sistema
 i baze kandidata (dodavanje, brisanje i mijenjanje kandidata ali samo do odreðenog
roka). Može upravljati oficijelnim [Twitter accountom](https://twitter.com/glasaj_ba) 
za izbore te dodavati, mijenjati i brisati dijelove informacionog dijela.
3. Sistem - Sistem èuva informacije o kandidatima, glasaèima, glasovima, naèinima 
glasanja pojedinaca, biraèkim mjestima, 
ulicama koje pripadaju odreðenim biraèkim mjestima, tweetovima sa oficijelnog Twitter 
accounta, može upravljati statistikama u informacionom dijelu, ukoliko doðe do greške,
prijavljuje je, pruža usluge i slijepim i slabovidnim osobama.
4. Kandidat - Kanditat je osoba koja administratoru daje informacije o sebi (koji vrši
potrebne izmjene kandidatovog profila ili ga dodaje, odnosno briše iz baze).