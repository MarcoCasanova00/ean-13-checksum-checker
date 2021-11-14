# ean-13-checksum-checker

Italian Comment:

' I generi alimentari in tutti il mondo sono classificati con codici a barre EAN13 , a 13 cifre. '
' Le prime due cifre sono il codice della nazione es. Italia = Da 80 a 83 '
' Le successive nove o dieci cifre sono il codice vero e proprio e una cifra è il checksum '
' il checksum è calcolato come modulo 10 del codice. '
' se vogliamo provare a calcolarlo, dobbiamo: '
' 1 sommare il valore delle cifre nelle posizioni pari '
' 2 moltiplicare il risultato per 3 '
' sommare il valore delle cifre nelle posizioni dispari '
' sommare il risultato ottenuto al punto 2 con quello ottenuto al punto 3 '
' il carattere di controllo è il più piccolo numero che, aggiunto al risultato al punto 4, '
' da un multiplo di dieci
