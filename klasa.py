class Urzadzenie:
    pobor_mocy = int()
    nazwa_modelu = str()
    numer_seryjny = str()
    def __init__(self, nazwa_modelu, pobor_mocy, SN):
        self.nazwa_modelu = nazwa_modelu
        self.pobor_mocy = pobor_mocy
        self.numer_seryjny = SN

class CPU(Urzadzenie):
    taktowaniee = float()
    ilosc_rdzeni = int()

    def __init__(self,nazwa_modelu, pobor_mocy, SN, taktowanie, rdzenie):
        super().__init__( nazwa_modelu, pobor_mocy, SN)
        self.taktowaniee = taktowanie
        self.ilosc_rdzeni = rdzenie
        print("STWORZONO CPU")


class płyta_główna(Urzadzenie):
    ilość_banków_pamięci = int()
    socket = str()

    def __init__(self,nazwa_modelu, pobor_mocy, SN, ilosc_bankow_pamieci, socket):
        super().__init__( nazwa_modelu, pobor_mocy, SN)
        self.ilość_banków_pamięci = ilosc_bankow_pamieci
        self.socket = socket
        print("STWORZONO MOBO")

class RAM(Urzadzenie):
    Wielkość = int()
    taktowanie_pamięci = int()

    def __init__(self,nazwa_modelu, pobor_mocy, SN, wielkosc, taktowanie_pamieci):
        super().__init__( nazwa_modelu, pobor_mocy, SN)
        self.Wielkość = wielkosc
        self.taktowanie_pamięci = taktowanie_pamieci
        print("STWORZONO RAM")

class GPU(Urzadzenie):
    producent = str()
    rozmiar_VRAM = int()

    def __init__(self,nazwa_modelu, pobor_mocy, SN, producent, rozmiar_VRAM):
        super().__init__( nazwa_modelu, pobor_mocy, SN)
        self.producent = producent
        self.rozmiar_VRAM = rozmiar_VRAM
        print("STWORZONO GPU")

class Zasilacz(Urzadzenie):
    certyfikat = str()
    moc = int()

    def __init__(self,nazwa_modelu, pobor_mocy, SN, certyfikat, moc):
        super().__init__( nazwa_modelu, pobor_mocy, SN)
        self.moc = moc
        self.certyfikat = certyfikat
        print("STWORZONO PSU")


class Komputer:
    plyta_glowna = None
    RAM = None
    CPU = None
    GPU = None
    Pamiec = []
    zasilacz = None

    def __init__(self,plyta_glowna, ram, cpu, gpu, Zasilacz):
        if isinstance(plyta_glowna,płyta_główna):
            self.płyta_główna = plyta_glowna
        else:
            print("ERROR: Wprowadzono błędne MOBO")

        if isinstance(ram,RAM):
            self.RAM = ram
        else:
            print("ERROR: Wprowadzono błędy RAM")

        if isinstance(cpu,CPU):
            self.CPU = cpu
        else:
            print("ERROR: Wprowadzono błędy procesor")

        if isinstance(gpu,GPU):
            self.GPU = gpu
        else:
            print("ERROR: Wprowadzono błędną grafę")
        if isinstance(Zasilacz,zasilacz):
           self.zasilacz = Zasilacz
       else:
            print("ERROR: Wprowadzono błędne PSU")

    def dodajDysk(self, pojemnosc):
        self.Pamiec.append(pojemnosc)

    def __str__(self):
        return "ok"
    #def uruchom(self):
    #def wylacz(self):



konkuter1 = Komputer("Z470",32,"szybki","RFTX3060",550)
konkuter1.dodajDysk(1000)
print(konkuter1)














