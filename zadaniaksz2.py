typ_sredniej = int(input('[0]=aryt[1]=wazona>>>'))
oceny = [5, 4, 3, 3, 2, 1, 2, 3, 6]
wagi = [2, 2, 1, 1, 1, 1, 2, 3, 2, 1]
if typ_sredniej == 0:
    ilosc_ocen = len(oceny)
    suma_ocen = sum(oceny)
    srednia_aryt = suma_ocen / ilosc_ocen
    print('Srednia aryt = ', srednia_aryt)
elif typ_sredniej == 1:
    mianownik_wag = sum(wagi)
    index = 0
    licznik_wag = 0
    while index < len(oceny):
        ocena = oceny[index]
        waga = wagi[index]
        licznik_wag += ocena * waga
        index += 1
    print('Srednia wazona =', licznik_wag / mianownik_wag)
else:
    print('Nieznany tryb')
