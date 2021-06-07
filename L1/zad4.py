morse_dic = { 'A':'.-', 'B':'-...',
                    'C':'-.-.', 'D':'-..', 'E':'.',
                    'F':'..-.', 'G':'--.', 'H':'....',
                    'I':'..', 'J':'.---', 'K':'-.-',
                    'L':'.-..', 'M':'--', 'N':'-.',
                    'O':'---', 'P':'.--.', 'Q':'--.-',
                    'R':'.-.', 'S':'...', 'T':'-',
                    'U':'..-', 'V':'...-', 'W':'.--',
                    'X':'-..-', 'Y':'-.--', 'Z':'--..',
                    '1':'.----', '2':'..---', '3':'...--',
                    '4':'....-', '5':'.....', '6':'-....',
                    '7':'--...', '8':'---..', '9':'----.',
                    '0':'-----', '/':' ', ' ':'/'}

def code(slowa): #argument to krotka, ktorej elementy to stringi slowa
    wynik = ""
    for slowo in slowa:
        for znak in slowo:
            wynik += (morse_dic[znak.upper()] + ' ')
        wynik += "/ "
    return wynik

def decode(slowa): #argument to krotka, ktorej elementy to stringi slowa w alfabecie morse'a
    wynik=""
    for slowo in slowa:
        litery = slowo.split()
        for char in litery:
            wynik += list(morse_dic.keys())[list(morse_dic.values()).index(char)] #odczytanie klucza, po podaniu wartosci
        wynik += " "
    return wynik
