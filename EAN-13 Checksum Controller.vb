'                             EAN-13 Label Checksum Checker '
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
' da un multiplo di dieci '

Module VBModule

  Sub Main(
Function Append_EAN_Checksum
(RawString as String)
Dim Position as Integer
Dim CheckSum as Integer

CheckSum = 0
For Position = 2 to 12 step 2
	Checksum - Checksum +
Val(Mid$(RawString, Position 1))
Next Position
CheckSum = CheckSum * 3
For Position = 1 to 11 Step 2
	CheckSum = CheckSum +
Val(Mid$(RawString, Position, 1))
Next Position
CheckSum = CheckSum Mod 10
CheckSum = 10 - CheckSum
If CheckSum = 10 Then
	CheckSum = 0
End If
Append_Ean_Checksum = Raw-
String & Format$(CheckSum, "0")
End Function


