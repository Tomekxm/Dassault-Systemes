# Dassault-Systemes
>Zadania uzupełniające do rozmowy kwalifikacyjnej
>
>Treść pierwszego zadania:
```txt
    1. Zadanie nr 1 (programowanie obiektowe).
    • Przygotować 2 publiczne klasy A i B;
    • Klasa A powinna zwierać publiczne właściwości C i D typu integer. Właściwości te powinny używać prywatnych pól _c i _d do przechowywania danych. Właściwości te powinny być tylko do odczytu;
    • Klasa A powinna zawierać konstruktor z parametrami c i d, inicjalizującymi wartości właściwości C i D odpowiednio;
    • Klasa B powinna dziedziczyć z klasy A;
    • Klasa B powinna zawierać publiczną właściwość E typu integer, która jest tylko do odczytu i używa pola _e do przechowywania danych;
    • Klasa B powinna zawierać konstruktor bezparametrowy, który inicjalizuje właściwość E wartością 1 i wywołuje konstruktor bazowy z wartościami 2 i 3 dla parametrów c i d;
    • Klasa A powinna zawierać publiczną metodę wirtualną Test, która zwraca ciąg znaków powstały po sklejeniu wartości właściwości C, znaku ',' oraz wartości właściwości D;
    • Klasa B powinna przeładować metodą Test z klasy bazowej, doklejając wartość właściwości E i znak ',' do początku wartości zwróconej przez metodę bazową;
    • Do statycznej klasy Program zawierającej metodę Main, dodać statyczną metodę RunTest, która przyjmuje obiekt typu A, wywołuje na nim metodę Test, i wypisuje wynik na konsolę;
    • W metodzie Main programu, stworzyć dwa obiekty, jeden typu A (parametry konstruktora: 1, 2), drugi typu B;
    • Wywołać na tych obiektach metodę RunTest;
```
>Treść drugiego zadania:
```txt
    2. Zadanie nr 2 (algorytmika, struktury danych).
    Napisz program sprawdzający poprawność działania matematycznego, w którym usunięto wszystkie liczby i operatory a pozostawiono jedynie nawiasy okrągłe, np. (()()) lub )()), przy czy pierwszy przykład jest zapisem prawidłowym a drugi nieprawidłowym:
    • Program powinien zwrócić flagę typu Bool, przy czym:
        ◦ wartość true oznacza zapis prawidłowy
        ◦ wartość false zapis nieprawdiłowy 
    • Program powinien przyjmować jeden argument typu String. Wartość tego parametru to dowolny ciąg znaków ‘(‘ oraz ‘)’.
    • Napisać test jednostkowy, który sprawdza działanie metody na reprezentatywnych przykładach, np. dla następujących wartości:
        ◦ (((()()))())
        ◦ (((()()))()))
        ◦ )((((()))()))
    • Proszę dodać kilka własnych wartości w w/w teście jednostkowym
```
