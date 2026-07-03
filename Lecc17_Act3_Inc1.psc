Algoritmo Lecc17_Act3_Inc1
	Definir Fila, Columna, num, suma Como Entero
	Definir tabla Como Entero
	Dimension tabla[4,3]
	Para Fila<-1 Hasta 4 Hacer
		suma=0
		Para Columna<-1 Hasta 3 Hacer
			Escribir "Ingrese un Numero"
			Leer num
			tabla[fila,columna]=num
			suma=suma+num
		Fin Para
		Escribir "La suma de la fila ", fila, " es:",suma
	Fin Para
	
FinAlgoritmo