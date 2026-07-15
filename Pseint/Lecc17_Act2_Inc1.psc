Algoritmo Lecc17_Act2_Inc1
	Definir nF,nC Como Entero
	Definir mI Como Entero
	Dimension mI[4,4]
	
	Para nF=1 Hasta 4 Hacer
		Para nC=1 Hasta 4 Hacer
			Si nF=nC Entonces
				mI[nF,nC]=1
			SiNo
				mI[nF,nC]=0
			FinSi
		FinPara
	Fin Para
	
	Escribir "Matriz Identidad"
	Para nF=1 Hasta 4 Hacer
		Para nC=1 Hasta 4 Hacer
			Escribir Sin Saltar mI[nF,nC]," "
		FinPara
		Escribir " "
	Fin Para
FinAlgoritmo
