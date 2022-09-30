suma=0
ilosc=0
liczba=int(input('Podaj liczbę '))
while liczba > 0:
    suma+=liczba%10
    liczba//=10
    ilosc+=1
print(suma)
print(ilosc)
