
import math

def new_square(a,b,c,d):
    if len(a) != 2 or len(b) != 2 or len(c) != 2 or len(d) != 2:
        raise BaseException("Argumenty powinny byc listami lub krotkami o dlugosci 2, zawieraja^cymi liczby")
    def distance(p1, p2): #funkcja pomocnicza
        x1=p1[0]
        y1=p1[1]
        x2=p2[0]
        y2=p2[1]
        return math.sqrt( (x2 - x1)**2 + (y2 - y1)**2 )
    if distance(a, b) != distance(b, c) or distance(b, c) != distance(c, d) or distance(c, d) != distance(d, a) or distance(a, c) != distance(b, d): #sprawdzam czy punkty tworza kwadrat
        raise BaseException("Punkty nie tworza kwadratu")
    return (list(a), list(b), list(c), list(d)) #zwraca krotke list, ktore reprezentuja punkty

def new_triangle(a,b,c):
    if len(a) != 2 or len(b) != 2 or len(c) != 2:
        raise BaseException("Argumenty powinny byc listami lub krotkami o dlugosci 2, zawierajacymi liczby")
    return (list(a), list(b), list(c))

def new_circle(s, r):
    if len(s) != 2:
        raise BaseException("Argument 's'  powinien byc lista lub krotka o dlugosci 2, zawierajaca liczby")
    if r <= 0:
        raise BaseException("Promien musi byc liczba dodatnia")
    return (list(s), r) #s-wsp srodka, r-dlugosc promienia

#Ponizsze funkcje rozpoznaja z jaka figura maja do czynienia ze wzgledu na liczbe elementow krotki
def pole(fig):
    if len(fig) == 2:
        r = fig[1]
        return math.pi*(r**2)
    elif len(fig) == 3:
        a = fig[0]
        b = fig[1]
        c = fig[2]
        return 0.5*abs((b[0] - a[0])*(c[1] - a[1]) - (b[1]-a[1])*(c[0]-a[0]))
    elif len(fig) == 4:
        a = fig[0]
        b = fig[1]
        c = fig[2]
        d = fig[3]
        if a[0] == b[0]: #korzystam z zalozenia ze bok kwadratu jest rownlegly do osi ukladu wsp
            return abs(a[1] - b[1])**2
        elif a[0] == c[0]:
            return abs(a[1] - c[1])**2
        elif a[0] == d[0]:
            return abs(a[1] - d[1])**2

def przesun(fig, x, y):
    for p in fig:
        p[0] += x
        p[1] += y
        if len(fig) == 2: break #gdy obslugujemy kolo konczymy po jednym obrocie, nie chcemy modyfikowac promienia
    return fig

def suma_pol(tab):
    suma = 0
    for fig in tab:
        suma += pole(fig)
    return suma
