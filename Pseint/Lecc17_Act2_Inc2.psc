Algoritmo Lecc17_Act2_Inc2
	Definir nF,nC Como Entero
	Definir mC Como Entero
	Dimension mC[4,4]
	
	Para nF=1 Hasta 4 Hacer
		Para nC=1 Hasta 4 Hacer
			mC[nF,nC]=nC
		FinPara
	Fin Para
	
	Escribir "Matriz Columnas"
	Para nF=1 Hasta 4 Hacer
		Para nC=1 Hasta 4 Hacer
			Escribir Sin Saltar mC[nF,nC]," "
		FinPara
		Escribir " "
	Fin Para
	
FinAlgoritmo
