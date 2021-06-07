#!/usr/bin/env python3
# -*- coding: utf-8 -*-
import zad1
import zad4

print("ZAD1: \n")
kwadrat = zad1.new_square((-1,1), (2, 1), (2, -2), (-1, -2))
print("Kwadrat: " + str(kwadrat))
trojkat = zad1.new_triangle((2, 5), (3, -2), (-3, -2))
print("Trojkat: " + str(trojkat))
kolo = zad1.new_circle((1, 3), 4)
print("Kolo: " + str(kolo))

print("Pole kwadratu: " + str(zad1.pole(kwadrat)))
print("Pole trojkata: " + str(zad1.pole(trojkat)))
print("Pole kola: " + str(zad1.pole(kolo)))

print("Suma tych pol: " + str(zad1.suma_pol([kolo, kwadrat, trojkat])))

kwadrat = zad1.przesun(kwadrat, 3, 4)
kolo = zad1.przesun(kolo, 3, 4)
trojkat = zad1.przesun(trojkat, 3, 4)
print("Przesuniety kwadrat: " + str(kwadrat))
print("Przesuniety trojkat: " + str(trojkat))
print("Przesuniete kolo: " + str(kolo))

print("\nZAD4: \n")
print(zad4.code(("Mam", "na", "imie", "Karol")))
print(zad4.decode(("-- .- -- ", "-. .- " ,".. -- .. . " ,"-.- .- .-. --- .-.. " )))
