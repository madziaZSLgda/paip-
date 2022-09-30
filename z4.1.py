 a = int(input('Podaj współczynnik a: '))
 b = int(input('Podaj współczynnik b: '))
 k = int(input('Podaj koniec podziału: '))
 for x in range(2,k,2):
     f = a * x + b
     wynik = 'f({}) = {}'
      print(wynik.format(x,f))
    # print('f(',x,') = ',f)

