##### Naziv Tima: Tim12-MrviceLJubavi

##### Èlanovi Tima:

- Kupusoviæ Elma
- Krupalija Ehlimana
- Muftiæ Belma

#### Naziv teme: Glasanje na bosanskohercegovaèkim izborima (u Sarajevu)

#### Opis teme

Potrebno je kreirati aplikaciju za (online) glasanje na izborima 
u Sarajevu.
Svrha sistema jeste omoguæiti lakši naèin glasanja graðanima BiH (Sarajlijama),
 taènije omoguæiti elektronsko glasanje ili pronalazak biraèkog mjesta 
(ukoliko se glasaè odluèi za glasanje na listiæu).
Sam dolazak na biraèko mjesto za neke glasaèe je nemoguæ ili skoro
 pa nemoguæ te bi u tom sluèaju online glasanje bilo najjednostavniji
 naèin.
Ukoliko se glasaè odluèi za glasanje putem Interneta (ili odluèi da 
neæe nikako glasati), tada se neæe 
kreirati njegov glasaèki listiæ te æe se time smanjiti ukupna potrošnja budžetskog
novca i proizvodnja papira (što je pozitivno za našu okolinu).
Ukoliko glasaè želi glasati na biraèkom mjestu, aplikacija æe mu
pomoæi da naðe lokaciju svog biraèkog mjesta te tako uštedjeti njegovo vrijeme i novac.

#### Procesi

##### Registracija glasaèa
Glasaè se pokuša prijaviti u sistem koristeæi svoj JMBG, ime i prezime.
Ukoliko podaci nisu validni sistem mu prijavljuje grešku, a ukoliko su
validni tada se glasaè prijavljuje i time mu se omoguæuje glasanje
(ukoliko je glasaè prijavljen u vremenu glasanja), moguænost izbora naèina
glasanja (elektronskim ili pismenim putem), pronalazak biraèkog mjesta,
pristup informacionom dijelu koji se sastoji od:
informacija o stranakama, pregleda kandidata, vrstama izbora, 
naèinima glasanja (online i na biraèkom mjestu) i objašnjenju kako glasati
u oba sluèaja, historije politike u BiH, novostima o izborima te pregled 
najnovijih tweetova sa Twitter accounta stranice.

##### Pregled kandidata
Glasaè ima moguænost da pogleda osnovne informacije o svakom kandidatu uz 
pomoæno filtriranje i sortiranje

##### Registracija administratora
Administrator ima poseban account kojim (kada se prijavi) može održavati 
sistema u realnom vremenu i održavati bazu kandidata (zabranjeno je mijenjanje 
baze sa glasovima). Administrator može promijeniti informacije o kandidatu,
dodati novog kandidata i obrisati kandidata iz baze, no samo do odreðenog roka
(ako trenutno izbori nisu u toku ili ako nije par dana pred izbor).

#### Funkcionalnosti
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
- moguænost pregeda svih trenutnih kandidata uz odreðena filtriranja (po godinama,
struènoj spremi, stranci, poziciji, društvenim priznanjima, popularnosti) 

#### Akteri
1. Glasaè - Glasaè je osoba koja ima moguænost glasanja, odabira naèina glasanja,
 pronalaska biraèkog mjesta (elektronskim ili pismenim putem), igranja igrice,
 pregleda informacionog dijela
2. Administrator - Administrator je osoba koja je zadužena za održavanje sistema
 i baze kandidata (dodavanje, brisanje i mijenjanje kandidata ali samo do odreðenog
roka). Može upravljati oficijelnim [Twitter accountom](https://twitter.com/glasaj_ba) 
za izbore te dodavati, mijenjati i brisati dijelove informacionog dijela.
3. Sistem - Sistem èuva informacije o kandidatima, glasaèima, glasovima, naèinima 
glasanja pojedinaca, biraèkim mjestima, 
ulicama koje pripadaju odreðenim biraèkim mjestima, može upravljati statistikama u 
informacionom dijelu.