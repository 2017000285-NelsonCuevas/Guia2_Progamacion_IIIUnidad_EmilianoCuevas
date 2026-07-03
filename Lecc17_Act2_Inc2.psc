Algoritmo Lecc17_Act2_Inc2
	Definir numeroFila, numeroCOlumna Como Entero
	Definir matrizColumna Como Entero
	Dimension matrizColumna[4,4]
	Para numeroFila<-1 Hasta 4 Hacer
		Para numeroCOlumna<-1 Hasta 4  Hacer
			matrizColumna[numeroFila,numeroCOlumna]=numeroCOlumna
		Fin Para
	Fin Para
	Escribir "MATRIZ COLUMNAS"
	Para numeroFila<-1 Hasta 4 Hacer
		Para numeroCOlumna<-1 Hasta 4 Hacer
			Escribir Sin Saltar matrizColumna[numeroFila,numeroCOlumna],""
		Fin Para
		Escribir ""
	Fin Para
FinAlgoritmo